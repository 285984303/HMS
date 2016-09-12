using System.Windows.Forms;

namespace HMS
{
    public partial class frmFind : Form
    {
        public frmFind()
        {
            InitializeComponent();
        }

        private void btnFlush_Click(object sender, System.EventArgs e)
        {

        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
