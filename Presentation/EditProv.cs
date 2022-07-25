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
    public partial class EditProv : Form
    {
        public EditProv()
        {
            InitializeComponent();
        }
        public string proveedor;
        public string rutUser;
        public AdminView f1ref;
        Connection cn = new Connection();
        List<ComboBoxPairs> comboSource = new List<ComboBoxPairs>();

        private void EditProv_Shown(object sender, EventArgs e) //When the edit product card is shown is filled with the selected one from the list
        {
            try
            {
                cn.Open();
                rutUsr.Enabled = false;
                string query = "select * from proveedor where rut_proveedor='" + proveedor + "'";
                MySqlDataReader row;
                row = cn.ExecuteReader(query);
                while (row.Read())
                {
                    rutUsr.Text = row["rut_proveedor"].ToString();
                    nombre.Text = row["nombre"].ToString();
                    direccion.Text = row["direccion"].ToString();
                    celular.Text = row["celular"].ToString();
                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar datos de proveedor");
            }
        }

        private bool validacionUpdate()
        {
            bool validar = false;
            if (rutUsr.Text == "")
            {
                MessageBox.Show("Rut vacio");
            }
            else if (nombre.Text == "")
            {
                MessageBox.Show("Ingrese nombre");
            }
            else if (direccion.Text == "")
            {
                MessageBox.Show("Ingrese direccion");
            }
            else if (celular.Text == "")
            {
                MessageBox.Show("Ingrese celular");
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
                    if (Metodos.ValidaRut(rutUsr.Text))
                    {
                        cn.Open();
                        string query = "UPDATE proveedor SET " +
                            "nombre='" + nombre.Text + "', " +
                            "direccion='" + direccion.Text + "', " +
                            "celular=" + celular.Text +
                            " WHERE rut_proveedor='" + rutUsr.Text + "'";
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
                MessageBox.Show("Error al actualizar");
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

