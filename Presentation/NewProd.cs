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
using Microsoft.VisualBasic;

namespace Presentation
{
    public partial class NewProd : Form
    {
        Connection cn = new Connection();
        public string rutUser;
        public AdminView f1ref;
        List<ComboBoxPairs> comboSource = new List<ComboBoxPairs>();

        public NewProd()
        {
            InitializeComponent();
        }

        private void NewProd_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private bool validacionIngreso()
        {
            bool validar = false;
            if (idProd.Text == "")
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

        private string getIdAjuste()
        {
            int retorno = 0;
            cn.Open();
            string query = "Select count(id_ajuste) from ajuste";
            MySqlDataReader row = cn.ExecuteReader(query);
            while (row.Read()) retorno = 1 + Convert.ToInt32(row[0].ToString()); 
            cn.Close();
            return retorno.ToString();
        }

        private void realizaAjuste()
        {
            try
            {
                string idAjuste = getIdAjuste();
                cn.Open();
                string query = "INSERT INTO `ajuste`(`id_ajuste`,`id_tipo_ajuste`,`rut_usuario`,`id_producto`,`cantidad`,`fecha_hora_ajuste`) "+
                    "VALUES('" + idAjuste + "', '4', '" + rutUser + "', '" + idProd.Text + "', '" + stock.Text + "', 'now()')";
                cn.ExecuteReader(query);
                cn.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacionIngreso())
                {
                    ComboBoxPairs cbp = (ComboBoxPairs)tipoProd.SelectedItem;
                    string idTipo = cbp.idCat;
                    cn.Open();
                    string query = "INSERT INTO `producto`(`id_producto`, `cod_categoria`, `nombre`, `descripcion`, `precio_por_detalle`, `precio_por_mayor`, `stock`) " +
                        "VALUES('" + idProd.Text + "', '" + idTipo + "', '" + nombre.Text + "', '" + descripcion.Text + "', '" + ppcu.Text + "', '" + ppm.Text + "', '" + stock.Text + "')";
                    cn.ExecuteReader(query);
                    cn.Close();
                    realizaAjuste();
                    f1ref.actualizaLista();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error al ingresar producto");
            }
            
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void NewProd_Load(object sender, EventArgs e)
        {
            comboSource = fillList();
            tipoProd.DisplayMember = "nameCat";
            tipoProd.ValueMember = "idCat";
            tipoProd.DataSource = comboSource;
            
        }
        private void insertarCat(string id, string input)
        {
            cn.Open();
            string query2 = "INSERT INTO `categoria`(`cod_categoria`, `categoria`) VALUES('" + id + "', '" + input + "')";
            cn.ExecuteReader(query2);
            cn.Close();
            comboSource.Add(new ComboBoxPairs(input, id));
            tipoProd.DataSource = null;
            tipoProd.Items.Clear();
            tipoProd.DisplayMember = "nameCat";
            tipoProd.ValueMember = "idCat";
            tipoProd.DataSource = comboSource;
            tipoProd.SelectedValue = id;
        }
        private void newCat_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Ingrese nueva Categoría", "Nueva Categoría");
            if (input != "")
            {
                int idCat = 0;
                try
                {
                    cn.Open();
                    string query1 = "SELECT max(cod_categoria) FROM categoria";
                    MySqlDataReader row = cn.ExecuteReader(query1);
                    while(row.Read()) idCat = 1 + Convert.ToInt32(row[0].ToString());
                    cn.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                insertarCat(idCat.ToString(), input);
            }

        }
    }
}
