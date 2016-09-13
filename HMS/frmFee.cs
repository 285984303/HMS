using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace HMS
{
    public partial class frmFee : Form
    {
        public frmFee()
        {
            InitializeComponent();
        }

        private void frmFee_Load(object sender, System.EventArgs e)
        {
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            string sql = "select * from `hm_fee`";
            DbHelper db = new DbHelper();
            DataTable data = db.ExecuteDataTable(sql, null);
            this.dataGridView1.DataSource = data;
        }

        private void btnFind_Click(object sender, System.EventArgs e)
        {
            string key = this.txtKey.Text;
            


            string sql = "select * from `hm_fee` where `p_Id`=@p_Id or `P_Name`=@P_Name";
            DbHelper db = new DbHelper();
            MySqlParameter[] parameters = {
new MySqlParameter("@p_Id", key),
new MySqlParameter("@P_Name", key),

};
            if (key.Trim().Length == 0)
            {
                sql = "select * from `hm_fee` ";
                parameters = null;
            }
            DataTable data = db.ExecuteDataTable(sql, parameters);
            this.dataGridView1.DataSource = data;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string pid = this.txtp_Id.Text;
            string fee = this.txtFee.Text;
            string B = this.txtB.Text;
            string C = this.txtC.Text;
            string D = this.txtD.Text;
            

            string sql = "select P_Name from `hm_patient` where `p_Id`=@pid";
            DbHelper db = new DbHelper();


            MySqlParameter[] parameters = {
new MySqlParameter("@pid", pid),

};

            string name = (string)db.ExecuteScalar(sql, parameters);
            if (name != "")
            {
                sql = "INSERT INTO `hms_db`.`hm_fee` (`p_Id`, `p_Name`, `B`, `C`, `D`) VALUES(@p_Id, @p_Name, @B, @C,@D)";

                MySqlParameter[] parameters2 = {
new MySqlParameter("@p_Id", pid),
new MySqlParameter("@p_Name", name),
new MySqlParameter("@B", B),
new MySqlParameter("@C", C),
new MySqlParameter("@D", D),

};

                int ok = db.ExecuteNonQuery(sql, parameters2);
                if (ok > 0)
                {
                    MessageBox.Show("添加成功!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("系统忙,请稍候重试!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("没有这个病例!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
        
        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
