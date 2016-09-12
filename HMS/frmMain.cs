using System;
using System.Windows.Forms;
namespace HMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            //this.Close();
            //this.Dispose();
            frm.Show();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出系统吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                // notifyIcon1.Visible = false;
                this.Close();
                this.Dispose();
                Application.Exit();
            }
        }

        private void picMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picDoctor_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor();
            //this.Hide();
            frm.ShowDialog();
        }

        private void picPatient_Click(object sender, EventArgs e)
        {
            frmPatient frm = new frmPatient();
            frm.ShowDialog();
        }

        private void picFee_Click(object sender, EventArgs e)
        {
            frmFee frm = new frmFee();
            frm.ShowDialog();
        }

        private void picFind_Click(object sender, EventArgs e)
        {
            frmFind frm = new frmFind();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
