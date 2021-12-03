using _1911191_Lab09.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911191_Lab09
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private List<Category> GetCats()
        {
            var dbContext = new RestaurantContext();
            return dbContext.Categories.OrderBy(x => x.Name).ToList();
        }
        private List<FoodModel> GetFoodByCat(int? catID)
        {
            var dbContext = new RestaurantContext();
            var foods = dbContext.Foods.AsQueryable();
            if (catID != null && catID > 0)
            {
                foods = foods.Where(x => x.FoodCategoryID == catID);
            }
            return foods.OrderBy(x => x.Id).Select(x => new FoodModel()
            {
                Id = x.Id,
                Name = x.Name,
                Unit = x.Unit,
                Price = x.Price,
                Notes = x.Notes,
                CategoryName = x.Category.Name
            }).ToList();
        }
        private List<FoodModel> GetFoodByCatType(CatType catType)
        {
            var dbContext = new RestaurantContext();
            return dbContext.Foods.Where(x => x.Category.Type == catType).OrderBy(x => x.Id).Select(x => new FoodModel()
            {
                Id = x.Id,
                Name = x.Name,
                Unit = x.Unit,
                Price = x.Price,
                Notes = x.Notes,
                CategoryName = x.Category.Name
            }).ToList();
        }
        private void ShowFoodsForNode(TreeNode node)
        {
            lvFood.Items.Clear();
            if (node == null) return;
            List<FoodModel> foods = null;
            if (node.Level == 1)
            {
                var catType = (CatType)node.Tag;
                foods = GetFoodByCatType(catType);
            }
            else
            {
                var cat = node.Tag as Category;
                foods = GetFoodByCat(cat?.Id);
            }
            ShowFoodsOnListView(foods);
        }
        private void ShowFoodsOnListView(List<FoodModel> foods)
        {
            foreach (var foodItem in foods)
            {
                var item = lvFood.Items.Add(foodItem.Id.ToString());
                
                item.SubItems.Add(foodItem.Name);
                item.SubItems.Add(foodItem.Unit);
                item.SubItems.Add(foodItem.Price.ToString("##,###"));
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);
            }
        }
        private void ShowCats()
        {
            tvCat.Nodes.Clear();
            var catMap = new Dictionary<CatType, string>()
            {
                [CatType.Food] = "Đồ ăn",
                [CatType.Drink] = "Thức uống"
            };
            var rootNode = tvCat.Nodes.Add("Tất cả");
            var cats = GetCats();
            foreach (var catType in catMap)
            {
                var childNode = rootNode.Nodes.Add(catType.Key.ToString(), catType.Value);
                childNode.Tag = catType.Key;

                foreach (var cat in cats)
                {
                    if (cat.Type != catType.Key)
                    {
                        continue;
                    }
                    var grandChildNode = childNode.Nodes.Add(cat.Id.ToString(), cat.Name);
                    grandChildNode.Tag = cat;
                }
            }
            tvCat.ExpandAll();
            tvCat.SelectedNode = rootNode;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowCats();
        }

        private void btnReloadCat_Click(object sender, EventArgs e)
        {
            ShowCats();
        }

        private void tvCat_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowFoodsForNode(e.Node);
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            var dialog = new frmUpdateCat();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowCats();
            }
        }

        private void tvCat_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null || e.Node.Level < 2 || e.Node.Tag == null) return;

            var cat = e.Node.Tag as Category;
            var dialog = new frmUpdateCat(cat?.Id);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowCats();
            }
        }

        private void btnReloadFood_Click(object sender, EventArgs e)
        {
            ShowFoodsForNode(tvCat.SelectedNode);
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (lvFood.SelectedItems.Count == 0) return;

            var dbContext = new RestaurantContext();
            var selFoodID = int.Parse(lvFood.SelectedItems[0].Text);
            var selFood = dbContext.Foods.Find(selFoodID);

            if(selFood != null)
            {
                dbContext.Foods.Remove(selFood);
                dbContext.SaveChanges();

                lvFood.Items.Remove(lvFood.SelectedItems[0]);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var dialog = new frmUpdateFood();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowFoodsForNode(tvCat.SelectedNode);
            }
        }

        private void lvFood_DoubleClick(object sender, EventArgs e)
        {
            if (lvFood.SelectedItems.Count == 0) return;

            var foodID = int.Parse(lvFood.SelectedItems[0].Text);
            var dialog = new frmUpdateFood(foodID);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowFoodsForNode(tvCat.SelectedNode);
            }
        }
    }
}
