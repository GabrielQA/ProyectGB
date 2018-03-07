using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace WindowsFormsApp1
{
    public partial class Reporte : Form
    {

        int A;
        int B; 
        public Reporte()
        {
            InitializeComponent();
        }
       
       
        private void Reporte_Load(object sender, EventArgs e)
        {
           

         
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrador v = new Administrador();
            v.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A = Convert.ToInt32(QQQ.Text);
            B = Convert.ToInt32(QQ.Text);
            string[] series = { "Guacamaya", "VolcanLook" };
        int[] puntos = { A,B};

        chart1.Palette = ChartColorPalette.Pastel;
        chart1.Titles.Add("Hoteles");

            for (int i = 0; i < series.Length; i++)
            {

                Series serie = chart1.Series.Add(series[i]);
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }
    }
}
