﻿namespace Docvid.GUI.Gestores.compartirproyectos
{
    partial class gestionarcompartir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionarcompartir));
            this.dtgvdatos = new System.Windows.Forms.DataGridView();
            this.idproyectocompartido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_compartido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblestado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtfiltro = new System.Windows.Forms.ToolStripTextBox();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidproyectocompartido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproyecto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdatos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvdatos
            // 
            this.dtgvdatos.AllowUserToAddRows = false;
            this.dtgvdatos.AllowUserToDeleteRows = false;
            this.dtgvdatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproyectocompartido,
            this.idproyecto,
            this.titulo,
            this.descripcion,
            this.usuario_compartido,
            this.usuario_propietario});
            this.dtgvdatos.EnableHeadersVisualStyles = false;
            this.dtgvdatos.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvdatos.Location = new System.Drawing.Point(0, 28);
            this.dtgvdatos.Name = "dtgvdatos";
            this.dtgvdatos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvdatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvdatos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvdatos.Size = new System.Drawing.Size(654, 324);
            this.dtgvdatos.TabIndex = 21;
            this.dtgvdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvdatos_CellContentClick);
            this.dtgvdatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvdatos_CellContentDoubleClick);
            // 
            // idproyectocompartido
            // 
            this.idproyectocompartido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idproyectocompartido.DataPropertyName = "idproyectocompartido";
            this.idproyectocompartido.HeaderText = "ID proyecto compartido";
            this.idproyectocompartido.Name = "idproyectocompartido";
            this.idproyectocompartido.ReadOnly = true;
            this.idproyectocompartido.Visible = false;
            // 
            // idproyecto
            // 
            this.idproyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idproyecto.DataPropertyName = "idproyecto";
            this.idproyecto.HeaderText = "ID proyecto";
            this.idproyecto.Name = "idproyecto";
            this.idproyecto.ReadOnly = true;
            this.idproyecto.Width = 80;
            // 
            // titulo
            // 
            this.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.titulo.DataPropertyName = "titulo";
            this.titulo.HeaderText = "Titulo del proyecto";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 109;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion del proyecto";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 99;
            // 
            // usuario_compartido
            // 
            this.usuario_compartido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.usuario_compartido.DataPropertyName = "usuario_compartido";
            this.usuario_compartido.HeaderText = "Compartido a";
            this.usuario_compartido.Name = "usuario_compartido";
            this.usuario_compartido.ReadOnly = true;
            this.usuario_compartido.Width = 87;
            // 
            // usuario_propietario
            // 
            this.usuario_propietario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.usuario_propietario.DataPropertyName = "usuario_propietario";
            this.usuario_propietario.HeaderText = "Nombre del usuario propietario";
            this.usuario_propietario.Name = "usuario_propietario";
            this.usuario_propietario.ReadOnly = true;
            this.usuario_propietario.Width = 159;
            // 
            // lblestado
            // 
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(136, 17);
            this.lblestado.Text = "Registros encontrados: 0";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "Filtrar";
            // 
            // txtfiltro
            // 
            this.txtfiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(100, 25);
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(70, 22);
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(78, 22);
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblestado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(880, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btnmodificar,
            this.toolStripSeparator3,
            this.btneliminar,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.txtfiltro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(880, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton1.Text = "Agregar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(705, 124);
            this.txtidusuario.Multiline = true;
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.ReadOnly = true;
            this.txtidusuario.Size = new System.Drawing.Size(115, 28);
            this.txtidusuario.TabIndex = 28;
            this.txtidusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(711, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Usuario seleccionado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(711, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "idproyectocompartido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtidproyectocompartido
            // 
            this.txtidproyectocompartido.Location = new System.Drawing.Point(705, 51);
            this.txtidproyectocompartido.Multiline = true;
            this.txtidproyectocompartido.Name = "txtidproyectocompartido";
            this.txtidproyectocompartido.ReadOnly = true;
            this.txtidproyectocompartido.Size = new System.Drawing.Size(115, 28);
            this.txtidproyectocompartido.TabIndex = 30;
            this.txtidproyectocompartido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(711, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Proyecto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtproyecto
            // 
            this.txtproyecto.Location = new System.Drawing.Point(705, 240);
            this.txtproyecto.Multiline = true;
            this.txtproyecto.Name = "txtproyecto";
            this.txtproyecto.ReadOnly = true;
            this.txtproyecto.Size = new System.Drawing.Size(115, 28);
            this.txtproyecto.TabIndex = 32;
            this.txtproyecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(721, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 34;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(723, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 25);
            this.button3.TabIndex = 35;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // gestionarcompartir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 566);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtproyecto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidproyectocompartido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvdatos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "gestionarcompartir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyectos compartidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gestionarcompartir_FormClosed);
            this.Load += new System.EventHandler(this.gestionarcompartir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdatos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvdatos;
        private System.Windows.Forms.ToolStripStatusLabel lblestado;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtfiltro;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.TextBox txtidusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtidproyectocompartido;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtproyecto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproyectocompartido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_compartido;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_propietario;
    }
}