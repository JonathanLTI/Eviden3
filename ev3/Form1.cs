using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //VAR
        string operador = "";
        double num1 = 0;
        double num2 = 0;    


        private void btn_suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            num1 = 0;   
            num2 = 0;
            operador = "";
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if(txtScreen.Text == "1") txtScreen.Text = "0";
            else txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
        }

        private void btn_uno_Click(object sender, EventArgs e)
        {
            if(txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "1";
        }
        private void btn_dos_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "2";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "3";
        }

        private void btn_cuatro_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "4";
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "5";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "6";
        }

        private void btn_siete_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "7";
        }

        private void btn_ocho_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "8";
        }

        private void btn_nueve_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "9";
        }

        private void btn_cero_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "0";
            
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ".";
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtScreen.Text);

            switch (operador)
            {
                case "+":
                    txtScreen.Text = $"{num1 + num2}";
                    break;

                case "-":
                    txtScreen.Text = $"{num1 - num2}";
                    break;

                case "*":
                    txtScreen.Text = $"{num1 * num2}";
                    break;

                case "/":
                    txtScreen.Text = $"{num1 / num2}";
                    break;
            }

        }
    }
}
