using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.GUI.UCs
{
    public partial class ucFrmQLThanhVien : DevExpress.XtraEditors.XtraUserControl
    {
        DocGia_BUS docGiaBUS = new DocGia_BUS();
        public ucFrmQLThanhVien()
        {
            InitializeComponent();
        }

        private void ResetGridview()
        {
            txtMaDocGia.ResetText();
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            rdoBtnNu.Checked = false;
            rdoBtnNam.Checked = false;
            dateNamSinh.ResetText();
            txt_TenDangNhap.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lb_MDG.Visible = false;
            lb_Trung.Visible = false;

            DocGia dg = new DocGia();

            Random rdm = new Random();
            dg.MaDocGia = rdm.Next(0, 1000).ToString();
            dg.TenDangNhap = txt_TenDangNhap.Text;
            dg.HoTen = txtHoTen.Text;
            dg.DiaChi = txtDiaChi.Text;
            if (rdoBtnNam.Checked == true)
                dg.GioiTinh = "Nam  ";
            else if (rdoBtnNu.Checked == true)
                dg.GioiTinh = "Nữ   ";

            if (dateNamSinh.Text == "")
                dg.NamSinh = DateTime.Now;
            else
                dg.NamSinh = dateNamSinh.DateTime;
            //kiem tra loi madocgia
            int check = docGiaBUS.Them(dg);
            if (check == 0)
                lb_MDG.Visible = true;
            else if (check == -1)
                lb_Trung.Visible = true;
            //load lai
            ucFrmQLThanhVien_Load(sender, e);
            ResetGridview();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lb_MDG.Visible = false;
            lb_Trung.Visible = false;
            DocGia dg = new DocGia();
            dg.MaDocGia = txtMaDocGia.Text;
            dg.TenDangNhap = txt_TenDangNhap.Text;
            dg.HoTen = txtHoTen.Text;
            dg.DiaChi = txtDiaChi.Text;
            if (rdoBtnNam.Checked == true)
                dg.GioiTinh = "Nam  ";
            else if (rdoBtnNu.Checked == true)
                dg.GioiTinh = "Nữ   ";
            dg.NamSinh = dateNamSinh.DateTime;
            //kiem tra loi madocgia
            if (!docGiaBUS.Sua(dg))
                lb_MDG.Visible = true;

            //load lai
            ucFrmQLThanhVien_Load(sender, e);
            ResetGridview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text != "")
            {
                docGiaBUS.Xoa(txtMaDocGia.Text);
                ResetGridview();
                ucFrmQLThanhVien_Load(sender, e);
            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            txtMaDocGia.Text = gridView1.GetRowCellValue(e.RowHandle, "MaDocGia").ToString();
            txt_TenDangNhap.Text = gridView1.GetRowCellValue(e.RowHandle, "TenDangNhap").ToString();
            txtHoTen.Text = gridView1.GetRowCellValue(e.RowHandle, "HoTen").ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(e.RowHandle, "DiaChi").ToString();
            string a = gridView1.GetRowCellValue(e.RowHandle, "GioiTinh").ToString();
            if (a == "Nam  ")
                rdoBtnNam.Checked = true;
            else if (a == "Nữ   ")
                rdoBtnNu.Checked = true;
            dateNamSinh.Text = gridView1.GetRowCellDisplayText(e.RowHandle, "NamSinh");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void txtTimDocGia_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimDocGia.Text == "")
            {
                gridControl1.DataSource = docGiaBUS.GetList();
            }
            else
                gridControl1.DataSource = docGiaBUS.TimKiem(txtTimDocGia.Text);
        }

        private void ucFrmQLThanhVien_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = docGiaBUS.GetList();
            lb_MDG.Visible = false;
            lb_Trung.Visible = false;
        }
    }
}
