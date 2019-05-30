namespace Main.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtMST = new DevExpress.XtraEditors.TextEdit();
            this.txtSTK = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtCusName = new DevExpress.XtraEditors.TextEdit();
            this.txtCusID = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridUS1 = new Main.GUI.GridUS.GridUS();
            this.taskControl1 = new Main.GUI.TaskControl();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gridUS1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 276);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 496);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panelContent);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 276);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.panel5.Controls.Add(this.taskControl1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 214);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1039, 62);
            this.panel5.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.layoutControl1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContent.Enabled = false;
            this.panelContent.Location = new System.Drawing.Point(0, 52);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1039, 156);
            this.panelContent.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtPhone);
            this.layoutControl1.Controls.Add(this.txtMST);
            this.layoutControl1.Controls.Add(this.txtSTK);
            this.layoutControl1.Controls.Add(this.txtAddress);
            this.layoutControl1.Controls.Add(this.txtCusName);
            this.layoutControl1.Controls.Add(this.txtCusID);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1037, 154);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(679, 100);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(342, 22);
            this.txtPhone.StyleController = this.layoutControl1;
            this.txtPhone.TabIndex = 9;
            // 
            // txtMST
            // 
            this.txtMST.Location = new System.Drawing.Point(679, 44);
            this.txtMST.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMST.Name = "txtMST";
            this.txtMST.Size = new System.Drawing.Size(342, 22);
            this.txtMST.StyleController = this.layoutControl1;
            this.txtMST.TabIndex = 8;
            // 
            // txtSTK
            // 
            this.txtSTK.Location = new System.Drawing.Point(110, 100);
            this.txtSTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(469, 22);
            this.txtSTK.StyleController = this.layoutControl1;
            this.txtSTK.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 72);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(911, 22);
            this.txtAddress.StyleController = this.layoutControl1;
            this.txtAddress.TabIndex = 6;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(110, 44);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(469, 22);
            this.txtCusName.StyleController = this.layoutControl1;
            this.txtCusName.TabIndex = 5;
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(110, 16);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Properties.ReadOnly = true;
            this.txtCusID.Size = new System.Drawing.Size(911, 22);
            this.txtCusID.StyleController = this.layoutControl1;
            this.txtCusID.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1037, 154);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCusID;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1011, 28);
            this.layoutControlItem1.Text = "Mã khách hàng";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(91, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtCusName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(569, 28);
            this.layoutControlItem2.Text = "Tên khách hàng";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(91, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtAddress;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1011, 28);
            this.layoutControlItem3.Text = "Địa chỉ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(91, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtSTK;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(569, 44);
            this.layoutControlItem4.Text = "Số tài khoản";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(91, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtMST;
            this.layoutControlItem5.Location = new System.Drawing.Point(569, 28);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(442, 28);
            this.layoutControlItem5.Text = "Mã số thuế";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(91, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtPhone;
            this.layoutControlItem6.Location = new System.Drawing.Point(569, 84);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(442, 44);
            this.layoutControlItem6.Text = "Số điện thoại";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(91, 17);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1039, 52);
            this.panel3.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(368, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(258, 29);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Thông tin khách hàng";
            // 
            // gridUS1
            // 
            this.gridUS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.gridUS1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUS1.IsSelected = false;
            this.gridUS1.Location = new System.Drawing.Point(0, 0);
            this.gridUS1.Margin = new System.Windows.Forms.Padding(5);
            this.gridUS1.Name = "gridUS1";
            this.gridUS1.NumberRecord = 10;
            this.gridUS1.PageCurrent = 1;
            this.gridUS1.Size = new System.Drawing.Size(1037, 494);
            this.gridUS1.Source = null;
            this.gridUS1.TabIndex = 0;
            this.gridUS1.ThongTinTimKiem = null;
            this.gridUS1.Load += new System.EventHandler(this.gridUS1_Load);
            // 
            // taskControl1
            // 
            this.taskControl1.isSuccessFul = false;
            this.taskControl1.Location = new System.Drawing.Point(31, 6);
            this.taskControl1.Margin = new System.Windows.Forms.Padding(5);
            this.taskControl1.Name = "taskControl1";
            this.taskControl1.Size = new System.Drawing.Size(541, 50);
            this.taskControl1.TabIndex = 0;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1039, 772);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập khách hàng";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private GridUS.GridUS gridUS1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private TaskControl taskControl1;
        private System.Windows.Forms.Panel panelContent;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtMST;
        private DevExpress.XtraEditors.TextEdit txtSTK;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtCusName;
        private DevExpress.XtraEditors.TextEdit txtCusID;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}