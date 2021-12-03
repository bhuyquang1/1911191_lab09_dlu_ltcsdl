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
    public partial class frmUpdateFood : Form
    {
        private RestaurantContext _dbContext;
        private int _foodID;
        public frmUpdateFood(int? foodID = null)
        {
            InitializeComponent();

            _dbContext = new RestaurantContext();
            _foodID = foodID ?? 0;
        }
        private void LoadCatToCB()
        {
            var cats = _dbContext.Categories.OrderBy(x => x.Name).ToList();
            cbFoodCat.DisplayMember = "Name";
            cbFoodCat.ValueMember = "Id";
            cbFoodCat.DataSource = cats;
        }
        private Food GetFoodByID(int foodID)
        {
            return foodID > 0 ? _dbContext.Foods.Find(foodID) : null;
        }
        private void ShowFoodInfo()
        {
            var food = GetFoodByID(_foodID);

            if (food == null) return;

            tbFoodID.Text = food.Id.ToString();
            tbFoodName.Text = food.Name;
            cbFoodCat.SelectedValue = food.FoodCategoryID;
            tbFoodUnit.Text = food.Unit;
            nudFoodPrice.Value = food.Price;
            tbFoodNotes.Text = food.Notes;
        }
        private bool ValidateUserInput()
        {
            if (string.IsNullOrWhiteSpace(tbFoodName.Text))
            {
                MessageBox.Show("Tên món ăn/uống không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tbFoodUnit.Text))
            {
                MessageBox.Show("Đơn vị tính không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            else if (nudFoodPrice.Value.Equals(0))
            {
                MessageBox.Show("Giá của thức ăn phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            else if (cbFoodCat.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn nhóm thức ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            else return true;
        }
        private Food GetUpdatedFood()
        {
            var food = new Food()
            {
                Name = tbFoodName.Text.Trim(),
                FoodCategoryID = (int)cbFoodCat.SelectedValue,
                Unit = tbFoodUnit.Text,
                Price = (int)nudFoodPrice.Value,
                Notes = tbFoodNotes.Text
            };

            if (_foodID > 0)
            {
                food.Id = _foodID;
            }
            return food;
        }
        private void frmUpdateFood_Load(object sender, EventArgs e)
        {
            LoadCatToCB();
            ShowFoodInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                var newFood = GetUpdatedFood();
                var oldFood = GetFoodByID(_foodID);

                if (oldFood == null)
                {
                    _dbContext.Foods.Add(newFood);
                }
                else
                {
                    oldFood.Name = newFood.Name;
                    oldFood.FoodCategoryID = newFood.FoodCategoryID;
                    oldFood.Unit = newFood.Unit;
                    oldFood.Price = newFood.Price;
                    oldFood.Notes = newFood.Notes;
                }
                _dbContext.SaveChanges();

                DialogResult = DialogResult.OK;
            }
        }
    }
}
