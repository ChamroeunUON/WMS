using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Administrator.FormCategory;
using WinForm.Models;

namespace WinForm.Administrator.frmProduct
{
    public partial class frmPopupCategory : Form
    {
        private readonly AppContext _appContext;
        public frmPopupCategory()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }
        
        public string CatName
        {

            get
            {
                var name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                return name;
            }
        }
        public string CatId
        {

            get
            {
                var id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                return id;
            }
        }


        private void frmPopupCategory_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var cat = _appContext.Categories.ToList();
            foreach (var category in cat)
            {
                dataGridView1.Rows.Add(category.Id, category.Name);
            }
        }

        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
          
            this.Hide();
        }
    }
}
