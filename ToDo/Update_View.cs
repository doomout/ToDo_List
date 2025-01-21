using System.Data;


namespace ToDo_List.ToDo
{
    public partial class updateView : Form
    {
        private Mode currentMode;
        private DataRow dataRow;
        private string userId; // user_id 필드 추가
        private Main mainForm; // Main 폼 참조

        public updateView(Mode mode, string userId, Main mainForm,  DataRow row = null)
        {
            InitializeComponent();
            currentMode = mode;
            this.userId = userId; // user_id 저장
            this.mainForm = mainForm; // Main 폼 인스턴스 저장
            dataRow = row;
        }

        public enum Mode
        {
            Add,
            Update
        }

        private void Update_Load(object sender, EventArgs e)
        {
            // 추가 모드, 수정 모드 구분
            if (currentMode == Mode.Add)
            {
                this.Text = "할 일 추가";
                this.btnUpdateOrAdd.Text = "추가";
            }
            else if (currentMode == Mode.Update)
            {
                this.Text = "할 일 수정";
                this.btnUpdateOrAdd.Text = "수정";

                // 데이터 그리드뷰에서 정보를 가져와서 폼에 표시
                if (dataRow != null)
                {
                    txtTitle.Text = dataRow["title"].ToString();
                    txtDescription.Text = dataRow["description"].ToString();

                    // created_at 값을 DateTime으로 변환하여 MonthCalendar에 설정
                    DateTime createdAt = Convert.ToDateTime(dataRow["created_at"]);
                    mCalCreate.SelectionStart = createdAt;
                    mCalCreate.SelectionEnd = createdAt;

                    if (Convert.ToBoolean(dataRow["is_completed"]))
                    {
                        rdoTrue.Checked = true;
                    }
                    else
                    {
                        rdoFalse.Checked = true;
                    }
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addOrUpdate(Mode addOrUpdte)
        {
            // 입력값 검사
            if (txtTitle.Text == "")
            {
                MessageBox.Show("할 일을 입력해주세요.");
                return;
            }

            // DB에 추가 또는 수정
            string query;
            if (currentMode == Mode.Add)
            {
                query = "INSERT INTO todo_list (title, description, created_at, is_completed,user_id) " +
                            "VALUES (@title, @description, @created_at, @is_completed,@user_id)";
            }
            else if (currentMode == Mode.Update && dataRow != null)
            {
                query = "UPDATE todo_list " +
                    "SET title = @title, description = @description, created_at = @created_at, is_completed = @is_completed " +
                    "WHERE id = @id AND user_id = @user_id";
            }
            else
            {
                MessageBox.Show("잘못된 모드입니다.");
                return;
            }

            using (var conn = DatabaseManager.GetConnection())
            {
                conn.Open();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.Parameters.AddWithValue("@title", txtTitle.Text);
                    command.Parameters.AddWithValue("@description", txtDescription.Text);
                    command.Parameters.AddWithValue("@created_at", mCalCreate.SelectionStart);
                    command.Parameters.AddWithValue("@is_completed", rdoTrue.Checked);

                    if (currentMode == Mode.Update && dataRow != null)
                    {
                        command.Parameters.AddWithValue("@id", dataRow["id"]);
                    }

                    command.ExecuteNonQuery();
                }
            }
            // 인서트 성공 시 메시지 표시 및 창 닫기
            MessageBox.Show("저장 완료");

            // Main 폼의 데이터 새로 고침 메서드 호출
            mainForm?.RefreshData();
            this.Close();
        }

        private void btn_UpdateOrAdd_Click(object sender, EventArgs e)
        {
            addOrUpdate(Mode.Add);
        }
    }
}
