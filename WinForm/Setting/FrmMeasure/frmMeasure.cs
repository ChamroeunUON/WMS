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

namespace WinForm.Setting.FrmMeasure
{
    public partial class frmMeasure : Office2007Form
    {
        private AppContext _appContext;
        private Models.Measure _measure;

        private Models.Measure FormData
        {
            get
            {
                var measure = new Measure
                {
                    Name = txtName.Text,
                    Note = txtNote.Text

                };
                return measure;
            }
        }
        public frmMeasure()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }

        private void frmMeasure_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Name is required.", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (_measure == null)
                {
                    var measure = FormData;
                    _appContext.Measures.Add(measure);
                }
                else
                {
                    _measure.Name = FormData.Name;
                    _measure.Note = FormData.Note;
                }
                _appContext.SaveChanges();
                _measure = null;
                MessageBox.Show("Successfuly", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : "+exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                var measure = _appContext.Measures.ToList();

                foreach (var measure1 in measure)
                {
                    dataGridView1.Rows.Add(measure1.Id, measure1.Name, measure1.Note);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error :"+exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var id =int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                _measure = _appContext.Measures.Find(id);
                if (_measure == null) return;
                txtName.Text = _measure.Name;
                txtNote.Text = _measure.Note;
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error :"+exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var dialogResult = MessageBox.Show("Are you sure delete this measure?", @"Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult != DialogResult.Yes) return;
                var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var measure = _appContext.Measures.Find(id);
                if (measure != null) _appContext.Measures.Remove(measure);
                _appContext.SaveChanges();
                tabControl1_SelectedIndexChanged(null,null);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error :" + exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
