﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVAPV07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLlamarFormaDos_Click(object sender, EventArgs e)
        {
            FrmDos frmDos = new FrmDos();
            frmDos.Show();
            

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmLlamarFormaTres_Click(object sender, EventArgs e)
        {
            FrmTres frmtres = new FrmTres ();
            frmtres.Show();
        }
    }
}
