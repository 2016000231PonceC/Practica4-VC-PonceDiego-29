using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Practica4_VC_PonceDiego_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[,] m1;
        private int[,] m2;
        private int[,] suma;
        private int[,] resta;
        private int[,] multiplicacion;
        private int[,] division;
      
   
        private void Matriz1_Click(object sender, EventArgs e)
        {
            m1 = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 4; c++) 
                {
                    m1[i, c]= Convert.ToInt32(Interaction.InputBox("Ingrese un Numero"));
                    listBox1.Items.Add(m1[i, c]);
                
                }
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m2 = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 4; c++)
                {
                    m2[i, c] = Convert.ToInt32(Interaction.InputBox("Ingrese un Numero"));
                    listBox2.Items.Add(m2[i, c]);

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            suma = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 4; c++)
                {
                    suma[i, c] = m1[i, c]+ m2[i, c];
                    listBox3.Items.Add(suma[i, c]);

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resta = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 4; c++)
                {
                    resta[i, c] = m1[i, c] - m2[i, c];
                    listBox3.Items.Add(resta[i, c]);

                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            multiplicacion = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 4; c++)
                {
                    multiplicacion[i, c] = m1[i, c] * m2[i, c];
                    listBox3.Items.Add(multiplicacion[i, c]);

                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            division = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 4; c++)
                {
                    division[i, c] = m1[i, c] / m2[i, c];
                    listBox3.Items.Add(division[i, c]);

                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cuadrado = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 4; c++)
                {
                    cuadrado[i, c] = m1[i, c] ^ m2[i, c];
                    listBox3.Items.Add(cuadrado[i, c]);

                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cubo = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 4; c++)
                {
                    cubo[i, c] = m1[i, c] + m2[i, c];
                    listBox3.Items.Add(cubo[i, c]);

                }

            }
        }
        private double[,] raiz1;
        private void button8_Click(object sender, EventArgs e)
        {
            raiz1 = new double[3, 4];
            m1 = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 4; c++)
                {
                    raiz1[i, c] = Math.Sqrt(m1[3, 4]);
                    listBox3.Items.Add(raiz[i, c]);

                }

            }
        }
    }
}
