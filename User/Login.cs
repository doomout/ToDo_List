using Npgsql;
using ToDo_List.ToDo;

namespace ToDo_List
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            // 회원 가입 창이 떠야 함 
            Sign_Up sign_up = new Sign_Up();
            sign_up.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM users WHERE id = @id AND password = crypt(@password, password)";
            string id = txt_ID.Text;
            string pw = txt_PW.Text;

            using (var conn = DatabaseManager.GetConnection())
            {
                conn.Open();
                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("password", pw);

                    long userCount = (long)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        //MessageBox.Show("로그인 성공");
                        // 로그인 성공 후 메인 폼 열기
                        Main mainForm = new Main(id);
                        mainForm.Show();
                        this.Hide(); // 로그인 창 가리기
                    }
                    else
                    {
                        MessageBox.Show("로그인 실패: 아이디 또는 비밀번호가 잘못되었습니다.");
                    }

                }
            }
        }

        private void txt_PW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(this, new EventArgs());
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //로그인 창을 Hide 하기에 이벤트가 발생하지 않으므로 강제 종료
            Application.Exit();
        }
    }
}
