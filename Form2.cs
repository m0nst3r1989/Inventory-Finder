using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_FInder
{
    public partial class Form2 : Form
    {
        Form1 frm;
        public Form2()
        {
            InitializeComponent();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();

        }
       
        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            Close();
        }

        public void AisleNumBox_TextChanged(object sender, EventArgs e)
        {
          
           
        }
    }
}
