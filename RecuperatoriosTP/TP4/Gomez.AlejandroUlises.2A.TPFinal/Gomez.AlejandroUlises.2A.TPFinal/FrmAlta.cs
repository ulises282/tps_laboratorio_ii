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

namespace Gomez.AlejandroUlises._2A.TPFinal
{
    public partial class FrmAlta : Form
    {
        int dni;
        public FrmAlta()
        {
            InitializeComponent();
            cmbPlan.DataSource = PlanesDao.Leer();
            cmbSexo.SelectedIndex = 0;
        }
        public FrmAlta(int dni, string plan) : this()
        {            
            txtDni.Hide();
            lblDni.Text = string.Empty;
            this.dni = dni;  
            btnGuardar.Text = "Modificar";
            cmbPlan.SelectedIndex = cmbPlan.FindString(plan);
            PintarForm();
        }

        private void PintarForm()
        {
            Usuario usuario = UsuarioDao.LeerPorDni(dni);

            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            cmbSexo.SelectedItem = usuario.Sexo;
            txtDni.Text = usuario.Dni.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!Validaciones.ValidarDni(txtDni.Text))
            {
                MessageBox.Show("Error con el dni ingresado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(!Validaciones.ValidarNombre(txtNombre.Text))
            {
                MessageBox.Show("Error con el nombre ingresado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(!Validaciones.ValidarNombre(txtApellido.Text))
            {
                MessageBox.Show("Error con el apellido ingresado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (btnGuardar.Text != "Modificar")
                {
                    Usuario nuevoUsuario = new Usuario(txtNombre.Text, txtApellido.Text, cmbSexo.SelectedItem.ToString(),
                        Convert.ToInt32(txtDni.Text), ((Planes)cmbPlan.SelectedItem).CodigoPlan);

                    UsuarioDao.Guardar(nuevoUsuario);
                }
                else
                {
                    Usuario nuevoUsuario = new Usuario(txtNombre.Text, txtApellido.Text, cmbSexo.SelectedItem.ToString(),
                        Convert.ToInt32(txtDni.Text), ((Planes)cmbPlan.SelectedItem).CodigoPlan);

                    UsuarioDao.Modificar(nuevoUsuario);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }


}
