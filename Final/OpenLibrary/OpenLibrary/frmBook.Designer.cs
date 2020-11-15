namespace OpenLibrary
{
    partial class frmBook
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
            this.lblTitleBook = new System.Windows.Forms.Label();
            this.grbBook = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboBookType = new System.Windows.Forms.ComboBox();
            this.cboPublishing = new System.Windows.Forms.ComboBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblPublishingCompany = new System.Windows.Forms.Label();
            this.lblBookTypeName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.grbButton = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbBook.SuspendLayout();
            this.grbButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleBook
            // 
            this.lblTitleBook.AutoSize = true;
            this.lblTitleBook.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBook.ForeColor = System.Drawing.Color.Blue;
            this.lblTitleBook.Location = new System.Drawing.Point(440, 19);
            this.lblTitleBook.Name = "lblTitleBook";
            this.lblTitleBook.Size = new System.Drawing.Size(193, 26);
            this.lblTitleBook.TabIndex = 0;
            this.lblTitleBook.Text = "QUẢN LÝ SÁCH";
            // 
            // grbBook
            // 
            this.grbBook.Controls.Add(this.txtDescription);
            this.grbBook.Controls.Add(this.cboBookType);
            this.grbBook.Controls.Add(this.cboPublishing);
            this.grbBook.Controls.Add(this.txtBookPrice);
            this.grbBook.Controls.Add(this.txtBookID);
            this.grbBook.Controls.Add(this.txtBookName);
            this.grbBook.Controls.Add(this.lblPublishingCompany);
            this.grbBook.Controls.Add(this.lblBookTypeName);
            this.grbBook.Controls.Add(this.lblDescription);
            this.grbBook.Controls.Add(this.lblBookPrice);
            this.grbBook.Controls.Add(this.lblBookID);
            this.grbBook.Controls.Add(this.lblBookName);
            this.grbBook.Location = new System.Drawing.Point(21, 57);
            this.grbBook.Name = "grbBook";
            this.grbBook.Size = new System.Drawing.Size(846, 112);
            this.grbBook.TabIndex = 1;
            this.grbBook.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(602, 59);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(190, 22);
            this.txtDescription.TabIndex = 5;
            // 
            // cboBookType
            // 
            this.cboBookType.FormattingEnabled = true;
            this.cboBookType.Location = new System.Drawing.Point(602, 27);
            this.cboBookType.Name = "cboBookType";
            this.cboBookType.Size = new System.Drawing.Size(190, 24);
            this.cboBookType.TabIndex = 4;
            // 
            // cboPublishing
            // 
            this.cboPublishing.FormattingEnabled = true;
            this.cboPublishing.Location = new System.Drawing.Point(336, 55);
            this.cboPublishing.Name = "cboPublishing";
            this.cboPublishing.Size = new System.Drawing.Size(168, 24);
            this.cboPublishing.TabIndex = 3;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(336, 27);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(168, 22);
            this.txtBookPrice.TabIndex = 2;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(88, 25);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(181, 22);
            this.txtBookID.TabIndex = 0;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(88, 57);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(181, 22);
            this.txtBookName.TabIndex = 1;
            // 
            // lblPublishingCompany
            // 
            this.lblPublishingCompany.AutoSize = true;
            this.lblPublishingCompany.Location = new System.Drawing.Point(290, 62);
            this.lblPublishingCompany.Name = "lblPublishingCompany";
            this.lblPublishingCompany.Size = new System.Drawing.Size(40, 17);
            this.lblPublishingCompany.TabIndex = 0;
            this.lblPublishingCompany.Text = "NXB:";
            // 
            // lblBookTypeName
            // 
            this.lblBookTypeName.AutoSize = true;
            this.lblBookTypeName.Location = new System.Drawing.Point(519, 32);
            this.lblBookTypeName.Name = "lblBookTypeName";
            this.lblBookTypeName.Size = new System.Drawing.Size(73, 17);
            this.lblBookTypeName.TabIndex = 0;
            this.lblBookTypeName.Text = "Loại sách:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(519, 62);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(47, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Mô tả:";
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Location = new System.Drawing.Point(287, 30);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(34, 17);
            this.lblBookPrice.TabIndex = 0;
            this.lblBookPrice.Text = "Giá:";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(6, 30);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(65, 17);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "Mã sách:";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(6, 62);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(71, 17);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Tên sách:";
            // 
            // grbButton
            // 
            this.grbButton.Controls.Add(this.btnCancel);
            this.grbButton.Controls.Add(this.btnDelete);
            this.grbButton.Controls.Add(this.btnUpdate);
            this.grbButton.Controls.Add(this.btnAdd);
            this.grbButton.Location = new System.Drawing.Point(932, 69);
            this.grbButton.Name = "grbButton";
            this.grbButton.Size = new System.Drawing.Size(144, 278);
            this.grbButton.TabIndex = 1;
            this.grbButton.TabStop = false;
            this.grbButton.Text = "Chức năng";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::OpenLibrary.Properties.Resources.IconError;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(34, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 42);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::OpenLibrary.Properties.Resources.exit__2_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(34, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 42);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::OpenLibrary.Properties.Resources.EDIT;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(34, 94);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 42);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::OpenLibrary.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(34, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(890, 300);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 543);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbButton);
            this.Controls.Add(this.grbBook);
            this.Controls.Add(this.lblTitleBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBook";
            this.grbBook.ResumeLayout(false);
            this.grbBook.PerformLayout();
            this.grbButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleBook;
        private System.Windows.Forms.GroupBox grbBook;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.GroupBox grbButton;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboBookType;
        private System.Windows.Forms.ComboBox cboPublishing;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label lblPublishingCompany;
        private System.Windows.Forms.Label lblBookTypeName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}