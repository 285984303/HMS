namespace HMS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picDoctor = new System.Windows.Forms.PictureBox();
            this.picPatient = new System.Windows.Forms.PictureBox();
            this.picFee = new System.Windows.Forms.PictureBox();
            this.picFind = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picMini = new System.Windows.Forms.PictureBox();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.Transparent;
            this.picBack.BackgroundImage = global::HMS.Properties.Resources.QQ截图20160908102133;
            this.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBack.Location = new System.Drawing.Point(24, 14);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(100, 50);
            this.picBack.TabIndex = 0;
            this.picBack.TabStop = false;
            this.toolTip1.SetToolTip(this.picBack, "返回登录");
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // picDoctor
            // 
            this.picDoctor.BackColor = System.Drawing.Color.Transparent;
            this.picDoctor.BackgroundImage = global::HMS.Properties.Resources.QQ截图20160908102141;
            this.picDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picDoctor.Location = new System.Drawing.Point(146, 134);
            this.picDoctor.Name = "picDoctor";
            this.picDoctor.Size = new System.Drawing.Size(79, 95);
            this.picDoctor.TabIndex = 0;
            this.picDoctor.TabStop = false;
            this.toolTip1.SetToolTip(this.picDoctor, "医生信息管理");
            this.picDoctor.Click += new System.EventHandler(this.picDoctor_Click);
            // 
            // picPatient
            // 
            this.picPatient.BackColor = System.Drawing.Color.Transparent;
            this.picPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPatient.Image = global::HMS.Properties.Resources.QQ截图20160908102148;
            this.picPatient.Location = new System.Drawing.Point(274, 134);
            this.picPatient.Name = "picPatient";
            this.picPatient.Size = new System.Drawing.Size(88, 95);
            this.picPatient.TabIndex = 0;
            this.picPatient.TabStop = false;
            this.toolTip1.SetToolTip(this.picPatient, "求医者信息管理");
            this.picPatient.Click += new System.EventHandler(this.picPatient_Click);
            // 
            // picFee
            // 
            this.picFee.BackColor = System.Drawing.Color.Transparent;
            this.picFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picFee.Image = global::HMS.Properties.Resources.QQ截图20160908102148;
            this.picFee.Location = new System.Drawing.Point(405, 134);
            this.picFee.Name = "picFee";
            this.picFee.Size = new System.Drawing.Size(88, 95);
            this.picFee.TabIndex = 0;
            this.picFee.TabStop = false;
            this.toolTip1.SetToolTip(this.picFee, "收费信息管理");
            this.picFee.Click += new System.EventHandler(this.picFee_Click);
            // 
            // picFind
            // 
            this.picFind.BackColor = System.Drawing.Color.Transparent;
            this.picFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picFind.Image = global::HMS.Properties.Resources.QQ截图20160908102155;
            this.picFind.Location = new System.Drawing.Point(546, 134);
            this.picFind.Name = "picFind";
            this.picFind.Size = new System.Drawing.Size(90, 95);
            this.picFind.TabIndex = 0;
            this.picFind.TabStop = false;
            this.toolTip1.SetToolTip(this.picFind, "信息查询");
            this.picFind.Click += new System.EventHandler(this.picFind_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = global::HMS.Properties.Resources.exit;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picExit.Location = new System.Drawing.Point(817, 13);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(35, 33);
            this.picExit.TabIndex = 2;
            this.picExit.TabStop = false;
            this.toolTip1.SetToolTip(this.picExit, "退出系统");
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picMini
            // 
            this.picMini.BackColor = System.Drawing.Color.Transparent;
            this.picMini.BackgroundImage = global::HMS.Properties.Resources.mini;
            this.picMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMini.Location = new System.Drawing.Point(776, 14);
            this.picMini.Name = "picMini";
            this.picMini.Size = new System.Drawing.Size(35, 33);
            this.picMini.TabIndex = 2;
            this.picMini.TabStop = false;
            this.toolTip1.SetToolTip(this.picMini, "最小化");
            this.picMini.Click += new System.EventHandler(this.picMini_Click);
            // 
            // picInfo
            // 
            this.picInfo.BackColor = System.Drawing.Color.Transparent;
            this.picInfo.BackgroundImage = global::HMS.Properties.Resources.info;
            this.picInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picInfo.Location = new System.Drawing.Point(735, 14);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(35, 33);
            this.picInfo.TabIndex = 2;
            this.picInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.picInfo, "系统信息");
            this.picInfo.Click += new System.EventHandler(this.picInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(462, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "￥";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HMS.Properties.Resources.eb32c1fb998feb6576dab0cfac50f32a_big;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picInfo);
            this.Controls.Add(this.picMini);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picFind);
            this.Controls.Add(this.picFee);
            this.Controls.Add(this.picPatient);
            this.Controls.Add(this.picDoctor);
            this.Controls.Add(this.picBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox picDoctor;
        private System.Windows.Forms.PictureBox picPatient;
        private System.Windows.Forms.PictureBox picFee;
        private System.Windows.Forms.PictureBox picFind;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picMini;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}