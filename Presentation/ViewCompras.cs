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
    public partial class ViewCompras : Form
    {
        public AdminView f1ref;
        Connection cn = new Connection();
        public ViewCompras()
        {
            InitializeComponent();
        }
        private void loadCompras()
        {
            try
            {
                cn.Open();
                string query = "select * from compra_producto";
                MySqlDataReader row;
                row = cn.ExecuteReader(query);
                listCompras.Columns.Add("id_compra", "N Compra", 50);
                listCompras.Columns.Add("codigo_producto", "Codigo Producto", 100);
                listCompras.Columns.Add("nombre_producto", "Nombre Producto", 100);
                listCompras.Columns.Add("rut_proveedor", "Proveedor", 100);
                listCompras.Columns.Add("nombre_proveedor", "Nombre Proveedor", 100);
                listCompras.Columns.Add("precio", "Precio Unitario", 50);
                listCompras.Columns.Add("cantidad", "Cantidad", 50);
                listCompras.Columns.Add("fecha", "Fecha Compra", 100);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        if(row["deleted_at"].ToString() == "")
                        listCompras.Items.Add(new ListViewItem(new[] { row["id_compra"].ToString(), row["codigo_producto"].ToString(), GetProdName(row["codigo_producto"].ToString()), row["rut_proveedor"].ToString(), GetProvName(row["rut_proveedor"].ToString()), row["precio_compra"].ToString(), row["cantidad"].ToString(), row["fecha"].ToString() }));
                    }
                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar compras");
            }
        }
        private void ViewCompras_Load(object sender, EventArgs e)
        {
            
            listCompras.View = View.Details;
            listCompras.GridLines = true;
            listCompras.FullRowSelect = true;
            loadCompras();
        }
        private string GetProdName(string codigo)
        {
            string retorno = "";
            cn.Open();
            MySqlDataReader row = cn.ExecuteReader("select nombre from producto where id_producto=" + codigo);
            while (row.Read()) retorno = row["nombre"].ToString();
            cn.Close();
            return retorno;
        }
        private string GetProvName(string rut)
        {
            string retorno = "";
            cn.Open();
            MySqlDataReader row = cn.ExecuteReader("select nombre from proveedor where rut_proveedor='" + rut + "'");
            while (row.Read()) retorno = row["nombre"].ToString();
            cn.Close();
            return retorno;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listCompras.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una compra a eliminar");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Esta seguro de querer eliminar dicha compra?", "Important Question", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        cn.Open();
                        string query = "update compra_producto set deleted_at=NOW() where id_compra =" + listCompras.SelectedItems[0].Text + " and rut_proveedor='" + listCompras.SelectedItems[0].SubItems[3].Text + "' and codigo_producto= " + listCompras.SelectedItems[0].SubItems[1].Text;
                        cn.ExecuteReader(query);
                        cn.Close();
                        MessageBox.Show("Artículo Eliminado");
                        listCompras.Clear();
                        loadCompras();
                    }
                    catch
                    {
                        MessageBox.Show("Error desconocido");
                    }
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if(listCompras.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una compra para editar");
            }
            else
            {
                EditCompra editCompra = new EditCompra();
                editCompra.Show();
                editCompra.compra = listCompras;
                editCompra.f1ref = this;
            }
        }

        public void actualizar()
        {
            listCompras.Clear();
            loadCompras();
        }
    }
}
