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
                editBtn.Text = "Editar";
                label2.Visible = false;
                price.Visible = false;
                addBtn.Text = "Agregar";
                remove.Visible = false;
                add.Visible = false;
                listAdmin2.Visible = false;
                add.Visible = false;
                labelCant.Visible = false;
                cantidad.Visible = false;
                addInexist.Visible = false;
                listAdmin.Width = 787;
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
                        if (row["deleted_at"].ToString() == "")
                        {
                            listAdmin.Items.Add(new ListViewItem(new[] { row["id_producto"].ToString(), row["nombre"].ToString(), row["precio_por_detalle"].ToString(), row["precio_por_mayor"].ToString(), row["stock"].ToString() }));
                        }
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
            try
            {
                editBtn.Text = "Editar";
                label2.Visible = false;
                price.Visible = false;
                addBtn.Text = "Agregar";
                remove.Visible = false;
                add.Visible = false;
                add.Visible = false;
                labelCant.Visible = false;
                cantidad.Visible = false;
                addInexist.Visible = false;
                listAdmin2.Visible = false;
                listAdmin.Width = 787;
                cn.Open();
                string query = "select * from usuario";
                MySqlDataReader row;
                row = cn.ExecuteReader(query);
                listAdmin.Columns.Add("rut_usuario", "Rut", 200);
                listAdmin.Columns.Add("nombre", "Nombre", 200);
                listAdmin.Columns.Add("apellido", "Apellido", 200);
                listAdmin.Columns.Add("tipo_usuario", "Tipo de Usuario", 200);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        if (row["deleted_at"].ToString() == "")
                        {
                            string tipo = "";
                            if (row["id_tipo_usuario"].ToString() == "1") tipo = "Administrador";
                            else if (row["id_tipo_usuario"].ToString() == "2") tipo = "Usuario";
                            listAdmin.Items.Add(new ListViewItem(new[] { row["rut_usuario"].ToString(), row["nombre_usuario"].ToString(), row["apellido_usuario"].ToString(), tipo}));
                        }
                    }
                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar usuarios");
            }

        }

        private void loadProveedores()
        {
            try
            {
                editBtn.Text = "Editar";
                label2.Visible = false;
                price.Visible = false;
                addBtn.Text = "Agregar";
                remove.Visible = false;
                add.Visible = false;
                add.Visible = false;
                labelCant.Visible = false;
                cantidad.Visible = false;
                addInexist.Visible = false;
                listAdmin2.Visible = false;
                listAdmin.Width = 787;
                cn.Open();
                string query = "select * from proveedor";
                MySqlDataReader row;
                row = cn.ExecuteReader(query);
                listAdmin.Columns.Add("rut_proveedor", "Rut", 200);
                listAdmin.Columns.Add("nombre", "Nombre", 200);
                listAdmin.Columns.Add("direccion", "Direccion", 200);
                listAdmin.Columns.Add("celular", "Celular", 200);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        if (row["deleted_at"].ToString() == "")
                        {
                            listAdmin.Items.Add(new ListViewItem(new[] { row["rut_proveedor"].ToString(), row["nombre"].ToString(), row["direccion"].ToString(), row["celular"].ToString() }));
                        }
                    }
                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar proveedores");
            }

        }
        private void loadCompras()
        {
            try
            {
                editBtn.Enabled = true;
                editBtn.Text = "Ver Compras";
                label2.Visible = true;
                price.Visible = true;
                addBtn.Text = "Confirmar";
                remove.Visible = true;
                add.Visible = true;
                labelCant.Visible = true;
                cantidad.Visible = true;
                addInexist.Visible = true;
                listAdmin2.Visible = true; 
                listAdmin.Width = 350;
                cn.Open();
                string query = "select * from producto";
                MySqlDataReader row;
                row = cn.ExecuteReader(query);
                listAdmin.Columns.Add("id_producto", "Id", 50);
                listAdmin.Columns.Add("nombre", "Nombre", 200);
                listAdmin.Columns.Add("stock", "Cantidad", 130);
                listAdmin2.Columns.Add("id_producto", "Id", 50);
                listAdmin2.Columns.Add("nombre", "Nombre", 200);
                listAdmin2.Columns.Add("precio", "Precio", 100);
                listAdmin2.Columns.Add("cantidad", "Cantidad", 100);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        if (row["deleted_at"].ToString() == "")
                        {
                            listAdmin.Items.Add(new ListViewItem(new[] { row["id_producto"].ToString(), row["nombre"].ToString(), row["stock"].ToString() }));
                        }
                    }
                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar productos");
            }
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            listAdmin.View = View.Details;
            listAdmin.GridLines = true;
            listAdmin.FullRowSelect = true;
            listAdmin2.View = View.Details;
            listAdmin2.GridLines = true;
            listAdmin2.FullRowSelect = true;
            prodRadBtn.Checked = true;
            editBtn.Enabled = true;
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
        private void comprasRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (comprasRadBtn.Checked)
            {
                listAdmin.Clear();
                loadCompras();
            }
        }

        private void proveedoresRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (proveedoresRadBtn.Checked)
            {
                listAdmin.Clear();
                loadProveedores();
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
            if (prodRadBtn.Checked)
            {
                NewProd newProd = new NewProd();
                newProd.rutUser = id;
                newProd.Show();
                newProd.f1ref = this;
            } else if (usrRadBtn.Checked)
            {
                NewUsr newUsr = new NewUsr();
                newUsr.Show();
                newUsr.f1ref = this;
                newUsr.rutUser = id;
            } else if (comprasRadBtn.Checked)
            {
                NewCompra newCompra = new NewCompra();
                newCompra.listaProductos = listAdmin2;
                newCompra.f1ref = this;
                newCompra.Show();
            } else if (proveedoresRadBtn.Checked)
            {
                NewProveedor newProveedor = new NewProveedor();
                newProveedor.Show();
                newProveedor.rutUser = id;
                newProveedor.f1ref = this;
            } else
            {
                MessageBox.Show("Seleccione un elemento a agregar");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (prodRadBtn.Checked)
            {
                if (listAdmin.SelectedItems.Count > 0)
                {
                    EditProd editProd = new EditProd();
                    editProd.Show();
                    editProd.f1ref = this;
                    editProd.rutUser = id;
                    editProd.prod = listAdmin.SelectedItems[0].Text;
                }
                else
                {
                    MessageBox.Show("Seleccione un articulo para editar");
                }
            }
            if( usrRadBtn.Checked)
            {
                if(listAdmin.SelectedItems.Count > 0)
                {
                    EditUsr editUsr = new EditUsr();
                    editUsr.Show();
                    editUsr.f1ref = this;
                    editUsr.rutUser = id;
                    editUsr.user = listAdmin.SelectedItems[0].Text;
                } else
                {
                    MessageBox.Show("Seleccione un usuario para editar");
                }
            }
            else if(comprasRadBtn.Checked)
            {
                ViewCompras viewCompras = new ViewCompras();
                viewCompras.Show();
                viewCompras.f1ref = this;
            }
            else if (proveedoresRadBtn.Checked)
            {
                if (listAdmin.SelectedItems.Count > 0)
                {
                    EditProv editProv = new EditProv();
                    editProv.Show();
                    editProv.f1ref = this;
                    editProv.proveedor = listAdmin.SelectedItems[0].Text;
                    editProv.rutUser = id;
                } else
                {
                    MessageBox.Show("Seleccione un proveedor para editar");
                }
            }
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

                string query = "INSERT INTO ajuste(id_ajuste,id_tipo_ajuste,rut_usuario,id_producto,cantidad,fecha_hora_ajuste) " +
                    "VALUES(" + idAjuste + ", 3, " + id + ", " + listAdmin.SelectedItems[0].Text + ", 0, NOW())";
                cn.ExecuteReader(query);
                cn.Close();
            }
            catch
            {

            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (prodRadBtn.Checked)
            {
                if (listAdmin.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione un artículo a eliminar");
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Esta seguro de querer eliminar dicho artículo?", "Important Question", MessageBoxButtons.YesNo))
                    {
                        try
                        {
                            cn.Open();
                            string query = "update producto set deleted_at=NOW() where id_producto =" + listAdmin.SelectedItems[0].Text;
                            cn.ExecuteReader(query);
                            cn.Close();
                            realizaAjuste();
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
            else if(usrRadBtn.Checked)
            {
                if (listAdmin.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione un usuario a eliminar");
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Esta seguro de querer eliminar dicho usuario?", "Important Question", MessageBoxButtons.YesNo))
                    {
                        try
                        {
                            cn.Open();
                            string query = "update usuario set deleted_at=NOW() where rut_usuario='" + listAdmin.SelectedItems[0].Text +"'";
                            cn.ExecuteReader(query);
                            cn.Close();
                            MessageBox.Show("Usuario Eliminado");
                            actualizaLista();
                        }
                        catch
                        {
                            MessageBox.Show("Error desconocido");
                        }
                    }
                }
            }
            else if (proveedoresRadBtn.Checked)
            {
                if (listAdmin.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione un proveedor a eliminar");
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Esta seguro de querer eliminar dicho proveedor?", "Important Question", MessageBoxButtons.YesNo))
                    {
                        try
                        {
                            cn.Open();
                            string query = "update proveedor set deleted_at=NOW() where rut_proveedor='" + listAdmin.SelectedItems[0].Text + "'";
                            cn.ExecuteReader(query);
                            cn.Close();
                            MessageBox.Show("Proveedor Eliminado");
                            actualizaLista();
                        }
                        catch
                        {
                            MessageBox.Show("Error desconocido");
                        }
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
            listAdmin2.Clear();
            if (prodRadBtn.Checked) loadProds();
            else if (usrRadBtn.Checked) loadUsrs();
            else if (comprasRadBtn.Checked) loadCompras();
            else if (proveedoresRadBtn.Checked) loadProveedores();
        }

        private void listAdmin_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            
        }

        private void listAdmin_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
        }

        private void addInexist_Click(object sender, EventArgs e)
        {
            NewProd newProd = new NewProd();
            newProd.rutUser = id;
            newProd.Show();
            newProd.f1ref = this;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(cantidad.Text != "")
            {
                listAdmin2.Items.Add(new ListViewItem(new[] { listAdmin.SelectedItems[0].Text, listAdmin.SelectedItems[0].SubItems[1].Text, price.Text,cantidad.Text }));;
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (listAdmin2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto a remover");
            }
            else
            {
                listAdmin2.SelectedItems[0].Remove();
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

        private void price_KeyPress(object sender, KeyPressEventArgs e)
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
