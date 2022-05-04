using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Connection_DB;

namespace Presentation
{
    public partial class Login : Form
    {
        Connection cn = new Connection();
        string nombre, apellido;
        string id;
        string rut;

        private void accBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (usrTextBox.Text != "" && passTextBox.Text != "")
                {
                    cn.Open();
                    string query = "select rut_usuario, id_tipo_usuario,nombre_usuario,apellido_usuario from usuario where rut_usuario = '" + usrTextBox.Text + "' AND contrasena = '" + passTextBox.Text + "'";
                    MySqlDataReader row;
                    row = cn.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            rut = row["rut_usuario"].ToString();
                            id = row["id_tipo_usuario"].ToString();
                            nombre = row["nombre_usuario"].ToString();
                            apellido = row["apellido_usuario"].ToString();
                        }
                        MessageBox.Show("Bienvenido " + nombre + " " + apellido);
                        if (id == "1")
                        {
                            cn.Close();

                            this.Hide();
                            foreach (Form frm in Application.OpenForms)
                            {
                                if (frm is AdminView)
                                {
                                    frm.Show();
                                    return;
                                }
                            }

                            AdminView adminView = new AdminView();
                            adminView.titleAdminView = nombre + " " + apellido;
                            adminView.id = rut;
                            adminView.Show();
                        }
                        else
                        {
                            cn.Close();

                            this.Hide();
                            foreach (Form frm in Application.OpenForms)
                            {
                                if (frm is UserView)
                                {
                                    frm.Show();
                                    return;
                                }
                            }

                            UserView userView = new UserView();
                            userView.load(usrTextBox.Text);
                            userView.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrectos");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Usuario o Contraseña vacios", "Information");
            }
            
        }

        private void validation()
        {
            if (usrTextBox.Text != "" && passTextBox.Text != "")
            {
                accBtn.Enabled = true;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usrTextBox_TextChanged(object sender, EventArgs e)
        {
            validation();
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            validation();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            usrTextBox.Text = "";
            passTextBox.Text = "";
            accBtn.Enabled = false;
        }

        internal void vaciar()
        {
            usrTextBox.Text = "";
            passTextBox.Text = "";
            accBtn.Enabled = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        public Login()
        {
            InitializeComponent();
            passTextBox.UseSystemPasswordChar = true;
            accBtn.Enabled = false;
        }

    }
}
