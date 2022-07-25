using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection_DB;
using MySql.Data.MySqlClient;
using Presentation;

namespace Presentation
{
    public partial class CambiarPass : Form
    {
        public CambiarPass()
        {
            InitializeComponent();
            pass1.UseSystemPasswordChar = true;
            pass2.UseSystemPasswordChar = true;
        }
        public string user;
        Connection cn = new Connection();

        private bool validacionUpdate()
        {
            bool validar = false;
            if (pass1.Text == "")
            {
                MessageBox.Show("Contrasena Vacia");
            }
            else if (pass2.Text == "")
            {
                MessageBox.Show("Debe confirmar su contrasena");
            }
            else
            {
                validar = true;
            }
            return validar;
        }

        private void aceptEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacionUpdate())
                {
                    if (pass1.Text == pass2.Text)
                    {
                        cn.Open();
                        string query = "UPDATE `usuario` SET " +
                            "`contrasena`='" + Metodos.EncryptPlainTextToCipherText(pass1.Text) +
                            "' WHERE rut_usuario='" + user + "'";
                        MessageBox.Show("Contrasena Cambiada");
                        cn.ExecuteReader(query);
                        cn.Close();
                        this.Close();
                    }
                    else MessageBox.Show("Contrasenas no coinciden");
                }
            }
            catch
            {
                MessageBox.Show("Error al actualizar");
            }
        }


        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
