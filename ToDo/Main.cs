using System.Data;
using ToDo_List.User;

namespace ToDo_List.ToDo
{
    public partial class Main : Form
    {
        private string userId;

        public Main(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.lbl_welcome.Text = $"{userId} 님 반갑습니다!";
            dgv_ToDoList.CellValueChanged += dgv_ToDoList_CellValueChanged;
            dgv_ToDoList.CurrentCellDirtyStateChanged += dgv_ToDoList_CurrentCellDirtyStateChanged;
        }

        // CurrentCellDirtyStateChanged 이벤트 핸들러
        private void dgv_ToDoList_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (dgv_ToDoList.IsCurrentCellDirty)
            {
                dgv_ToDoList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            //로그 아웃시 로그인 창으로 이동
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_UserSet_Click(object sender, EventArgs e)
        {
            User_Set user_Set = new User_Set(userId);
            user_Set.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ToDo_List();
        }

        private void ToDo_List()
        {
            //폼 로드시 할 일 목록 불러오기
            string query = "SELECT id, title, description, is_completed, created_at FROM todo_list WHERE user_id = @user_id";
            using (var conn = DatabaseManager.GetConnection())
            {
                conn.Open();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("user_id", userId); // 로그인한 사용자의 ID
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("id", typeof(int));
                        dataTable.Columns.Add("is_completed", typeof(bool)); // bool로 명시
                        dataTable.Columns.Add("title", typeof(string));
                        dataTable.Columns.Add("description", typeof(string));
                        dataTable.Columns.Add("created_at", typeof(DateTime));
                        dataTable.Load(reader);
           
                        // DataGridView에 데이터 바인딩
                        dgv_ToDoList.DataSource = dataTable;

                        // DataGridView의 ReadOnly 설정
                        foreach (DataGridViewColumn column in dgv_ToDoList.Columns)
                        {
                            if (column.Name == "is_completed")
                            {
                                column.ReadOnly = false; // 'is_completed' 열만 수정 가능
                            }
                            else
                            {
                                column.ReadOnly = true; // 나머지 열은 읽기 전용
                            }
                        }

                        // 'id' 열 숨기기
                        if (dgv_ToDoList.Columns["id"] != null)
                        {
                            dgv_ToDoList.Columns["id"].Visible = false;
                        }

                        //Console.WriteLine(dataTable.Columns["is_completed"].ReadOnly); // false여야 수정 가능(확인용)

                        // 열 순서 설정
                        if (dgv_ToDoList.Columns.Contains("is_completed"))
                        {
                            dgv_ToDoList.Columns["is_completed"].DisplayIndex = 0; // 확인
                        }
                        if (dgv_ToDoList.Columns.Contains("title"))
                        {
                            dgv_ToDoList.Columns["title"].DisplayIndex = 1; // 할일
                        }
                        if (dgv_ToDoList.Columns.Contains("description"))
                        {
                            dgv_ToDoList.Columns["description"].DisplayIndex = 2; // 할일 상세
                        }
                        if (dgv_ToDoList.Columns.Contains("created_at"))
                        {
                            dgv_ToDoList.Columns["created_at"].DisplayIndex = 3; // 생성일
                        }
                    }
                }
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //숨겨진 로그인 창 닫기
            Application.Exit();
        }

        private void dgv_ToDoList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 'is_completed' 열을 처리
            if (dgv_ToDoList.Columns[e.ColumnIndex].Name == "is_completed")
            {
                if (e.Value != null)
                {
                    // 'is_completed' 값이 true이면 "달성", false이면 "미달성"
                    e.Value = (bool)e.Value ? "달성" : "미달성";
                }
            }
        }

        private void dgv_ToDoList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //셀 더블 클릭시 수정 창 열기
            Update update = new Update();
            update.ShowDialog();
        }

        private void dgv_ToDoList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //할일 체크박스 클릭시 is_completed 값 변경
            if (dgv_ToDoList.Columns.Contains("is_completed") && e.ColumnIndex == dgv_ToDoList.Columns["is_completed"].Index)
            {
                int id = Convert.ToInt32(dgv_ToDoList.Rows[e.RowIndex].Cells["id"].Value);
                bool isCompleted = Convert.ToBoolean(dgv_ToDoList.Rows[e.RowIndex].Cells["is_completed"].Value);

                string query = "UPDATE todo_list SET is_completed = @is_completed WHERE id = @id";
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandText = query;
                        command.Parameters.AddWithValue("is_completed", isCompleted);
                        command.Parameters.AddWithValue("id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
