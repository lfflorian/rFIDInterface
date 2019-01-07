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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pMenu.SuspendLayout();
            this.pContenido.SuspendLayout();
            this.pTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).BeginInit();
            this.pReaders.SuspendLayout();
            this.pListReaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).BeginInit();
            this.pAddReaders.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Readers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tags registrados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(295, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Agregar Readers";
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pMenu.Controls.Add(this.panel1);
            this.pMenu.Controls.Add(this.btnMinimized);
            this.pMenu.Controls.Add(this.btnClose);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(1158, 31);
            this.pMenu.TabIndex = 3;
            this.pMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pMenu_MouseDown);
            this.pMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pMenu_MouseMove);
            this.pMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pMenu_MouseUp);
            // 
            // pContenido
            // 
            this.pContenido.Controls.Add(this.pTags);
            this.pContenido.Controls.Add(this.pReaders);
            this.pContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenido.Location = new System.Drawing.Point(0, 31);
            this.pContenido.Name = "pContenido";
            this.pContenido.Size = new System.Drawing.Size(1158, 539);
            this.pContenido.TabIndex = 4;
            // 
            // pTags
            // 
            this.pTags.Controls.Add(this.dgvTags);
            this.pTags.Controls.Add(this.label2);
            this.pTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTags.Location = new System.Drawing.Point(0, 0);
            this.pTags.Name = "pTags";
            this.pTags.Size = new System.Drawing.Size(632, 539);
            this.pTags.TabIndex = 1;
            // 
            // dgvTags
            // 
            this.dgvTags.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTags.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTags.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTags.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTags.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTags.EnableHeadersVisualStyles = false;
            this.dgvTags.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvTags.Location = new System.Drawing.Point(25, 42);
            this.dgvTags.Name = "dgvTags";
            this.dgvTags.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTags.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTags.RowTemplate.Height = 24;
            this.dgvTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.pReaders.Size = new System.Drawing.Size(526, 539);
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
            this.pListReaders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pListReaders.ForeColor = System.Drawing.Color.White;
            this.pListReaders.Location = new System.Drawing.Point(0, 141);
            this.pListReaders.Name = "pListReaders";
            this.pListReaders.Size = new System.Drawing.Size(526, 398);
            this.pListReaders.TabIndex = 1;
            // 
            // btnConectarTodos
            // 
            this.btnConectarTodos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConectarTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnConectarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnConectarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectarTodos.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectarTodos.ForeColor = System.Drawing.Color.White;
            this.btnConectarTodos.Location = new System.Drawing.Point(377, 327);
            this.btnConectarTodos.Name = "btnConectarTodos";
            this.btnConectarTodos.Size = new System.Drawing.Size(137, 31);
            this.btnConectarTodos.TabIndex = 6;
            this.btnConectarTodos.Text = "Conectar Todos";
            this.btnConectarTodos.UseVisualStyleBackColor = true;
            // 
            // btnconectar
            // 
            this.btnconectar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnconectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnconectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconectar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconectar.ForeColor = System.Drawing.Color.White;
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
            this.lbIp.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIp.ForeColor = System.Drawing.Color.White;
            this.lbIp.Location = new System.Drawing.Point(18, 298);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(189, 19);
            this.lbIp.TabIndex = 4;
            this.lbIp.Text = "Dirección IP Seleccionado";
            // 
            // dgvReaders
            // 
            this.dgvReaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReaders.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvReaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReaders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReaders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaders.EnableHeadersVisualStyles = false;
            this.dgvReaders.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvReaders.Location = new System.Drawing.Point(18, 43);
            this.dgvReaders.Name = "dgvReaders";
            this.dgvReaders.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReaders.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReaders.RowTemplate.Height = 24;
            this.dgvReaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.btnAgregarReader.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarReader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAgregarReader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAgregarReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarReader.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarReader.ForeColor = System.Drawing.Color.White;
            this.btnAgregarReader.Location = new System.Drawing.Point(409, 94);
            this.btnAgregarReader.Name = "btnAgregarReader";
            this.btnAgregarReader.Size = new System.Drawing.Size(101, 31);
            this.btnAgregarReader.TabIndex = 7;
            this.btnAgregarReader.Text = "Agregar";
            this.btnAgregarReader.UseVisualStyleBackColor = true;
            this.btnAgregarReader.Click += new System.EventHandler(this.btnAgregarReader_Click);
            // 
            // txtPuerto
            // 
            this.txtPuerto.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuerto.ForeColor = System.Drawing.Color.White;
            this.txtPuerto.Location = new System.Drawing.Point(263, 65);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(247, 23);
            this.txtPuerto.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(178, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Puerto : ";
            // 
            // txtIp
            // 
            this.txtIp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIp.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIp.ForeColor = System.Drawing.Color.White;
            this.txtIp.Location = new System.Drawing.Point(263, 37);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(247, 23);
            this.txtIp.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(134, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección IP : ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1118, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimized.ForeColor = System.Drawing.Color.White;
            this.btnMinimized.Location = new System.Drawing.Point(1078, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(40, 31);
            this.btnMinimized.TabIndex = 4;
            this.btnMinimized.Text = "-";
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 31);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sistema rFID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1158, 570);
            this.Controls.Add(this.pContenido);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Aplicación rFID";
            this.pMenu.ResumeLayout(false);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}

