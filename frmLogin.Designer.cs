namespace LibraryManagement
{
    partial class frmLogin
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
            this.cmbxusertypelogin = new System.Windows.Forms.ComboBox();
            this.txtemaillogin = new System.Windows.Forms.TextBox();
            this.txtpasslogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // cmbxusertypelogin
            // 
            this.cmbxusertypelogin.FormattingEnabled = true;
            this.cmbxusertypelogin.Location = new System.Drawing.Point(481, 224);
            this.cmbxusertypelogin.Name = "cmbxusertypelogin";
            this.cmbxusertypelogin.Size = new System.Drawing.Size(152, 24);
            this.cmbxusertypelogin.TabIndex = 3;
            // 
            // txtemaillogin
            // 
            this.txtemaillogin.Location = new System.Drawing.Point(481, 288);
            this.txtemaillogin.Name = "txtemaillogin";
            this.txtemaillogin.Size = new System.Drawing.Size(152, 22);
            this.txtemaillogin.TabIndex = 4;
            // 
            // txtpasslogin
            // 
            this.txtpasslogin.Location = new System.Drawing.Point(481, 355);
            this.txtpasslogin.Name = "txtpasslogin";
            this.txtpasslogin.Size = new System.Drawing.Size(152, 22);
            this.txtpasslogin.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(429, 431);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 30);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 477);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtpasslogin);
            this.Controls.Add(this.txtemaillogin);
            this.Controls.Add(this.cmbxusertypelogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxusertypelogin;
        private System.Windows.Forms.TextBox txtemaillogin;
        private System.Windows.Forms.TextBox txtpasslogin;
        private System.Windows.Forms.Button btnLogin;
    }
}