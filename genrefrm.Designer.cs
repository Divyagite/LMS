namespace LibraryManagement
{
    partial class genrefrm
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
            this.txtbxgenre = new System.Windows.Forms.TextBox();
            this.btngenre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(428, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre:";
            // 
            // txtbxgenre
            // 
            this.txtbxgenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxgenre.Location = new System.Drawing.Point(534, 229);
            this.txtbxgenre.Name = "txtbxgenre";
            this.txtbxgenre.Size = new System.Drawing.Size(253, 30);
            this.txtbxgenre.TabIndex = 1;
            // 
            // btngenre
            // 
            this.btngenre.BackColor = System.Drawing.Color.AliceBlue;
            this.btngenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenre.Location = new System.Drawing.Point(496, 298);
            this.btngenre.Name = "btngenre";
            this.btngenre.Size = new System.Drawing.Size(105, 41);
            this.btngenre.TabIndex = 2;
            this.btngenre.Text = "Add";
            this.btngenre.UseVisualStyleBackColor = false;
            this.btngenre.Click += new System.EventHandler(this.btngenre_Click);
            // 
            // genrefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1253, 641);
            this.Controls.Add(this.btngenre);
            this.Controls.Add(this.txtbxgenre);
            this.Controls.Add(this.label1);
            this.Name = "genrefrm";
            this.Text = "Add Genre ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxgenre;
        private System.Windows.Forms.Button btngenre;
    }
}