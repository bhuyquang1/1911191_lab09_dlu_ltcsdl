namespace _1911191_Lab09
{
    partial class frmMain
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
            this.ttReload = new System.Windows.Forms.ToolTip(this.components);
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.tpRoles = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnReloadFood = new System.Windows.Forms.Button();
            this.lvFood = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvCat = new System.Windows.Forms.TreeView();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnReloadCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tpAccounts = new System.Windows.Forms.TabPage();
            this.tabGeneral.SuspendLayout();
            this.tpFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttReload
            // 
            this.ttReload.Tag = "";
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tpFood);
            this.tabGeneral.Controls.Add(this.tpRoles);
            this.tabGeneral.Controls.Add(this.tpAccounts);
            this.tabGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGeneral.Location = new System.Drawing.Point(0, 0);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(1165, 527);
            this.tabGeneral.TabIndex = 0;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.label2);
            this.tpFood.Controls.Add(this.btnAddFood);
            this.tpFood.Controls.Add(this.btnDeleteFood);
            this.tpFood.Controls.Add(this.btnReloadFood);
            this.tpFood.Controls.Add(this.lvFood);
            this.tpFood.Controls.Add(this.tvCat);
            this.tpFood.Controls.Add(this.btnAddCat);
            this.tpFood.Controls.Add(this.btnReloadCat);
            this.tpFood.Controls.Add(this.label1);
            this.tpFood.Location = new System.Drawing.Point(4, 25);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(1157, 498);
            this.tpFood.TabIndex = 0;
            this.tpFood.Text = "Danh sách món ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // tpRoles
            // 
            this.tpRoles.Location = new System.Drawing.Point(4, 25);
            this.tpRoles.Name = "tpRoles";
            this.tpRoles.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoles.Size = new System.Drawing.Size(1157, 498);
            this.tpRoles.TabIndex = 1;
            this.tpRoles.Text = "Các vai trò";
            this.tpRoles.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Thực đơn";
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(1110, 4);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(35, 28);
            this.btnAddFood.TabIndex = 16;
            this.btnAddFood.Text = "+";
            this.ttReload.SetToolTip(this.btnAddFood, "Thêm món");
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFood.Location = new System.Drawing.Point(1067, 4);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(35, 28);
            this.btnDeleteFood.TabIndex = 15;
            this.btnDeleteFood.Text = "-";
            this.ttReload.SetToolTip(this.btnDeleteFood, "Xóa món");
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnReloadFood
            // 
            this.btnReloadFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadFood.Location = new System.Drawing.Point(1024, 4);
            this.btnReloadFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnReloadFood.Name = "btnReloadFood";
            this.btnReloadFood.Size = new System.Drawing.Size(35, 28);
            this.btnReloadFood.TabIndex = 14;
            this.btnReloadFood.Text = "⟳";
            this.ttReload.SetToolTip(this.btnReloadFood, "Tải lại danh sách món ăn");
            this.btnReloadFood.UseVisualStyleBackColor = true;
            this.btnReloadFood.Click += new System.EventHandler(this.btnReloadFood_Click);
            // 
            // lvFood
            // 
            this.lvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvFood.FullRowSelect = true;
            this.lvFood.GridLines = true;
            this.lvFood.Location = new System.Drawing.Point(302, 35);
            this.lvFood.Margin = new System.Windows.Forms.Padding(4);
            this.lvFood.MultiSelect = false;
            this.lvFood.Name = "lvFood";
            this.lvFood.Size = new System.Drawing.Size(841, 454);
            this.lvFood.TabIndex = 13;
            this.lvFood.UseCompatibleStateImageBehavior = false;
            this.lvFood.View = System.Windows.Forms.View.Details;
            this.lvFood.DoubleClick += new System.EventHandler(this.lvFood_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã số";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đồ ăn/thức uống";
            this.columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ĐV tính";
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá bán";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nhóm mặt hàng";
            this.columnHeader5.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ghi chú";
            this.columnHeader6.Width = 400;
            // 
            // tvCat
            // 
            this.tvCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvCat.Location = new System.Drawing.Point(16, 35);
            this.tvCat.Margin = new System.Windows.Forms.Padding(4);
            this.tvCat.Name = "tvCat";
            this.tvCat.Size = new System.Drawing.Size(275, 454);
            this.tvCat.TabIndex = 12;
            this.tvCat.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCat_AfterSelect);
            this.tvCat.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvCat_NodeMouseDoubleClick);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.Location = new System.Drawing.Point(256, 4);
            this.btnAddCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(35, 28);
            this.btnAddCat.TabIndex = 11;
            this.btnAddCat.Text = "+";
            this.ttReload.SetToolTip(this.btnAddCat, "Thêm danh mục mới");
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnReloadCat
            // 
            this.btnReloadCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadCat.Location = new System.Drawing.Point(213, 4);
            this.btnReloadCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnReloadCat.Name = "btnReloadCat";
            this.btnReloadCat.Size = new System.Drawing.Size(35, 28);
            this.btnReloadCat.TabIndex = 10;
            this.btnReloadCat.Text = "⟳";
            this.ttReload.SetToolTip(this.btnReloadCat, "Tải lại danh mục");
            this.btnReloadCat.UseVisualStyleBackColor = true;
            this.btnReloadCat.Click += new System.EventHandler(this.btnReloadCat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh mục";
            // 
            // tpAccounts
            // 
            this.tpAccounts.Location = new System.Drawing.Point(4, 25);
            this.tpAccounts.Name = "tpAccounts";
            this.tpAccounts.Size = new System.Drawing.Size(1157, 498);
            this.tpAccounts.TabIndex = 2;
            this.tpAccounts.Text = "Quản lý tài khoản";
            this.tpAccounts.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 527);
            this.Controls.Add(this.tabGeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabGeneral.ResumeLayout(false);
            this.tpFood.ResumeLayout(false);
            this.tpFood.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ttReload;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnReloadFood;
        private System.Windows.Forms.ListView lvFood;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TreeView tvCat;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Button btnReloadCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpRoles;
        private System.Windows.Forms.TabPage tpAccounts;
    }
}

