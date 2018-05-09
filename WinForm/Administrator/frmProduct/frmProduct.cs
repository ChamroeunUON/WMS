using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WinForm.Models;

namespace WinForm.Administrator.frmProduct
{
    public partial class frmProduct : Office2007Form
    {
        private AppContext _appContext;
        private Models.Product _product;

//        private Models.Product FormData
//        {
//            get
//            {
//                var product = new Product
//                {
//                    NameEn = txtNameEN.Text,
//                    NameKh = txtNameKH.Text,
//                    
//                }
//            }
//        }
        public frmProduct()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

        }

        public string CatName { set; get; }
        private void btnCategoryId_Click(object sender, EventArgs e)
        {
            var frm =new frmPopupCategory();
            frm.ShowDialog();
            txtCategoryId.Text = frm.CatId;
            txtCategoryName.Text = frm.CatName;

        }

        private void btnMeasurId_Click(object sender, EventArgs e)
        {
            var frm = new frmPopupMeasure();
            frm.ShowDialog();
            txtMeasureId.Text = frm.MeasureId;
            txtMeasureName.Text = frm.MeasureName;

        }

        private void btnSupplierId_Click(object sender, EventArgs e)
        {
           
        }

        private void n_Click(object sender, EventArgs e)
        {
            try
            {

                var openFileDialog = new OpenFileDialog
                {
                    Title = "Please Select Photo.",
                    Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif",
                    Multiselect = false
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    pictureBox1.ImageLocation = openFileDialog.FileName;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Message :" + exception, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
