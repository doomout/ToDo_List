using System.Data;
using ToDo_List.User;
using System.Linq;

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
            dgvTodoList.CellValueChanged += dgv_ToDoList_CellValueChanged;
            dgvTodoList.CurrentCellDirtyStateChanged += dgv_ToDoList_CurrentCellDirtyStateChanged;
        }

        // CurrentCellDirtyStateChanged 이벤트 핸들러
        /*
        DataGridView는 기본적으로 셀 편집을 마친 후에 값이 변경되는데, 
        체크박스 같은 컨트롤은 클릭하는 순간 바로 값이 바뀌기 때문에, 
        그 순간에 CellValueChanged가 자동으로 트리거되지 않아요. 
        그래서 체크박스를 클릭했을 때 값이 변경되도록 하려면 
        CurrentCellDirtyStateChanged 이벤트를 활용해 값을 강제로 커밋하도록 해야 합니다.
        */
        private void dgv_ToDoList_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (dgvTodoList.IsCurrentCellDirty)
            {
                dgvTodoList.CommitEdit(DataGridViewDataErrorContexts.Commit);
                RefreshData();
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            //로그 아웃시 로그인 창으로 이동
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ShowUpdateView(updateView.Mode mode, DataRow? row = null)
        {
            updateView form = new updateView(mode, userId, this, row);
            form.ShowDialog();
        }

        private void btn_UserSet_Click(object sender, EventArgs e)
        {
            User_Set user_Set = new User_Set(userId);
            user_Set.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //dtpStart는 오늘로 부터 일주일 전, dtpEnd는 오늘로 설정
            dtpStart.Value = DateTime.Now.AddDays(-7);
            dtpEnd.Value = DateTime.Now;

            RefreshData();
        }

        private void AchievementRate()
        {
            //true 갯수
            int completedCount = ((DataTable)dgvTodoList.DataSource).AsEnumerable()
                .Count(row => row.Field<bool>("is_completed"));
            
            //전체 갯수
            int totalCount = dgvTodoList.Rows.Count;

            //달성율 계산
            int achievementRate = (int)((double)completedCount / totalCount * 100);

            //progressBar에 달성율 표시
            proARate.Value = achievementRate;

            // Label에 퍼센트 값 표시
            lblPercent.Text = $"{achievementRate}%";
        }

        public void RefreshData()
        {
            // 기존 데이터를 다시 로드하는 메서드 호출
            TodoList(); 

            //달성율 계산
            AchievementRate();
        }

        private void TodoList()
        {
            //폼 로드시 할 일 목록 불러오기
            string query = "SELECT id, title, description, is_completed, created_at " +
                                "FROM todo_list WHERE user_id = @user_id";

            using (var conn = DatabaseManager.GetConnection())
            {
                conn.Open();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("user_id", userId); // 로그인한 사용자의 ID

                    try
                    {
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
                            dgvTodoList.DataSource = dataTable;

                            ConfigureDataGridView(dgvTodoList);
                            Console.WriteLine("쿼리 성공: " + query);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("쿼리 실패: " + ex.Message);
                    }
                    
                }
            }
        }

        private void ConfigureDataGridView(DataGridView dgv)
        {
            // DataGridView의 ReadOnly 설정
            foreach (DataGridViewColumn column in dgvTodoList.Columns)
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
            if (dgvTodoList.Columns["id"] != null)
            {
                dgvTodoList.Columns["id"].Visible = false;
            }

            //Console.WriteLine(dataTable.Columns["is_completed"].ReadOnly); // false여야 수정 가능(확인용)

            // 열 순서 설정
            if (dgvTodoList.Columns.Contains("is_completed"))
            {
                dgvTodoList.Columns["is_completed"].DisplayIndex = 0; // 확인
            }
            if (dgvTodoList.Columns.Contains("title"))
            {
                dgvTodoList.Columns["title"].DisplayIndex = 1; // 할일
            }
            if (dgvTodoList.Columns.Contains("description"))
            {
                dgvTodoList.Columns["description"].DisplayIndex = 2; // 할일 상세
            }
            if (dgvTodoList.Columns.Contains("created_at"))
            {
                dgvTodoList.Columns["created_at"].DisplayIndex = 3; // 생성일
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //숨겨진 로그인 창 닫기
            Application.Exit();
        }

        private void dgv_ToDoList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 셀 더블 클릭시 수정 창 열기
            if (e.RowIndex >= 0)
            {
                DataRow row = ((DataTable)dgvTodoList.DataSource).Rows[e.RowIndex];
                ShowUpdateView(updateView.Mode.Update, row);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            // 추가 버튼 클릭시 추가 창 열기
            ShowUpdateView(updateView.Mode.Add); ;
        }

        private void dgv_ToDoList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //할일 체크박스 클릭시 is_completed 값 변경
            if (dgvTodoList.Columns.Contains("is_completed") && e.ColumnIndex == dgvTodoList.Columns["is_completed"].Index)
            {
                int id = Convert.ToInt32(dgvTodoList.Rows[e.RowIndex].Cells["id"].Value);
                bool isCompleted = Convert.ToBoolean(dgvTodoList.Rows[e.RowIndex].Cells["is_completed"].Value);

                string query = "UPDATE todo_list " +
                                    "SET is_completed = @is_completed WHERE id = @id";
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandText = query;
                        command.Parameters.AddWithValue("is_completed", isCompleted);
                        command.Parameters.AddWithValue("id", id);

                        try
                        {
                            command.ExecuteNonQuery();
                            Console.WriteLine("쿼리 성공: " + query);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("쿼리 실패: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
