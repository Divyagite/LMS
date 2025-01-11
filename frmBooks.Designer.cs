namespace LibraryManagement
{
    partial class frmBooks
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
            this.cmbxgenrebooks = new System.Windows.Forms.ComboBox();
            this.cmbxcupboardbooks = new System.Windows.Forms.ComboBox();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.btnAddbooks = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrealprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cupboard:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book name:";
            // 
            // cmbxgenrebooks
            // 
            this.cmbxgenrebooks.FormattingEnabled = true;
            this.cmbxgenrebooks.Location = new System.Drawing.Point(298, 139);
            this.cmbxgenrebooks.Name = "cmbxgenrebooks";
            this.cmbxgenrebooks.Size = new System.Drawing.Size(156, 24);
            this.cmbxgenrebooks.TabIndex = 3;
            this.cmbxgenrebooks.SelectedIndexChanged += new System.EventHandler(this.cmbxgenrebooks_SelectedIndexChanged);
            // 
            // cmbxcupboardbooks
            // 
            this.cmbxcupboardbooks.FormattingEnabled = true;
            this.cmbxcupboardbooks.Location = new System.Drawing.Point(298, 185);
            this.cmbxcupboardbooks.Name = "cmbxcupboardbooks";
            this.cmbxcupboardbooks.Size = new System.Drawing.Size(156, 24);
            this.cmbxcupboardbooks.TabIndex = 4;
            this.cmbxcupboardbooks.SelectedIndexChanged += new System.EventHandler(this.cmbxcupboardbooks_SelectedIndexChanged);
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(298, 235);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(156, 22);
            this.txtbookname.TabIndex = 5;
            // 
            // btnAddbooks
            // 
            this.btnAddbooks.Location = new System.Drawing.Point(221, 367);
            this.btnAddbooks.Name = "btnAddbooks";
            this.btnAddbooks.Size = new System.Drawing.Size(87, 35);
            this.btnAddbooks.TabIndex = 6;
            this.btnAddbooks.Text = "Add";
            this.btnAddbooks.UseVisualStyleBackColor = true;
            this.btnAddbooks.Click += new System.EventHandler(this.btnAddbooks_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rent Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity:";
            // 
            // txtrealprice
            // 
            this.txtrealprice.Location = new System.Drawing.Point(298, 279);
            this.txtrealprice.Name = "txtrealprice";
            this.txtrealprice.Size = new System.Drawing.Size(156, 22);
            this.txtrealprice.TabIndex = 9;
            this.txtrealprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrealprice_KeyPress);
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(298, 315);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(156, 22);
            this.txtquantity.TabIndex = 10;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(369, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 35);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1032, 577);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtrealprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddbooks);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.cmbxcupboardbooks);
            this.Controls.Add(this.cmbxgenrebooks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBooks";
            this.Text = "frmBooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxgenrebooks;
        private System.Windows.Forms.ComboBox cmbxcupboardbooks;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Button btnAddbooks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrealprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button btnClear;
    }
}