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
    public partial class VentasView : Form
    {
        public VentasView()
        {
            InitializeComponent();
        }
        public AdminView f1ref;
        Connection cn = new Connection();

        private void loadVentas()
        {
            try
            {
                cn.Open();
                string query = "select * from venta_producto";
                MySqlDataReader row;
                row = cn.ExecuteReader(query);
                listCompras.Columns.Add("id_compra", "N Compra", 50);
                listCompras.Columns.Add("codigo_producto", "Codigo Producto", 100);
                listCompras.Columns.Add("nombre_producto", "Nombre Producto", 100);
                listCompras.Columns.Add("rut_usuario", "Usuario", 100);
                listCompras.Columns.Add("nombre_usuario", "Nombre Usuario", 100);
                listCompras.Columns.Add("precio", "Precio Unitario", 50);
                listCompras.Columns.Add("cantidad", "Cantidad", 50);
                listCompras.Columns.Add("fecha", "Fecha Compra", 100);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        if (row["deleted_at"].ToString() == "")
                            listCompras.Items.Add(new ListViewItem(new[] { row["id_venta"].ToString(), row["codigo_producto"].ToString(), GetProdName(row["codigo_producto"].ToString()), row["rut_usuario"].ToString(), GetProvName(row["rut_usuario"].ToString()), row["precio_venta"].ToString(), row["cantidad"].ToString(), row["fecha"].ToString() }));
                    }
                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar ventas");
            }
        }
        private void ViewCompras_Load(object sender, EventArgs e)
        {

            listCompras.View = View.Details;
            listCompras.GridLines = true;
            listCompras.FullRowSelect = true;
            loadVentas();
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
            MySqlDataReader row = cn.ExecuteReader("select nombre_usuario from usuario where rut_usuario='" + rut + "'");
            while (row.Read()) retorno = row["nombre_usuario"].ToString();
            cn.Close();
            return retorno;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listCompras.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una venta a eliminar");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Esta seguro de querer eliminar dicha venta?", "Important Question", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        cn.Open();
                        string query = "update venta_producto set deleted_at=NOW() where id_venta =" + listCompras.SelectedItems[0].Text + " and rut_usuario='" + listCompras.SelectedItems[0].SubItems[3].Text + "' and codigo_producto= " + listCompras.SelectedItems[0].SubItems[1].Text;
                        cn.ExecuteReader(query);
                        cn.Close();
                        MessageBox.Show("Artículo Eliminado");
                        listCompras.Clear();
                        loadVentas();
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
            if (listCompras.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una venta para editar");
            }
            else
            {
                EditVenta editVenta = new EditVenta();
                editVenta.Show();
                editVenta.venta = listCompras;
                editVenta.f1ref = this;
            }
        }

        public void actualizar()
        {
            listCompras.Clear();
            loadVentas();
        }
    }
}

