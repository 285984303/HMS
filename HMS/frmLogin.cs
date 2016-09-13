using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUserName.Text;
            string pass = this.txtPass.Text;


            string sql = "select * from `hm_user` where `a_User`=@a_User and `a_Password`=@a_Password";
            DbHelper db = new DbHelper();


            MySqlParameter[] parameters = {
new MySqlParameter("@a_User", username),
new MySqlParameter("@a_Password", pass),

};

            int ok = (int)db.ExecuteScalar(sql, parameters);
            if (ok > 0)
            {
                
                frmMain frm = new frmMain();
                this.Hide();
                frm.Show();
                
            }
            else
            {
                MessageBox.Show("用户名或密码错误!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


           
            
            
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
            //this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            frmReg frm = new frmReg();
            //this.Hide();
            frm.ShowDialog();
        }
    }
}
