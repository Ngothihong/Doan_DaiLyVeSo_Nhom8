namespace Dai_Ly_Ve_So_1.UI
{
    partial class ucSoluongDK
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcDanhsachDK = new DevExpress.XtraGrid.GridControl();
            this.gvDSdangki = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.btxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btsua = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNgayDK = new DevExpress.XtraEditors.DateEdit();
            this.cbMadaily = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbLoaiveso = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtsoLuongDk = new DevExpress.XtraEditors.TextEdit();
            this.txtmadk = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ColID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMaLoaiVeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDaily = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSL = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSdangki)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbNgayDK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNgayDK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMadaily.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiveso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoLuongDk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmadk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.groupBox3);
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(986, 643);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcDanhsachDK);
            this.panelControl2.Location = new System.Drawing.Point(31, 283);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(931, 306);
            this.panelControl2.TabIndex = 3;
            // 
            // gcDanhsachDK
            // 
            this.gcDanhsachDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhsachDK.Location = new System.Drawing.Point(2, 2);
            this.gcDanhsachDK.MainView = this.gvDSdangki;
            this.gcDanhsachDK.Name = "gcDanhsachDK";
            this.gcDanhsachDK.Size = new System.Drawing.Size(927, 302);
            this.gcDanhsachDK.TabIndex = 0;
            this.gcDanhsachDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSdangki});
            // 
            // gvDSdangki
            // 
            this.gvDSdangki.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColID,
            this.ColMaLoaiVeso,
            this.colMaDaily,
            this.colNgayDK,
            this.colSL});
            this.gvDSdangki.GridControl = this.gcDanhsachDK;
            this.gvDSdangki.Name = "gvDSdangki";
            this.gvDSdangki.OptionsFind.AlwaysVisible = true;
            this.gvDSdangki.OptionsView.ShowAutoFilterRow = true;
            this.gvDSdangki.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDSdangki_RowClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridControl1);
            this.groupBox3.Controls.Add(this.radioGroup1);
            this.groupBox3.Controls.Add(this.labelControl6);
            this.groupBox3.Location = new System.Drawing.Point(547, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 250);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả tìm kiếm";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(15, 50);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(387, 181);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(84, 15);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Mã đại lý", true, "Mã đại lý"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Mã loại vé số", true, "Mã loại vé sô"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Ngày đăng ký", true, "Ngày đăng kí")});
            this.radioGroup1.Size = new System.Drawing.Size(331, 29);
            this.radioGroup1.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(6, 23);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Tùy chọn";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttimkiem);
            this.groupBox2.Controls.Add(this.btxoa);
            this.groupBox2.Controls.Add(this.btsua);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Location = new System.Drawing.Point(372, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoạt động";
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(22, 208);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(75, 23);
            this.bttimkiem.TabIndex = 0;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(22, 152);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 0;
            this.btxoa.Text = "Xóa";
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(22, 89);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 0;
            this.btsua.Text = "Sửa";
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(22, 31);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNgayDK);
            this.groupBox1.Controls.Add(this.cbMadaily);
            this.groupBox1.Controls.Add(this.cbLoaiveso);
            this.groupBox1.Controls.Add(this.txtsoLuongDk);
            this.groupBox1.Controls.Add(this.txtmadk);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(31, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng kí";
            // 
            // cbNgayDK
            // 
            this.cbNgayDK.EditValue = null;
            this.cbNgayDK.Location = new System.Drawing.Point(120, 152);
            this.cbNgayDK.Name = "cbNgayDK";
            this.cbNgayDK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbNgayDK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbNgayDK.Size = new System.Drawing.Size(152, 20);
            this.cbNgayDK.TabIndex = 3;
            // 
            // cbMadaily
            // 
            this.cbMadaily.EditValue = "DL01";
            this.cbMadaily.Location = new System.Drawing.Point(120, 106);
            this.cbMadaily.Name = "cbMadaily";
            this.cbMadaily.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMadaily.Properties.Items.AddRange(new object[] {
            "DL01"});
            this.cbMadaily.Size = new System.Drawing.Size(152, 20);
            this.cbMadaily.TabIndex = 2;
            // 
            // cbLoaiveso
            // 
            this.cbLoaiveso.EditValue = "AG67-T03";
            this.cbLoaiveso.Location = new System.Drawing.Point(120, 69);
            this.cbLoaiveso.Name = "cbLoaiveso";
            this.cbLoaiveso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLoaiveso.Properties.Items.AddRange(new object[] {
            "AG67-T03"});
            this.cbLoaiveso.Size = new System.Drawing.Size(152, 20);
            this.cbLoaiveso.TabIndex = 2;
            // 
            // txtsoLuongDk
            // 
            this.txtsoLuongDk.Location = new System.Drawing.Point(120, 192);
            this.txtsoLuongDk.Name = "txtsoLuongDk";
            this.txtsoLuongDk.Size = new System.Drawing.Size(152, 20);
            this.txtsoLuongDk.TabIndex = 1;
            // 
            // txtmadk
            // 
            this.txtmadk.Location = new System.Drawing.Point(120, 28);
            this.txtmadk.Name = "txtmadk";
            this.txtmadk.Size = new System.Drawing.Size(152, 20);
            this.txtmadk.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Mã đại lý";
            this.labelControl4.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 152);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày đăng ký";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 195);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Số Lượng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Loại vé số";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã đăng kí";
            // 
            // ColID
            // 
            this.ColID.Caption = "Mã đăng ký";
            this.ColID.FieldName = "ID";
            this.ColID.Name = "ColID";
            this.ColID.Visible = true;
            this.ColID.VisibleIndex = 0;
            // 
            // ColMaLoaiVeso
            // 
            this.ColMaLoaiVeso.Caption = "Mã loại vé số";
            this.ColMaLoaiVeso.FieldName = "MaLoaiveSo";
            this.ColMaLoaiVeso.Name = "ColMaLoaiVeso";
            this.ColMaLoaiVeso.Visible = true;
            this.ColMaLoaiVeso.VisibleIndex = 1;
            // 
            // colMaDaily
            // 
            this.colMaDaily.Caption = "Mã đại lý";
            this.colMaDaily.FieldName = "MaDaiLy";
            this.colMaDaily.Name = "colMaDaily";
            this.colMaDaily.Visible = true;
            this.colMaDaily.VisibleIndex = 2;
            // 
            // colNgayDK
            // 
            this.colNgayDK.Caption = "Ngày đăng kí";
            this.colNgayDK.FieldName = "NgayDK";
            this.colNgayDK.Name = "colNgayDK";
            this.colNgayDK.Visible = true;
            this.colNgayDK.VisibleIndex = 3;
            // 
            // colSL
            // 
            this.colSL.Caption = "Số lượng";
            this.colSL.FieldName = "SoLuongDK1";
            this.colSL.Name = "colSL";
            this.colSL.Visible = true;
            this.colSL.VisibleIndex = 4;
            // 
            // ucSoluongDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucSoluongDK";
            this.Size = new System.Drawing.Size(986, 643);
            this.Load += new System.EventHandler(this.ucSoluongDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSdangki)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbNgayDK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNgayDK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMadaily.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiveso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoLuongDk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmadk.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtmadk;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcDanhsachDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSdangki;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.DateEdit cbNgayDK;
        private DevExpress.XtraEditors.ComboBoxEdit cbMadaily;
        private DevExpress.XtraEditors.ComboBoxEdit cbLoaiveso;
        private DevExpress.XtraEditors.TextEdit txtsoLuongDk;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton bttimkiem;
        private DevExpress.XtraEditors.SimpleButton btxoa;
        private DevExpress.XtraEditors.SimpleButton btsua;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ColID;
        private DevExpress.XtraGrid.Columns.GridColumn ColMaLoaiVeso;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDaily;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDK;
        private DevExpress.XtraGrid.Columns.GridColumn colSL;
    }
}
