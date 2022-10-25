using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Inventory_FInder
{
    
    public partial class Form1 : Form
    {
        Form2 frm2;
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();

        }

    private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void SearchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }  

    private void ExitBtn_Click(object sender, EventArgs e)
        {

        this.Close();

        }

        public void ProductNamBox_SelectedIndexChanged(object sender, EventArgs e, Form2 Form2)
        {
           
            

            productNamBox.Items.Add("Resistors");


            if (productNamBox.SelectedItem == "resistor")
            {
                textBox1.Text = "1";
            }


            productNamBox.Items.Add("Capacitor");

            if(productNamBox.SelectedItem == "Capacitor")
            {
                textBox1.Text="2";
            }

            productNamBox.Items.Add("Transistors");

            if (productNamBox.SelectedItem == "Transistors")
            {
                textBox1.Text = "3";
            }

            if(productNamBox.SelectedItem == "resistor")
            {
                
                Form2.AisleNumBox.Text = "Aisle 10";
                Form2.shelfNumBox.Text = "Shelf 2";
                Form2.quantityNumBox.Text = "50";
            }
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
