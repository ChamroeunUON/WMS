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

namespace WinForm.Administrator.frmProduct
{
    public partial class FormListSupplier : Form
    {
        public FormListSupplier()
        {
            InitializeComponent();
        }

        public string SupplierId
        {
            get
            {
                var id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                return id;
            }
        }
        public string SupplierName
        {
            get
            {
                var name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                return name;
            }
        }
        private void FormListSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                using (var appContext = new AppContext())
                {
                    var suppliers  = appContext.Suppliers.ToList();
                    foreach (var supplier in suppliers )
                    {
                        dataGridView1.Rows.Add(supplier.Id, supplier.Name,supplier.Email,supplier.Address);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error :" + exception, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
