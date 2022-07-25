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
using Entidades.Exceptions;

namespace Gomez.AlejandroUlises._2A.TPFinal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            RefrescarBiblioteca();
            RefrescarPlanes();
        }

        private void RefrescarBiblioteca()
        {
            try
            {
                dtgvBiblioteca.DataSource = UsuarioDao.Leer();
                dtgvBiblioteca.Refresh();
                dtgvBiblioteca.Update();
            }
            catch (DbInvalidException exception)
            {
                MessageBox.Show(exception.Message, "Error al conectarse a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RefrescarPlanes()
        {
            try
            {
                dtgvPlanes.DataSource = PlanesDao.Leer();
                dtgvPlanes.Refresh();
                dtgvPlanes.Update();
            }
            catch (DbInvalidException exception)
            {
                MessageBox.Show(exception.Message, "Error al conectarse a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = new FrmAlta();
            if (frmAlta.ShowDialog() == DialogResult.OK)
            {
                RefrescarBiblioteca();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dtgvBiblioteca.SelectedRows.Cunt > 0)
            {
                Biblioteca biblioteca = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;

                UsuarioDao.Eliminar(biblioteca.Dni);
                RefrescarBiblioteca();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (dtgvBiblioteca.SelectedRows.Count > 0)
            {
                Biblioteca biblioteca = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;

                FrmAlta frmAlta = new FrmAlta(biblioteca.Dni, biblioteca.NombrePlan);
                if (frmAlta.ShowDialog() == DialogResult.OK)
                {
                    RefrescarBiblioteca();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            FrmAltaPlanes frmAltaPlanes = new FrmAltaPlanes();
            if (frmAltaPlanes.ShowDialog() == DialogResult.OK)
            {
                RefrescarPlanes();
            }
        }

        private void btnModificarPlan_Click(object sender, EventArgs e)
        {
            if (dtgvPlanes.SelectedRows.Count > 0)
            {
                Planes plan = (Planes)dtgvPlanes.CurrentRow.DataBoundItem;
                if(plan.CodigoPlan != 1)
                {
                    FrmAltaPlanes frmAltaPlanes = new FrmAltaPlanes(plan.CodigoPlan);
                    if (frmAltaPlanes.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarPlanes();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un plan", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarPlan_Click(object sender, EventArgs e)
        {
            if (dtgvPlanes.SelectedRows.Count > 0)
            {
                Planes plan = (Planes)dtgvPlanes.CurrentRow.DataBoundItem;
                if(plan.CodigoPlan != 1)
                {
                    
                    CambiarPlanesEliminados(plan.CodigoPlan);
                    PlanesDao.Eliminar(plan.CodigoPlan);
                }
                RefrescarPlanes();
                RefrescarBiblioteca();
            }
            else
            {
                MessageBox.Show("Seleccione un plan", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CambiarPlanesEliminados(int codigoPlan)
        {
            List<Usuario> usuarios = new List<Usuario>();

            usuarios = UsuarioDao.LeerUsuarios();

            foreach (Usuario item in usuarios)
            {
                if(item.CodigoPlan == codigoPlan)
                {
                    item.CodigoPlan = 1;
                    UsuarioDao.Modificar(item);
                }
            }
        }
    }
}
