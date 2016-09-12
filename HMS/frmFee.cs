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
    }
}
