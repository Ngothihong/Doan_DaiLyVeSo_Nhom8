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
    public partial class ucSoluongDK : DevExpress.XtraEditors.XtraUserControl
    {
        BusSoLuongDangKy busSoLuongDangKy = new BusSoLuongDangKy();
        public ucSoluongDK()
        {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void ucSoluongDK_Load(object sender, EventArgs e)
        {
            Load_DS_SLDK();
            Load_Cb_Madaily();
            Load_Cb_Maveso();
        }
        public void Load_Cb_Madaily()
        {
            foreach (var item in busSoLuongDangKy.get_Madaily())
                cbMadaily.Properties.Items.Add(item);
        }
        public void Load_Cb_Maveso()
        {
            foreach (var item in busSoLuongDangKy.get_MaloaiveSo())
                cbLoaiveso.Properties.Items.Add(item);
        }
        public void Load_DS_SLDK()
        {
            //foreach( var item in busSoLuongDangKy.GetAll())
            //{
            //    MessageBox.Show(item.So)
            //}
            gcDanhsachDK.DataSource = busSoLuongDangKy.GetAll();

        }

        private void gvDSdangki_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

         txtmadk.Text = gvDSdangki.GetRowCellValue(gvDSdangki.FocusedRowHandle, "ID").ToString();
            cbLoaiveso.Text = gvDSdangki.GetRowCellValue(gvDSdangki.FocusedRowHandle, "MaLoaiveSo").ToString();
            cbMadaily.Text = gvDSdangki.GetRowCellValue(gvDSdangki.FocusedRowHandle, "MaDaiLy").ToString();
            cbNgayDK.Text = gvDSdangki.GetRowCellValue(gvDSdangki.FocusedRowHandle, "NgayDK").ToString();
            
           txtsoLuongDk.Text = gvDSdangki.GetRowCellValue(gvDSdangki.FocusedRowHandle, "SoLuongDK1").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SoLuongDK soLuongDK = new SoLuongDK();
            soLuongDK.ID = txtmadk.EditValue.ToString();
            soLuongDK.MaLoaiveSo = cbLoaiveso.EditValue.ToString();
            soLuongDK.MaDaiLy = cbMadaily.EditValue.ToString();
            soLuongDK.NgayDK = DateTime.Parse( cbNgayDK.EditValue.ToString());
            soLuongDK.SoLuongDK1 =int.Parse( txtsoLuongDk.EditValue.ToString());

            if (busSoLuongDangKy.Exits_SoLuongDK_byMa(soLuongDK.ID))
            {
                MessageBox.Show("Đã tồn tại mã: " + soLuongDK.ID.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else
            {
                busSoLuongDangKy.Insert_SoLuongDk(soLuongDK);
                Load_DS_SLDK();
            }

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            SoLuongDK soLuongDK = new SoLuongDK();
            soLuongDK.ID = txtmadk.EditValue.ToString();
            soLuongDK.MaLoaiveSo = cbLoaiveso.EditValue.ToString();
            soLuongDK.MaDaiLy = cbMadaily.EditValue.ToString();
            soLuongDK.NgayDK = DateTime.Parse(cbNgayDK.EditValue.ToString());
            soLuongDK.SoLuongDK1 = int.Parse(txtsoLuongDk.EditValue.ToString());

            busSoLuongDangKy.Update_SoLuongDk(soLuongDK);
            Load_DS_SLDK();

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            

            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn xóa Đại lý có mã đại lý: " + txtmadk.EditValue.ToString(), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                busSoLuongDangKy.Delete_SoLuongDk(txtmadk.EditValue.ToString());
                Load_DS_SLDK();
            }

        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {

        }
    }
}
