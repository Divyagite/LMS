namespace LibraryManagement
{
    partial class frmCupboard
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
            this.btnaddCupboard = new System.Windows.Forms.Button();
            this.cmbxgenrecb = new System.Windows.Forms.ComboBox();
            this.txtbxaddcupboard = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Cupboard:";
            // 
            // btnaddCupboard
            // 
            this.btnaddCupboard.Location = new System.Drawing.Point(282, 287);
            this.btnaddCupboard.Name = "btnaddCupboard";
            this.btnaddCupboard.Size = new System.Drawing.Size(75, 33);
            this.btnaddCupboard.TabIndex = 2;
            this.btnaddCupboard.Text = "Add";
            this.btnaddCupboard.UseVisualStyleBackColor = true;
            this.btnaddCupboard.Click += new System.EventHandler(this.btnaddCupboard_Click);
            // 
            // cmbxgenrecb
            // 
            this.cmbxgenrecb.FormattingEnabled = true;
            this.cmbxgenrecb.Location = new System.Drawing.Point(315, 146);
            this.cmbxgenrecb.Name = "cmbxgenrecb";
            this.cmbxgenrecb.Size = new System.Drawing.Size(150, 24);
            this.cmbxgenrecb.TabIndex = 3;
            this.cmbxgenrecb.SelectedIndexChanged += new System.EventHandler(this.cmbxgenrecb_SelectedIndexChanged);
            // 
            // txtbxaddcupboard
            // 
            this.txtbxaddcupboard.Location = new System.Drawing.Point(315, 211);
            this.txtbxaddcupboard.Name = "txtbxaddcupboard";
            this.txtbxaddcupboard.Size = new System.Drawing.Size(150, 22);
            this.txtbxaddcupboard.TabIndex = 4;
            // 
            // frmCupboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxaddcupboard);
            this.Controls.Add(this.cmbxgenrecb);
            this.Controls.Add(this.btnaddCupboard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCupboard";
            this.Text = "frmCupboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCupboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnaddCupboard;
        private System.Windows.Forms.ComboBox cmbxgenrecb;
        private System.Windows.Forms.TextBox txtbxaddcupboard;
    }
}