using _1911191_Lab09.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911191_Lab09
{
    public partial class frmUpdateCat : Form
    {
        private RestaurantContext _dbContext;
        private int _catID;
        public frmUpdateCat(int? catID = null)
        {
            InitializeComponent();

            _dbContext = new RestaurantContext();
            _catID = catID ?? 0;
        }
        private Category GetCatByID(int catID)
        {
            return catID > 0 ? _dbContext.Categories.Find(catID) : null;
        }
        private void ShowCat()
        {
            var cat = GetCatByID(_catID);
            if (cat == null) return;

            tbCatID.Text = cat.Id.ToString();
            tbCatName.Text = cat.Name;
            cbCatType.SelectedIndex = (int)cat.Type;
        }
        private Category GetUpdatedCat()
        {
            var cat = new Category()
            {
                Name = tbCatName.Text.Trim(),
                Type = (CatType)cbCatType.SelectedIndex
            };
            if (_catID > 0)
            {
                cat.Id = _catID;
            }
            return cat;
        }
        private bool ValidateUserInput()
        {
            if (string.IsNullOrWhiteSpace(tbCatName.Text))
            {
                MessageBox.Show("Tên nhóm thức ăn không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            else if (cbCatType.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn loại nhóm món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            else return true;
        }
        private void frmUpdateCat_Load(object sender, EventArgs e)
        {
            ShowCat();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                var newCat = GetUpdatedCat();
                var oldCat = GetCatByID(_catID);
                if (oldCat == null)
                {
                    _dbContext.Categories.Add(newCat);
                } else
                {
                    oldCat.Name = newCat.Name;
                    oldCat.Type = newCat.Type;
                }
                _dbContext.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
