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
using WinForm.Models.Support;

namespace WinForm.Administrator
{
    public partial class FrmUser : Office2007Form
    {
        private AppContext _appContext;
        private Models.User _user;

        private Models.User Formdata
        {
            get
            {
                var user = new User
                {
                    UserNmae = txtUserNmae.Text,
                    Password = Encryption.Encrypt(Encryption.GetHashKey(Encryption.HashKey), txtPwd.Text),
                    Note = txtNote.Text
                    
            };
                return user;
            }
        }
        public FrmUser()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                var users = _appContext.Users.ToList();
                foreach (var user in users)
                {
                    dataGridView1.Rows.Add(user.Id, user.UserNmae, user.Note);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error" + exception);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                _user = _appContext.Users.Find(id);
                if (_user != null)
                {
                    txtUserNmae.Text = _user.UserNmae;
                    txtPwd.Text = Encryption.Decrypt(Encryption.GetHashKey(Encryption.HashKey), _user.Password);
                    txtNote.Text = _user.Note;
                }
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error" + exception);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_user == null)
                {
                    var user = Formdata;
                    _appContext.Users.Add(user);
                    MessageBox.Show("Inserted");
                }
                else
                {
                    _user.UserNmae = txtUserNmae.Text;
                    _user.Password = Encryption.Encrypt(Encryption.GetHashKey(Encryption.HashKey), _user.Password);
                    _user.Note = txtNote.Text;
                    MessageBox.Show("Updated");
                }
                _appContext.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error" + exception);
            }

        }
    }
}
