namespace Docvid.GUI.Gestores.tipo_evidencias
{
    partial class gestiontipoevidencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestiontipoevidencias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.txtfiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblestado = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgvdatos = new System.Windows.Forms.DataGridView();
            this.idtipoevidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caracteristica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcaracteristica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtformato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtextension = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReporte = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnmodificar,
            this.toolStripSeparator2,
            this.btneliminar,
            this.txtfiltro,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btnReporte});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1320, 32);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(115, 29);
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(102, 29);
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtfiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(149, 32);
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 29);
            this.toolStripLabel1.Text = "Filtrar";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblestado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 841);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1320, 30);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblestado
            // 
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(208, 25);
            this.lblestado.Text = "Registros encontrados: 0";
            // 
            // dtgvdatos
            // 
            this.dtgvdatos.AllowUserToAddRows = false;
            this.dtgvdatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dtgvdatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvdatos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtipoevidencia,
            this.tipo,
            this.caracteristica,
            this.formato,
            this.extension});
            this.dtgvdatos.Location = new System.Drawing.Point(0, 43);
            this.dtgvdatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvdatos.Name = "dtgvdatos";
            this.dtgvdatos.ReadOnly = true;
            this.dtgvdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvdatos.Size = new System.Drawing.Size(1048, 789);
            this.dtgvdatos.TabIndex = 20;
            // 
            // idtipoevidencia
            // 
            this.idtipoevidencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idtipoevidencia.DataPropertyName = "idtipoevidencia";
            this.idtipoevidencia.HeaderText = "ID tipo";
            this.idtipoevidencia.Name = "idtipoevidencia";
            this.idtipoevidencia.ReadOnly = true;
            this.idtipoevidencia.Visible = false;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // caracteristica
            // 
            this.caracteristica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.caracteristica.DataPropertyName = "caracteristica";
            this.caracteristica.HeaderText = "Caracteristica";
            this.caracteristica.Name = "caracteristica";
            this.caracteristica.ReadOnly = true;
            // 
            // formato
            // 
            this.formato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.formato.DataPropertyName = "formato";
            this.formato.HeaderText = "Formato";
            this.formato.Name = "formato";
            this.formato.ReadOnly = true;
            // 
            // extension
            // 
            this.extension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.extension.DataPropertyName = "extension";
            this.extension.HeaderText = "Extension";
            this.extension.Name = "extension";
            this.extension.ReadOnly = true;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(1106, 105);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(148, 30);
            this.txtid.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1158, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1158, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tipo";
            // 
            // txttipo
            // 
            this.txttipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.Location = new System.Drawing.Point(1106, 217);
            this.txttipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(148, 30);
            this.txttipo.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1106, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Caracteristica";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcaracteristica
            // 
            this.txtcaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaracteristica.Location = new System.Drawing.Point(1106, 340);
            this.txtcaracteristica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcaracteristica.Name = "txtcaracteristica";
            this.txtcaracteristica.Size = new System.Drawing.Size(148, 30);
            this.txtcaracteristica.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1106, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "Formato";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtformato
            // 
            this.txtformato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtformato.Location = new System.Drawing.Point(1106, 455);
            this.txtformato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtformato.Name = "txtformato";
            this.txtformato.Size = new System.Drawing.Size(148, 30);
            this.txtformato.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1106, 540);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "Extension";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtextension
            // 
            this.txtextension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtextension.Location = new System.Drawing.Point(1106, 572);
            this.txtextension.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtextension.Name = "txtextension";
            this.txtextension.Size = new System.Drawing.Size(148, 30);
            this.txtextension.TabIndex = 29;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(1122, 652);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(112, 35);
            this.btnagregar.TabIndex = 31;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(1122, 725);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(112, 35);
            this.btncancelar.TabIndex = 32;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // btnReporte
            // 
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(168, 29);
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // gestiontipoevidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 871);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtextension);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtformato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcaracteristica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dtgvdatos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "gestiontipoevidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gestiontipoevidencias";
            this.Load += new System.EventHandler(this.gestiontipoevidencias_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ToolStripTextBox txtfiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblestado;
        public System.Windows.Forms.DataGridView dtgvdatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipoevidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn caracteristica;
        private System.Windows.Forms.DataGridViewTextBoxColumn formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn extension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txttipo;
        public System.Windows.Forms.TextBox txtcaracteristica;
        public System.Windows.Forms.TextBox txtformato;
        public System.Windows.Forms.TextBox txtextension;
        public System.Windows.Forms.Button btnagregar;
        public System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnReporte;

    }
}