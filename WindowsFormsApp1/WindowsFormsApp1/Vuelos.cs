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
        string escala = "No hay escala";
        string hotel;
        string hlugar;
        string hprecio;

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
            spnAdultos.Maximum = spnPasajeros.Value;
            if (btnPasajeros.Text.Equals("+"))
            {
                btnPasajeros.Text = "-";
                this.Size = new Size(555, this.Size.Height);
                pnlPasajeros.Visible = true;
            }
            else
            {
                btnPasajeros.Text = "+";
                this.Size = new Size(405, this.Size.Height);
                pnlPasajeros.Visible = false;
            }
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
                try
                {
                    Conexion.Coneccion();
                    Conexion.conexion.Open();
                    Conexion.cmd = new NpgsqlCommand("SELECT tipo FROM vehiculos", Conexion.conexion);
                    NpgsqlDataReader dr = Conexion.cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            if (boxTipo.Items.Contains(dr["tipo"].ToString()) == false)
                            {
                                boxTipo.Items.Add(dr["tipo"].ToString());
                            }
                        }
                    }
                    Conexion.conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            else if(boxHotel.Checked.Equals(false) && boxAuto.Checked.Equals(false))
            {
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

        private void spnMenores_Click(object sender, EventArgs e)
        {
            spnMenores.Maximum = spnPasajeros.Value - spnAdultos.Value;
            if (spnAdultos.Maximum.Equals(spnAdultos.Value + spnMenores.Value))
            {
                spnAdultos.Maximum = spnPasajeros.Value - spnMenores.Value;
            }
        }

        private void spnHabitaciones_Click(object sender, EventArgs e)
        {
            spnHabitaciones.Maximum = spnPasajeros.Value;
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            int fecha1 = dtpInicio.Value.DayOfYear;
            int fecha2 = dtpFin.Value.DayOfYear;
            lblDias.Text = fecha2 - fecha1 + " Dias";
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            int fecha1 = dtpInicio.Value.DayOfYear;
            int fecha2 = dtpFin.Value.DayOfYear;
            lblDias.Text = fecha2 - fecha1 + " Dias";
        }

        private void boxModelo_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Coneccion();
                Conexion.conexion.Open();
                Conexion.cmd = new NpgsqlCommand("SELECT modelo FROM vehiculos WHERE tipo = '"+boxTipo.SelectedItem+"'", Conexion.conexion);
                NpgsqlDataReader dr = Conexion.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (boxModelo.Items.Contains(dr["modelo"].ToString()) == false)
                        {
                            boxModelo.Items.Add(dr["modelo"].ToString());
                        }
                    }
                }
                Conexion.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void boxMarca_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Coneccion();
                Conexion.conexion.Open();
                Conexion.cmd = new NpgsqlCommand("SELECT marca FROM vehiculos WHERE modelo = '" + boxModelo.SelectedItem + "'", Conexion.conexion);
                NpgsqlDataReader dr = Conexion.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (boxMarca.Items.Contains(dr["marca"].ToString()) == false)
                        {
                            boxMarca.Items.Add(dr["marca"].ToString());
                        }
                    }
                }
                Conexion.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnPreliminar_Click(object sender, EventArgs e)
        {
            if (boxHotel.Checked == true && boxAuto.Checked == true)
            {
                Preliminar.Validar = "Ambos";
                Preliminar.fecha1 = dtpInicio.Value;
                Preliminar.fecha2 = dtpFin.Value;
                Preliminar.Origen = txtOrigen.Text;
                Preliminar.Destino = txtDestino.Text;
                Preliminar.Hotel = hotel;
                Preliminar.Habitaciones = spnHabitaciones.Value.ToString();
                Preliminar.Marca = boxMarca.SelectedItem.ToString();
                Preliminar.Modelo = boxModelo.SelectedItem.ToString();
                Preliminar.Tipo = boxTipo.SelectedItem.ToString();
                Preliminar.Cantidad = spnCantidadV.Value.ToString();
                Preliminar.Pvuelo = Convert.ToString(spnPasajeros.Value * Convert.ToInt32(preciovuelo()));
                Preliminar.Escala = escala;
                Preliminar.Photel = hprecio;
                Preliminar.Hlugar = hlugar;
                Preliminar.Pvehiculo = preciovehiculo();
                Preliminar ven = new Preliminar();
                ven.Show();
            }
            else if(boxHotel.Checked == true)
            {
                Preliminar.Validar = "Hotel";
                Preliminar.fecha1 = dtpInicio.Value;
                Preliminar.fecha2 = dtpFin.Value;
                Preliminar.Origen = txtOrigen.Text;
                Preliminar.Destino = txtDestino.Text;
                Preliminar.Hotel = hotel;
                Preliminar.Habitaciones = spnHabitaciones.Value.ToString();
                Preliminar.Pvuelo = Convert.ToString(spnPasajeros.Value * Convert.ToInt32(preciovuelo()));
                Preliminar.Escala = escala;
                Preliminar.Photel = hprecio;
                Preliminar.Hlugar = hlugar;
                Preliminar ven = new Preliminar();
                ven.Show();
            }
            else if(boxAuto.Checked == true)
            {
                Preliminar.Validar = "Auto";
                Preliminar.fecha1 = dtpInicio.Value;
                Preliminar.fecha2 = dtpFin.Value;
                Preliminar.Origen = txtOrigen.Text;
                Preliminar.Destino = txtDestino.Text;
                Preliminar.Marca = boxMarca.SelectedItem.ToString();
                Preliminar.Modelo = boxModelo.SelectedItem.ToString();
                Preliminar.Tipo = boxTipo.SelectedItem.ToString();
                Preliminar.Cantidad = spnCantidadV.Value.ToString();
                Preliminar.Pvuelo = Convert.ToString(spnPasajeros.Value * Convert.ToInt32(preciovuelo()));
                Preliminar.Escala = escala;
                Preliminar.Pvehiculo = preciovehiculo();
                Preliminar ven = new Preliminar();
                ven.Show();
            }
            else
            {
                Preliminar.Validar = "Vuelo";
                Preliminar.fecha1 = dtpInicio.Value;
                Preliminar.fecha2 = dtpFin.Value;
                Preliminar.Origen = txtOrigen.Text;
                Preliminar.Destino = txtDestino.Text;
                Preliminar.Pvuelo = Convert.ToString(spnPasajeros.Value * Convert.ToInt32(preciovuelo()));
                Preliminar.Escala = escala;
                Preliminar ven = new Preliminar();
                ven.Show();
            }
        }

        public string preciovehiculo()
        {
            try
            {
                Conexion.Coneccion();
                Conexion.conexion.Open();
                Conexion.cmd = new NpgsqlCommand("SELECT precio FROM vehiculos WHERE tipo = '" + boxTipo.Text + "' AND modelo = '" + boxModelo.Text + "' AND marca = '" + boxMarca.Text + "'", Conexion.conexion);
                NpgsqlDataReader dr = Conexion.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        return dr["precio"].ToString();
                    }
                }
                Conexion.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            return "Se callo xD";
        }

        public string preciovuelo()
        {
            int precio = 0;
            try
            {
                Conexion.Coneccion();
                Conexion.conexion.Open();
                Conexion.cmd = new NpgsqlCommand("SELECT id FROM rutas WHERE pais_origen = '" + txtOrigen.Text + "' AND pais_destino = '" + txtDestino.Text + "'", Conexion.conexion);
                NpgsqlDataReader dr = Conexion.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Conexion.Coneccion();
                        Conexion.conexion.Open();
                        Conexion.cmd = new NpgsqlCommand("SELECT precio FROM vuelos WHERE ruta = '" + dr["id"].ToString() + "'", Conexion.conexion);
                        NpgsqlDataReader dr1 = Conexion.cmd.ExecuteReader();
                        if (dr1.HasRows)
                        {
                            while (dr1.Read())
                            {
                                return dr1["precio"].ToString();
                            }
                        }
                    }
                }
                Conexion.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            try
            {
                Conexion.Coneccion();
                Conexion.conexion.Open();
                Conexion.cmd = new NpgsqlCommand("SELECT id, pais_destino FROM rutas WHERE pais_origen = '" + txtOrigen.Text + "'", Conexion.conexion);
                NpgsqlDataReader dr = Conexion.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Conexion.Coneccion();
                        Conexion.conexion.Open();
                        Conexion.cmd = new NpgsqlCommand("SELECT id FROM rutas WHERE pais_origen = '" + dr["pais_destino"].ToString() + "' AND pais_destino = '"+ txtDestino.Text +"'", Conexion.conexion);
                        NpgsqlDataReader dr1 = Conexion.cmd.ExecuteReader();
                        if (dr1.HasRows)
                        {
                            while (dr1.Read())
                            {
                                Conexion.Coneccion();
                                Conexion.conexion.Open();
                                Conexion.cmd = new NpgsqlCommand("SELECT precio FROM vuelos WHERE ruta = '" + dr["id"].ToString() + "' OR ruta = '" + dr1["id"].ToString() + "'", Conexion.conexion);
                                NpgsqlDataReader dr2 = Conexion.cmd.ExecuteReader();
                                if (dr2.HasRows)
                                {
                                    while (dr2.Read())
                                    {
                                        precio = precio + Convert.ToInt32(dr2["precio"].ToString());
                                    }
                                    escala = dr["pais_destino"].ToString();
                                    return Convert.ToString(precio);
                                }
                            }
                        }
                    }
                }
                Conexion.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            return "Se callo xD";
        }

        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila =dgvBusqueda.CurrentRow;
            hotel= Convert.ToString(fila.Cells[0].Value);
            hlugar = Convert.ToString(fila.Cells[1].Value);
            hprecio = Convert.ToString(fila.Cells[2].Value);           
        }
    }
}
