using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class UserForm : UserControl
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private string _fullname;
        private string _email;
        private Image _avatar;
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; Full_name.Text = value; }
        }
        public string email
        { 
            get { return _email; } set {  _email = value; Email.Text = value; } 
        }
        public Image Avatar
        { 
            get { return _avatar; } set { _avatar = value; avatar.Image = value; }
        }

        private void Full_name_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }
    }
}
