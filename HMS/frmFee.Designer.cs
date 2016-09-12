namespace HMS
{
    partial class frmFee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFee));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 248);
            this.dataGridView1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(292, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "收费管理信息";
            // 
            // txtKey
            // 
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKey.Location = new System.Drawing.Point(60, 55);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(557, 30);
            this.txtKey.TabIndex = 31;
            this.toolTip1.SetToolTip(this.txtKey, "请输入病历号");
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(624, 55);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 29);
            this.btnFind.TabIndex = 32;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkGray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(18, 349);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(688, 40);
            this.listBox1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "病例号";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 400);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 21);
            this.textBox2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "药费";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 400);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(63, 21);
            this.textBox3.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "挂号费";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(278, 401);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 21);
            this.textBox4.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 34;
            this.label5.Text = "处置费";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(396, 402);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(63, 21);
            this.textBox5.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 34;
            this.label6.Text = "化验费";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(510, 404);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(63, 21);
            this.textBox6.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(642, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(699, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 23);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 439);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFee";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmFee";
            this.Load += new System.EventHandler(this.frmFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}