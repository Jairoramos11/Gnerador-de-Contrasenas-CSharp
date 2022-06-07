using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_de_Contraseñas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#$%^^&*()_+";
            var Charsarr = new char[16];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }

            var resultString = new String(Charsarr);
            texbox1.Text = resultString.ToString();
        }

        private void btncopiar_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(texbox1.Text, true);
                MessageBox.Show("Texto copiado al portapapeles de Windows.",
                    "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al copiar texto al portapapeles: " +
                    Environment.NewLine + err.Message, "Error al copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
