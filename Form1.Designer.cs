namespace App
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pMenu = new System.Windows.Forms.Panel();
            this.pContenido = new System.Windows.Forms.Panel();
            this.pTags = new System.Windows.Forms.Panel();
            this.dgvTags = new System.Windows.Forms.DataGridView();
            this.pReaders = new System.Windows.Forms.Panel();
            this.pListReaders = new System.Windows.Forms.Panel();
            this.btnConectarTodos = new System.Windows.Forms.Button();
            this.btnconectar = new System.Windows.Forms.Button();
            this.lbIp = new System.Windows.Forms.Label();
            this.dgvReaders = new System.Windows.Forms.DataGridView();
            this.pAddReaders = new System.Windows.Forms.Panel();
            this.btnAgregarReader = new System.Windows.Forms.Button();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pContenido.SuspendLayout();
            this.pTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).BeginInit();
            this.pReaders.SuspendLayout();
            this.pListReaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).BeginInit();
            this.pAddReaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Readers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registro de Tags";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Agregar Readers";
            // 
            // pMenu
            // 
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(1158, 43);
            this.pMenu.TabIndex = 3;
            // 
            // pContenido
            // 
            this.pContenido.Controls.Add(this.pTags);
            this.pContenido.Controls.Add(this.pReaders);
            this.pContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenido.Location = new System.Drawing.Point(0, 43);
            this.pContenido.Name = "pContenido";
            this.pContenido.Size = new System.Drawing.Size(1158, 553);
            this.pContenido.TabIndex = 4;
            // 
            // pTags
            // 
            this.pTags.Controls.Add(this.dgvTags);
            this.pTags.Controls.Add(this.label2);
            this.pTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTags.Location = new System.Drawing.Point(0, 0);
            this.pTags.Name = "pTags";
            this.pTags.Size = new System.Drawing.Size(632, 553);
            this.pTags.TabIndex = 1;
            // 
            // dgvTags
            // 
            this.dgvTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTags.Location = new System.Drawing.Point(24, 42);
            this.dgvTags.Name = "dgvTags";
            this.dgvTags.RowTemplate.Height = 24;
            this.dgvTags.Size = new System.Drawing.Size(562, 457);
            this.dgvTags.TabIndex = 2;
            // 
            // pReaders
            // 
            this.pReaders.Controls.Add(this.pListReaders);
            this.pReaders.Controls.Add(this.pAddReaders);
            this.pReaders.Dock = System.Windows.Forms.DockStyle.Right;
            this.pReaders.Location = new System.Drawing.Point(632, 0);
            this.pReaders.Name = "pReaders";
            this.pReaders.Size = new System.Drawing.Size(526, 553);
            this.pReaders.TabIndex = 0;
            // 
            // pListReaders
            // 
            this.pListReaders.Controls.Add(this.btnConectarTodos);
            this.pListReaders.Controls.Add(this.btnconectar);
            this.pListReaders.Controls.Add(this.lbIp);
            this.pListReaders.Controls.Add(this.dgvReaders);
            this.pListReaders.Controls.Add(this.label1);
            this.pListReaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pListReaders.Location = new System.Drawing.Point(0, 141);
            this.pListReaders.Name = "pListReaders";
            this.pListReaders.Size = new System.Drawing.Size(526, 412);
            this.pListReaders.TabIndex = 1;
            // 
            // btnConectarTodos
            // 
            this.btnConectarTodos.Location = new System.Drawing.Point(377, 327);
            this.btnConectarTodos.Name = "btnConectarTodos";
            this.btnConectarTodos.Size = new System.Drawing.Size(137, 31);
            this.btnConectarTodos.TabIndex = 6;
            this.btnConectarTodos.Text = "Conectar Todos";
            this.btnConectarTodos.UseVisualStyleBackColor = true;
            // 
            // btnconectar
            // 
            this.btnconectar.Location = new System.Drawing.Point(18, 327);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(92, 31);
            this.btnconectar.TabIndex = 5;
            this.btnconectar.Text = "Conectar";
            this.btnconectar.UseVisualStyleBackColor = true;
            // 
            // lbIp
            // 
            this.lbIp.AutoSize = true;
            this.lbIp.Location = new System.Drawing.Point(18, 298);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(172, 17);
            this.lbIp.TabIndex = 4;
            this.lbIp.Text = "Dirección IP Seleccionado";
            // 
            // dgvReaders
            // 
            this.dgvReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaders.Location = new System.Drawing.Point(18, 43);
            this.dgvReaders.Name = "dgvReaders";
            this.dgvReaders.RowTemplate.Height = 24;
            this.dgvReaders.Size = new System.Drawing.Size(496, 234);
            this.dgvReaders.TabIndex = 3;
            // 
            // pAddReaders
            // 
            this.pAddReaders.Controls.Add(this.btnAgregarReader);
            this.pAddReaders.Controls.Add(this.txtPuerto);
            this.pAddReaders.Controls.Add(this.label5);
            this.pAddReaders.Controls.Add(this.txtIp);
            this.pAddReaders.Controls.Add(this.label4);
            this.pAddReaders.Controls.Add(this.label3);
            this.pAddReaders.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAddReaders.Location = new System.Drawing.Point(0, 0);
            this.pAddReaders.Name = "pAddReaders";
            this.pAddReaders.Size = new System.Drawing.Size(526, 141);
            this.pAddReaders.TabIndex = 0;
            // 
            // btnAgregarReader
            // 
            this.btnAgregarReader.Location = new System.Drawing.Point(119, 94);
            this.btnAgregarReader.Name = "btnAgregarReader";
            this.btnAgregarReader.Size = new System.Drawing.Size(101, 26);
            this.btnAgregarReader.TabIndex = 7;
            this.btnAgregarReader.Text = "Agregar";
            this.btnAgregarReader.UseVisualStyleBackColor = true;
            this.btnAgregarReader.Click += new System.EventHandler(this.btnAgregarReader_Click);
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(119, 65);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(247, 22);
            this.txtPuerto.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Puerto : ";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(119, 37);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(247, 22);
            this.txtIp.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección IP : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 596);
            this.Controls.Add(this.pContenido);
            this.Controls.Add(this.pMenu);
            this.Name = "Form1";
            this.Text = "Aplicación rFID";
            this.pContenido.ResumeLayout(false);
            this.pTags.ResumeLayout(false);
            this.pTags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).EndInit();
            this.pReaders.ResumeLayout(false);
            this.pListReaders.ResumeLayout(false);
            this.pListReaders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).EndInit();
            this.pAddReaders.ResumeLayout(false);
            this.pAddReaders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pContenido;
        private System.Windows.Forms.Panel pTags;
        private System.Windows.Forms.DataGridView dgvTags;
        private System.Windows.Forms.Panel pReaders;
        private System.Windows.Forms.Panel pListReaders;
        private System.Windows.Forms.Button btnConectarTodos;
        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Label lbIp;
        private System.Windows.Forms.DataGridView dgvReaders;
        private System.Windows.Forms.Panel pAddReaders;
        private System.Windows.Forms.Button btnAgregarReader;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label4;
    }
}

