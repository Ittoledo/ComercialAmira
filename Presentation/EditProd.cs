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
    public partial class EditProd : Form
    {
        public string prod;
        public AdminView f1ref;
        Connection cn = new Connection();
        List<ComboBoxPairs> comboSource = new List<ComboBoxPairs>();

        public EditProd()
        {
            InitializeComponent();
        }

        private void EditProd_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private List<ComboBoxPairs> fillList()
        {
            List<ComboBoxPairs> comboSourceFinal = new List<ComboBoxPairs>();
            try
            {
                cn.Open();
                string query = "SELECT * FROM categoria";
                MySqlDataReader row = cn.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        comboSourceFinal.Add(new ComboBoxPairs(row["categoria"].ToString(), row["cod_categoria"].ToString()));
                    }

                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Error al llenar categorias de productos");
            }
            return comboSourceFinal;
        }

        private void selectCombo(string cod_categoria)
        {
            comboSource = fillList();
            tipoProd.DisplayMember = "nameCat";
            tipoProd.ValueMember = "idCat";
            tipoProd.DataSource = comboSource;
            tipoProd.SelectedValue = cod_categoria;
        }

        private void EditProd_Shown(object sender, EventArgs e) //When the edit product card is shown is filled with the selected one from the list
        {
            try
            {
                cn.Open();
                string query = "select * from producto where id_producto=" + prod;
                MySqlDataReader row;
                row = cn.ExecuteReader(query);
                while (row.Read())
                {
                    idProd.Text = row["id_producto"].ToString();
                    selectCombo(row["cod_categoria"].ToString());
                    nombre.Text = row["nombre"].ToString();
                    descripcion.Text = row["descripcion"].ToString();
                    ppcu.Text = row["precio_por_detalle"].ToString();
                    ppm.Text = row["precio_por_mayor"].ToString();
                    stock.Text = row["stock"].ToString();
                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar datos de producto");
            }
        }

        private bool validacionUpdate()
        {
            bool validar = false;
            if(idProd.Text == "")
            {
                MessageBox.Show("Campo id vacio");
            }
            else if (tipoProd.Text == "")
            {
                MessageBox.Show("Seleccione un tipo de producto");
            }
            else if (nombre.Text == "")
            {
                MessageBox.Show("Ingrese nombre de producto");
            }
            else if (ppcu.Text == "")
            {
                MessageBox.Show("Ingrese un precio por unidad");
            }
            else if (ppm.Text == "")
            {
                MessageBox.Show("Ingrese un precio por mayor");
            }
            else if (stock.Text == "")
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
            try
            {
                if (validacionUpdate())
                {
                    cn.Open();
                    string query = "UPDATE `producto` SET " +
                        "`id_producto`='" + idProd.Text + "'," +
                        "`cod_categoria`='" + tipoProd.SelectedValue+ "'," +
                        "`nombre`='" + nombre.Text + "'," +
                        "`descripcion`='" + descripcion.Text + "'," +
                        "`precio_por_detalle`='" + ppcu.Text + "'," +
                        "`precio_por_mayor`='" + ppm.Text + "'," +
                        "`stock`='" + stock.Text + "' WHERE id_producto=" + idProd.Text;
                    cn.ExecuteReader(query);
                    cn.Close();
                    f1ref.actualizaLista();
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
    }
}
