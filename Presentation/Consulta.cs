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
    public partial class Consulta : Form
    {
        Connection cn = new Connection();
        public Consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtconsulta.Text))
                {
                    MessageBox.Show("Ingrese Codigo");
                }
                else { 
                cn.Open();
                string query = "select precio_por_detalle, precio_por_mayor from producto Where id_producto =" + txtconsulta.Text;
                MySqlDataReader row;
                row = cn.ExecuteReader(query);

                listprecio.Items.Clear();

                while (row.Read())
                {
                    ListViewItem item = new ListViewItem(row["precio_por_detalle"].ToString());
                    item.SubItems.Add(row["precio_por_mayor"].ToString());
                    listprecio.Items.Add(item);

                }

                cn.Close();
                txtconsulta.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error desconocido");
            }
        }

        private void listprecio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtconsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
