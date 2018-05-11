using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Models;

namespace WinForm.Inventory.ProductMaster
{
    public partial class FormListProduct : Form
    {
        private AppContext _appContext;
        public Models.Product Product;
        public FormListProduct()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }

        public Product SelectProduct
        {
            get { return Product; }
            set { Product = value; }
        }

        private void FormListProduct_Load(object sender, EventArgs e)
        {
            try
            {
                using (var _appContext = new AppContext())
                {
                    var products = _appContext.Products.ToList();
                    foreach (var product in products)
                    {
                        dataGridView1.Rows.Add(product.Id, product.NameEn, product.NameKh, product.CategoryId,
                            product.MeasureId,product.Price,product.Cost);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error message :" + exception);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var pro = _appContext.Products.Find(id);
            SelectProduct = pro;
            Close();
        }
    }
}
