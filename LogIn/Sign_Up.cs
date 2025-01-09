using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo_List.ToDo;

namespace ToDo_List
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        //패스워드 확인 로직
        private void txt_PW2_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_pw1.Text.Trim() == this.txt_pw2.Text.Trim())
            {
                lbl_PWCheck.Text = "비밀번호가 일치합니다.";
                lbl_PWCheck.ForeColor = Color.Green;
            }
            else
            {
                lbl_PWCheck.Text = "비밀번호가 일치하지 않습니다.";
                lbl_PWCheck.ForeColor = Color.Red;
            }
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            string id = this.txt_id.Text;
            string pw = this.txt_pw2.Text;

            if (pw.Length <= 8)
            {
                MessageBox.Show("비밀번호는 8자리 이상이어야 합니다.");
                return;
            }

            using (var conn = DatabaseManager.GetConnection())
            {
                conn.Open();
                // ID 중복 확인
                string checkIdQuery = "SELECT COUNT(*) FROM users WHERE id = @id";
                using (var checkIdCommand = new NpgsqlCommand(checkIdQuery, conn))
                {
                    checkIdCommand.Parameters.AddWithValue("id", id);
                    long idCount = (long)checkIdCommand.ExecuteScalar();

                    if (idCount > 0)
                    {
                        MessageBox.Show("이미 존재하는 ID입니다.");
                        return;
                    }
                }

                // 회원 가입(비밀번호 암호화)
                string signUpQuery = "INSERT INTO users (id, password) VALUES (@id, crypt(@password, gen_salt('bf')))";
                using (var signUpCommand = new NpgsqlCommand(signUpQuery, conn))
                {
                    signUpCommand.Parameters.AddWithValue("id", id);
                    signUpCommand.Parameters.AddWithValue("password", pw);

                    try
                    {
                        int result = signUpCommand.ExecuteNonQuery();

                        if (result == 1)
                        {
                            MessageBox.Show("회원가입 성공");

                            // 마지막 사용한 ID 저장
                            string saveIdQuery = "INSERT INTO last_used_id (id) VALUES (@id) ON CONFLICT (id) DO UPDATE SET id = @id";
                            using (var saveIdCommand = new NpgsqlCommand(saveIdQuery, conn))
                            {
                                saveIdCommand.Parameters.AddWithValue("id", id);
                                saveIdCommand.ExecuteNonQuery();
                            }

                            // 자동 로그인
                            string loginQuery = "SELECT COUNT(*) FROM users WHERE id = @id AND password = crypt(@password, password)";
                            using (var loginCommand = new NpgsqlCommand(loginQuery, conn))
                            {
                                loginCommand.Parameters.AddWithValue("id", id);
                                loginCommand.Parameters.AddWithValue("password", pw);

                                long userCount = (long)loginCommand.ExecuteScalar();

                                if (userCount > 0)
                                {
                                    MessageBox.Show("자동 로그인 성공");
                                    // 로그인 성공 후 메인 폼 열기
                                    Main mainForm = new Main(id);
                                    mainForm.Show();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("자동 로그인 실패");
                                }
                            }
                            /*
                            // 회원가입 성공 후 Login 폼으로 이동
                            this.Close();
                            Login loginForm = new Login();
                            loginForm.Show();
                            */
                        }
                        else
                        {
                            MessageBox.Show("회원가입 실패");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("회원가입 중 오류가 발생했습니다: " + ex.Message);
                    }
                }
            }
        }
    }
}
