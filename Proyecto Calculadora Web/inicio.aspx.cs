
//Proyecto 1: Calculadora
//Estudiante: José Pablo Muñoz Zúñiga
//            Karina Maria Unfried Montoya
//            Dillan Josue Obando Samudio
//Carrera: Ingeniería Informática
//Materia: Prográmacion II 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Calculadora_Web
{
    //En esta parte estan cuatro letras donde tienen la funcion de que el resultado que digito ya sea una suma, resta, multiplicacion o division funcione correctamente
    public partial class inicio : System.Web.UI.Page
    {
        static float a, c, d;
        static char b;

        //En esta parte es para recargar la pagina web
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //En esta parte es para mostrar los numeros que se digitan
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //En esta parte el usuario digita el numero uno
        protected void btnOne_Click(object sender, EventArgs e)
        {
            if((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnOne.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnOne.Text;
            }
        }

        //En esta parte el usuario digita el numero dos 
        protected void btnTwo_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnTwo.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnTwo.Text;
            }
        }

        //En esta parte el usuario digita el numero tres
        protected void btnThree_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnThree.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnThree.Text;
            }
        }

        //En esta parte el usuario es para sumar el resultado que digito
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '+';
            TextBox1.Text += b;
        }

        //En esta parte el usuario digita el numero cuatro
        protected void btnFour_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnFour.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnFour.Text;
            }
        }

        //En esta parte el usuario digita el numero cinco
        protected void btnFive_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnFive.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnFive.Text;
            }
        }

        //En esta parte el usuario digita el numero seis
        protected void btnSix_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnSix.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnSix.Text;
            }
        }

        //En esta parte el usuario es para restar el resultado que digito
        protected void btnSub_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '-';
            TextBox1.Text += b;
        }

        //En esta parte el usuario digita el numero siete
        protected void btnSeven_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnSeven.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnSeven.Text;
            }
        }

        //En esta parte el usuario digita el numero ocho
        protected void btnEight_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnEight.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnEight.Text;
            }
        }

        //En esta parte el usuario digita el numero nueve
        protected void btnNine_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnNine.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnNine.Text;
            }
        }

        //En esta parte el usuario es para multiplicar el resultado que digito
        protected void btnMul_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '*';
            TextBox1.Text += b;
        }

        //En esta parte el usuario digita el numero cero
        protected void btnZero_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + btnZero.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + btnZero.Text;
            }
        }

        //En esta parte el usuario es para dividir el resultado que digito
        protected void btnDiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '/';
            TextBox1.Text += b;
        }

        //En esta parte es para que el usuario descubra el resultado que digito 
        protected void btnEqual_Click(object sender, EventArgs e)
        {
            c = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            if (b == '/')
            {
                d = a / c;
                TextBox1.Text += d;
                a = d;
            }
            else if (b == '+')
            {
                d = a + c;
                TextBox1.Text += d;
                a = d;
            }
            else if (b == '-')
            {
                d = a - c;
                TextBox1.Text += d;
                a = d;
            }
            else
            {
                d = a * c;
                TextBox1.Text += d;
                a = d;
            }
        }

        //En esta parte el usuario puede quitar un numero que digito incorrecto
        protected void btnClear_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

    }
}