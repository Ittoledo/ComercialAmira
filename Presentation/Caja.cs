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
    public partial class Caja : Form
    {
        Connection cn = new Connection();
        public Caja()
        {
            InitializeComponent();
            int egreso = 0;
            int ingreso = 0;
            int balance = 0;

            cn.Open();
            string query = "select precio_venta, cantidad from venta_producto where isnull(deleted_at)";
            MySqlDataReader row = cn.ExecuteReader(query);
            while(row.Read())
            {
                ingreso += Int32.Parse(row["precio_venta"].ToString()) * Int32.Parse(row["cantidad"].ToString());
            }
            cn.Close();

            cn.Open();
            query = "select precio_compra, cantidad from compra_producto where isnull(deleted_at)";
            row = cn.ExecuteReader(query);
            while (row.Read())
            {
                egreso += Int32.Parse(row["precio_compra"].ToString()) * Int32.Parse(row["cantidad"].ToString());
            }
            cn.Close();

            balance = ingreso - egreso;
            label1.Text = "Los ingresos de ventas totales son: " + ingreso.ToString();
            label2.Text = "Los egresos de compras totales son: " + egreso.ToString();
            label3.Text = "Balance total: " + balance.ToString();
        }
    }
}
