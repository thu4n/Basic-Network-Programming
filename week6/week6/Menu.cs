using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week6
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void todosAPI_Click(object sender, EventArgs e)
        {
            TodosAPI todos = new TodosAPI();
            todos.Show();
        }

        private void puppyAPI_Click(object sender, EventArgs e)
        {
            PuppyAPI puppy = new PuppyAPI();
            puppy.Show();
        }

        private void customBtn_Click(object sender, EventArgs e)
        {
            CustomAPI custom = new CustomAPI();
            custom.Show();
        }
    }
}
