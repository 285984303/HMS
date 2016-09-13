using System.Data;
using System.Windows.Forms;

namespace HMS
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        private void frmPatient_Load(object sender, System.EventArgs e)
        {
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            string sql = "select * from `hm_patient`";
            DbHelper db = new DbHelper();
            DataTable data = db.ExecuteDataTable(sql, null);
            this.dataGridView1.DataSource = data;
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {

        }
    }
}
