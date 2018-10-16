using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dai_Ly_Ve_So_1.BUS;
using Dai_Ly_Ve_So_1.DAL;

namespace Dai_Ly_Ve_So_1.UI
{
    public partial class ucPhatHanh : DevExpress.XtraEditors.XtraUserControl
    {
        BusPhathanh busPhathanh = new BusPhathanh();
        public ucPhatHanh()
        {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ucPhatHanh_Load(object sender, EventArgs e)
        {
            Load_DS_Phathanh();
            Load_DS_Phanphoi();
            Load_Cb_MaDaily();
            Load_Cb_Maloaiveso();
            Load_Cb_MAPhathanh();
        }
        public void Load_Cb_MAPhathanh()
        {
            foreach (var item in busPhathanh.get_Maphathanh())
                cbmaphathanh.Properties.Items.Add(item);
        }
        public void Load_Cb_MaDaily()
        {
            foreach (var item in busPhathanh.get_Madaily())
                cbmadaily.Properties.Items.Add(item);
        }
        public void Load_Cb_Maloaiveso()
        {
            foreach (var item in busPhathanh.get_Maloaiveso())
                cbmaloaive.Properties.Items.Add(item);
        }
        public void Load_DS_Phathanh()
        {
            gcPhathanh.DataSource = busPhathanh.GetAll();
        }

        private void gvPhathanh_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtmaphathanh.Text = gvPhathanh.GetRowCellValue(gvPhathanh.FocusedRowHandle, "MaPhatHanh").ToString();
            txtslve.Text  = gvPhathanh.GetRowCellValue(gvPhathanh.FocusedRowHandle, "SoLuong").ToString();
            txtngayphathanh.Text = gvPhathanh.GetRowCellValue(gvPhathanh.FocusedRowHandle, "NgayPhatHanh").ToString();
            txtslban.Text = gvPhathanh.GetRowCellValue(gvPhathanh.FocusedRowHandle, "SLBan").ToString();
            txtdoanhthu.Text = gvPhathanh.GetRowCellValue(gvPhathanh.FocusedRowHandle, "DoanhThuDPH").ToString();
            txthoahong.Text = gvPhathanh.GetRowCellValue(gvPhathanh.FocusedRowHandle, "HoaHong").ToString();
            txttienthanhtoan.Text =  gvPhathanh.GetRowCellValue(gvPhathanh.FocusedRowHandle, "TienThanhToan").ToString();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            PhatHanh a = new PhatHanh();
            a.MaPhatHanh = txtmaphathanh.EditValue.ToString();
            a.SoLuong = int.Parse( txtslve.EditValue.ToString());
            a.NgayPhatHanh =DateTime.Parse( txtngayphathanh.EditValue.ToString());
            a.SLBan=int.Parse( txtslban.EditValue.ToString());
            a.DoanhThuDPH = int.Parse(txtdoanhthu.EditValue.ToString());
            a.HoaHong = float.Parse(txthoahong.EditValue.ToString());
            a.TienThanhToan = float.Parse(txttienthanhtoan.EditValue.ToString());
            if (busPhathanh.Exits_Phathanh_byMa(a.MaPhatHanh))
            {
                MessageBox.Show("Mã đại lý đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                busPhathanh.Insert_Phathanh(a);
                Load_DS_Phathanh();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            PhatHanh a = new PhatHanh();
            a.MaPhatHanh = txtmaphathanh.EditValue.ToString();
            a.SoLuong = int.Parse(txtslve.EditValue.ToString());
            a.NgayPhatHanh = DateTime.Parse(txtngayphathanh.EditValue.ToString());
            a.SLBan = int.Parse(txtslban.EditValue.ToString());
            a.DoanhThuDPH = int.Parse(txtdoanhthu.EditValue.ToString());
            a.HoaHong = float.Parse(txthoahong.EditValue.ToString());
            a.TienThanhToan = float.Parse(txttienthanhtoan.EditValue.ToString());
         
                busPhathanh.Update_phathanh(a);
                Load_DS_Phathanh();
            
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn xóa đợt phát hành với mã: " + txtmaphathanh.EditValue.ToString(), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                busPhathanh.Delete_PhatHanh(txtmaphathanh.EditValue.ToString());
                Load_DS_Phathanh();
            }
        }
        public void Load_DS_Phanphoi()
        {
            gcphanphoi.DataSource = busPhathanh.GetAll_Phanphoi();
        }
    }
}
