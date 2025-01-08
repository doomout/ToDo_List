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
            // ȸ�� ���� â�� ���� �� 
            Sign_Up sign_up = new Sign_Up();
            sign_up.ShowDialog();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM users WHERE id = @id AND password = @password";
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
                        MessageBox.Show("�α��� ����");
                        // �α��� ���� �� ���� �� ����
                        Main mainForm = new Main();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("�α��� ����: ���̵� �Ǵ� ��й�ȣ�� �߸��Ǿ����ϴ�.");
                    }
                }
            }
        }
    }
}
