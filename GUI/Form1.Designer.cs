namespace GUI
{
    partial class frmStudentManagement
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
            this.lblStudentManagement = new System.Windows.Forms.Label();
            this.grpStudentInfor = new System.Windows.Forms.GroupBox();
            this.btnAvatarSet = new System.Windows.Forms.Button();
            this.picAvatarSet = new System.Windows.Forms.PictureBox();
            this.lblAvatarSet = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkMajor = new System.Windows.Forms.CheckBox();
            this.grpStudentInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentManagement
            // 
            this.lblStudentManagement.AutoSize = true;
            this.lblStudentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentManagement.ForeColor = System.Drawing.Color.Blue;
            this.lblStudentManagement.Location = new System.Drawing.Point(246, 32);
            this.lblStudentManagement.Name = "lblStudentManagement";
            this.lblStudentManagement.Size = new System.Drawing.Size(409, 36);
            this.lblStudentManagement.TabIndex = 0;
            this.lblStudentManagement.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // grpStudentInfor
            // 
            this.grpStudentInfor.Controls.Add(this.btnAvatarSet);
            this.grpStudentInfor.Controls.Add(this.picAvatarSet);
            this.grpStudentInfor.Controls.Add(this.lblAvatarSet);
            this.grpStudentInfor.Controls.Add(this.txtStudentID);
            this.grpStudentInfor.Controls.Add(this.txtFullName);
            this.grpStudentInfor.Controls.Add(this.txtAverageScore);
            this.grpStudentInfor.Controls.Add(this.lblFaculty);
            this.grpStudentInfor.Controls.Add(this.lblAverageScore);
            this.grpStudentInfor.Controls.Add(this.lblFullName);
            this.grpStudentInfor.Controls.Add(this.lblStudentID);
            this.grpStudentInfor.Controls.Add(this.cmbFaculty);
            this.grpStudentInfor.Location = new System.Drawing.Point(24, 87);
            this.grpStudentInfor.Name = "grpStudentInfor";
            this.grpStudentInfor.Size = new System.Drawing.Size(363, 395);
            this.grpStudentInfor.TabIndex = 1;
            this.grpStudentInfor.TabStop = false;
            this.grpStudentInfor.Text = "Thông Tin Sinh Viên";
            // 
            // btnAvatarSet
            // 
            this.btnAvatarSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvatarSet.Location = new System.Drawing.Point(309, 271);
            this.btnAvatarSet.Name = "btnAvatarSet";
            this.btnAvatarSet.Size = new System.Drawing.Size(37, 41);
            this.btnAvatarSet.TabIndex = 7;
            this.btnAvatarSet.Text = "...";
            this.btnAvatarSet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAvatarSet.UseVisualStyleBackColor = true;
            this.btnAvatarSet.Click += new System.EventHandler(this.btnAvatarSet_Click);
            // 
            // picAvatarSet
            // 
            this.picAvatarSet.Location = new System.Drawing.Point(134, 239);
            this.picAvatarSet.Name = "picAvatarSet";
            this.picAvatarSet.Size = new System.Drawing.Size(153, 124);
            this.picAvatarSet.TabIndex = 6;
            this.picAvatarSet.TabStop = false;
            // 
            // lblAvatarSet
            // 
            this.lblAvatarSet.AutoSize = true;
            this.lblAvatarSet.Location = new System.Drawing.Point(27, 271);
            this.lblAvatarSet.Name = "lblAvatarSet";
            this.lblAvatarSet.Size = new System.Drawing.Size(46, 16);
            this.lblAvatarSet.TabIndex = 5;
            this.lblAvatarSet.Text = "Avatar";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(134, 38);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(142, 22);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentID_KeyPress);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(134, 79);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(204, 22);
            this.txtFullName.TabIndex = 1;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(134, 178);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(100, 22);
            this.txtAverageScore.TabIndex = 3;
            this.txtAverageScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAverageScore_KeyPress);
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(24, 138);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(38, 16);
            this.lblFaculty.TabIndex = 0;
            this.lblFaculty.Text = "Khoa";
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Location = new System.Drawing.Point(24, 184);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(59, 16);
            this.lblAverageScore.TabIndex = 0;
            this.lblAverageScore.Text = "Điểm TB";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(26, 85);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(52, 16);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Họ Tên";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(25, 44);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(85, 16);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Mã Sinh Viên";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(134, 130);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(204, 24);
            this.cmbFaculty.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 498);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 497);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column3});
            this.dgvStudent.Location = new System.Drawing.Point(421, 87);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(761, 395);
            this.dgvStudent.TabIndex = 3;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MSSV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Khoa";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ĐTB";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Chuyên ngành";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(179, 497);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 30);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1086, 502);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkMajor
            // 
            this.chkMajor.AutoSize = true;
            this.chkMajor.Location = new System.Drawing.Point(985, 61);
            this.chkMajor.Name = "chkMajor";
            this.chkMajor.Size = new System.Drawing.Size(197, 20);
            this.chkMajor.TabIndex = 6;
            this.chkMajor.Text = "Chưa đăng ký chuyên ngành";
            this.chkMajor.UseVisualStyleBackColor = true;
            this.chkMajor.CheckedChanged += new System.EventHandler(this.chkMajor_CheckedChanged);
            // 
            // frmStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 557);
            this.Controls.Add(this.chkMajor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpStudentInfor);
            this.Controls.Add(this.lblStudentManagement);
            this.Name = "frmStudentManagement";
            this.Text = "Quản lý thông tin sinh viên";
            this.Load += new System.EventHandler(this.frmStudentManagement_Load);
            this.grpStudentInfor.ResumeLayout(false);
            this.grpStudentInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentManagement;
        private System.Windows.Forms.GroupBox grpStudentInfor;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnAvatarSet;
        private System.Windows.Forms.PictureBox picAvatarSet;
        private System.Windows.Forms.Label lblAvatarSet;
        private System.Windows.Forms.CheckBox chkMajor;
    }
}

