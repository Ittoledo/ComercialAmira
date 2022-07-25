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
    public partial class NewCompra : Form
    {
        public NewCompra()
        {
            InitializeComponent();
        }
        public AdminView f1ref;
        public string rutUser;
        Connection cn = new Connection();
        public ListView listaProductos;
        
        List<ComboBoxPairs> comboSource = new List<ComboBoxPairs>();

        private bool validacionIngreso()
        {
            bool validar = false;
            if (rutUsr.Text == "")
            {
                MessageBox.Show("Ingrese rut");
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
                        if (Metodos.ValidaRut(rutUsr.Text))
                        {
                            string query = "SELECT * from proveedor where rut_proveedor='" + rutUsr.Text + "'";
                            cn.Open();
                            MySqlDataReader row = cn.ExecuteReader(query);
                            if (row.HasRows)
                            {
                                while (row.Read())
                                {
                                    agregarDatos();
                                }
                            }
                            cn.Close();
                            f1ref.actualizaLista();
                            this.Close();
                        }
                        else MessageBox.Show("Ingrese un rut valido");
                    }
            }
            catch
            {
                MessageBox.Show("Error al ingresar compra");
            }

        }

        private void agregarDatos()
        {
            string idCompra = getIdCompra();
            foreach (ListViewItem item in listaProductos.Items)
            {
                cn.Open();
                string query = "INSERT INTO `compra_producto`(`id_compra`, `codigo_producto`, `rut_proveedor`, `fecha`, `precio_compra`, `cantidad`)" +
                    " VALUES ('" + idCompra + "','" + item.SubItems[0].Text + "','" + rutUsr.Text + "',NOW(),'" + item.SubItems[2].Text + "','" + item.SubItems[3].Text + "')";
                cn.ExecuteReader(query);
                cn.Close();
                cn.Open();
                query = "Update producto set stock=(select stock from producto where id_producto=" + item.SubItems[0].Text +") + " +item.SubItems[3].Text + " where id_producto = " + item.SubItems[0].Text;
                cn.ExecuteReader(query);
                cn.Close();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string getIdCompra()
        {
            int retorno = 0;
            cn.Open();
            string query = "Select count(id_compra) from compra_producto";
            MySqlDataReader row = cn.ExecuteReader(query);
            while (row.Read()) retorno = 1 + Convert.ToInt32(row[0].ToString());
            cn.Close();
            return retorno.ToString();
        }

        
        
    }
}

