using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WinForm.Models;
using WinForm.Models.Support;

namespace WinForm.Administrator.Employee
{
    public partial class frmEmployee : Office2007Form
    {
        private readonly AppContext _appContext;
        private Models.Employee _employee;

        private Models.Employee FormData
        {
            get
            {
                var employee = new Models.Employee
                {
                    NameEN = txtNameEN.Text,
                    NameKH = txtNameKH.Text,
                    Sex = cboSex.SelectedItem.ToString(),
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    DOB = birthdate.Value,
                    Address = txtAddress.Text,
                    Note = txtNote.Text,
                    Possition = txtPosition.Text,
                    Photo = ConvertFilterToByte(pictureBox1.ImageLocation)
                };
                return employee;
            }
        }


        public frmEmployee()
        {
            _appContext = new AppContext();
                InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private static byte[] ConvertFilterToByte(string sPath)
        {
            byte[] data = null;
            var info = new FileInfo(sPath);
            var numByte = info.Length;
            var fileStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            var binaryReader = new BinaryReader(fileStream);
            data = binaryReader.ReadBytes((int) numByte);
            return data;
        }

        public void btnBrowse_Click(object sender, EventArgs e)
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

        private void bnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNameEN.Text))
                {
                    MessageBox.Show("Name EN is Required ", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNameKH.Text))
                {
                    MessageBox.Show("Name KH is Required ", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (_employee == null)
                {
                    var employee = FormData;
                    _appContext.Employees.Add(employee);
                    MessageBox.Show("Inserted Successfully");
                }
                else
                {
                    _employee.NameEN = txtNameEN.Text;
                    _employee.NameKH = txtNameKH.Text;
                    _employee.Sex = cboSex.SelectedItem.ToString();
                    _employee.Phone = txtPhone.Text;
                    _employee.Email = txtEmail.Text;
                    _employee.Note = txtNote.Text;
                    _employee.Address = txtAddress.Text;
                    _employee.DOB = birthdate.Value;
                    _employee.Possition = txtPosition.Text;
                    _employee.Photo = ConvertFilterToByte(pictureBox1.ImageLocation);
                    MessageBox.Show("Updated Success.");
                }
                _employee = null;
                _appContext.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Message:" + exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                var employees = _appContext.Employees.ToList();
                foreach (var employee in employees)
                    dataGridView1.Rows.Add(employee.Id, employee.NameEN, employee.Sex, employee.Phone, employee.DOB,
                        employee.Address, employee.Note);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Message:" + exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                _employee = _appContext.Employees.Find(id);
                if (_employee != null)
                {
                    txtNameEN.Text = _employee.NameEN;
                    txtNameKH.Text = _employee.NameKH;
                    txtPhone.Text = _employee.Phone;
                    txtEmail.Text = _employee.Email;
                    cboSex.SelectedItem = _employee.Sex;
                    txtPosition.Text = _employee.Possition;
                    txtNote.Text = _employee.Note;
                    txtAddress.Text = _employee.Address;
                    pictureBox1.Image = ConvertByteToImage(_employee.Photo);
                    tabControl1.SelectedIndex = 0;
                }
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
                var emp = _appContext.Employees.Find(id);
                if (emp != null) _appContext.Employees.Remove(emp);
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
