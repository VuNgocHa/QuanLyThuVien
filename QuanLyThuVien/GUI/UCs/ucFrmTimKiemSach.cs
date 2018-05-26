﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.GUI.UCs
{
    public partial class ucFrmTimKiemSach : DevExpress.XtraEditors.XtraUserControl
    {
        Sach_BUS sachBUS = new Sach_BUS();
        public ucFrmTimKiemSach()
        {
            InitializeComponent();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                gridControl1.DataSource = sachBUS.GetList();

            }
            else
            {
                if (rdoBtnMaSach.Checked == true)
                    gridControl1.DataSource = sachBUS.TimKiem(txtTimKiem.Text, "MaSach");
                else if (rdoBtnNhaXuatBan.Checked == true)
                    gridControl1.DataSource = sachBUS.TimKiem(txtTimKiem.Text, "NhaXuatBan");
                else if (rdoBtnTacGia.Checked == true)
                    gridControl1.DataSource = sachBUS.TimKiem(txtTimKiem.Text, "TacGia");
                else if (rdoBtnTenSach.Checked == true)
                    gridControl1.DataSource = sachBUS.TimKiem(txtTimKiem.Text, "TenSach");
                else if (rdoBtnTheLoai.Checked == true)
                    gridControl1.DataSource = sachBUS.TimKiem(txtTimKiem.Text, "TheLoai");
                else if (rdoBtnTinhTrang.Checked == true)
                    gridControl1.DataSource = sachBUS.TimKiem(txtTimKiem.Text, "TinhTrang");
            }
        }

        private void ucFrmTimKiemSach_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = sachBUS.GetList();
        }
    }
}
