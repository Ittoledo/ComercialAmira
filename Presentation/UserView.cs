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
    public partial class UserView : Form
    {
        Connection cn = new Connection();
        public string id;
        public UserView()
        {
            InitializeComponent();
            lblFecha.Text= DateTime.Now.ToString("f");
            listUser.View = View.Details;
            listUser.GridLines = true;
            listUser.FullRowSelect = true;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Consultar_CheckedChanged(object sender, EventArgs e)
        {
            Consulta consult = new Consulta();
            consult.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Salir_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Login)
                {
                    frm.Show();
                    return;
                }
            }


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtDatos.Text)|| (String.IsNullOrEmpty(txtCantidad.Text)))
                {
                    MessageBox.Show("Ingrese Codigo y Cantidad");
                }
                else
                {
                    cn.Open();
                    string query = "select * from producto Where id_producto =" + txtDatos.Text + " and ISNULL(deleted_at)";
                    int cantidad = Int32.Parse(txtCantidad.Text);
                    MySqlDataReader row;
                    row = cn.ExecuteReader(query);
                    listUser.Columns.Add("id_producto", "Id", 50);
                    listUser.Columns.Add("nombre", "Nombre", 100);
                    listUser.Columns.Add("descripcion", "Descripcion", 200);
                    listUser.Columns.Add("cantidad", "Cantidad", 100);

                    listUser.Columns.Add("precio_por_detalle", "subtotal", 200);

                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            if (cantidad <= Int32.Parse(row["stock"].ToString())){
                                if (cantidad >= 50)
                                {
                                    int precio = Int32.Parse(row["precio_por_mayor"].ToString());
                                    int subtotal = precio * cantidad;
                                    listUser.Items.Add(new ListViewItem(new[] { row["id_producto"].ToString(), row["nombre"].ToString(), row["descripcion"].ToString(), cantidad.ToString(), subtotal.ToString() }));
                                }
                                else
                                {
                                    int precio = Int32.Parse(row["precio_por_detalle"].ToString());
                                    int subtotal = precio * cantidad;
                                    listUser.Items.Add(new ListViewItem(new[] { row["id_producto"].ToString(), row["nombre"].ToString(), row["descripcion"].ToString(), cantidad.ToString(), subtotal.ToString() }));

                                }
                            } else MessageBox.Show("No hay suficiente Stock");
                        }
                    } else
                    {
                        MessageBox.Show("Producto no existe");
                    }
                    cn.Close();
                    txtCantidad.Clear();
                    txtDatos.Clear();
                   
                }

            }
            catch
            {
                MessageBox.Show("Error al añadir producto");
            }
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            
        }
        
        private void delartBtn_Click(object sender, EventArgs e)
        {
            if (listUser.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un artículo a eliminar");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Esta seguro de querer eliminar este artículo?", "Important Question", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        for (int i = 0; i < listUser.Items.Count; i++)
                        {
                            if (listUser.Items[i].Selected)
                            {
                                listUser.Items[i].Remove();
                                i--;
                            }
                        }
                        MessageBox.Show("Artículo Eliminado");
                        
                    }
                    catch
                    {
                        MessageBox.Show("Error desconocido");
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            listUser.Clear();
        }

        private void txtDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar)&&(e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void finalizarBtn_Click(object sender, EventArgs e)
        {
            if (listUser.Items.Count == 0)
            {
                MessageBox.Show("Debe añadir productos");
            }
            else 
            {
                String idVenta = GetIdVenta();
                foreach (ListViewItem item in listUser.Items) {
                    cn.Open();
                    int precio = Convert.ToInt32(item.SubItems[4].Text)/Convert.ToInt32(item.SubItems[3].Text);

                    string query = "Insert into venta_producto(id_venta, codigo_producto,fecha, rut_usuario,cantidad,precio_venta)" +
                    " VALUES ('" + idVenta + "','" + item.SubItems[0].Text + "',NOW(),'" + id + "','" + item.SubItems[3].Text + "','"+precio.ToString() +"')";
                    MessageBox.Show(query);
                    cn.ExecuteReader(query);
                    cn.Close();
                    cn.Open();
                    query = "Update producto set stock=(select stock from producto where id_producto=" + item.SubItems[0].Text + ") - " + item.SubItems[3].Text + " where id_producto = " + item.SubItems[0].Text;
                    cn.ExecuteReader(query);
                    cn.Close();
                    MessageBox.Show("Venta Registrada exitosamente");
                    listUser.Clear();
                }
            }
        }
        private string GetIdVenta()
        {
            int retorno = 0;
            cn.Open();
            string query = "Select count(id_venta) from venta_producto";
            MySqlDataReader row = cn.ExecuteReader(query);
            while (row.Read()) retorno = 1 + Convert.ToInt32(row[0].ToString());
            cn.Close();
            return retorno.ToString();
        }
    }
}
