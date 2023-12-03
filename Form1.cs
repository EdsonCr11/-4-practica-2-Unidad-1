using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_practica_2_Unidad_1
{
    public partial class Form1 : Form
    {
        float f_num, Total = 0;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {//Boton Añadir
            listBox1.Items.Add(textBox1.Text);
            //Aqui es donde pasamos el parametro
            f_num = float.Parse(textBox1.Text);
            Total += f_num;
            textBox1.Text = "";
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton sumarnumeros
            textBox2.Text = Total.ToString();
        }
    }
}
