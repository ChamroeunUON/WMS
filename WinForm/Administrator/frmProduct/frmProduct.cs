using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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

        private Models.Product FormData
        {
            get
            {
                var product = new Product
                {
                    NameEn = txtNameEN.Text,
                    NameKh = txtNameKH.Text,
                    Photo = ConvertFilterToByte(this.pictureBox1.ImageLocation),
                    Cost = float.Parse(txtCost.Text),
                    Price = float.Parse(txtPrice.Text),
                    Note = txtNote.Text,
                    CategoryId = int.Parse(txtCategoryId.Text),
                    MeasureId = int.Parse(txtMeasureId.Text),
                    Status = (byte) chkActive.CheckState
                };
                return product;
            }
        }
        public frmProduct()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }
      
        private static byte[] ConvertFilterToByte(string sPath)
        {
            byte[] data = null;
            var info = new FileInfo(sPath);
            var numByte = info.Length;
            var fileStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            var binaryReader = new BinaryReader(fileStream);
            data = binaryReader.ReadBytes((int)numByte);
            return data;
        }

        private static Image ConvertByteToImage(byte[] photo)
        {
            Image image;
            using (var memoryStream = new MemoryStream(photo, 0, photo.Length))
            {
                memoryStream.Write(photo, 0, photo.Length);
                image = Image.FromStream(memoryStream, true);
            }
            return image;
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
                MessageBox.Show("Error Message :" + exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                _product = _appContext.Products.Find(id);
                if (_product != null)
                {
                    txtNameEN.Text = _product.NameEn;
                    txtNameKH.Text = _product.NameKh;

                    txtCost.Text = _product.Cost.ToString();
                    txtPrice.Text = _product.Price.ToString();
                    txtNote.Text = _product.Note;
                    txtCategoryId.Text = _product.CategoryId.ToString();
                    txtMeasureId.Text = _product.MeasureId.ToString();
                    chkActive.CheckState = (CheckState) _product.Status;
                    pictureBox1.Image = ConvertByteToImage(_product.Photo);
                    tabControl1.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Message:" + exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameEN.Text))
            {
                MessageBox.Show("Name is required");
                return;
            }
            if (_product == null)
            {
                var pro = FormData;
                _appContext.Products.Add(pro);
                MessageBox.Show("Inserted.");
            }
            else
            {
                _product.NameEn = txtNameEN.Text;
                _product.NameKh = txtNameKH.Text;
                _product.Status = (byte) chkActive.CheckState;
                _product.Note = txtNote.Text;
                _product.CategoryId = int.Parse(txtCategoryId.Text);
                _product.MeasureId = int.Parse(txtMeasureId.Text);
                _product.Cost = float.Parse(txtCost.Text);
                _product.Price = float.Parse(txtPrice.Text);
                _product.Photo = ConvertFilterToByte(pictureBox1.ImageLocation);
                MessageBox.Show("Updated.");
            }
            _appContext.SaveChanges();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                var products = _appContext.Products.ToList();
                foreach (var product in products)
                    dataGridView1.Rows.Add(product.Id, product.NameEn, product.NameKh, product.CategoryId, product.MeasureId,
                        product.Cost, product.Price,product.Note,product.Status);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Message:" + exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = MessageBox.Show("Are you sure want to delete this employee?", @"Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog != DialogResult.Yes) return;
                var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var product = _appContext.Products.Find(id);
                if (product != null) _appContext.Products.Remove(product);
                _appContext.SaveChanges();
                tabControl1_SelectedIndexChanged(null, null);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Message:" + exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
