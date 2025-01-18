using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            string query = "SELECT * FROM todo_list WHERE user_id = @user_id";
            using (var conn = DatabaseManager.GetConnection())
            {
                conn.Open();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("user_id", userId); //로그인한 사용자의 ID
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["id"].ToString()); //ID
                            item.SubItems.Add(reader["title"].ToString()); //제목
                            item.SubItems.Add(reader["description"].ToString()); //내용
                            item.SubItems.Add(reader["is_completed"].ToString()); //완료 여부
                            item.SubItems.Add(reader["created_at"].ToString()); //생성일
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
    }
}
