using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dai_Ly_Ve_So_1.UI;
using DevExpress.XtraEditors;

namespace Dai_Ly_Ve_So_1
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
        }
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Valentine";
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            skins();
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có chắn chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( dr  == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            panelControl1.Controls.Clear();
            ucLoaiveso form = new ucLoaiveso();
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(form);
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucLoaiveso form = new ucLoaiveso();
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(form);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucPhatHanh form = new ucPhatHanh();
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(form);

        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucDailycon form = new ucDailycon();
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(form);

        }

        private void btsoluongdkve_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucSoluongDK from = new ucSoluongDK();
            from.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(from);
        }

        private void btcongno_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucCongno from = new ucCongno();
            from.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(from);
        }
    }
}
