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

namespace WinForm.POS
{
    public partial class FormListCustomer : Form
    {
        private AppContext _appContext;
        public FormListCustomer()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }
        public int CustomerId => int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
        public string CustomerName => dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

        private void FormListCustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var customers = _appContext.Customers.ToList();
            foreach (var customer in customers)
            {
                dataGridView1.Rows.Add(customer.CusId,customer.Name, customer.Sex,customer.Email, customer.Phone, customer.Note, customer.Address);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
