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
    public partial class EditUsr : Form
    {
        public string user;
        public string rutUser;
        public AdminView f1ref;
        Connection cn = new Connection();
        List<ComboBoxPairs> comboSource = new List<ComboBoxPairs>();

        public EditUsr()
        {
            InitializeComponent();
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
                MessageBox.Show("Error al llenar tipos de Usuario");
            }
            return comboSourceFinal;
        }

        private void selectCombo(string cod_categoria)
        {
            comboSource = fillList();
            tipoUsr.DisplayMember = "nameCat";
            tipoUsr.ValueMember = "idCat";
            tipoUsr.DataSource = comboSource;
            tipoUsr.SelectedValue = cod_categoria;
        }

        private void EditUsr_Shown(object sender, EventArgs e) //When the edit product card is shown is filled with the selected one from the list
        {
            try
            {
                cn.Open();
                string query = "select * from usuario where rut_usuario='" + user + "'";
                MySqlDataReader row;
                row = cn.ExecuteReader(query);
                while (row.Read())
                {
                    rutUsr.Text = row["rut_usuario"].ToString();
                    selectCombo(row["id_tipo_usuario"].ToString());
                    nombre.Text = row["nombre_usuario"].ToString();
                    apellido.Text = row["apellido_usuario"].ToString();
                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar datos de usuario");
            }
        }

        private bool validacionUpdate()
        {
            bool validar = false;
            if (rutUsr.Text == "")
            {
                MessageBox.Show("Rut vacio");
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
                        string query = "UPDATE `usuario` SET " +
                            "`rut_usuario`='" + rutUsr.Text + "'," +
                            "`id_tipo_usuario`='" + tipoUsr.SelectedValue + "'," +
                            "`nombre_usuario`='" + nombre.Text + "'," +
                            "`apellido_usuario`='" + apellido.Text +
                            "' WHERE rut_usuario='" + rutUsr.Text + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            CambiarPass cambiarPass = new CambiarPass();
            cambiarPass.Show();
            cambiarPass.user = rutUsr.Text;
        }

        private void EditUsr_Load(object sender, EventArgs e)
        {

        }

        private void EditUsr_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
