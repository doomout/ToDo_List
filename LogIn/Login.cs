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
            
        }
    }
}
