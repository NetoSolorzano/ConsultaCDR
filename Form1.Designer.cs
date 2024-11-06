namespace ConsultaCDR
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_ruc = new System.Windows.Forms.TextBox();
            this.tx_serie = new System.Windows.Forms.TextBox();
            this.tx_numero = new System.Windows.Forms.TextBox();
            this.bt_proc = new System.Windows.Forms.Button();
            this.tx_base64 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bt_destino = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tx_ruta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_codRpta = new System.Windows.Forms.TextBox();
            this.tx_deta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero";
            // 
            // tx_ruc
            // 
            this.tx_ruc.Location = new System.Drawing.Point(68, 4);
            this.tx_ruc.Name = "tx_ruc";
            this.tx_ruc.Size = new System.Drawing.Size(100, 20);
            this.tx_ruc.TabIndex = 3;
            this.tx_ruc.Validating += new System.ComponentModel.CancelEventHandler(this.tx_ruc_Validating);
            // 
            // tx_serie
            // 
            this.tx_serie.Location = new System.Drawing.Point(68, 28);
            this.tx_serie.Name = "tx_serie";
            this.tx_serie.Size = new System.Drawing.Size(43, 20);
            this.tx_serie.TabIndex = 4;
            this.tx_serie.Validating += new System.ComponentModel.CancelEventHandler(this.tx_serie_Validating);
            // 
            // tx_numero
            // 
            this.tx_numero.Location = new System.Drawing.Point(68, 52);
            this.tx_numero.Name = "tx_numero";
            this.tx_numero.Size = new System.Drawing.Size(100, 20);
            this.tx_numero.TabIndex = 5;
            this.tx_numero.Validating += new System.ComponentModel.CancelEventHandler(this.tx_numero_Validating);
            // 
            // bt_proc
            // 
            this.bt_proc.Location = new System.Drawing.Point(214, 18);
            this.bt_proc.Name = "bt_proc";
            this.bt_proc.Size = new System.Drawing.Size(75, 43);
            this.bt_proc.TabIndex = 6;
            this.bt_proc.Text = "Consultar";
            this.bt_proc.UseVisualStyleBackColor = true;
            this.bt_proc.Click += new System.EventHandler(this.bt_proc_Click);
            // 
            // tx_base64
            // 
            this.tx_base64.Location = new System.Drawing.Point(3, 132);
            this.tx_base64.Multiline = true;
            this.tx_base64.Name = "tx_base64";
            this.tx_base64.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_base64.Size = new System.Drawing.Size(319, 266);
            this.tx_base64.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Texto Base64";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bt_destino
            // 
            this.bt_destino.Location = new System.Drawing.Point(11, 76);
            this.bt_destino.Name = "bt_destino";
            this.bt_destino.Size = new System.Drawing.Size(75, 34);
            this.bt_destino.TabIndex = 9;
            this.bt_destino.Text = "Folder destino";
            this.bt_destino.UseVisualStyleBackColor = true;
            this.bt_destino.Click += new System.EventHandler(this.bt_destino_Click);
            // 
            // tx_ruta
            // 
            this.tx_ruta.Location = new System.Drawing.Point(88, 77);
            this.tx_ruta.Multiline = true;
            this.tx_ruta.Name = "tx_ruta";
            this.tx_ruta.ReadOnly = true;
            this.tx_ruta.Size = new System.Drawing.Size(234, 32);
            this.tx_ruta.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Codigo Rpta.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Detalle";
            // 
            // tx_codRpta
            // 
            this.tx_codRpta.Location = new System.Drawing.Point(88, 404);
            this.tx_codRpta.Name = "tx_codRpta";
            this.tx_codRpta.ReadOnly = true;
            this.tx_codRpta.Size = new System.Drawing.Size(58, 20);
            this.tx_codRpta.TabIndex = 13;
            // 
            // tx_deta
            // 
            this.tx_deta.Location = new System.Drawing.Point(68, 430);
            this.tx_deta.Name = "tx_deta";
            this.tx_deta.ReadOnly = true;
            this.tx_deta.Size = new System.Drawing.Size(254, 20);
            this.tx_deta.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 480);
            this.Controls.Add(this.tx_deta);
            this.Controls.Add(this.tx_codRpta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_ruta);
            this.Controls.Add(this.bt_destino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_base64);
            this.Controls.Add(this.bt_proc);
            this.Controls.Add(this.tx_numero);
            this.Controls.Add(this.tx_serie);
            this.Controls.Add(this.tx_ruc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Consulta de CDR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_ruc;
        private System.Windows.Forms.TextBox tx_serie;
        private System.Windows.Forms.TextBox tx_numero;
        private System.Windows.Forms.Button bt_proc;
        private System.Windows.Forms.TextBox tx_base64;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bt_destino;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tx_ruta;
        private System.Windows.Forms.TextBox tx_deta;
        private System.Windows.Forms.TextBox tx_codRpta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

