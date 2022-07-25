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

namespace Presentation
{
    public partial class NewProveedor : Form
    {
        public NewProveedor()
        {
            InitializeComponent();
        }
        public AdminView f1ref;
        public string rutUser;
        Connection cn = new Connection();
        List<ComboBoxPairs> comboSource = new List<ComboBoxPairs>();
 
        private bool validacionIngreso()
        {
            bool validar = false;
            if (rutProv.Text == "")
            {
                MessageBox.Show("Ingrese rut");
            }
            else if (nombre.Text == "")
            {
                MessageBox.Show("Ingrese nombre");
            }
            else if (direccion.Text == "")
            {
                MessageBox.Show("Ingrese apellido");
            }
            else if (celular.Text == "")
            {
                MessageBox.Show("Ingrese una contrasena");
            }
            else
            {
                validar = true;
            }
            return validar;
        }

        private void aceptNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (validacionIngreso())
                    {
                        if (Metodos.ValidaRut(rutProv.Text))
                        {
                            bool validacion = true;
                            string query = "SELECT * from proveedor where rut_proveedor='" + rutProv.Text + "'";
                            cn.Open();
                            MySqlDataReader row = cn.ExecuteReader(query);
                            if (row.HasRows)
                            {
                                while (row.Read())
                                {
                                    query = "UPDATE `proveedor` SET " +
                                        "`nombre`='" + nombre.Text + "'," +
                                        "`direccion`='" + direccion.Text + "'," +
                                        "`celular`='" + celular.Text + "'," +
                                        "deleted_at=NULL" + " WHERE rut_proveedor='" + rutProv.Text + "'";
                                }
                                validacion = false;
                            }
                            cn.Close();
                            cn.Open();
                            if (validacion)
                            {
                                query = "INSERT INTO `proveedor`(`rut_proveedor`, `nombre`, `direccion`, `celular`) " +
                                "VALUES('" + rutProv.Text + "', '" + nombre.Text + "', '" + direccion.Text + "', '" + celular.Text + "')";
                            }
                            cn.ExecuteReader(query);
                            cn.Close();
                            f1ref.actualizaLista();
                            this.Close();
                        }
                        else MessageBox.Show("Ingrese un rut valido");
                    }
            }
            catch
            {
                MessageBox.Show("Error al ingresar proveedor");
            }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
