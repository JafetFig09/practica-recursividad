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
            
            if(int.TryParse(tbFactorial.Text.Trim(), out int result))
            {
                if (result <= 0)
                {
                    MessageBox.Show("El número debe ser mayor o igual a cero", "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    Recursiva recursiva = new Recursiva();
                    recursiva.numero = result;

                    lbFactorial.Text = recursiva.Factorial(recursiva.numero).ToString();
                }
            }
            else
            {
                MessageBox.Show("No se acetan caracteres","ERROR",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnCalcularFibonacci_Click(object sender, EventArgs e)
        {
            if(int.TryParse(tbFibonacci.Text.Trim(), out int result))
            {
                if (result < 0)
                {
                    MessageBox.Show("El número debe ser mayor o igual a cero", "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    Recursiva recursiva = new Recursiva();
                    recursiva.numero = result;
                    lbFibonacci.Text = recursiva.Fibonacci(recursiva.numero).ToString();
                }
            }
            else
            {
                MessageBox.Show("No se acetan caracteres", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

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
            if(int.TryParse(tbMcd1.Text.Trim(), out int result1) && 
                int.TryParse(tbMcd2.Text.Trim(), out int result2))
            {
                if (result1 <= 0 || result2 <= 0)
                {
                    MessageBox.Show("El número debe ser mayor o igual a cero", "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    Recursiva recurisiva = new Recursiva();

                    recurisiva.numero = result1;
                    recurisiva.numero2 = result2;

                    lbMcd.Text = recurisiva.MaximoComunDivisor(recurisiva.numero, recurisiva.numero2).ToString();

                }
            }
            else
            {
                MessageBox.Show("No se acetan caracteres", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
