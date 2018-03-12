using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Info;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Vuelos : Form
    {
        DataSet hoteles = new DataSet();

        public Vuelos()
        {
            InitializeComponent();
            btnPreliminar.Visible = false;
            pnlPasajeros.Visible = false;
            pnlHotel.Visible = false;
            pnlAuto.Visible = false;
        }

        public void autoComplete()
        {
            try
            {
                Conexion.Coneccion();
                Conexion.conexion.Open();
                Conexion.cmd = new NpgsqlCommand("SELECT pais_origen, pais_destino FROM rutas", Conexion.conexion);
                NpgsqlDataReader dr = Conexion.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtOrigen.AutoCompleteCustomSource.Add(dr["pais_origen"].ToString());
                        txtDestino.AutoCompleteCustomSource.Add(dr["pais_destino"].ToString());
                    }
                }
                Conexion.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
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
            autoComplete();
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
                btnPreliminar.Visible = true;
                pnlHotel.Visible = true;
                dgvBusqueda.DataSource = null;
                this.Size = new Size(this.Size.Width, 385);
                hoteles.Clear();
                dgvBusqueda.Rows.Clear();
                Conexion.Coneccion();
                Conexion.conexion.Open();
                NpgsqlDataAdapter read = new NpgsqlDataAdapter("SELECT nombre,lugar,precio FROM hoteles WHERE pais = '" + txtDestino.Text + "'", Conexion.conexion);
                read.Fill(hoteles);
                Conexion.conexion.Close();
                DataTable dtAll = hoteles.Tables[0].Copy();
                for (var i = 1; i < hoteles.Tables.Count; i++)
                {
                    dtAll.Merge(hoteles.Tables[i]);
                }
                dgvBusqueda.AutoGenerateColumns = true;
                dgvBusqueda.DataSource = dtAll;
            }
            if (boxAuto.Checked.Equals(true))
            {
                this.Size = new Size(555, this.Size.Height);
                pnlAuto.Visible = true;
                btnPreliminar.Visible = true;
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
