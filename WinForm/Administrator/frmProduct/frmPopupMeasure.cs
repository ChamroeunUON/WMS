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
    public partial class frmPopupMeasure : Office2007Form
    {
        private readonly AppContext _appContext;
        public frmPopupMeasure()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }

        public string MeasureId
        {
            get
            {
                var id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                return id;
            }
        }

        public string MeasureName
        {
            get
            {
                var id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                return id;
            }
        }
        private void frmPopupMeasure_Load(object sender, EventArgs e)
        {
            try
            {
                var measures = _appContext.Measures.ToList();
                foreach (var measure in measures)
                {
                    dataGridView1.Rows.Add(measure.Id, measure.Name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Message:"+exception);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
