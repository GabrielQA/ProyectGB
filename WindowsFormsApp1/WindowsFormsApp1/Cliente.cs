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
    public partial class formAlojamiento : Form
    {
        DataSet hoteles = new DataSet();

        public formAlojamiento()
        {
            InitializeComponent();
            pHabitaciones.Visible = false;
            btnBuscar.Enabled = false;
            dgvBusqueda.Visible = false;
        }

        public void autoComplete()
        {
            try
            {
                Conexion.Coneccion();
                Conexion.conexion.Open();
                Conexion.cmd = new NpgsqlCommand("SELECT nombre, pais, lugar FROM hoteles",Conexion.conexion);
                NpgsqlDataReader dr = Conexion.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtDestino.AutoCompleteCustomSource.Add(dr["nombre"].ToString());
                        txtDestino.AutoCompleteCustomSource.Add(dr["pais"].ToString());
                        txtDestino.AutoCompleteCustomSource.Add(dr["lugar"].ToString());
                    }
                }
                Conexion.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(553, this.Size.Height);
            pHabitaciones.Visible = true;
            lblCantidad.Text = Convert.ToString(spnHabitaciones.Value);
            spnAdultos.Maximum = spnHabitaciones.Value * 4;
            spnMenores.Maximum = spnHabitaciones.Value * 4;
            spnHabitaciones.Enabled = false;
            btnCheck.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(348, this.Size.Height);
            spnHabitaciones.Enabled = true;
            btnCheck.Enabled = true;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(348, this.Size.Height);
            spnHabitaciones.Enabled = true;
            btnCheck.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void dtpFecha2_ValueChanged(object sender, EventArgs e)
        {
            int fecha1 = dtpFecha1.Value.DayOfYear;
            int fecha2 = dtpFecha2.Value.DayOfYear;
            lblNoches.Text = fecha2 - fecha1 + " Noches";
        }

        private void dtpFecha1_ValueChanged(object sender, EventArgs e)
        {
            int fecha1 = dtpFecha1.Value.DayOfYear;
            int fecha2 = dtpFecha2.Value.DayOfYear;
            lblNoches.Text = fecha2 - fecha1 + " Noches";
        }

        private void formAlojamiento_Load(object sender, EventArgs e)
        {
            autoComplete();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Visible = true;
            dgvBusqueda.DataSource = null;
            this.Size = new Size(348, 355);
            try
            {
                if (txtDestino.Text.Equals(""))
                {
                    hoteles.Clear();
                    dgvBusqueda.Rows.Clear();
                    Conexion.Coneccion();
                    Conexion.conexion.Open();
                    NpgsqlDataAdapter read = new NpgsqlDataAdapter("SELECT nombre, pais, lugar FROM hoteles", Conexion.conexion);
                    read.Fill(hoteles);
                    Conexion.conexion.Close();
                    DataTable dtAll = hoteles.Tables[0].Copy();
                    for (var i= 1; i < hoteles.Tables.Count; i++)
                    {
                        dtAll.Merge(hoteles.Tables[i]);
                    }
                    dgvBusqueda.AutoGenerateColumns = true;
                    dgvBusqueda.DataSource = dtAll;

                }
                else
                {
                    hoteles.Clear();
                    dgvBusqueda.Rows.Clear();
                    Conexion.Coneccion();
                    Conexion.conexion.Open();
                    NpgsqlDataAdapter read = new NpgsqlDataAdapter("SELECT nombre, pais, lugar FROM hoteles WHERE nombre = '" + txtDestino.Text + "' OR pais = '" + txtDestino.Text + "' OR lugar = '" + txtDestino.Text + "'", Conexion.conexion);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
