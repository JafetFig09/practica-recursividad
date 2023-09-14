using PracticaRecursividad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            panel1.Visible=true;
            panel2.Visible=false;
            panel3.Visible=false;
        }

        private void btnCalcularFactorial_Click(object sender, EventArgs e)
        {
            Recursiva recursiva = new Recursiva();

            recursiva.numero = Convert.ToInt32(tbFactorial.Text.Trim());

            lbFactorial.Text = recursiva.Factorial(recursiva.numero).ToString();

        }

        private void btnCalcularFibonacci_Click(object sender, EventArgs e)
        {
            Recursiva recursiva=new Recursiva();
            recursiva.numero = Convert.ToInt32(tbFibonacci.Text.Trim());
            lbFibonacci.Text = recursiva.Fibonacci(recursiva.numero).ToString();
        }

        private void Fibonacci_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            panel2.Visible=true;
            panel3.Visible=false;
        }

        private void Mcd_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible=false;
            panel3.Visible=true;
        }

        private void btnCalcularMcd_Click(object sender, EventArgs e)
        {
            Recursiva recurisiva = new Recursiva();

            recurisiva.numero = Convert.ToInt32(tbMcd1.Text.Trim());
            recurisiva.numero2 = Convert.ToInt32(tbMcd2.Text.Trim());

            lbMcd.Text = recurisiva.MaximoComunDivisor(recurisiva.numero, recurisiva.numero2).ToString();
        }
    }
}
