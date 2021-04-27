using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones_Basicas;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool secuencia = true;
        string operacion, borrado;
        double numero1, numero2, resultado;

        //operacoines
        private void divicion_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }
        private void resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }
        private void suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }
       

        private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void textBox18_TextChanged(object sender, EventArgs e)
            {

            }

            //nombre botones//  
            private void textBox13_TextChanged(object sender, EventArgs e)
            {
                if (Pantalla.Text == "0")
                {
                    return;
                }
                else { Pantalla.Text = Pantalla.Text + "0"; }
            }

            private void cero_Click(object sender, EventArgs e)
            {
                if (Pantalla.Text == "0")
                {
                    return;
                }
                else { Pantalla.Text = Pantalla.Text + "0"; }
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void uno_Click(object sender, EventArgs e)
            {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "1";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "1";
            }
        }

            private void dos_Click(object sender, EventArgs e)
            {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "2";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "2";
            }
        }

            private void tres_Click(object sender, EventArgs e)
            {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "3";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "3";
            }
        }

            private void cuatro_Click(object sender, EventArgs e)
            {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "4";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "4";
            }
        }

            private void cinco_Click(object sender, EventArgs e)
            {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "5";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "5";
            }
        }

            private void seis_Click(object sender, EventArgs e)
            {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "6";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "6";
            }
        }

            private void siete_Click(object sender, EventArgs e)
            {
                if (Pantalla.Text == "7")
                {
                    return;
                }
                else { Pantalla.Text = Pantalla.Text + "7"; }
            }

            private void ocho_Click(object sender, EventArgs e)
            {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "8";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "8";
            }
        }
        

        private void nueve_Click(object sender, EventArgs e)
            {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "9";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "9";
            }
        }
        

        private void punto_Click(object sender, EventArgs e)
            {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = ".";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + ".";
            }
        }

        //igual operaciones
        private void igual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(Pantalla.Text);
            if (operacion == "/")
            {
                //objeto de la clase operaciones basicas para utilizar los metodos de dicha clase
                OperacionesBasicas operaciones = new OperacionesBasicas(numero1, numero2);
                resultado = operaciones.divicion();
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "*")
            {
                OperacionesBasicas operaciones = new OperacionesBasicas(numero1, numero2);
                resultado = operaciones.multiplicacion();
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "-")
            {
                OperacionesBasicas operaciones = new OperacionesBasicas(numero1, numero2);
                resultado = operaciones.resta();
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "+")
            {
                OperacionesBasicas operaciones = new OperacionesBasicas(numero1, numero2);
                resultado = operaciones.suma();
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }
        }
        private void cubo_Click(object sender, EventArgs e)
        {
            OperacionesBasicas operacion = new OperacionesBasicas(numero1);
            numero1 = double.Parse(Pantalla.Text);
            resultado = operacion.cuadrado(numero1);
            Pantalla.Text = resultado.ToString();
            secuencia = true;
        }
        private void raiz_Click(object sender, EventArgs e)
        {
            OperacionesBasicas operacion = new OperacionesBasicas(numero1);
            numero1 = double.Parse(Pantalla.Text);
            resultado = operacion.raiz(numero1);
            Pantalla.Text = resultado.ToString();
            secuencia = true;
        }

        //borramos la pantalla
        private void borrar_Click(object sender, EventArgs e)
            {
            Pantalla.Text = "0";
            numero1 = 0;
            numero2 = 0;
            secuencia = true;
        }

        //retroceso o borrar numero ultimo
        private void retroceso_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = Pantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            Pantalla.Text = borrado;
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "0";
                secuencia = true;
            }
            if (Pantalla.Text == "-")
            {
                Pantalla.Text = "0";
                secuencia = true;
            }
        }



    }
}
