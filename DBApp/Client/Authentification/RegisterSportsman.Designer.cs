namespace DBApp
{
    partial class RegisterSportsman
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
            this.FullNameIn = new System.Windows.Forms.TextBox();
            this.PasswordIn = new System.Windows.Forms.TextBox();
            this.LoginIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.PhoneIn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FullNameIn
            // 
            this.FullNameIn.Location = new System.Drawing.Point(72, 64);
            this.FullNameIn.Name = "FullNameIn";
            this.FullNameIn.Size = new System.Drawing.Size(185, 20);
            this.FullNameIn.TabIndex = 25;
            this.FullNameIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameIn_KeyPress);
            // 
            // PasswordIn
            // 
            this.PasswordIn.Location = new System.Drawing.Point(72, 38);
            this.PasswordIn.Name = "PasswordIn";
            this.PasswordIn.Size = new System.Drawing.Size(185, 20);
            this.PasswordIn.TabIndex = 24;
            this.PasswordIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordIn_KeyPress);
            // 
            // LoginIn
            // 
            this.LoginIn.Location = new System.Drawing.Point(72, 8);
            this.LoginIn.Name = "LoginIn";
            this.LoginIn.Size = new System.Drawing.Size(185, 20);
            this.LoginIn.TabIndex = 23;
            this.LoginIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginIn_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(12, 116);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(77, 23);
            this.RegisterBtn.TabIndex = 17;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(207, 116);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(77, 23);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // PhoneIn
            // 
            this.PhoneIn.Location = new System.Drawing.Point(72, 90);
            this.PhoneIn.Name = "PhoneIn";
            this.PhoneIn.Size = new System.Drawing.Size(185, 20);
            this.PhoneIn.TabIndex = 26;
            this.PhoneIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneIn_KeyPress);
            // 
            // RegisterSportsman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 157);
            this.Controls.Add(this.PhoneIn);
            this.Controls.Add(this.FullNameIn);
            this.Controls.Add(this.PasswordIn);
            this.Controls.Add(this.LoginIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.CancelBtn);
            this.Name = "RegisterSportsman";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullNameIn;
        private System.Windows.Forms.TextBox PasswordIn;
        private System.Windows.Forms.TextBox LoginIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox PhoneIn;
    }
}