using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        bool cerrar = false;
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "";
            cmbOperador.SelectedIndex = -1;
            lstOperaciones.Items.Clear();
        }
        private static double Operar(string numero1, string numero2, string operador)
        {
            double retorno;
            Operando primerOperando = new Operando(numero1);
            Operando segundoOperando = new Operando(numero2);

            retorno = Calculadora.Operar(primerOperando, segundoOperando, char.Parse(operador));

            return retorno;
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(this.cmbOperador.Text.ToString()!="")
            {
                double intentoParseo;
                if(double.TryParse(this.txtNumero1.Text, out intentoParseo) && double.TryParse(this.txtNumero2.Text, out intentoParseo))
                {
                    StringBuilder s = new StringBuilder();
                    double resultado;
                    resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text.ToString());
                    s.Append(this.txtNumero1.Text);
                    s.Append(this.cmbOperador.Text.ToString());
                    s.Append(this.txtNumero2.Text);
                    s.Append("=");
                    s.Append(resultado);
                    this.lblResultado.Text = resultado.ToString();
                    this.lstOperaciones.Items.Add(s.ToString());
                }
                else
                {
                    MessageBox.Show("Ingrese numeros validos.");
                } 
            }
            else
            {
                MessageBox.Show("Ingrese un operador.");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(this.lblResultado.Text!=null)
            {
                string resultado;
                resultado = Operando.DecimalBinario(this.lblResultado.Text);
                this.lblResultado.Text = resultado;
            }
            else
            {
                MessageBox.Show("primero haga una operacion.");
            }
        }
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if(this.lblResultado.Text != null)
            {
                string resultado;
                resultado = Operando.BinarioDecimal(this.lblResultado.Text);
                this.lblResultado.Text = resultado;
            }
            else
            {
                MessageBox.Show("primero haga una operacion.");
            }
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cerrar == true)
            {
                this.Close();
            }
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿seguro de querer salir?", "Salir", botones, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                cerrar = true;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
