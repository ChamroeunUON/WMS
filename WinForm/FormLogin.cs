﻿using System;
using System.Linq;
using System.Windows.Forms;
using WinForm.Models;
using WinForm.Models.Support;

namespace WinForm
{
    public partial class FormLogin : Form
    {
        public string Username { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            var focused = txtUserName.Focused;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_Click(object sender, EventArgs e)
        {
            try
            {
                using (var appContext = new AppContext())
                {
                    var users = appContext.Users.ToList();
                    foreach (var user in users)
                    {
                        if (txtUserName.Text != user.UserNmae) continue;
                        var pwd = Encryption.Decrypt(Encryption.GetHashKey(Encryption.HashKey), user.Password);
                        if (pwd != txtpwd.Text) continue;
                        CurrentUser.GetCurrentUser = txtUserName.Text;
                        CurrentUser.GetCurrentUserId = user.Id;
                        Hide();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Error :" + exception);
            }
        }
    }
}
