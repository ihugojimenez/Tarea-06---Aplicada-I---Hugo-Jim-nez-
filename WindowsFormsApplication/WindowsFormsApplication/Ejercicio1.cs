using System;
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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Separarbutton_Click(object sender, EventArgs e)
        {
            String Oracion = CadenatextBox.Text;
            char[] Delimitador = {' '};
            String[] Resultado= Oracion.Split(Delimitador);

            for(int ae=0; ae<Resultado.Length; ae++)
            {
                SalidarichTextBox.Text += String.Join("\n", Resultado[ae]) + "\n";
            }


        }
    }
}
