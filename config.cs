﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class config : Form
    {
        private string estado;
        public string returnEstado()
        {
            return estado;
        }
        public void setEstado(string actual)
        {
            estado = actual;
        }
        public config()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void config_Load(object sender, EventArgs e)
        {

        }
    }
}
