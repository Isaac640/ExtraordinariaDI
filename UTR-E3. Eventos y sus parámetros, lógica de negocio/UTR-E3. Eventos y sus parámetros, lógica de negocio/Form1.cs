using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTR_E3.Eventos_y_sus_parámetros__lógica_de_negocio
{
    public partial class Form1 : Form
    {
        private Calculadora _calculadora;
        public Form1()
        {
            InitializeComponent();
            _calculadora = new Calculadora();
        }

        //NUMEROS

        private float num;

        private void btnNum_Click(object sender, EventArgs e)
        {
            string numero = ((Button)sender).Tag.ToString();
            switch (numero)
            {
                case "1":
                    txtCalc.Text += 1;
                    break;

                case "2":
                    txtCalc.Text += 2;
                    break;

                case "3":
                    txtCalc.Text += 3;
                    break;

                case "4":
                    txtCalc.Text += 4;
                    break;

                case "5":
                    txtCalc.Text += 5;
                    break;

                case "6":
                    txtCalc.Text += 6;
                    break;

                case "7":
                    txtCalc.Text += 7;
                    break;

                case "8":
                    txtCalc.Text += 8;
                    break;

                case "9":
                    txtCalc.Text += 9;
                    break;

                case "0":
                    txtCalc.Text += 0;
                    break;

                case ",":
                    if (!txtCalc.Text.Contains(","))
                    {
                        txtCalc.Text += ",";
                    }
                    break;

            }
        }

        //OPERADORES

        private void btnOp_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtCalc.Text);
            _calculadora.Visor = num;
            string operacion = ((Button)sender).Tag.ToString();
            switch (operacion)
            {
                case "+":
                    _calculadora.Operacion = OperacionEnum.Suma;
                    break;

                case "-":
                    _calculadora.Operacion = OperacionEnum.Resta;
                    break;

                case "*":
                    _calculadora.Operacion = OperacionEnum.Multiplicacion;
                    break;

                case "/":
                    _calculadora.Operacion = OperacionEnum.Division;
                    break;
            }
            txtCalc.Text = string.Empty;
        }

        //MISC

        private void btnMS_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtCalc.Text);
            _calculadora.Memoria = num;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtCalc.Text = _calculadora.Memoria.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCalc.Text = string.Empty;
            _calculadora.Borrar();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            _calculadora.Visor = float.Parse(txtCalc.Text);
            _calculadora.Calcular();
            txtCalc.Text = _calculadora.Visor.ToString();
        }

        //TECLADO

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TECLADO DE NUMEROS

            if (Char.IsDigit(e.KeyChar))
            {
                txtCalc.Text += e.KeyChar.ToString();
                return;
            }

            //COMA

            if (e.KeyChar == ',')
            {
                if (txtCalc.Text.Contains(','))
                {
                    return;
                }
                txtCalc.Text += ",";
            }

            //TECLADO DE OPERADORES

            switch (e.KeyChar)
            {
                case '+':
                    num = float.Parse(txtCalc.Text);
                    _calculadora.Visor = num;
                    _calculadora.Operacion = OperacionEnum.Suma;
                    txtCalc.Text = string.Empty;
                    break;

                case '-':
                    num = float.Parse(txtCalc.Text);
                    _calculadora.Visor = num;
                    _calculadora.Operacion = OperacionEnum.Resta;
                    txtCalc.Text = string.Empty;
                    break;

                case '*':
                    num = float.Parse(txtCalc.Text);
                    _calculadora.Visor = num;
                    _calculadora.Operacion = OperacionEnum.Multiplicacion;
                    txtCalc.Text = string.Empty;
                    break;

                case '/':
                    num = float.Parse(txtCalc.Text);
                    _calculadora.Visor = num;
                    _calculadora.Operacion = OperacionEnum.Division;
                    txtCalc.Text = string.Empty;
                    break;
            }

        }

    }
}

