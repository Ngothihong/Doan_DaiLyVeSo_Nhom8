namespace Dai_Ly_Ve_So_1.UI
{
    partial class ucCongno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsotienconno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txttongsotien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtmacongno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbmaphathanh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbmadaily = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btsua = new DevExpress.XtraEditors.SimpleButton();
            this.btthem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gcCongno = new DevExpress.XtraGrid.GridControl();
            this.gvCongno = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMacongno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaphathanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMadaily = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongSotien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSotienconno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsotienconno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttongsotien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacongno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbmaphathanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbmadaily.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongno)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsotienconno);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.txttongsotien);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtmacongno);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.cbmaphathanh);
            this.groupBox1.Controls.Add(this.cbmadaily);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin công nợ";
            // 
            // txtsotienconno
            // 
            this.txtsotienconno.Location = new System.Drawing.Point(472, 68);
            this.txtsotienconno.Name = "txtsotienconno";
            this.txtsotienconno.Size = new System.Drawing.Size(178, 20);
            this.txtsotienconno.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(383, 71);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Số tiền còn nợ";
            this.labelControl5.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // txttongsotien
            // 
            this.txttongsotien.Location = new System.Drawing.Point(472, 24);
            this.txttongsotien.Name = "txttongsotien";
            this.txttongsotien.Size = new System.Drawing.Size(178, 20);
            this.txttongsotien.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(383, 27);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tổng số tiền";
            this.labelControl4.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(38, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mã đại lý";
            this.labelControl3.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(38, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã phát hành";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // txtmacongno
            // 
            this.txtmacongno.Location = new System.Drawing.Point(127, 29);
            this.txtmacongno.Name = "txtmacongno";
            this.txtmacongno.Size = new System.Drawing.Size(232, 20);
            this.txtmacongno.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã công nợ";
            // 
            // cbmaphathanh
            // 
            this.cbmaphathanh.Location = new System.Drawing.Point(127, 68);
            this.cbmaphathanh.Name = "cbmaphathanh";
            this.cbmaphathanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbmaphathanh.Size = new System.Drawing.Size(232, 20);
            this.cbmaphathanh.TabIndex = 1;
            // 
            // cbmadaily
            // 
            this.cbmadaily.Location = new System.Drawing.Point(127, 107);
            this.cbmadaily.Name = "cbmadaily";
            this.cbmadaily.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbmadaily.Size = new System.Drawing.Size(232, 20);
            this.cbmadaily.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btxoa);
            this.groupBox2.Controls.Add(this.btsua);
            this.groupBox2.Controls.Add(this.btthem);
            this.groupBox2.Location = new System.Drawing.Point(96, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoạt động";
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(367, 19);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 0;
            this.btxoa.Text = "Xóa";
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(232, 19);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 0;
            this.btsua.Text = "Sửa";
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(102, 20);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm";
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gcCongno);
            this.groupBox3.Location = new System.Drawing.Point(4, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(679, 219);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách công nợ";
            // 
            // gcCongno
            // 
            this.gcCongno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCongno.Location = new System.Drawing.Point(3, 16);
            this.gcCongno.MainView = this.gvCongno;
            this.gcCongno.Name = "gcCongno";
            this.gcCongno.Size = new System.Drawing.Size(673, 200);
            this.gcCongno.TabIndex = 0;
            this.gcCongno.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCongno});
            // 
            // gvCongno
            // 
            this.gvCongno.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMacongno,
            this.colmaphathanh,
            this.colMadaily,
            this.colTongSotien,
            this.ColSotienconno});
            this.gvCongno.GridControl = this.gcCongno;
            this.gvCongno.Name = "gvCongno";
            this.gvCongno.OptionsFind.AlwaysVisible = true;
            this.gvCongno.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCongno_RowClick);
            // 
            // colMacongno
            // 
            this.colMacongno.Caption = "Mã công nơ";
            this.colMacongno.FieldName = "MaCongNo";
            this.colMacongno.Name = "colMacongno";
            this.colMacongno.Visible = true;
            this.colMacongno.VisibleIndex = 0;
            // 
            // colmaphathanh
            // 
            this.colmaphathanh.Caption = "Mã phát hành";
            this.colmaphathanh.FieldName = "MaPhatHanh";
            this.colmaphathanh.Name = "colmaphathanh";
            this.colmaphathanh.Visible = true;
            this.colmaphathanh.VisibleIndex = 1;
            // 
            // colMadaily
            // 
            this.colMadaily.Caption = "Mã đại lý";
            this.colMadaily.FieldName = "MaDaiLy";
            this.colMadaily.Name = "colMadaily";
            this.colMadaily.Visible = true;
            this.colMadaily.VisibleIndex = 2;
            // 
            // colTongSotien
            // 
            this.colTongSotien.Caption = "Tổng số tiền";
            this.colTongSotien.FieldName = "TongSoTien";
            this.colTongSotien.Name = "colTongSotien";
            this.colTongSotien.Visible = true;
            this.colTongSotien.VisibleIndex = 3;
            // 
            // ColSotienconno
            // 
            this.ColSotienconno.Caption = "Số tiền còn nợ";
            this.ColSotienconno.FieldName = "SoTienConNo";
            this.ColSotienconno.Name = "ColSotienconno";
            this.ColSotienconno.Visible = true;
            this.ColSotienconno.VisibleIndex = 4;
            // 
            // ucCongno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucCongno";
            this.Size = new System.Drawing.Size(1354, 657);
            this.Load += new System.EventHandler(this.ucCongno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsotienconno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttongsotien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacongno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbmaphathanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbmadaily.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCongno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtmacongno;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtsotienconno;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txttongsotien;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbmaphathanh;
        private DevExpress.XtraEditors.ComboBoxEdit cbmadaily;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btxoa;
        private DevExpress.XtraEditors.SimpleButton btsua;
        private DevExpress.XtraEditors.SimpleButton btthem;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gcCongno;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCongno;
        private DevExpress.XtraGrid.Columns.GridColumn colMacongno;
        private DevExpress.XtraGrid.Columns.GridColumn colmaphathanh;
        private DevExpress.XtraGrid.Columns.GridColumn colMadaily;
        private DevExpress.XtraGrid.Columns.GridColumn colTongSotien;
        private DevExpress.XtraGrid.Columns.GridColumn ColSotienconno;
    }
}
