﻿using System;
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
    public partial class Cliente : Form
    {
        

        public Cliente()
        {
            InitializeComponent();
            comboBox1.Items.Add("Vuelos");
            comboBox1.Items.Add("Alojamientos");

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.Text == "Vuelos")
            {
                this.Hide();
                Vuelos V = new Vuelos();
                V.Show();

            }
            else if (comboBox1.Text == "Alojamiento")
            {
                this.Hide();
                formAlojamiento v = new formAlojamiento();
                v.Show();
            }
        }
    }
}
