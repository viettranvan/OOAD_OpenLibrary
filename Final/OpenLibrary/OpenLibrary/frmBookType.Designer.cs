namespace OpenLibrary
{
    partial class frmBookType
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
            this.lblTitleBookType = new System.Windows.Forms.Label();
            this.grbBookType = new System.Windows.Forms.GroupBox();
            this.txtBookTypeName = new System.Windows.Forms.TextBox();
            this.txtBookTypeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBookTypeID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbButton = new System.Windows.Forms.GroupBox();
            this.grbBookType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleBookType
            // 
            this.lblTitleBookType.AutoSize = true;
            this.lblTitleBookType.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBookType.ForeColor = System.Drawing.Color.Blue;
            this.lblTitleBookType.Location = new System.Drawing.Point(274, 9);
            this.lblTitleBookType.Name = "lblTitleBookType";
            this.lblTitleBookType.Size = new System.Drawing.Size(260, 26);
            this.lblTitleBookType.TabIndex = 0;
            this.lblTitleBookType.Text = "QUẢN LÝ LOẠI SÁCH";
            // 
            // grbBookType
            // 
            this.grbBookType.Controls.Add(this.txtBookTypeName);
            this.grbBookType.Controls.Add(this.txtBookTypeID);
            this.grbBookType.Controls.Add(this.label3);
            this.grbBookType.Controls.Add(this.lblBookTypeID);
            this.grbBookType.Location = new System.Drawing.Point(85, 65);
            this.grbBookType.Name = "grbBookType";
            this.grbBookType.Size = new System.Drawing.Size(327, 87);
            this.grbBookType.TabIndex = 1;
            this.grbBookType.TabStop = false;
            // 
            // txtBookTypeName
            // 
            this.txtBookTypeName.Location = new System.Drawing.Point(91, 49);
            this.txtBookTypeName.Name = "txtBookTypeName";
            this.txtBookTypeName.Size = new System.Drawing.Size(181, 22);
            this.txtBookTypeName.TabIndex = 1;
            // 
            // txtBookTypeID
            // 
            this.txtBookTypeID.Location = new System.Drawing.Point(91, 13);
            this.txtBookTypeID.Name = "txtBookTypeID";
            this.txtBookTypeID.Size = new System.Drawing.Size(181, 22);
            this.txtBookTypeID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Loại";
            // 
            // lblBookTypeID
            // 
            this.lblBookTypeID.AutoSize = true;
            this.lblBookTypeID.Location = new System.Drawing.Point(6, 18);
            this.lblBookTypeID.Name = "lblBookTypeID";
            this.lblBookTypeID.Size = new System.Drawing.Size(62, 17);
            this.lblBookTypeID.TabIndex = 0;
            this.lblBookTypeID.Text = "Mã Loại:";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::OpenLibrary.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(35, 53);
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenKhoa});
            this.dataGridView1.Location = new System.Drawing.Point(26, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(498, 206);
            this.dataGridView1.TabIndex = 2;
            // 
            // MaLoai
            // 
            this.MaLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.Name = "MaLoai";
            // 
            // TenKhoa
            // 
            this.TenKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhoa.HeaderText = "Tên Loại";
            this.TenKhoa.Name = "TenKhoa";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::OpenLibrary.Properties.Resources.EDIT;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(35, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 42);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::OpenLibrary.Properties.Resources.exit__2_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(35, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 42);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::OpenLibrary.Properties.Resources.IconError;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(35, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 42);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbButton
            // 
            this.grbButton.Controls.Add(this.btnUpdate);
            this.grbButton.Controls.Add(this.btnAdd);
            this.grbButton.Controls.Add(this.btnCancel);
            this.grbButton.Controls.Add(this.btnDelete);
            this.grbButton.Location = new System.Drawing.Point(551, 65);
            this.grbButton.Name = "grbButton";
            this.grbButton.Size = new System.Drawing.Size(142, 282);
            this.grbButton.TabIndex = 3;
            this.grbButton.TabStop = false;
            this.grbButton.Text = "Chức năng";
            // 
            // frmBookType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 411);
            this.Controls.Add(this.grbButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbBookType);
            this.Controls.Add(this.lblTitleBookType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmBookType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại sách";
            this.grbBookType.ResumeLayout(false);
            this.grbBookType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleBookType;
        private System.Windows.Forms.GroupBox grbBookType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBookTypeName;
        private System.Windows.Forms.TextBox txtBookTypeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBookTypeID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
    }
}