namespace LibraryManagement
{
    partial class frmUnassignedBooks
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
            this.grdviewUnassignedBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewUnassignedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // grdviewUnassignedBooks
            // 
            this.grdviewUnassignedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdviewUnassignedBooks.Location = new System.Drawing.Point(27, 74);
            this.grdviewUnassignedBooks.Name = "grdviewUnassignedBooks";
            this.grdviewUnassignedBooks.RowHeadersWidth = 51;
            this.grdviewUnassignedBooks.RowTemplate.Height = 24;
            this.grdviewUnassignedBooks.Size = new System.Drawing.Size(936, 438);
            this.grdviewUnassignedBooks.TabIndex = 0;
            // 
            // frmUnassignedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 660);
            this.Controls.Add(this.grdviewUnassignedBooks);
            this.Name = "frmUnassignedBooks";
            this.Text = "frmUnassignedBooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUnassignedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdviewUnassignedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdviewUnassignedBooks;
    }
}