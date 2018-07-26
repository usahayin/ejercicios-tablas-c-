using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIOS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, resta;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);

           resta = num1 - num2;

            label5.Text = resta.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulario2 formulario = new formulario2();
            formulario.Show();
        }
    }
}
