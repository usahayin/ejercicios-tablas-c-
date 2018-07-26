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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, multiplicacion;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            multiplicacion = num1 * num2;
            label4.Text = multiplicacion.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num1, num2, multiplicacion;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);

            multiplicacion = num1 * num2;

            label5.Text = multiplicacion.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulario2 formulario = new formulario2();
            formulario.Show();
        }
    }
    }


