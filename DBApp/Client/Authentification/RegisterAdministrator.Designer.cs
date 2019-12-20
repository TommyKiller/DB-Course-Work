namespace DBApp
{
    partial class RegisterAdministrator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginIn = new System.Windows.Forms.TextBox();
            this.PasswordIn = new System.Windows.Forms.TextBox();
            this.NameIn = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.CnacelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full name";
            // 
            // LoginIn
            // 
            this.LoginIn.Location = new System.Drawing.Point(71, 12);
            this.LoginIn.Name = "LoginIn";
            this.LoginIn.Size = new System.Drawing.Size(100, 20);
            this.LoginIn.TabIndex = 3;
            this.LoginIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginIn_KeyPress);
            // 
            // PasswordIn
            // 
            this.PasswordIn.Location = new System.Drawing.Point(71, 38);
            this.PasswordIn.Name = "PasswordIn";
            this.PasswordIn.Size = new System.Drawing.Size(100, 20);
            this.PasswordIn.TabIndex = 4;
            this.PasswordIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordIn_KeyPress);
            // 
            // NameIn
            // 
            this.NameIn.Location = new System.Drawing.Point(71, 64);
            this.NameIn.Name = "NameIn";
            this.NameIn.Size = new System.Drawing.Size(100, 20);
            this.NameIn.TabIndex = 5;
            this.NameIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameIn_KeyPress);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(15, 90);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(62, 23);
            this.RegisterBtn.TabIndex = 6;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // CnacelBtn
            // 
            this.CnacelBtn.Location = new System.Drawing.Point(118, 90);
            this.CnacelBtn.Name = "CnacelBtn";
            this.CnacelBtn.Size = new System.Drawing.Size(53, 23);
            this.CnacelBtn.TabIndex = 7;
            this.CnacelBtn.Text = "Cancel";
            this.CnacelBtn.UseVisualStyleBackColor = true;
            this.CnacelBtn.Click += new System.EventHandler(this.CnacelBtn_Click);
            // 
            // RegisterAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 134);
            this.Controls.Add(this.CnacelBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.NameIn);
            this.Controls.Add(this.PasswordIn);
            this.Controls.Add(this.LoginIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterAdministrator";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginIn;
        private System.Windows.Forms.TextBox PasswordIn;
        private System.Windows.Forms.TextBox NameIn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button CnacelBtn;
    }
}