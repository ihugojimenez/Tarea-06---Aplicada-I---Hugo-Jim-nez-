﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Ejercicio1 e1 = new Ejercicio1();
            e1.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            JustificarCadena jc = new JustificarCadena();
            jc.Show();


        }

        private void sumasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sumas s = new Sumas();
            s.Show();
        }

        private void ordenarCadenasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ordenar o = new Ordenar();
            o.Show();
        }
    }
}
