namespace Main.GUI
{
    partial class frmEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gridUS1 = new Main.GUI.GridUS.GridUS();
            this.panel4 = new System.Windows.Forms.Panel();
            this.taskControl1 = new Main.GUI.TaskControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.groupPersonalInfo = new System.Windows.Forms.GroupBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMarried = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlaceMade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmloyeeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupAccount = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.groupPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.groupAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 498);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gridUS1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(563, 404);
            this.panel5.TabIndex = 2;
            // 
            // gridUS1
            // 
            this.gridUS1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUS1.IsSelected = false;
            this.gridUS1.Location = new System.Drawing.Point(0, 0);
            this.gridUS1.Name = "gridUS1";
            this.gridUS1.NumberRecord = 10;
            this.gridUS1.PageCurrent = 1;
            this.gridUS1.Size = new System.Drawing.Size(563, 404);
            this.gridUS1.Source = null;
            this.gridUS1.TabIndex = 0;
            this.gridUS1.ThongTinTimKiem = null;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.taskControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 447);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 51);
            this.panel4.TabIndex = 1;
            // 
            // taskControl1
            // 
            this.taskControl1.isSuccessFul = false;
            this.taskControl1.Location = new System.Drawing.Point(3, 6);
            this.taskControl1.Name = "taskControl1";
            this.taskControl1.Size = new System.Drawing.Size(406, 41);
            this.taskControl1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 43);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.groupPersonalInfo);
            this.panelContent.Controls.Add(this.groupAccount);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContent.Enabled = false;
            this.panelContent.Location = new System.Drawing.Point(563, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(590, 498);
            this.panelContent.TabIndex = 1;
            // 
            // groupPersonalInfo
            // 
            this.groupPersonalInfo.Controls.Add(this.cbState);
            this.groupPersonalInfo.Controls.Add(this.label12);
            this.groupPersonalInfo.Controls.Add(this.label11);
            this.groupPersonalInfo.Controls.Add(this.txtAddress);
            this.groupPersonalInfo.Controls.Add(this.label10);
            this.groupPersonalInfo.Controls.Add(this.txtPhoneNumber);
            this.groupPersonalInfo.Controls.Add(this.label9);
            this.groupPersonalInfo.Controls.Add(this.label8);
            this.groupPersonalInfo.Controls.Add(this.cbMarried);
            this.groupPersonalInfo.Controls.Add(this.label14);
            this.groupPersonalInfo.Controls.Add(this.dtBirthDay);
            this.groupPersonalInfo.Controls.Add(this.label7);
            this.groupPersonalInfo.Controls.Add(this.txtPlaceMade);
            this.groupPersonalInfo.Controls.Add(this.label13);
            this.groupPersonalInfo.Controls.Add(this.cbSex);
            this.groupPersonalInfo.Controls.Add(this.txtEmployeeName);
            this.groupPersonalInfo.Controls.Add(this.dtDate);
            this.groupPersonalInfo.Controls.Add(this.label6);
            this.groupPersonalInfo.Controls.Add(this.label5);
            this.groupPersonalInfo.Controls.Add(this.picAvatar);
            this.groupPersonalInfo.Controls.Add(this.txtCMND);
            this.groupPersonalInfo.Controls.Add(this.label4);
            this.groupPersonalInfo.Controls.Add(this.label3);
            this.groupPersonalInfo.Controls.Add(this.txtEmloyeeId);
            this.groupPersonalInfo.Controls.Add(this.label2);
            this.groupPersonalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPersonalInfo.Location = new System.Drawing.Point(0, 95);
            this.groupPersonalInfo.Name = "groupPersonalInfo";
            this.groupPersonalInfo.Size = new System.Drawing.Size(590, 403);
            this.groupPersonalInfo.TabIndex = 2;
            this.groupPersonalInfo.TabStop = false;
            this.groupPersonalInfo.Text = "Thông tin cá nhân";
            // 
            // cbState
            // 
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "Đang làm việc",
            "Đã nghỉ việc"});
            this.cbState.Location = new System.Drawing.Point(97, 135);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(182, 24);
            this.cbState.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(173, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 16);
            this.label12.TabIndex = 64;
            this.label12.Text = "(Click chuột phải để cập nhật)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Hình ảnh (3x4)";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(97, 164);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(476, 22);
            this.txtAddress.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 62;
            this.label10.Text = "Địa chỉ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(391, 135);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(182, 22);
            this.txtPhoneNumber.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "SĐT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Tình trạng";
            // 
            // cbMarried
            // 
            this.cbMarried.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarried.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarried.FormattingEnabled = true;
            this.cbMarried.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cbMarried.Location = new System.Drawing.Point(391, 105);
            this.cbMarried.Name = "cbMarried";
            this.cbMarried.Size = new System.Drawing.Size(182, 24);
            this.cbMarried.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(312, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 59;
            this.label14.Text = "Hôn nhân";
            // 
            // dtBirthDay
            // 
            this.dtBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthDay.Location = new System.Drawing.Point(97, 106);
            this.dtBirthDay.Name = "dtBirthDay";
            this.dtBirthDay.Size = new System.Drawing.Size(182, 22);
            this.dtBirthDay.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "Ngày sinh";
            // 
            // txtPlaceMade
            // 
            this.txtPlaceMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceMade.Location = new System.Drawing.Point(97, 78);
            this.txtPlaceMade.Name = "txtPlaceMade";
            this.txtPlaceMade.Size = new System.Drawing.Size(182, 22);
            this.txtPlaceMade.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 57;
            this.label13.Text = "Nơi cấp";
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbSex.Location = new System.Drawing.Point(391, 75);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(182, 24);
            this.cbSex.TabIndex = 48;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(391, 20);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(182, 22);
            this.txtEmployeeName.TabIndex = 42;
            // 
            // dtDate
            // 
            this.dtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Location = new System.Drawing.Point(391, 48);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(182, 22);
            this.dtDate.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Ngày cấp";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Red;
            this.picAvatar.Location = new System.Drawing.Point(15, 216);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(152, 160);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 49;
            this.picAvatar.TabStop = false;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(97, 50);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(182, 22);
            this.txtCMND.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "CMND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tên";
            // 
            // txtEmloyeeId
            // 
            this.txtEmloyeeId.Enabled = false;
            this.txtEmloyeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmloyeeId.Location = new System.Drawing.Point(97, 22);
            this.txtEmloyeeId.Name = "txtEmloyeeId";
            this.txtEmloyeeId.Size = new System.Drawing.Size(182, 22);
            this.txtEmloyeeId.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mã số";
            // 
            // groupAccount
            // 
            this.groupAccount.Controls.Add(this.txtPassword);
            this.groupAccount.Controls.Add(this.label16);
            this.groupAccount.Controls.Add(this.txtUserName);
            this.groupAccount.Controls.Add(this.label17);
            this.groupAccount.Controls.Add(this.cbRole);
            this.groupAccount.Controls.Add(this.label15);
            this.groupAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAccount.Location = new System.Drawing.Point(0, 0);
            this.groupAccount.Name = "groupAccount";
            this.groupAccount.Size = new System.Drawing.Size(590, 95);
            this.groupAccount.TabIndex = 1;
            this.groupAccount.TabStop = false;
            this.groupAccount.Text = "Thông tin tài khoản";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(391, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(312, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 16);
            this.label16.TabIndex = 61;
            this.label16.Text = "Mật khẩu";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(97, 53);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(182, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 16);
            this.label17.TabIndex = 58;
            this.label17.Text = "Tài khoản";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(97, 21);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(182, 24);
            this.cbRole.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 16);
            this.label15.TabIndex = 57;
            this.label15.Text = "Vai trò";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1153, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContent);
            this.Name = "frmEmployee";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.groupPersonalInfo.ResumeLayout(false);
            this.groupPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.groupAccount.ResumeLayout(false);
            this.groupAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContent;
        private GridUS.GridUS gridUS1;
        private TaskControl taskControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupPersonalInfo;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMarried;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtBirthDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlaceMade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmloyeeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label15;
    }
}