﻿
namespace ParcialDeJohnDoe.Windows
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.colArista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRelleno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVolumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFiltrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.FiltroToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOrdenar = new System.Windows.Forms.ToolStripDropDownButton();
            this.ascendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 527);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDatos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 462);
            this.panel3.TabIndex = 2;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArista,
            this.colRelleno,
            this.colTrazo,
            this.colVolumen,
            this.colArea});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1067, 462);
            this.dgvDatos.TabIndex = 0;
            // 
            // colArista
            // 
            this.colArista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArista.HeaderText = "Arista";
            this.colArista.MinimumWidth = 6;
            this.colArista.Name = "colArista";
            this.colArista.ReadOnly = true;
            // 
            // colRelleno
            // 
            this.colRelleno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRelleno.HeaderText = "Relleno";
            this.colRelleno.MinimumWidth = 6;
            this.colRelleno.Name = "colRelleno";
            this.colRelleno.ReadOnly = true;
            // 
            // colTrazo
            // 
            this.colTrazo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrazo.HeaderText = "Trazo";
            this.colTrazo.MinimumWidth = 6;
            this.colTrazo.Name = "colTrazo";
            this.colTrazo.ReadOnly = true;
            // 
            // colVolumen
            // 
            this.colVolumen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVolumen.HeaderText = "Volumen";
            this.colVolumen.MinimumWidth = 6;
            this.colVolumen.Name = "colVolumen";
            this.colVolumen.ReadOnly = true;
            // 
            // colArea
            // 
            this.colArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArea.HeaderText = "Área";
            this.colArea.MinimumWidth = 6;
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CantidadTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 462);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 65);
            this.panel2.TabIndex = 1;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Enabled = false;
            this.CantidadTextBox.Location = new System.Drawing.Point(199, 17);
            this.CantidadTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(47, 22);
            this.CantidadTextBox.TabIndex = 17;
            this.CantidadTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cantidad:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBorrar,
            this.tsbEditar,
            this.toolStripSeparator1,
            this.tsbFiltrar,
            this.tsbRefrescar,
            this.toolStripSeparator2,
            this.tsbOrdenar,
            this.toolStripSeparator3,
            this.tsbSalir,
            this.toolStripSeparator4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip2.TabIndex = 14;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(56, 24);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(54, 24);
            this.tsbBorrar.Text = "Borrar";
            this.tsbBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBorrar.Click += new System.EventHandler(this.tsbBorrar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(52, 24);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbFiltrar
            // 
            this.tsbFiltrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiltroToolStripComboBox});
            this.tsbFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiltrar.Name = "tsbFiltrar";
            this.tsbFiltrar.Size = new System.Drawing.Size(61, 24);
            this.tsbFiltrar.Text = "Filtrar";
            this.tsbFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FiltroToolStripComboBox
            // 
            this.FiltroToolStripComboBox.Name = "FiltroToolStripComboBox";
            this.FiltroToolStripComboBox.Size = new System.Drawing.Size(121, 28);
            this.FiltroToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroToolStripComboBox_SelectedIndexChanged);
            // 
            // tsbRefrescar
            // 
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(74, 24);
            this.tsbRefrescar.Text = "Refrescar";
            this.tsbRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRefrescar.Click += new System.EventHandler(this.tsbRefrescar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbOrdenar
            // 
            this.tsbOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendenteToolStripMenuItem,
            this.descendenteToolStripMenuItem});
            this.tsbOrdenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrdenar.Name = "tsbOrdenar";
            this.tsbOrdenar.Size = new System.Drawing.Size(77, 24);
            this.tsbOrdenar.Text = "Ordenar";
            this.tsbOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ascendenteToolStripMenuItem
            // 
            this.ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            this.ascendenteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ascendenteToolStripMenuItem.Text = "Ascendente";
            this.ascendenteToolStripMenuItem.Click += new System.EventHandler(this.ascendenteToolStripMenuItem_Click);
            // 
            // descendenteToolStripMenuItem
            // 
            this.descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            this.descendenteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.descendenteToolStripMenuItem.Text = "Descendente";
            this.descendenteToolStripMenuItem.Click += new System.EventHandler(this.descendenteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbSalir
            // 
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(42, 24);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsbFiltrar;
        private System.Windows.Forms.ToolStripButton tsbRefrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsbOrdenar;
        private System.Windows.Forms.ToolStripMenuItem ascendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.ToolStripComboBox FiltroToolStripComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRelleno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.Panel panel2;
    }
}

