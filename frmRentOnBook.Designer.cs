namespace LibraryManagement
{
    partial class frmRentOnBook
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearchUser = new System.Windows.Forms.TextBox();
            this.txtsearchbyBook = new System.Windows.Forms.TextBox();
            this.grdviewrentonBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewrentonBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(76, 74);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(188, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Search By UserName :-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By BookName :-";
            // 
            // txtsearchUser
            // 
            this.txtsearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchUser.Location = new System.Drawing.Point(270, 71);
            this.txtsearchUser.Name = "txtsearchUser";
            this.txtsearchUser.Size = new System.Drawing.Size(182, 27);
            this.txtsearchUser.TabIndex = 2;
            this.txtsearchUser.TextChanged += new System.EventHandler(this.txtsearchUser_TextChanged);
            // 
            // txtsearchbyBook
            // 
            this.txtsearchbyBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchbyBook.Location = new System.Drawing.Point(772, 71);
            this.txtsearchbyBook.Name = "txtsearchbyBook";
            this.txtsearchbyBook.Size = new System.Drawing.Size(181, 27);
            this.txtsearchbyBook.TabIndex = 3;
            this.txtsearchbyBook.TextChanged += new System.EventHandler(this.txtsearchbyBook_TextChanged);
            // 
            // grdviewrentonBooks
            // 
            this.grdviewrentonBooks.AllowUserToAddRows = false;
            this.grdviewrentonBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdviewrentonBooks.Location = new System.Drawing.Point(45, 123);
            this.grdviewrentonBooks.Name = "grdviewrentonBooks";
            this.grdviewrentonBooks.RowHeadersVisible = false;
            this.grdviewrentonBooks.RowHeadersWidth = 51;
            this.grdviewrentonBooks.RowTemplate.Height = 24;
            this.grdviewrentonBooks.Size = new System.Drawing.Size(1290, 492);
            this.grdviewrentonBooks.TabIndex = 4;
            this.grdviewrentonBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdviewrentonBooks_CellClick);
            this.grdviewrentonBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdviewrentonBooks_CellContentClick);
            this.grdviewrentonBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdviewrentonBooks_CellFormatting);
            this.grdviewrentonBooks.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdviewrentonBooks_CurrentCellDirtyStateChanged);
            // 
            // frmRentOnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1407, 680);
            this.Controls.Add(this.grdviewrentonBooks);
            this.Controls.Add(this.txtsearchbyBook);
            this.Controls.Add(this.txtsearchUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Name = "frmRentOnBook";
            this.Text = "frmRentOnBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRentOnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdviewrentonBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearchUser;
        private System.Windows.Forms.TextBox txtsearchbyBook;
        private System.Windows.Forms.DataGridView grdviewrentonBooks;
    }
}