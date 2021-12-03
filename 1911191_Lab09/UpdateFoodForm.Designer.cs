namespace _1911191_Lab09
{
    partial class frmUpdateFood
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFoodID = new System.Windows.Forms.TextBox();
            this.tbFoodName = new System.Windows.Forms.TextBox();
            this.cbFoodCat = new System.Windows.Forms.ComboBox();
            this.tbFoodUnit = new System.Windows.Forms.TextBox();
            this.nudFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.tbFoodNotes = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thuộc danh mục";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn vị tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ghi chú khác";
            // 
            // tbFoodID
            // 
            this.tbFoodID.Location = new System.Drawing.Point(106, 6);
            this.tbFoodID.Name = "tbFoodID";
            this.tbFoodID.ReadOnly = true;
            this.tbFoodID.Size = new System.Drawing.Size(100, 20);
            this.tbFoodID.TabIndex = 6;
            // 
            // tbFoodName
            // 
            this.tbFoodName.Location = new System.Drawing.Point(106, 32);
            this.tbFoodName.Name = "tbFoodName";
            this.tbFoodName.Size = new System.Drawing.Size(371, 20);
            this.tbFoodName.TabIndex = 7;
            // 
            // cbFoodCat
            // 
            this.cbFoodCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodCat.FormattingEnabled = true;
            this.cbFoodCat.Location = new System.Drawing.Point(106, 58);
            this.cbFoodCat.Name = "cbFoodCat";
            this.cbFoodCat.Size = new System.Drawing.Size(371, 21);
            this.cbFoodCat.TabIndex = 8;
            // 
            // tbFoodUnit
            // 
            this.tbFoodUnit.Location = new System.Drawing.Point(106, 85);
            this.tbFoodUnit.Name = "tbFoodUnit";
            this.tbFoodUnit.Size = new System.Drawing.Size(371, 20);
            this.tbFoodUnit.TabIndex = 9;
            // 
            // nudFoodPrice
            // 
            this.nudFoodPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFoodPrice.Location = new System.Drawing.Point(106, 111);
            this.nudFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudFoodPrice.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFoodPrice.Name = "nudFoodPrice";
            this.nudFoodPrice.Size = new System.Drawing.Size(371, 20);
            this.nudFoodPrice.TabIndex = 10;
            this.nudFoodPrice.ThousandsSeparator = true;
            this.nudFoodPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // tbFoodNotes
            // 
            this.tbFoodNotes.Location = new System.Drawing.Point(106, 137);
            this.tbFoodNotes.Name = "tbFoodNotes";
            this.tbFoodNotes.Size = new System.Drawing.Size(371, 96);
            this.tbFoodNotes.TabIndex = 11;
            this.tbFoodNotes.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(321, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(402, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmUpdateFood
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(489, 269);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbFoodNotes);
            this.Controls.Add(this.nudFoodPrice);
            this.Controls.Add(this.tbFoodUnit);
            this.Controls.Add(this.cbFoodCat);
            this.Controls.Add(this.tbFoodName);
            this.Controls.Add(this.tbFoodID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm/cập nhật món ăn";
            this.Load += new System.EventHandler(this.frmUpdateFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFoodID;
        private System.Windows.Forms.TextBox tbFoodName;
        private System.Windows.Forms.ComboBox cbFoodCat;
        private System.Windows.Forms.TextBox tbFoodUnit;
        private System.Windows.Forms.NumericUpDown nudFoodPrice;
        private System.Windows.Forms.RichTextBox tbFoodNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}