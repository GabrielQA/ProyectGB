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
        public formAlojamiento()
        {
            InitializeComponent();
            pHabitaciones.Visible = false;
        }

        public void autoComplete()
        {
            try
            {
                Conexion.Coneccion();
                Conexion.conexion.Open();
                Conexion.cmd = new NpgsqlCommand("Select nombre, pais, lugar from hoteles",Conexion.conexion);
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
            catch (Exception e)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(553,313);
            pHabitaciones.Visible = true;
            lblCantidad.Text = Convert.ToString(spnHabitaciones.Value);
            spnAdultos.Maximum = spnHabitaciones.Value * 4;
            spnMenores.Maximum = spnHabitaciones.Value * 4;
            spnHabitaciones.Enabled = false;
            btnCheck.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(348, 313);
            spnHabitaciones.Enabled = true;
            btnCheck.Enabled = true;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(348, 313);
            spnHabitaciones.Enabled = true;
            btnCheck.Enabled = true;
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
    }
}
