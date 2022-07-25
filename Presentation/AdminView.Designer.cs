
namespace Presentation
{
    partial class AdminView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.proveedoresRadBtn = new System.Windows.Forms.RadioButton();
            this.comprasRadBtn = new System.Windows.Forms.RadioButton();
            this.usrRadBtn = new System.Windows.Forms.RadioButton();
            this.prodRadBtn = new System.Windows.Forms.RadioButton();
            this.exitBtn = new System.Windows.Forms.Button();
            this.listAdmin = new System.Windows.Forms.ListView();
            this.idProd = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.listAdmin2 = new System.Windows.Forms.ListView();
            this.add = new System.Windows.Forms.Button();
            this.addInexist = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cantidad = new System.Windows.Forms.TextBox();
            this.labelCant = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.proveedoresRadBtn);
            this.panel1.Controls.Add(this.comprasRadBtn);
            this.panel1.Controls.Add(this.usrRadBtn);
            this.panel1.Controls.Add(this.prodRadBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 527);
            this.panel1.TabIndex = 0;
            // 
            // proveedoresRadBtn
            // 
            this.proveedoresRadBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.proveedoresRadBtn.Location = new System.Drawing.Point(12, 126);
            this.proveedoresRadBtn.Name = "proveedoresRadBtn";
            this.proveedoresRadBtn.Size = new System.Drawing.Size(121, 32);
            this.proveedoresRadBtn.TabIndex = 12;
            this.proveedoresRadBtn.Text = "Proveedores";
            this.proveedoresRadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.proveedoresRadBtn.UseVisualStyleBackColor = true;
            this.proveedoresRadBtn.CheckedChanged += new System.EventHandler(this.proveedoresRadBtn_CheckedChanged);
            // 
            // comprasRadBtn
            // 
            this.comprasRadBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.comprasRadBtn.Location = new System.Drawing.Point(12, 88);
            this.comprasRadBtn.Name = "comprasRadBtn";
            this.comprasRadBtn.Size = new System.Drawing.Size(121, 32);
            this.comprasRadBtn.TabIndex = 11;
            this.comprasRadBtn.Text = "Compras";
            this.comprasRadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comprasRadBtn.UseVisualStyleBackColor = true;
            this.comprasRadBtn.CheckedChanged += new System.EventHandler(this.comprasRadBtn_CheckedChanged);
            // 
            // usrRadBtn
            // 
            this.usrRadBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.usrRadBtn.Location = new System.Drawing.Point(12, 50);
            this.usrRadBtn.Name = "usrRadBtn";
            this.usrRadBtn.Size = new System.Drawing.Size(121, 32);
            this.usrRadBtn.TabIndex = 9;
            this.usrRadBtn.Text = "Usuarios";
            this.usrRadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usrRadBtn.UseVisualStyleBackColor = true;
            this.usrRadBtn.CheckedChanged += new System.EventHandler(this.usrRadBtn_CheckedChanged);
            // 
            // prodRadBtn
            // 
            this.prodRadBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.prodRadBtn.Location = new System.Drawing.Point(12, 12);
            this.prodRadBtn.Name = "prodRadBtn";
            this.prodRadBtn.Size = new System.Drawing.Size(121, 32);
            this.prodRadBtn.TabIndex = 6;
            this.prodRadBtn.Text = "Productos";
            this.prodRadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prodRadBtn.UseVisualStyleBackColor = true;
            this.prodRadBtn.CheckedChanged += new System.EventHandler(this.prodRadBtn_CheckedChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 489);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(121, 32);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Salir";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // listAdmin
            // 
            this.listAdmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idProd});
            this.listAdmin.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listAdmin.HideSelection = false;
            this.listAdmin.Location = new System.Drawing.Point(154, 12);
            this.listAdmin.MultiSelect = false;
            this.listAdmin.Name = "listAdmin";
            this.listAdmin.Size = new System.Drawing.Size(787, 466);
            this.listAdmin.TabIndex = 1;
            this.listAdmin.UseCompatibleStateImageBehavior = false;
            this.listAdmin.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listAdmin_ItemChecked);
            this.listAdmin.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listAdmin_ItemSelectionChanged);
            // 
            // idProd
            // 
            this.idProd.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(603, 487);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(109, 36);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Agregar";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(718, 487);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(109, 36);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Editar";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(833, 487);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(109, 36);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "Eliminar";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // listAdmin2
            // 
            this.listAdmin2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listAdmin2.HideSelection = false;
            this.listAdmin2.Location = new System.Drawing.Point(591, 12);
            this.listAdmin2.MultiSelect = false;
            this.listAdmin2.Name = "listAdmin2";
            this.listAdmin2.Size = new System.Drawing.Size(350, 466);
            this.listAdmin2.TabIndex = 6;
            this.listAdmin2.UseCompatibleStateImageBehavior = false;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(507, 200);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(78, 23);
            this.add.TabIndex = 7;
            this.add.Text = ">>";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // addInexist
            // 
            this.addInexist.Location = new System.Drawing.Point(507, 277);
            this.addInexist.Name = "addInexist";
            this.addInexist.Size = new System.Drawing.Size(78, 42);
            this.addInexist.TabIndex = 8;
            this.addInexist.Text = "Agregar Inexistente";
            this.addInexist.UseVisualStyleBackColor = true;
            this.addInexist.Click += new System.EventHandler(this.addInexist_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(507, 106);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(78, 23);
            this.cantidad.TabIndex = 10;
            this.cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_KeyPress);
            // 
            // labelCant
            // 
            this.labelCant.AutoSize = true;
            this.labelCant.Location = new System.Drawing.Point(517, 88);
            this.labelCant.Name = "labelCant";
            this.labelCant.Size = new System.Drawing.Size(58, 15);
            this.labelCant.TabIndex = 11;
            this.labelCant.Text = "Cantidad:";
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(507, 229);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(78, 23);
            this.remove.TabIndex = 12;
            this.remove.Text = "<<";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(507, 171);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(78, 23);
            this.price.TabIndex = 13;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(507, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Precio unitario compra:";
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.labelCant);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.addInexist);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listAdmin2);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAdmin);
            this.Controls.Add(this.panel1);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.Activated += new System.EventHandler(this.AdminView_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminView_FormClosing);
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.RadioButton prodRadBtn;
        private System.Windows.Forms.RadioButton usrRadBtn;
        private System.Windows.Forms.ColumnHeader idProd;
        private System.Windows.Forms.RadioButton comprasRadBtn;
        private System.Windows.Forms.ListView listAdmin2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button addInexist;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label labelCant;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton proveedoresRadBtn;
    }
}