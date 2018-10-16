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
    public partial class ucCongno : UserControl
    {
        BusCongNo busCongNo = new BusCongNo();
        public ucCongno()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void ucCongno_Load(object sender, EventArgs e)
        {
            load_DS_CongNo();
            Load_CB_MaPhathanh();
            Load_CB_MaDaiLy();
        }
        public void load_DS_CongNo()
        {
            gcCongno.DataSource = busCongNo.GetAll();
        }
        public void Load_CB_MaPhathanh()
        {
            foreach (var item in busCongNo.get_Maphathanh())
                cbmaphathanh.Properties.Items.Add(item);

        }
        public void Load_CB_MaDaiLy()
        {
            foreach (var item in busCongNo.get_Madaily())
                cbmadaily.Properties.Items.Add(item);
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            CongNo a = new CongNo();
            a.MaCongNo = txtmacongno.EditValue.ToString();
            a.MaPhatHanh = cbmaphathanh.EditValue.ToString();
            a.MaDaiLy = cbmadaily.EditValue.ToString();
            a.TongSoTien = float.Parse(txttongsotien.EditValue.ToString());
            a.SoTienConNo = float.Parse(txtsotienconno.EditValue.ToString());
            if(busCongNo.Exits_CongNos_byMa(a.MaCongNo))
            {
                MessageBox.Show("Mã công nợ đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                busCongNo.insert_CongNos(a);
                load_DS_CongNo();
            }
          
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            CongNo a = new CongNo();
            a.MaCongNo = txtmacongno.EditValue.ToString();
            a.MaPhatHanh = cbmaphathanh.EditValue.ToString();
            a.MaDaiLy = cbmadaily.EditValue.ToString();
            a.TongSoTien = float.Parse(txttongsotien.EditValue.ToString());
            a.SoTienConNo = float.Parse(txtsotienconno.EditValue.ToString());

            busCongNo.update_CongNos(a);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("bạn chắc chắn xóa mã công nợ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr  == DialogResult.OK)
            {
                busCongNo.delete_CongNos(txtmacongno.EditValue.ToString());
                load_DS_CongNo();
            }
        }

        private void gvCongno_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtmacongno.Text = gvCongno.GetRowCellValue(gvCongno.FocusedRowHandle, "MaCongNo").ToString();
            cbmaphathanh.Text = gvCongno.GetRowCellValue(gvCongno.FocusedRowHandle, "MaPhatHanh").ToString();
            cbmadaily.Text = gvCongno.GetRowCellValue(gvCongno.FocusedRowHandle, "MaDaiLy").ToString();
            txttongsotien.Text = gvCongno.GetRowCellValue(gvCongno.FocusedRowHandle, "TongSoTien").ToString();
            txtsotienconno.Text = gvCongno.GetRowCellValue(gvCongno.FocusedRowHandle, "SoTienConNo").ToString();
        }
    }
}
