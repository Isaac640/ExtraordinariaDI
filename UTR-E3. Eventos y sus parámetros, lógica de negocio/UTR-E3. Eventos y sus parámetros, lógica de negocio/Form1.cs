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

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 0 + "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 1 + "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 2 + "";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 3 + "";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 4 + "";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 5 + "";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 6 + "";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 7 + "";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 8 + "";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 9 + "";
        }
        private void btnComa_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + ",";
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
                    txtCalc.Text = "";
                    break;

                case "-":
                    _calculadora.Operacion = OperacionEnum.Resta;
                    txtCalc.Text = "";
                    break;

                case "*":
                    _calculadora.Operacion = OperacionEnum.Multiplicacion;
                    txtCalc.Text = "";
                    break;

                case "/":
                    _calculadora.Operacion = OperacionEnum.Division;
                    txtCalc.Text = "";
                    break;
            }
            txtCalc.Text = _calculadora.Visor.ToString();
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
