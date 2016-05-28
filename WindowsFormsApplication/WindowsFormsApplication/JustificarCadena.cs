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
    public partial class JustificarCadena : Form
    {
        public JustificarCadena()
        {
            InitializeComponent();
        }

        private void RightradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Justificarbutton_Click(object sender, EventArgs e)
        {
            int cont = Convert.ToInt32(EspaciosTextBox.Text); ;
            String resultado;
            String Temp = CadenatextBox.Text;
            for (int ae = 0; ae <= Temp.Length; ae++)
                cont += 1;

            if (RightradioButton.Checked)
            {
                resultado = CadenatextBox.Text.PadLeft(cont);
                SalidatextBox.Text = resultado;
            }
                
            if (LeftradioButton2.Checked)
            {
                resultado = CadenatextBox.Text.PadRight(cont);
                SalidatextBox.Text = resultado;
            }
                

            

        }
    }
}
