using Npgsql;
using ToDo_List.ToDo;

namespace ToDo_List
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            AutoLogin();
        }

        private void AutoLogin()
        {
            string id = LoadLastUsedId();
            if (!string.IsNullOrEmpty(id))
            {
                string query = "SELECT COUNT(*) FROM users WHERE id = @id";
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var command = new NpgsqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("id", id);
                        long userCount = (long)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("�ڵ� �α��� ����");
                            // �α��� ���� �� ���� �� ����
                            Main mainForm = new Main();
                            mainForm.Show();
                            this.Hide(); // �α��� â �����
                        }
                        else
                        {
                            MessageBox.Show("�ڵ� �α��� ����: ����� ID�� ��ȿ���� �ʽ��ϴ�.");
                        }
                    }
                }
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            // ȸ�� ���� â�� ���� �� 
            Sign_Up sign_up = new Sign_Up();
            sign_up.ShowDialog();

        }

        private string LoadLastUsedId()
        {
            using (var conn = DatabaseManager.GetConnection())
            {
                conn.Open();
                string query = "SELECT id FROM last_used_id LIMIT 1";
                using (var command = new NpgsqlCommand(query, conn))
                {
                    var result = command.ExecuteScalar();
                    return result != null ? result.ToString() : string.Empty;
                }
            }
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
                        MessageBox.Show("�α��� ����");
                        // �α��� ���� �� ���� �� ����
                        Main mainForm = new Main();
                        mainForm.Show();
                        this.Hide(); // �α��� â �����
                    }
                    else
                    {
                        MessageBox.Show("�α��� ����: ���̵� �Ǵ� ��й�ȣ�� �߸��Ǿ����ϴ�.");
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
    }
}
