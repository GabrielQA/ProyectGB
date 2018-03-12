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
    public partial class Preliminar : Form
    {
        public Preliminar()
        {
            InitializeComponent();
            pnlHotel.Visible = false;
            pnlTotal.Visible = false;
            pnlVehiculo.Visible = false;
        }

        private void Preliminar_Load(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (btnTotal.Text.Equals("+"))
            {
                btnTotal.Text = "-";
                this.Size = new Size(this.Size.Width, 374);
                pnlTotal.Visible = true;
            }
            else if (btnHotel.Text.Equals("-") || btnVehiculo.Text.Equals("-"))
            {
                btnTotal.Text = "+";
                pnlTotal.Visible = false;
            }
            else
            {
                btnTotal.Text = "+";
                this.Size = new Size(this.Size.Width, 238);
                pnlTotal.Visible = false;
            }  
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            if (btnHotel.Text.Equals("+"))
            {
                btnHotel.Text = "-";
                this.Size = new Size(this.Size.Width, 374);
                pnlHotel.Visible = true;
            }
            else if (btnVehiculo.Text.Equals("-") || btnTotal.Text.Equals("-"))
            {
                btnHotel.Text = "+";
                pnlHotel.Visible = false;
            }
            else
            {
                btnHotel.Text = "+";
                this.Size = new Size(this.Size.Width, 238);
                pnlHotel.Visible = false;
            }
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            if (btnVehiculo.Text.Equals("+"))
            {
                btnVehiculo.Text = "-";
                this.Size = new Size(this.Size.Width, 374);
                pnlVehiculo.Visible = true;
            }
            else if(btnHotel.Text.Equals("-") || btnTotal.Text.Equals("-"))
            {
                btnVehiculo.Text = "+";
                pnlVehiculo.Visible = false;
            }
            else
            {
                btnVehiculo.Text = "+";
                this.Size = new Size(this.Size.Width, 238);
                pnlVehiculo.Visible = false;
            }
        }
    }
}
