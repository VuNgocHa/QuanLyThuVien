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

namespace QuanLyThuVien.GUI.UCs
{
    public partial class ucFrmSachDaTra : DevExpress.XtraEditors.XtraUserControl
    {
        LichSuMuon_BUS lsmBus = new LichSuMuon_BUS();
        private string tdn;
        public ucFrmLichSuMuon(string _tdn)
        {
            InitializeComponent();
            tdn = _tdn;
        }

        private void txtTimTenSach_EditValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ucFrmSachDaTra_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
