using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class addnewBook : Form
    {
        public addnewBook()
        {
            InitializeComponent();
        }

        private void addnewBooKOk_Click(object sender, EventArgs e)
        {
            Program.newBookName = addnewBookBox.Text;
            this.Close();
        }

        private void addnewBookCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
