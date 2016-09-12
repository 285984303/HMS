using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmDoctor_Load(object sender, System.EventArgs e)
        {
            //设置DataGridView columns长度 适合字段头
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            //设置前景色背景色
            dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.DefaultCellStyle.BackColor = Color.Beige;

            string sql = "select * from `hm_doctor`";
            DbHelper db = new DbHelper();
            DataTable data = db.ExecuteDataTable(sql, null);
            //DbDataReader reader = db.ExecuteReader(sql, null);
            //reader.Close();
            this.dataGridView1.DataSource = data;
            //this.dataGridView1.DataBindings();
            //            MySqlParameter[] parameters = {
            //new MySqlParameter("@a_User", username),
            //new MySqlParameter("@a_Password", pass),
            //new MySqlParameter("@a_Name", name),
            //new MySqlParameter("@a_E_mail", mail),
            //new MySqlParameter("@a_Phone", phone),
            //};

            //            int ok = db.ExecuteNonQuery(sql, parameters);
            //this.dataGridView2.DataSource = data;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            //DataGridViewRow dr = new DataGridViewRow();
            //dr.CreateCells(dataGridView1);
            //dr.Cells[0].Value = 1;
            //dr.Cells[1].Value = "何医生";
            //dataGridView2.Rows.Insert(0, dr);     //插入的数据作为第一行显示
            string d_Name = "";
            string d_Profession = "";
            string d_Time = "";
            string d_Major = "";
            string d_Department = "";
            string p_Expert = "";
            if (dataGridView2.CurrentRow.Index > -1)
            {
                d_Name = dataGridView2.Rows[0].Cells["d_Name"].Value.ToString();
                d_Profession = dataGridView2.Rows[0].Cells["d_Profession"].Value.ToString();
                d_Time = dataGridView2.Rows[0].Cells["d_Time"].Value.ToString();
                d_Major = dataGridView2.Rows[0].Cells["d_Major"].Value.ToString();
                d_Department = dataGridView2.Rows[0].Cells["d_Department"].Value.ToString();
                p_Expert = dataGridView2.Rows[0].Cells["p_Expert"].Value.ToString();
                dataGridView2.EndEdit();
                //string[] strArray = {"1", "医生", "外科" };
                //DataRow dr = new DataRow();
                //dr.ItemArray.SetValue("医生", 1);
                //((DataTable)dataGridView1.DataSource).Rows.Add(strArray);
                //dataGridView1.Rows.Add(dr);                    //插入的数据作为最后一行显示
                DbHelper db = new DbHelper();
                string sql = "select * from `hm_doctor`";
                DataSet ds = db.ExecuteDataSet(sql);
                DataTable dt = (DataTable)this.dataGridView1.DataSource;
                DataRow dr = dt.NewRow();
                dr["d_Name"] = d_Name;
                dr["d_Profession"] = d_Profession;
                dr["d_Time"] = d_Time;
                dr["d_Major"] = d_Major;
                dr["d_Department"] = d_Department;
                dr["p_Expert"] = p_Expert;
                //dt.Rows.Add(dr);

                //dt.AcceptChanges();

                //ds.Tables.Add(dt);
                //ds.Tables[0].AcceptChanges();
                ds.Tables[0].Rows.Add(dr.ItemArray);
                //ds.AcceptChanges();
                bool ok = db.Update(sql, ds);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                MessageBox.Show("没有新增的数据."+ dataGridView2.CurrentRow.Index);
            }
            


        }

        private void btnFlush_Click(object sender, System.EventArgs e)
        {
            
            string sql = "select * from `hm_doctor`";
            DbHelper db = new DbHelper();
            DataTable data = db.ExecuteDataTable(sql, null);
            //DbDataReader reader = db.ExecuteReader(sql, null);
            //reader.Close();
            //dataGridView1.DataSource = dss.Tables[0].DefaultView;
            this.dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView _dgv = (DataGridView)sender;
            string d_Name = _dgv.Rows[e.RowIndex].Cells["d_Name"].Value.ToString();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            string mDeleteStr = "";
            //删除数据条数计数
            int count = 0;
            //string d_id = "";
            count = dataGridView1.SelectedRows.Count;
            //遍历数据获取checkbox为ture的行的ListCd值
            for (int i = 0; i < count; i++)
            {
                //d_id = dataGridView2.Rows[0].Cells["I_Id"].Value.ToString();
                //if (Convert.ToBoolean(dataGridView1[0, i].Value))
                //{
                //    mDeleteStr += dataGridView1[1, i].Value.ToString().Trim() + ",";
                //    count++;
                //}
                mDeleteStr += dataGridView1.SelectedRows[i].Cells[0].EditedFormattedValue.ToString().Trim() + ",";

            }
            

            if (count > 0)
            {
                
                mDeleteStr = mDeleteStr.Substring(0, mDeleteStr.Length - 1);
                mDeleteStr = "delete from hm_doctor where I_Id  in (" + mDeleteStr + ")";
                DbHelper db = new DbHelper();
                //ExuSQL(mDeleteStr);
                db.ExecuteNonQuery(mDeleteStr, null);
                MessageBox.Show("已删除数据：" + count + "条");
                //ExuSQL(selectStr + curTableStr);
                string sql = "select * from `hm_doctor`";
                //DbHelper db = new DbHelper();
                DataTable data = db.ExecuteDataTable(sql, null);
                //DbDataReader reader = db.ExecuteReader(sql, null);
                //reader.Close();
                //dataGridView1.DataSource = dss.Tables[0].DefaultView;
                this.dataGridView1.DataSource = data;
            }
            else
            {

                MessageBox.Show("未选中任何数据！");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.dataGridView2.EndEdit();
        }
    }
}
