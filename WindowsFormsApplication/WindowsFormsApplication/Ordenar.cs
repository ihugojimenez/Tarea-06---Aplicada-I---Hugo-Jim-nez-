using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Ordenar : Form
    {
        public Ordenar()
        {
            InitializeComponent();
        }

        private void Ordenarbutton_Click(object sender, EventArgs e)
        {

            String Palabras = CadenastextBox.Text;
            
            SalidarichTextBox.Text = Palabras.ToUpper();
        }
    }
}
