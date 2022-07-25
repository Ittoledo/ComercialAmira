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
    public partial class EditVenta : Form
    {
        public EditVenta()
        {
            InitializeComponent();
        }

        public ListView venta;
        public VentasView f1ref;
        Connection cn = new Connection();


        private void EditProd_Shown(object sender, EventArgs e) //When the edit product card is shown is filled with the selected one from the list
        {
            precio.Text = venta.SelectedItems[0].SubItems[5].Text;
            cantidad.Text = venta.SelectedItems[0].SubItems[6].Text;
        }

        private bool validacionUpdate()
        {
            bool validar = false;
            if (precio.Text == "")
            {
                MessageBox.Show("Campo precio vacio");
            }
            else if (cantidad.Text == "")
            {
                MessageBox.Show("Ingrese cantidad");
            }
            else
            {
                validar = true;
            }
            return validar;
        }

        private void aceptEdit_Click(object sender, EventArgs e)
        {
            string id_venta = venta.SelectedItems[0].SubItems[0].Text;
            string rut_usuario = venta.SelectedItems[0].SubItems[3].Text;
            string codigo_producto = venta.SelectedItems[0].SubItems[1].Text;
            try
            {
                if (validacionUpdate())
                {
                    cn.Open();
                    string query = "UPDATE `venta_producto` SET " +
                        "`precio_venta`='" + precio.Text + "'," +
                        "`cantidad`='" + cantidad.Text + "' where id_compra =" + id_venta + " and rut_proveedor='" + rut_usuario + "' and codigo_producto= " + codigo_producto;
                    cn.ExecuteReader(query);
                    f1ref.actualizar();
                    cn.Close();
                    this.Close();
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

        private void EditProd_Load(object sender, EventArgs e)
        {

        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cantidad_KeyPress(object sender, KeyPressEventArgs e)
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
