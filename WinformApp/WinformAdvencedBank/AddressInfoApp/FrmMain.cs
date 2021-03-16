using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AddressInfoApp
{
    public partial class FrmMain : Form
    {
        string connstring = "Data Source=127.0.0.1;Initial Catalog=PMS;Persist Security Info=True;" +
            "User ID=SA;Password=msspl_p@ssw0rd!"; // 이부분 안틀렸는지 확인 또 확인 App.config에 넣어서 공유 용이하게 할 수 있음(보안문제있음)
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result > 0)
            {
                MessageBox.Show("초기화를 하십시오.");
                return;
            }

            if (string.IsNullOrEmpty(TxtFullName.Text) || string.IsNullOrEmpty(TxtMobile.Text))
            {
                MessageBox.Show("값을 입력하세요");
                return;
            }
            
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // INSERT INTO를 쓰면 아래와 위의 순서쌍이 맞아야 오류가 안남
                string query = $"INSERT INTO dbo.Address " +
                    $" ( FullName, " +
                    $"  Mobile, " +
                    $"  Addr, " +
                    $"  RegId, " +
                    $"  RegDate) " +
                    $" VALUES " + 
                    $" ( '{TxtFullName.Text}'," +
                    $"  '{TxtMobile.Text.Replace("-", "")}'," +
                    $"  '{TxtAddr.Text}'," +
                    $"  'admin'," +
                    $"  GETDATE() ); ";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("입력성공");
                }
                else
                {
                    MessageBox.Show("입력실패");
                }
            }
            
            ClearInput();
            RefreshData();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result == 0)
            {
                MessageBox.Show("데이터를 선택하십시오");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();  // 디버그할때 여기서 오류나면 string connstring가 잘못된 것임

                string query = $"UPDATE Address " +
                            $" Set " +
                            $" FullName '{TxtFullName.Text}'," +
                            $" Mobile = '{TxtMobile.Text.Replace("-", "")}', " +
                            $" Addr = '{TxtAddr.Text}'," +
                            $" ModId = 'admin'," +
                            $" ModDate = GETDATE()" +
                            $" WHERE Idx = {result} ";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("삭제 성공!");
                }
                else
                {
                    MessageBox.Show("삭제 실패!");
                }
            }

            ClearInput();
            RefreshData();


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result == 0)
            {
                MessageBox.Show("데이터를 선택하십시오");
                return;
            }

            if (MessageBox.Show("삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes) // 이거 외에 IsModify로도 짤 수 있음
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();  // 디버그할때 여기서 오류나면 string connstring가 잘못된 것임

                    string query = $"DELETE FROM Address WHERE idx = {result}";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("삭제 성공!");
                    }
                    else
                    {
                        MessageBox.Show("삭제 실패!");
                    }
                }

                ClearInput();
                RefreshData();
            }
        }

        private void TxtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 엔터
            {
                TxtMobile.Focus();
            }
        }

        private void TxtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtAddr.Focus();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshData();
            ClearInput();
        }

        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // SSMS 테이블 스크립팅 메뉴활용
                string query = "SELECT Idx " +
                               "      ,FullName " +
                               "      ,Mobile " +
                               "      ,Addr " +
                               "  FROM dbo.Address ";

                // SqlCommand, SqlReader or Object 사용방법 1
                // SqlDataAdapter, DataSet
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn); // 그리드 뷰에 데이터 집어넣는 방법
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DgvAddress.DataSource = ds.Tables[0];
            }
        }

        private void ClearInput()
        {
            TxtIdx.Text = TxtFullName.Text = TxtMobile.Text = TxtAddr.Text = "";
        }

        private void DgvAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selData = DgvAddress.Rows[e.RowIndex].Cells;

            TxtIdx.Text = selData[0].Value.ToString();
            TxtFullName.Text = selData[1].Value.ToString();
            TxtMobile.Text = selData[2].Value.ToString();
            TxtAddr.Text = selData[3].Value.ToString();
        }
    }
}
