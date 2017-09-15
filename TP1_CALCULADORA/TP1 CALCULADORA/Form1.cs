using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_CALCULADORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.Items.Add("+");
            this.cmbOperacion.Items.Add("-");
            this.cmbOperacion.Items.Add("*");
            this.cmbOperacion.Items.Add("/");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textNumero1.Clear();
            this.textNumero2.Clear();
            this.cmbOperacion.Text = "";
            this.lblResultado.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero(this.textNumero1.Text); //INSTANCIO EL NUMERO 1 Y OBTENGO EL NUMERO
            Numero num2 = new Numero(this.textNumero2.Text); //INSTANCIO EL NUMERO 2 Y OBTENGO EL NUMERO
            Calculadora operador = new Calculadora(); // INSTANCION MI OPERADOR
            Calculadora operar = new Calculadora();
             //LLAMO A MI METODO VALDAR OPERADOR, le paso los numeros Y OBTENGO MI OPERADOR Y OPERO
            this.lblResultado.Text = Convert.ToString(operar.operar(num1, num2, operador.validarOperador(this.cmbOperacion.Text)));
            //this.button1_Click(sender, e);
            
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
