using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expresiones_Regulares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextSS_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            string input = TextContraseña.Text;
            string patron = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";

            if (Regex.IsMatch(input, patron))
            {
                MessageBox.Show("Cadena SI aceptada");
            }
            else
            {
                MessageBox.Show("Cadena NO aceptada");
            }
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            string input = TextTelefono.Text;
            string patron = @"^\+?\d{1,3}[-.\s]?\(?\d{1,4}\)?[-.\s]?\d{1,10}$";

            if (Regex.IsMatch(input, patron))
            {
                MessageBox.Show("Cadena SI aceptada");
            }
            else
            {
                MessageBox.Show("Cadena NO aceptada");
            }
        }

        private void btnSS_Click(object sender, EventArgs e)
        {
            string input = TextSS.Text;
            string patron = @"^\d{3}-\d{2}-\d{4}$";

            if (Regex.IsMatch(input, patron))
            {
                MessageBox.Show("Cadena SI aceptada");
            }
            else
            {
                MessageBox.Show("Cadena NO aceptada");
            }
        }

        private void btnDireccion_Click(object sender, EventArgs e)
        {
            string input = TextDireccion.Text;
            string patron = @"^\d+\s[A-Za-z]+\s(St|Rd|Ave|Blvd)\,\s(Ste|Apt)\s\d+[A-Za-z]*$";

            if (Regex.IsMatch(input, patron))
            {
                MessageBox.Show("Cadena SI aceptada");
            }
            else
            {
                MessageBox.Show("Cadena NO aceptada");
            }
        }
    }
}
