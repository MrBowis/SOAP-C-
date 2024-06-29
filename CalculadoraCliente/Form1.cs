using CalculadoraCliente.Calculadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCliente
{
    public partial class Form1 : Form
    {
        private Operaciones operaciones = new Operaciones();
        Calculadora.CalculadoraClient operar = new Calculadora.CalculadoraClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void suma_click(object sender, EventArgs e)
        {
            operaciones.Operacion = "+";
            operaciones.Numero1 = float.Parse(N1.Value.ToString());
            operaciones.Numero2 = float.Parse(N2.Value.ToString());
            operaciones.Resultado = operar.operar(operaciones);
            resultado.Text = operaciones.Resultado.ToString();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operaciones.Operacion = "-";
            operaciones.Numero1 = float.Parse(N1.Value.ToString());
            operaciones.Numero2 = float.Parse(N2.Value.ToString());
            operaciones.Resultado = operar.operar(operaciones);
            resultado.Text = operaciones.Resultado.ToString();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            operaciones.Operacion = "*";
            operaciones.Numero1 = float.Parse(N1.Value.ToString());
            operaciones.Numero2 = float.Parse(N2.Value.ToString());
            operaciones.Resultado = operar.operar(operaciones);
            resultado.Text = operaciones.Resultado.ToString();
        }

        private void division_Click(object sender, EventArgs e)
        {
            try
            {
                operaciones.Operacion = "/";
                operaciones.Numero1 = float.Parse(N1.Value.ToString());
                operaciones.Numero2 = float.Parse(N2.Value.ToString());
                operaciones.Resultado = operar.operar(operaciones);
                resultado.Text = operaciones.Resultado.ToString();
            } catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
        }
    }
}
