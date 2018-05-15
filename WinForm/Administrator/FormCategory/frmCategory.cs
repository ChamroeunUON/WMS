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
using DevComponents.DotNetBar.Rendering;
using WinForm.Models;

namespace WinForm.Administrator.FormCategory
{
    public partial class FrmCategory : Office2007Form
    {
        private AppContext _appContext;
        private Models.Category  _category;

        private Models.Category FormData
        {
            get
            {
                var category = new Category
                {
                    Name = txtName.Text,
                    Note = txtNote.Text
                };
                return category;
            }
        }
        public FrmCategory()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Name is required.", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNote.Text))
                    txtNote.Text = "N/A";
                if (_category == null)
                {
                    var category = FormData;
                    _appContext.Categories.Add(category);
                }
                else
                {
                    _category.Name = FormData.Name;
                    _category.Note = FormData.Note; 
                }
                _appContext.SaveChanges();
                _category = null;
                MessageBox.Show("Successfully.", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Meassge: "+ exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void brnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                _category = _appContext.Categories.Find(id);
                if (_category != null)
                {
                    txtName.Text = _category.Name;
                    txtNote.Text = _category.Note;
                }
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Meassge: " + exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                var category = _appContext.Categories.ToList();
                foreach (var category1 in category)
                {
                    dataGridView1.Rows.Add(category1.Id,category1.Name, category1.Note);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Meassge: " + exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure want delete this Category?",
                    @"Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    var category = _appContext.Categories.Find(id);
                    if (category != null)
                        _appContext.Categories.Remove(category);
                    _appContext.SaveChanges();
                    tabControl1_SelectedIndexChanged(null, null);
                }
                else if (dialogResult== DialogResult.No)
                {
                    return;
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Meassge: " + exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
