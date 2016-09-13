using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    public partial class frmReg : Form
    {
        public frmReg()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string username = this.txtUserName.Text;
            string pass = this.txtPass.Text;
            string name = this.txtName.Text;
            string mail = this.txtMail.Text;
            string phone = this.txtPhone.Text;
            
            string sql = "INSERT INTO `hms_db`.`hm_user` (`a_User`, `a_Password`, `a_Name`, `a_E_mail`, `a_Phone`) VALUES(@a_User, @a_Password, @a_Name, @a_E_mail,@a_Phone)";
            DbHelper db = new DbHelper();


            MySqlParameter[] parameters = {
new MySqlParameter("@a_User", username),
new MySqlParameter("@a_Password", pass),
new MySqlParameter("@a_Name", name),
new MySqlParameter("@a_E_mail", mail),
new MySqlParameter("@a_Phone", phone),
};

            int ok = db.ExecuteNonQuery(sql, parameters);
            if (ok > 0)
            {
                MessageBox.Show("注册成功!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("系统忙,请稍候重试!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            
            this.Close();
            this.Dispose();

            
        }

        private void frmReg_Load(object sender, EventArgs e)
        {
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.BackColor = this.BackColor;
            txtUserName.Refresh();
            Graphics gph = txtUserName.CreateGraphics();
            Rectangle Rec = txtUserName.ClientRectangle;
            gph.DrawLine(new Pen(Color.Black), new Point(0, Rec.Height - 1), new Point(Rec.Width, Rec.Height - 1));
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Close();
            this.Dispose();
            
            frm.Show();
        }
    }
}
