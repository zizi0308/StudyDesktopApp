using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var strUserId = "";

            //MessageBox.Show("로그인 처리!");
            if (string.IsNullOrEmpty(TxtUserId.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요!", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // SqlConnection 연결
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    var query = "SELECT userID FROM memberTbl " +
                                " WHERE userID = @userID " +
                                "   AND passwords = @passwords" +
                                "   AND levels = 'S' ";

                    // SqlCommand 생성
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // SqlInjection 해킹을 막기위해 사용
                    SqlParameter pUserID = new SqlParameter("@userID", SqlDbType.VarChar, 20);
                    pUserID.Value = TxtUserId.Text;
                    cmd.Parameters.Add(pUserID);
                    SqlParameter pPasswords = new SqlParameter("@passwords", SqlDbType.VarChar, 20);
                    pPasswords.Value = TxtPassword.Text;
                    cmd.Parameters.Add(pPasswords);

                        // SqlDataReader 실행(1)
                    SqlDataReader reader = cmd.ExecuteReader();

                    // reader로 처리
                    reader.Read();
                    strUserId = reader["userID"] != null ? reader["userID"].ToString() : "";
                    reader.Close(); // 1)
                    // 확인 MessageBox.Show(strUserId);
                    if (string.IsNullOrEmpty(strUserId))
                    {
                        MetroMessageBox.Show(this, "접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        var updateQuery = $@"UPDATE membertbl SET
                                             lastLoginDt = GETDATE()
                                            ,loginIpAddr = '{Helper.Common.GetLocalIp()}' 
                                             WHERE userID = '{strUserId}' "; // 2) 로그인정보 남기기
                        cmd.CommandText = updateQuery; // 3)
                        cmd.ExecuteNonQuery(); // 4)
                        MetroMessageBox.Show(this, "접속성공", "로그인성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"Error : {ex.Message}", "오류",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // 완전종료
        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) TxtPassword.Focus();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnLogin_Click(sender, e);
        }
    }
}
