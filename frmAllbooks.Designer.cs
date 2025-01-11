namespace LibraryManagement
{
    partial class frmAllbooks
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
            this.grdallbooks = new System.Windows.Forms.DataGridView();
            this.txtsearchbyBook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdallbooks)).BeginInit();
            this.SuspendLayout();
            // 
            // grdallbooks
            // 
            this.grdallbooks.AllowUserToAddRows = false;
            this.grdallbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdallbooks.Location = new System.Drawing.Point(83, 85);
            this.grdallbooks.Name = "grdallbooks";
            this.grdallbooks.RowHeadersVisible = false;
            this.grdallbooks.RowHeadersWidth = 51;
            this.grdallbooks.RowTemplate.Height = 24;
            this.grdallbooks.Size = new System.Drawing.Size(1167, 558);
            this.grdallbooks.TabIndex = 0;
            this.grdallbooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdallbooks_CellContentClick);
            // 
            // txtsearchbyBook
            // 
            this.txtsearchbyBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchbyBook.Location = new System.Drawing.Point(275, 39);
            this.txtsearchbyBook.Name = "txtsearchbyBook";
            this.txtsearchbyBook.Size = new System.Drawing.Size(193, 27);
            this.txtsearchbyBook.TabIndex = 5;
            this.txtsearchbyBook.TextChanged += new System.EventHandler(this.txtsearchbyBook_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search By BookName :-";
            // 
            // frmAllbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(1392, 655);
            this.Controls.Add(this.txtsearchbyBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdallbooks);
            this.Name = "frmAllbooks";
            this.Text = "frmAllbooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAllbooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdallbooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdallbooks;
        private System.Windows.Forms.TextBox txtsearchbyBook;
        private System.Windows.Forms.Label label1;
    }
}