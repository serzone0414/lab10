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
    public partial class addSimilarBookForm : Form
    {
        public addSimilarBookForm()
        {
            InitializeComponent();
        }

        private void addsimilarBooKOk_Click(object sender, EventArgs e)
        {
            Program.newSimlilarBookName = newSimilarBookBox.Text;
            this.Close();
        }

        private void addsimilarBookCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
