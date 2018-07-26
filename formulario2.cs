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
    public partial class formulario2 : Form
    {
        public formulario2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formulario = new Form2();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 formulario = new Form3();
            formulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 formulario = new Form4();
            formulario.Show();
        }
    }
}
