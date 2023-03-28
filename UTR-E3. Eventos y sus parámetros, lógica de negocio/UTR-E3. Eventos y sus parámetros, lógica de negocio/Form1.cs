using System;
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
                    txtCalc.Text = txtCalc.Text + 1 + "";
                    break;
                case "2":
                    txtCalc.Text = txtCalc.Text + 2 + "";
                    break;
                case "3":
                    txtCalc.Text = txtCalc.Text + 3 + "";
                    break;
                case "4":
                    txtCalc.Text = txtCalc.Text + 4 + "";
                    break;
                case "5":
                    txtCalc.Text = txtCalc.Text + 5 + "";
                    break;
                case "6":
                    txtCalc.Text = txtCalc.Text + 6 + "";
                    break;
                case "7":
                    txtCalc.Text = txtCalc.Text + 7 + "";
                    break;
                case "8":
                    txtCalc.Text = txtCalc.Text + 8 + "";
                    break;
                case "9":
                    txtCalc.Text = txtCalc.Text + 9 + "";
                    break;
                case "0":
                    txtCalc.Text = txtCalc.Text + 0 + "";
                    break;
                case ",":
                    if (!txtCalc.Text.Contains(","))
                    {
                        txtCalc.Text = txtCalc.Text + ",";
                    }
                    break;

            }
        }

        //OPERADORES

        private void btnOp_Click(object sender, EventArgs e)
        {
            float.TryParse(txtCalc.Text, out num);
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
            txtCalc.Text = "";
        }

        //MISC

        private void btnMS_Click(object sender, EventArgs e)
        {
            float.TryParse(txtCalc.Text, out num);
            _calculadora.Memoria = num;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtCalc.Text = _calculadora.Memoria.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCalc.Text = "";
            _calculadora.Borrar();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            _calculadora.Visor = float.Parse(txtCalc.Text);
            _calculadora.Calcular();
            txtCalc.Text = _calculadora.Visor.ToString();
        }

    }
}

