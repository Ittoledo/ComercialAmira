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
    public partial class AdminView : Form
    {
        Connection cn = new Connection();
        public string id;
        public string titleAdminView;
        public AdminView()
        {
            InitializeComponent();
        }


        private void loadProds()
        {
            try
            {
                cn.Open();
                string query = "select * from producto";
                MySqlDataReader row;
                row = cn.ExecuteReader(query);
                listAdmin.Columns.Add("id_producto", "Id", 50);
                listAdmin.Columns.Add("nombre", "Nombre", 200);
                listAdmin.Columns.Add("precio_por_detalle", "Precio por Detalle", 200);
                listAdmin.Columns.Add("precio_por_mayor", "Precio por Mayor", 200);
                listAdmin.Columns.Add("stock", "Cantidad", 130);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        listAdmin.Items.Add(new ListViewItem(new[] { row["id_producto"].ToString(), row["nombre"].ToString(), row["precio_por_detalle"].ToString(), row["precio_por_mayor"].ToString(), row["stock"].ToString() }));
                    }
                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar productos");
            }
        }
        private void loadUsrs()
        {

        }
        private void loadVentas()
        {

        }
        private void loadCompras()
        {

        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            listAdmin.View = View.Details;
            listAdmin.GridLines = true;
            listAdmin.FullRowSelect = true;
            prodRadBtn.Checked = true;
            editBtn.Enabled = false;
            this.Text = titleAdminView;
        }

        private void AdminView_FormClosing(object sender, FormClosingEventArgs e)
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

        private void prodRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (prodRadBtn.Checked)
            {
                listAdmin.Clear();
                loadProds();
            }
        }

        private void usrRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (usrRadBtn.Checked)
            {
                listAdmin.Clear();
                loadUsrs();
            }
        }

        private void ventasRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ventasRadBtn.Checked)
            {
                listAdmin.Clear();
                loadVentas();
            }
        }

        private void comprasRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (comprasRadBtn.Checked)
            {
                listAdmin.Clear();
                loadCompras();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
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
            NewProd newProd = new NewProd();
            newProd.rutUser = id;
            newProd.Show();
            newProd.f1ref = this;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if(listAdmin.SelectedItems.Count > 0)
            {
                EditProd editProd = new EditProd();
                editProd.Show();
                editProd.f1ref = this;
                editProd.prod = listAdmin.SelectedItems[0].Text;
            }
            else
            {
                MessageBox.Show("Seleccione un articulo para editar");
            }
            //pop up the new form for editing the selected product
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if(listAdmin.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un artículo a eliminar");
            }
            else
            {
                if(DialogResult.Yes == MessageBox.Show("Esta seguro de querer eliminar dicho artículo?", "Important Question", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        cn.Open();
                        string query = "delete from producto where id_producto=" + listAdmin.SelectedItems[0].Text;
                        cn.ExecuteReader(query);
                        cn.Close();
                        MessageBox.Show("Artículo Eliminado");
                        actualizaLista();
                    }
                    catch
                    {
                        MessageBox.Show("Error desconocido");
                    }
                }
            }
        }

        private void AdminView_Activated(object sender, EventArgs e)
        {
            
        }

        public void actualizaLista()
        {
            listAdmin.Clear();
            loadProds();
        }

        private void listAdmin_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            
        }

        private void listAdmin_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listAdmin.SelectedItems.Count > 0)
            {
                editBtn.Enabled = true;
            }
            else
            {
                editBtn.Enabled = false;
            }
        }

    }
}
