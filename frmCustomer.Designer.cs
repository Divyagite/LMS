namespace LibraryManagement
{
    partial class frmCustomer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRentBooks = new System.Windows.Forms.Button();
            this.txtbxtotalamt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridviewbookdata = new System.Windows.Forms.DataGridView();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbxGenre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxcupboard = new System.Windows.Forms.ComboBox();
            this.txtbxrentprice = new System.Windows.Forms.TextBox();
            this.lstviewcust = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblContactS = new System.Windows.Forms.Label();
            this.lblUid = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.btnremovecart = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewbookdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(1295, 560);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 34);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRentBooks
            // 
            this.btnRentBooks.BackColor = System.Drawing.Color.Lime;
            this.btnRentBooks.Location = new System.Drawing.Point(1032, 560);
            this.btnRentBooks.Name = "btnRentBooks";
            this.btnRentBooks.Size = new System.Drawing.Size(162, 34);
            this.btnRentBooks.TabIndex = 20;
            this.btnRentBooks.Text = "Rent Books";
            this.btnRentBooks.UseVisualStyleBackColor = false;
            this.btnRentBooks.Click += new System.EventHandler(this.btnRentBooks_Click);
            // 
            // txtbxtotalamt
            // 
            this.txtbxtotalamt.Location = new System.Drawing.Point(1265, 521);
            this.txtbxtotalamt.Name = "txtbxtotalamt";
            this.txtbxtotalamt.ReadOnly = true;
            this.txtbxtotalamt.Size = new System.Drawing.Size(114, 22);
            this.txtbxtotalamt.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1155, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total Amount:";
            // 
            // gridviewbookdata
            // 
            this.gridviewbookdata.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.gridviewbookdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridviewbookdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridviewbookdata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridviewbookdata.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewbookdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridviewbookdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewbookdata.GridColor = System.Drawing.Color.Black;
            this.gridviewbookdata.Location = new System.Drawing.Point(36, 187);
            this.gridviewbookdata.Name = "gridviewbookdata";
            this.gridviewbookdata.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewbookdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridviewbookdata.RowHeadersWidth = 51;
            this.gridviewbookdata.RowTemplate.Height = 24;
            this.gridviewbookdata.Size = new System.Drawing.Size(485, 223);
            this.gridviewbookdata.TabIndex = 17;
            this.gridviewbookdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewbookdata_CellContentClick);
            this.gridviewbookdata.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridviewbookdata_RowHeaderMouseClick);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddtoCart.Location = new System.Drawing.Point(579, 263);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(164, 44);
            this.btnAddtoCart.TabIndex = 16;
            this.btnAddtoCart.Text = "Add To Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = false;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 564);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbxGenre
            // 
            this.cmbxGenre.FormattingEnabled = true;
            this.cmbxGenre.Location = new System.Drawing.Point(194, 68);
            this.cmbxGenre.Name = "cmbxGenre";
            this.cmbxGenre.Size = new System.Drawing.Size(210, 24);
            this.cmbxGenre.TabIndex = 14;
            this.cmbxGenre.SelectedIndexChanged += new System.EventHandler(this.cmbxGenre_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(57, 569);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Return Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(66, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rent Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(80, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(57, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cupboard:";
            // 
            // cmbxcupboard
            // 
            this.cmbxcupboard.FormattingEnabled = true;
            this.cmbxcupboard.Location = new System.Drawing.Point(194, 123);
            this.cmbxcupboard.Name = "cmbxcupboard";
            this.cmbxcupboard.Size = new System.Drawing.Size(210, 24);
            this.cmbxcupboard.TabIndex = 23;
            this.cmbxcupboard.SelectedIndexChanged += new System.EventHandler(this.cmbxcupboard_SelectedIndexChanged);
            // 
            // txtbxrentprice
            // 
            this.txtbxrentprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxrentprice.Location = new System.Drawing.Point(194, 511);
            this.txtbxrentprice.Name = "txtbxrentprice";
            this.txtbxrentprice.ReadOnly = true;
            this.txtbxrentprice.Size = new System.Drawing.Size(200, 22);
            this.txtbxrentprice.TabIndex = 24;
            // 
            // lstviewcust
            // 
            this.lstviewcust.HideSelection = false;
            this.lstviewcust.Location = new System.Drawing.Point(848, 145);
            this.lstviewcust.Name = "lstviewcust";
            this.lstviewcust.Size = new System.Drawing.Size(801, 354);
            this.lstviewcust.TabIndex = 25;
            this.lstviewcust.UseCompatibleStateImageBehavior = false;
            this.lstviewcust.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstviewcust_ColumnClick);
            this.lstviewcust.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lstviewcust_DrawColumnHeader_1);
            this.lstviewcust.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lstviewcust_DrawItem_1);
            this.lstviewcust.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lstviewcust_DrawSubItem_1);
            this.lstviewcust.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstviewcust_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(782, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cart:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(1169, 600);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 34);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(848, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(848, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(834, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1190, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "Contact:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(918, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(13, 18);
            this.lblName.TabIndex = 32;
            this.lblName.Text = ":";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(918, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(13, 18);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = ":";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(918, 93);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(13, 18);
            this.lblAdd.TabIndex = 34;
            this.lblAdd.Text = ":";
            // 
            // lblContactS
            // 
            this.lblContactS.AutoSize = true;
            this.lblContactS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactS.Location = new System.Drawing.Point(1251, 13);
            this.lblContactS.Name = "lblContactS";
            this.lblContactS.Size = new System.Drawing.Size(13, 18);
            this.lblContactS.TabIndex = 35;
            this.lblContactS.Text = ":";
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUid.Location = new System.Drawing.Point(1190, 53);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(38, 18);
            this.lblUid.TabIndex = 36;
            this.lblUid.Text = "UId:";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblquantity.Location = new System.Drawing.Point(80, 470);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(67, 16);
            this.lblquantity.TabIndex = 37;
            this.lblquantity.Text = "Quantity:";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(194, 467);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.ReadOnly = true;
            this.txtquantity.Size = new System.Drawing.Size(200, 22);
            this.txtquantity.TabIndex = 38;
            // 
            // btnremovecart
            // 
            this.btnremovecart.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnremovecart.Location = new System.Drawing.Point(579, 341);
            this.btnremovecart.Name = "btnremovecart";
            this.btnremovecart.Size = new System.Drawing.Size(164, 34);
            this.btnremovecart.TabIndex = 39;
            this.btnremovecart.Text = "Remove From Cart";
            this.btnremovecart.UseVisualStyleBackColor = false;
            this.btnremovecart.Click += new System.EventHandler(this.btnremovecart_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "red cross.jpg");
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1674, 652);
            this.Controls.Add(this.btnremovecart);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.lblContactS);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstviewcust);
            this.Controls.Add(this.txtbxrentprice);
            this.Controls.Add(this.cmbxcupboard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRentBooks);
            this.Controls.Add(this.txtbxtotalamt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridviewbookdata);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbxGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewbookdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRentBooks;
        private System.Windows.Forms.TextBox txtbxtotalamt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridviewbookdata;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbxGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxcupboard;
        private System.Windows.Forms.TextBox txtbxrentprice;
        private System.Windows.Forms.ListView lstviewcust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblContactS;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button btnremovecart;
        private System.Windows.Forms.ImageList imageList1;
    }
}