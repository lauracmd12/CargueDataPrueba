
namespace CargarData
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarDocumento = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblResultadoConsulta = new System.Windows.Forms.Label();
            this.dataClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.lblArchivoCargar = new System.Windows.Forms.Label();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.ListaMeses = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta";
            // 
            // txtBuscarDocumento
            // 
            this.txtBuscarDocumento.Location = new System.Drawing.Point(20, 110);
            this.txtBuscarDocumento.Name = "txtBuscarDocumento";
            this.txtBuscarDocumento.Size = new System.Drawing.Size(166, 20);
            this.txtBuscarDocumento.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Aqua;
            this.btnConsultar.Location = new System.Drawing.Point(254, 87);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(88, 43);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblResultadoConsulta
            // 
            this.lblResultadoConsulta.AutoSize = true;
            this.lblResultadoConsulta.Location = new System.Drawing.Point(14, 129);
            this.lblResultadoConsulta.Name = "lblResultadoConsulta";
            this.lblResultadoConsulta.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoConsulta.TabIndex = 2;
            // 
            // dataClientes
            // 
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Location = new System.Drawing.Point(17, 144);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.Size = new System.Drawing.Size(1277, 307);
            this.dataClientes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cargar Informacion";
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(12, 538);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarArchivo.TabIndex = 5;
            this.btnSeleccionarArchivo.Text = "Seleccionar";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click_1);
            // 
            // lblArchivoCargar
            // 
            this.lblArchivoCargar.AutoSize = true;
            this.lblArchivoCargar.Location = new System.Drawing.Point(12, 522);
            this.lblArchivoCargar.Name = "lblArchivoCargar";
            this.lblArchivoCargar.Size = new System.Drawing.Size(49, 13);
            this.lblArchivoCargar.TabIndex = 6;
            this.lblArchivoCargar.Text = "Archivo: ";
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(855, 512);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDatos.TabIndex = 7;
            this.btnCargarDatos.Text = "CARGAR";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Visible = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Green;
            this.lblEstado.Location = new System.Drawing.Point(14, 588);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "label3";
            this.lblEstado.Visible = false;
            // 
            // ListaMeses
            // 
            this.ListaMeses.FormattingEnabled = true;
            this.ListaMeses.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.ListaMeses.Location = new System.Drawing.Point(531, 510);
            this.ListaMeses.Name = "ListaMeses";
            this.ListaMeses.Size = new System.Drawing.Size(120, 95);
            this.ListaMeses.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(855, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "DESCARGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 657);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaMeses);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.lblArchivoCargar);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataClientes);
            this.Controls.Add(this.lblResultadoConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtBuscarDocumento);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarDocumento;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblResultadoConsulta;
        private System.Windows.Forms.DataGridView dataClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.Label lblArchivoCargar;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ListBox ListaMeses;
        private System.Windows.Forms.Button button1;
    }
}

