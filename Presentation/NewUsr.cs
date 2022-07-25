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
using Microsoft.VisualBasic;

namespace Presentation
{
    public partial class NewUsr : Form
    {
        public AdminView f1ref;
        public string rutUser;
        Connection cn = new Connection();
        List<ComboBoxPairs> comboSource = new List<ComboBoxPairs>();
        public NewUsr()
        {
            InitializeComponent();
        }

        private bool validacionIngreso()
        {
            bool validar = false;
            if (rutUsr.Text == "")
            {
                MessageBox.Show("Ingrese rut");
            }
            else if (tipoUsr.Text == "")
            {
                MessageBox.Show("Seleccione un tipo de usuario");
            }
            else if (nombre.Text == "")
            {
                MessageBox.Show("Ingrese nombre");
            }
            else if (apellido.Text == "")
            {
                MessageBox.Show("Ingrese apellido");
            }
            else if (pass.Text == "")
            {
                MessageBox.Show("Ingrese una contrasena");
            }
            else if (pass2.Text == "")
            {
                MessageBox.Show("Confirme su contrasena");
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
                if (pass.Text == pass2.Text)
                {
                    if (validacionIngreso())
                    {
                        if (Metodos.ValidaRut(rutUsr.Text))
                        {
                            ComboBoxPairs cbp = (ComboBoxPairs)tipoUsr.SelectedItem;
                            bool validacion = true;
                            string idTipo = cbp.idCat;
                            string query = "SELECT * from usuario where rut_usuario='" + rutUsr.Text + "'";
                            cn.Open();
                            MySqlDataReader row = cn.ExecuteReader(query);
                            if (row.HasRows)
                            {
                                while (row.Read())
                                {
                                    query = "UPDATE `usuario` SET " +
                                        "`id_tipo_usuario`='" + idTipo + "'," +
                                        "`nombre_usuario`='" + nombre.Text + "'," +
                                        "`apellido_usuario`='" + apellido.Text + "'," +
                                        "`contrasena`='" + Metodos.EncryptPlainTextToCipherText(pass.Text) + "'," +
                                        "deleted_at=NULL" + " WHERE rut_usuario='" + rutUsr.Text + "'";
                                }
                                validacion = false;
                            }
                            cn.Close();
                            cn.Open();
                            if (validacion)
                            {
                                query = "INSERT INTO `usuario`(`rut_usuario`, `id_tipo_usuario`, `nombre_usuario`, `apellido_usuario`, `contrasena`) " +
                                "VALUES('" + rutUsr.Text + "', '" + idTipo + "', '" + nombre.Text + "', '" + apellido.Text + "', '" + Metodos.EncryptPlainTextToCipherText(pass.Text) + "')";
                            }
                            cn.ExecuteReader(query);
                            cn.Close();
                            f1ref.actualizaLista();
                            this.Close();
                        }
                        else MessageBox.Show("Ingrese un rut valido");
                    }
                }
                else MessageBox.Show("Las contrasenas no coinciden");
            }
            catch
            {
                MessageBox.Show("Error al ingresar producto");
            }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<ComboBoxPairs> fillList()
        {
            List<ComboBoxPairs> comboSourceFinal = new List<ComboBoxPairs>();
            try
            {
                cn.Open();
                string query = "SELECT * FROM tipo_usuario";
                MySqlDataReader row = cn.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        comboSourceFinal.Add(new ComboBoxPairs(row["nombre_tipo_usuario"].ToString(), row["id_tipo_usuario"].ToString()));
                    }

                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Error al llenar categorias de usuarios");
            }
            return comboSourceFinal;
        }

        private void NewUsr_Load(object sender, EventArgs e)
        {
            comboSource = fillList();
            tipoUsr.DisplayMember = "nameCat";
            tipoUsr.ValueMember = "idCat";
            tipoUsr.DataSource = comboSource;
            pass.UseSystemPasswordChar = true;
            pass2.UseSystemPasswordChar = true;
        }
    }
}

