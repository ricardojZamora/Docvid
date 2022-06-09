namespace Docvid.GUI.Gestores.firma_digital
{
    partial class panelfirmaprincipal
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
            this.btnbuscarpdf = new System.Windows.Forms.Button();
            this.btnfirma = new System.Windows.Forms.Button();
            this.txtescritura = new System.Windows.Forms.TextBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbuscarpdf
            // 
            this.btnbuscarpdf.Location = new System.Drawing.Point(193, 25);
            this.btnbuscarpdf.Name = "btnbuscarpdf";
            this.btnbuscarpdf.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarpdf.TabIndex = 0;
            this.btnbuscarpdf.Text = "Buscar PDF";
            this.btnbuscarpdf.UseVisualStyleBackColor = true;
            this.btnbuscarpdf.Click += new System.EventHandler(this.btnbuscarpdf_Click);
            // 
            // btnfirma
            // 
            this.btnfirma.Location = new System.Drawing.Point(793, 531);
            this.btnfirma.Name = "btnfirma";
            this.btnfirma.Size = new System.Drawing.Size(75, 23);
            this.btnfirma.TabIndex = 1;
            this.btnfirma.Text = "Firmar pdf";
            this.btnfirma.UseVisualStyleBackColor = true;
            this.btnfirma.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtescritura
            // 
            this.txtescritura.Location = new System.Drawing.Point(22, 62);
            this.txtescritura.Multiline = true;
            this.txtescritura.Name = "txtescritura";
            this.txtescritura.Size = new System.Drawing.Size(846, 463);
            this.txtescritura.TabIndex = 2;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(22, 534);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(484, 20);
            this.txtbuscar.TabIndex = 3;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(512, 532);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // panelfirmaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 566);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.txtescritura);
            this.Controls.Add(this.btnfirma);
            this.Controls.Add(this.btnbuscarpdf);
            this.Name = "panelfirmaprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma digital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfirma;
        public System.Windows.Forms.Button btnbuscarpdf;
        public System.Windows.Forms.TextBox txtescritura;
        private System.Windows.Forms.TextBox txtbuscar;
        public System.Windows.Forms.Button btnbuscar;
    }
}