using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Vuelos : Form
    {
        public Vuelos()
        {
            InitializeComponent();
        }

        private void btnPasajeros_Click(object sender, EventArgs e)
        {
            this.Size = new Size(555, this.Size.Height);
            pnlPasajeros.Visible = true;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(405, this.Size.Height);
            pnlPasajeros.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(405, this.Size.Height);
            pnlPasajeros.Visible = false;
        }

        private void Vuelos_Load(object sender, EventArgs e)
        {
            pnlPasajeros.Visible = false;
            pnlHotel.Visible = false;
            pnlAuto.Visible = false;
        }

        private void boxHotel_CheckedChanged(object sender, EventArgs e)
        {
            if (boxHotel.Checked.Equals(false))
            {
                this.Size = new Size(this.Size.Width, 215);
                pnlHotel.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (boxHotel.Checked.Equals(true) && txtDestino.Text.Equals(""))
            {
                MessageBox.Show("No se puede buscar, favor seleccione un origen y un destino o desabilite Añadir Hotel.");
            }
            if(boxHotel.Checked.Equals(true) && txtDestino.Text != "")
            {
                this.Size = new Size(this.Size.Width, 385);
                pnlHotel.Visible = true;
            }
            if (boxAuto.Checked.Equals(true))
            {
                this.Size = new Size(555, this.Size.Height);
                pnlAuto.Visible = true;
            }
        }

        private void boxAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (boxAuto.Checked.Equals(false))
            {
                this.Size = new Size(405, this.Size.Height);
                pnlAuto.Visible = false;
            }
        }
    }
}
