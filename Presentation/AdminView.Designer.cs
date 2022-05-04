
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ventasRadBtn = new System.Windows.Forms.RadioButton();
            this.usrRadBtn = new System.Windows.Forms.RadioButton();
            this.prodRadBtn = new System.Windows.Forms.RadioButton();
            this.exitBtn = new System.Windows.Forms.Button();
            this.listAdmin = new System.Windows.Forms.ListView();
            this.idProd = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.comprasRadBtn = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comprasRadBtn);
            this.panel1.Controls.Add(this.ventasRadBtn);
            this.panel1.Controls.Add(this.usrRadBtn);
            this.panel1.Controls.Add(this.prodRadBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 527);
            this.panel1.TabIndex = 0;
            // 
            // ventasRadBtn
            // 
            this.ventasRadBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.ventasRadBtn.Location = new System.Drawing.Point(12, 88);
            this.ventasRadBtn.Name = "ventasRadBtn";
            this.ventasRadBtn.Size = new System.Drawing.Size(121, 32);
            this.ventasRadBtn.TabIndex = 10;
            this.ventasRadBtn.Text = "Ventas";
            this.ventasRadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ventasRadBtn.UseVisualStyleBackColor = true;
            this.ventasRadBtn.CheckedChanged += new System.EventHandler(this.ventasRadBtn_CheckedChanged);
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
            // comprasRadBtn
            // 
            this.comprasRadBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.comprasRadBtn.Location = new System.Drawing.Point(12, 126);
            this.comprasRadBtn.Name = "comprasRadBtn";
            this.comprasRadBtn.Size = new System.Drawing.Size(121, 32);
            this.comprasRadBtn.TabIndex = 11;
            this.comprasRadBtn.Text = "Compras";
            this.comprasRadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comprasRadBtn.UseVisualStyleBackColor = true;
            this.comprasRadBtn.CheckedChanged += new System.EventHandler(this.comprasRadBtn_CheckedChanged);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 527);
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
        private System.Windows.Forms.RadioButton ventasRadBtn;
        private System.Windows.Forms.RadioButton comprasRadBtn;
    }
}