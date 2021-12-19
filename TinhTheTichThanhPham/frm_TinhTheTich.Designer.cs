
namespace TinhTheTichThanhPham
{
    partial class frm_TinhTheTich
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridDataRaw = new DevExpress.XtraGrid.GridControl();
            this.gridViewDataRaw = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtOutBound = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutBound.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridDataRaw);
            this.layoutControl1.Controls.Add(this.txtOutBound);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(896, 526);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridDataRaw
            // 
            this.gridDataRaw.Location = new System.Drawing.Point(36, 268);
            this.gridDataRaw.MainView = this.gridViewDataRaw;
            this.gridDataRaw.Name = "gridDataRaw";
            this.gridDataRaw.Size = new System.Drawing.Size(824, 222);
            this.gridDataRaw.TabIndex = 5;
            this.gridDataRaw.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDataRaw});
            // 
            // gridViewDataRaw
            // 
            this.gridViewDataRaw.GridControl = this.gridDataRaw;
            this.gridViewDataRaw.Name = "gridViewDataRaw";
            // 
            // txtOutBound
            // 
            this.txtOutBound.Location = new System.Drawing.Point(109, 48);
            this.txtOutBound.Name = "txtOutBound";
            this.txtOutBound.Size = new System.Drawing.Size(763, 130);
            this.txtOutBound.StyleController = this.layoutControl1;
            this.txtOutBound.TabIndex = 4;
            this.txtOutBound.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutBound_KeyDown);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(896, 526);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(876, 182);
            this.layoutControlGroup1.Text = "Lấy dữ liệu theo số phiếu OutBound";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtOutBound;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(852, 134);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(852, 134);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(852, 134);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Số outbound:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(81, 19);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 182);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(876, 324);
            this.layoutControlGroup2.Text = "Kết quả";
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup3;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(852, 276);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(828, 226);
            this.layoutControlGroup3.Text = "Dữ liệu OutBound (Data raw)";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridDataRaw;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(828, 226);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frm_TinhTheTich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 526);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_TinhTheTich";
            this.Text = "frm_TinhTheTich";
            this.Load += new System.EventHandler(this.frm_TinhTheTich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutBound.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.MemoEdit txtOutBound;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraGrid.GridControl gridDataRaw;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDataRaw;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}