namespace DBApp
{
    partial class RegisterTrainer
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginIn = new System.Windows.Forms.TextBox();
            this.PasswordIn = new System.Windows.Forms.TextBox();
            this.FullNameIn = new System.Windows.Forms.TextBox();
            this.MasterDegreeLst = new System.Windows.Forms.ComboBox();
            this.KindsOfSportLst = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(203, 154);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(77, 23);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(12, 154);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(77, 23);
            this.RegisterBtn.TabIndex = 1;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Master Degree";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kind of Sport";
            // 
            // LoginIn
            // 
            this.LoginIn.Location = new System.Drawing.Point(95, 12);
            this.LoginIn.Name = "LoginIn";
            this.LoginIn.Size = new System.Drawing.Size(185, 20);
            this.LoginIn.TabIndex = 11;
            this.LoginIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginIn_KeyPress);
            // 
            // PasswordIn
            // 
            this.PasswordIn.Location = new System.Drawing.Point(95, 38);
            this.PasswordIn.Name = "PasswordIn";
            this.PasswordIn.Size = new System.Drawing.Size(185, 20);
            this.PasswordIn.TabIndex = 12;
            this.PasswordIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordIn_KeyPress);
            // 
            // FullNameIn
            // 
            this.FullNameIn.Location = new System.Drawing.Point(95, 64);
            this.FullNameIn.Name = "FullNameIn";
            this.FullNameIn.Size = new System.Drawing.Size(185, 20);
            this.FullNameIn.TabIndex = 13;
            this.FullNameIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameIn_KeyPress);
            // 
            // MasterDegreeLst
            // 
            this.MasterDegreeLst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MasterDegreeLst.FormattingEnabled = true;
            this.MasterDegreeLst.Items.AddRange(new object[] {
            "novice",
            "amateur",
            "master"});
            this.MasterDegreeLst.Location = new System.Drawing.Point(95, 90);
            this.MasterDegreeLst.Name = "MasterDegreeLst";
            this.MasterDegreeLst.Size = new System.Drawing.Size(185, 21);
            this.MasterDegreeLst.TabIndex = 14;
            // 
            // KindsOfSportLst
            // 
            this.KindsOfSportLst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KindsOfSportLst.FormattingEnabled = true;
            this.KindsOfSportLst.Location = new System.Drawing.Point(95, 117);
            this.KindsOfSportLst.Name = "KindsOfSportLst";
            this.KindsOfSportLst.Size = new System.Drawing.Size(185, 21);
            this.KindsOfSportLst.TabIndex = 15;
            // 
            // RegisterTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 189);
            this.Controls.Add(this.KindsOfSportLst);
            this.Controls.Add(this.MasterDegreeLst);
            this.Controls.Add(this.FullNameIn);
            this.Controls.Add(this.PasswordIn);
            this.Controls.Add(this.LoginIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.CancelBtn);
            this.Name = "RegisterTrainer";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterTrainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoginIn;
        private System.Windows.Forms.TextBox PasswordIn;
        private System.Windows.Forms.TextBox FullNameIn;
        private System.Windows.Forms.ComboBox MasterDegreeLst;
        private System.Windows.Forms.ComboBox KindsOfSportLst;
    }
}