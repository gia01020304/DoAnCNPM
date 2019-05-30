using Main.BUS;
using Main.DAO;
using Main.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.GUI
{
    public partial class frmStartProgram : Form
    {
        ProductBus bus = new ProductBus();
        ProgramBUS programBus = new ProgramBUS();
        NhanVienBanBUS nhanVienBan = new NhanVienBanBUS();
        event EventHandler success;
        public frmStartProgram()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(string.Concat(Application.StartupPath, @"\Resources\print.png"));
            success += FrmStartProgram_success;
        }

        private void FrmStartProgram_success(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                progressBar1.Value = progressBar1.Maximum;
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.Show();
                frm.FormClosed += Frm_FormClosed;
          
            }));
    
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var number = (float)progressBar1.Value / progressBar1.Maximum * 100;
            if(number >= 99)
            {
                timer1.Stop();
            }
            lbValue.Text = string.Concat(number, "%");
            progressBar1.PerformStep();
        }

        private void frmStartProgram_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(() =>
            {
                try
                {
                    var rs = programBus.CountHTTT();
                    if(programBus.CountHTTT() == 0)
                    {
                        programBus.AddDefaultHTTT("Tiền mặt");
                        programBus.AddDefaultHTTT("Chuyển khoản");
                        programBus.AddDefaultHTTT("Tiền mặt/ Chuyển Khoản");
                        var nhanVien = new NhanVienBan()
                        {
                            Name = "Admin",
                            DOB = DateTime.Now,
                            NgayCap = DateTime.Now,
                            CMND = "0123456789",
                            NoiCap = "Admin",
                            GioiTinh = "Nam",
                            HonNhan =true,
                            HinhAnh ="",
                            SDT = "0123456789",
                            TTLamViec = "",
                            DiaChi = "",
                            DaXoa = false,
                            UserName = "admin",
                            PassWord = MyExtension.EnCodePassword("123456"),
                            RoleID = 1
                        };
                        nhanVienBan.Add(nhanVien);
                    }
                    if (rs != -1)
                    {
                        success?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show("Có lỗi trong quá trình kết nối đến cơ sở dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }));
                    }
                   
                }
                catch
                {
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show("Có lỗi trong quá trình kết nối đến cơ sở dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }));
                }
             
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
