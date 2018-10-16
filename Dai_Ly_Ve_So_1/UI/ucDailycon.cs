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
    public partial class ucDailycon : DevExpress.XtraEditors.XtraUserControl
    {
        BusDailycon busDailycon = new BusDailycon();
        public ucDailycon()
        {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucDailycon_Load(object sender, EventArgs e)
        {
            Load_Data();
            Load_Cb_Madaily();
            Load_Data_CongNo();
        }
        public void Load_Data()
        {
            gcDSDaily.DataSource = busDailycon.GetAll();
        }
        public void Load_Data_CongNo()
        {
            gcCongNo.DataSource = busDailycon.getCongNobyMadaily(cbMadaily.EditValue.ToString());
        }
        public void Load_Cb_Madaily()
        {
            foreach (var item in busDailycon.getTenDaily())
               cbMadaily.Properties.Items.Add(item);
        }

        private void gvDsDaily_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            txtmadaily.Text = gvDsDaily.GetRowCellValue(gvDsDaily.FocusedRowHandle, "MaDaiLy").ToString();
            txttendaily.Text = gvDsDaily.GetRowCellValue(gvDsDaily.FocusedRowHandle, "TenDaiLy").ToString();
            txtdiachi.Text = gvDsDaily.GetRowCellValue(gvDsDaily.FocusedRowHandle, "DiaChi").ToString();
            txtsdt.Text = gvDsDaily.GetRowCellValue(gvDsDaily.FocusedRowHandle, "SDT").ToString();
            cbhoatdong.Text = gvDsDaily.GetRowCellValue(gvDsDaily.FocusedRowHandle, "flag").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DaiLy a = new DaiLy();
            a.MaDaiLy = txtmadaily.EditValue.ToString();
            a.TenDaiLy = txttendaily.EditValue.ToString();
            a.SDT = txtsdt.EditValue.ToString();
            a.DiaChi = txtdiachi.EditValue.ToString();
            a.flag = int.Parse(cbhoatdong.EditValue.ToString());
            if( busDailycon.Exits_DaiLy_byMa(a.MaDaiLy))
            {
                MessageBox.Show("Mã đại lý đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                busDailycon.Insert_Daily(a);
                Load_Data();
            }
            

        }
        public void Kiemtra_Madai_rong()
        {
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DaiLy a = new DaiLy();
            a.MaDaiLy = txtmadaily.EditValue.ToString();
            a.TenDaiLy = txttendaily.EditValue.ToString();
            a.SDT = txtsdt.EditValue.ToString();
            a.DiaChi = txtdiachi.EditValue.ToString();
            a.flag = int.Parse(cbhoatdong.EditValue.ToString());
            busDailycon.Update_Daily(a);
            MessageBox.Show("Bạn đang update đại lý với mã: " + txtmadaily.EditValue.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_Data();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn xóa Đại lý có mã đại lý: " + txtmadaily.EditValue.ToString(), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                busDailycon.Delete_Daily(txtmadaily.EditValue.ToString());
                Load_Data();
            }
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void cbMadaily_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Data_CongNo();
        }
        
    }
}
