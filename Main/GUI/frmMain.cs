using Main.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Main
{
    public partial class frmMain : Form
    {
        PermisionBUS permisionBus = new PermisionBUS();
        private string userName { get; set; }
        public frmMain(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            setPermision();
            barSTUserName.Caption = string.Concat("Người dùng hiện tại : ",userName);
        }

        private void setPermision()
        {
            var perList = permisionBus.GetActionByUserName(userName);
            foreach (var per in perList)
            {
                if (per.ActionCode.Trim() == "MANAGE_CUSTOMER" && !per.CheckAction)
                {
                    barBtnCustomer.Enabled = false;
                }
                if (per.ActionCode.Trim() == "MANAGE_NV" && !per.CheckAction)
                {
                    btnEmployee.Enabled = false;
                }
                if (per.ActionCode.Trim() == "MANAGE_PRODUCT" && !per.CheckAction)
                {
                    barBtnProduct.Enabled = false;
                }
                if (per.ActionCode.Trim() == "MANAGE_BILL" && !per.CheckAction)
                {
                    barBtnBill.Enabled = false;
                }
                if (per.ActionCode.Trim() == "STATISTIC" && !per.CheckAction)
                {
                    barBtnStatistic.Enabled = false;
                }
                if (per.ActionCode.Trim() == "INFO_COMPANY" && !per.CheckAction)
                {
                    barBtnInforCompany.Enabled = false;
                }
                if (per.ActionCode.Trim() == "MANAGE_ACCOUNT" && !per.CheckAction)
                {
                    barBtnPermison.Enabled = false;
                }
                if (per.ActionCode.Trim() == "PRINT_BILL" && !per.CheckAction)
                {
                    barBtnPrintBill.Enabled = false;

                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            barStaticItem2.Caption = DateTime.Now.ToString();
            mdiManager.MdiParent = this;
            frmIntroduce frm = new frmIntroduce();
            frm.MdiParent = this;
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barStaticItem2.Caption = DateTime.Now.ToString();
        }

        private void barBtnBill_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == "frmBill")
                {
                    item.Dispose();
                    break;
                }
            }
            frmBill frm = new frmBill(userName);
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void barBtnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
        }

        private void barBtnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.ShowDialog();
        }

        private void barBtnStatistic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStatistic frm = new frmStatistic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnPrintBill_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == "frmPrintBill")
                {
                    item.Dispose();
                    break;
                }
            }
            frmPrintBill frm = new frmPrintBill();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnInforCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCompanyInfor frm = new frmCompanyInfor();
            frm.ShowDialog();
        }

        private void barBtnProgramInfor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProgramInfor frm = new frmProgramInfor();
            frm.ShowDialog();
        }

        private void barBtnOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var rs = MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(rs != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        private void btnEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Name == "frmEmployee")
                    {
                        item.Dispose();
                        break;
                    }
                }
            frmEmployee frm = new frmEmployee();
            frm.MdiParent = this;
            frm.Show();
		}

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPermision frm = new frmPermision();
            frm.ShowDialog();
            frm.Close();
        }
    }
}
