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
    public partial class FrmAltaPlanes : Form
    {
        int codigoPlan;
        public FrmAltaPlanes()
        {
            InitializeComponent();
        }

        public FrmAltaPlanes(int codigoPlan) : this()
        {
            this.codigoPlan = codigoPlan;
            btnGuardar.Text = "Modificar";
            PintarForm();
        }

        private void PintarForm()
        {
            Planes plan = PlanesDao.LeerPorCodigoPlan(codigoPlan);

            txtNombre.Text = plan.Nombre;
            nupPrecio.Value = Convert.ToInt32(plan.Precio);
            nupMegas.Value = plan.Megas;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text != "Modificar")
            {
                Planes nuevoPlan = new Planes(codigoPlan, Convert.ToDouble(nupPrecio.Value), Convert.ToInt32(nupMegas.Value), txtNombre.Text);

                PlanesDao.Guardar(nuevoPlan);
            }
            else
            {
                Planes nuevoPlan = new Planes(codigoPlan, Convert.ToDouble(nupPrecio.Value), Convert.ToInt32(nupMegas.Value), txtNombre.Text);

                PlanesDao.Modificar(nuevoPlan);
            }
            DialogResult = DialogResult.OK;
        }


    }
}
