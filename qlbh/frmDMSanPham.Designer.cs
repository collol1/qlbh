namespace qlbh
{
    partial class frmDMSanPham
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maspLabel;
            System.Windows.Forms.Label tenspLabel;
            System.Windows.Forms.Label dongiaLabel;
            System.Windows.Forms.Label soluongLabel;
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.qlbhDataSet = new qlbh.qlbhDataSet();
            this.sanphamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanphamTableAdapter = new qlbh.qlbhDataSetTableAdapters.sanphamTableAdapter();
            this.tableAdapterManager = new qlbh.qlbhDataSetTableAdapters.TableAdapterManager();
            this.txtsp = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.dGVSanPham = new System.Windows.Forms.DataGridView();
            this.updateOrderOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maspLabel = new System.Windows.Forms.Label();
            tenspLabel = new System.Windows.Forms.Label();
            dongiaLabel = new System.Windows.Forms.Label();
            soluongLabel = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 665);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1208, 32);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // qlbhDataSet
            // 
            this.qlbhDataSet.DataSetName = "qlbhDataSet";
            this.qlbhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanphamBindingSource
            // 
            this.sanphamBindingSource.DataMember = "sanpham";
            this.sanphamBindingSource.DataSource = this.qlbhDataSet;
            // 
            // sanphamTableAdapter
            // 
            this.sanphamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chitietdonhangTableAdapter = null;
            this.tableAdapterManager.donhangTableAdapter = null;
            this.tableAdapterManager.khachhangTableAdapter = null;
            this.tableAdapterManager.sanphamTableAdapter = this.sanphamTableAdapter;
            this.tableAdapterManager.UpdateOrder = qlbh.qlbhDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maspLabel
            // 
            maspLabel.AutoSize = true;
            maspLabel.Location = new System.Drawing.Point(46, 53);
            maspLabel.Name = "maspLabel";
            maspLabel.Size = new System.Drawing.Size(52, 20);
            maspLabel.TabIndex = 4;
            maspLabel.Text = "masp:";
            // 
            // txtsp
            // 
            this.txtsp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanphamBindingSource, "masp", true));
            this.txtsp.Location = new System.Drawing.Point(105, 50);
            this.txtsp.Name = "txtsp";
            this.txtsp.Size = new System.Drawing.Size(100, 26);
            this.txtsp.TabIndex = 5;
            // 
            // tenspLabel
            // 
            tenspLabel.AutoSize = true;
            tenspLabel.Location = new System.Drawing.Point(46, 130);
            tenspLabel.Name = "tenspLabel";
            tenspLabel.Size = new System.Drawing.Size(53, 20);
            tenspLabel.TabIndex = 6;
            tenspLabel.Text = "tensp:";
            // 
            // txttensp
            // 
            this.txttensp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanphamBindingSource, "tensp", true));
            this.txttensp.Location = new System.Drawing.Point(105, 127);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(100, 26);
            this.txttensp.TabIndex = 7;
            // 
            // dongiaLabel
            // 
            dongiaLabel.AutoSize = true;
            dongiaLabel.Location = new System.Drawing.Point(390, 133);
            dongiaLabel.Name = "dongiaLabel";
            dongiaLabel.Size = new System.Drawing.Size(61, 20);
            dongiaLabel.TabIndex = 8;
            dongiaLabel.Text = "dongia:";
            // 
            // txtdongia
            // 
            this.txtdongia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanphamBindingSource, "dongia", true));
            this.txtdongia.Location = new System.Drawing.Point(457, 130);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(100, 26);
            this.txtdongia.TabIndex = 9;
            // 
            // soluongLabel
            // 
            soluongLabel.AutoSize = true;
            soluongLabel.Location = new System.Drawing.Point(390, 50);
            soluongLabel.Name = "soluongLabel";
            soluongLabel.Size = new System.Drawing.Size(69, 20);
            soluongLabel.TabIndex = 10;
            soluongLabel.Text = "soluong:";
            // 
            // txtsl
            // 
            this.txtsl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanphamBindingSource, "soluong", true));
            this.txtsl.Location = new System.Drawing.Point(465, 47);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(100, 26);
            this.txtsl.TabIndex = 11;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(705, 53);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(67, 20);
            this.t.TabIndex = 13;
            this.t.Text = "tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(804, 53);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(181, 26);
            this.txttimkiem.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btncapnhat);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Location = new System.Drawing.Point(922, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 441);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chức năng";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(47, 51);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(128, 39);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(47, 118);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(128, 35);
            this.btncapnhat.TabIndex = 0;
            this.btncapnhat.Text = "cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(47, 181);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(128, 34);
            this.btnxoa.TabIndex = 0;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(47, 355);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(113, 48);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(47, 248);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(113, 40);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // dGVSanPham
            // 
            this.dGVSanPham.AutoGenerateColumns = false;
            this.dGVSanPham.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dGVSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maspDataGridViewTextBoxColumn,
            this.tenspDataGridViewTextBoxColumn,
            this.dongiaDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn});
            this.dGVSanPham.DataSource = this.sanphamBindingSource;
            this.dGVSanPham.Location = new System.Drawing.Point(78, 204);
            this.dGVSanPham.Name = "dGVSanPham";
            this.dGVSanPham.RowHeadersWidth = 62;
            this.dGVSanPham.RowTemplate.Height = 28;
            this.dGVSanPham.Size = new System.Drawing.Size(694, 351);
            this.dGVSanPham.TabIndex = 18;
            // 
            // updateOrderOptionBindingSource
            // 
            this.updateOrderOptionBindingSource.DataSource = typeof(qlbh.qlbhDataSetTableAdapters.TableAdapterManager.UpdateOrderOption);
            // 
            // maspDataGridViewTextBoxColumn
            // 
            this.maspDataGridViewTextBoxColumn.DataPropertyName = "masp";
            this.maspDataGridViewTextBoxColumn.HeaderText = "masp";
            this.maspDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maspDataGridViewTextBoxColumn.Name = "maspDataGridViewTextBoxColumn";
            this.maspDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenspDataGridViewTextBoxColumn
            // 
            this.tenspDataGridViewTextBoxColumn.DataPropertyName = "tensp";
            this.tenspDataGridViewTextBoxColumn.HeaderText = "tensp";
            this.tenspDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenspDataGridViewTextBoxColumn.Name = "tenspDataGridViewTextBoxColumn";
            this.tenspDataGridViewTextBoxColumn.Width = 150;
            // 
            // dongiaDataGridViewTextBoxColumn
            // 
            this.dongiaDataGridViewTextBoxColumn.DataPropertyName = "dongia";
            this.dongiaDataGridViewTextBoxColumn.HeaderText = "dongia";
            this.dongiaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dongiaDataGridViewTextBoxColumn.Name = "dongiaDataGridViewTextBoxColumn";
            this.dongiaDataGridViewTextBoxColumn.Width = 150;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "soluong";
            this.soluongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmDMSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 697);
            this.Controls.Add(this.dGVSanPham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.t);
            this.Controls.Add(soluongLabel);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(dongiaLabel);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(tenspLabel);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(maspLabel);
            this.Controls.Add(this.txtsp);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDMSanPham";
            this.Text = "frmDMSanPham";
            this.Load += new System.EventHandler(this.frmDMSanPham_Load);
            this.DpiChangedBeforeParent += new System.EventHandler(this.ShowNewForm);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private qlbhDataSet qlbhDataSet;
        private System.Windows.Forms.BindingSource sanphamBindingSource;
        private qlbhDataSetTableAdapters.sanphamTableAdapter sanphamTableAdapter;
        private qlbhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtsp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dGVSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource updateOrderOptionBindingSource;
    }
}



