namespace GeneradorePseudoWF
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMultiplicador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSemillaC = new System.Windows.Forms.TextBox();
            this.btnGenerarC = new System.Windows.Forms.Button();
            this.dgvCuadrados = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSemilla1 = new System.Windows.Forms.TextBox();
            this.txtSemilla2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerarP = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSemC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNuevaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSemilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPseudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuadrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(615, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTabla);
            this.tabPage1.Controls.Add(this.btnGenerar);
            this.tabPage1.Controls.Add(this.txtModulo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtMultiplicador);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtIncremento);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSemilla);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(607, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Congruencial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCuadrados);
            this.tabPage2.Controls.Add(this.btnGenerarC);
            this.tabPage2.Controls.Add(this.txtSemillaC);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(607, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cuadrados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.btnGenerarP);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtSemilla2);
            this.tabPage3.Controls.Add(this.txtSemilla1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(607, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semilla";
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(55, 4);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(59, 20);
            this.txtSemilla.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(186, 4);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(61, 20);
            this.txtIncremento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Multiplicador";
            // 
            // txtMultiplicador
            // 
            this.txtMultiplicador.Location = new System.Drawing.Point(325, 4);
            this.txtMultiplicador.Name = "txtMultiplicador";
            this.txtMultiplicador.Size = new System.Drawing.Size(62, 20);
            this.txtMultiplicador.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modulo";
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(441, 4);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(64, 20);
            this.txtModulo.TabIndex = 7;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(520, 3);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coli,
            this.colSemilla,
            this.colNew,
            this.colPseudo});
            this.dgvTabla.Location = new System.Drawing.Point(3, 30);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(602, 327);
            this.dgvTabla.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Semilla";
            // 
            // txtSemillaC
            // 
            this.txtSemillaC.Location = new System.Drawing.Point(54, 6);
            this.txtSemillaC.Name = "txtSemillaC";
            this.txtSemillaC.Size = new System.Drawing.Size(100, 20);
            this.txtSemillaC.TabIndex = 1;
            // 
            // btnGenerarC
            // 
            this.btnGenerarC.Location = new System.Drawing.Point(491, 4);
            this.btnGenerarC.Name = "btnGenerarC";
            this.btnGenerarC.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarC.TabIndex = 2;
            this.btnGenerarC.Text = "Generar";
            this.btnGenerarC.UseVisualStyleBackColor = true;
            this.btnGenerarC.Click += new System.EventHandler(this.btnGenerarC_Click);
            // 
            // dgvCuadrados
            // 
            this.dgvCuadrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuadrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuadrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colN,
            this.colSemC,
            this.colNuevaS,
            this.colNumP});
            this.dgvCuadrados.Location = new System.Drawing.Point(8, 32);
            this.dgvCuadrados.Name = "dgvCuadrados";
            this.dgvCuadrados.Size = new System.Drawing.Size(592, 318);
            this.dgvCuadrados.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(524, 396);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(434, 396);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Semilla 1";
            // 
            // txtSemilla1
            // 
            this.txtSemilla1.Location = new System.Drawing.Point(64, 3);
            this.txtSemilla1.Name = "txtSemilla1";
            this.txtSemilla1.Size = new System.Drawing.Size(100, 20);
            this.txtSemilla1.TabIndex = 1;
            // 
            // txtSemilla2
            // 
            this.txtSemilla2.Location = new System.Drawing.Point(225, 3);
            this.txtSemilla2.Name = "txtSemilla2";
            this.txtSemilla2.Size = new System.Drawing.Size(100, 20);
            this.txtSemilla2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Semilla 2";
            // 
            // btnGenerarP
            // 
            this.btnGenerarP.Location = new System.Drawing.Point(522, 2);
            this.btnGenerarP.Name = "btnGenerarP";
            this.btnGenerarP.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarP.TabIndex = 4;
            this.btnGenerarP.Text = "Generar";
            this.btnGenerarP.UseVisualStyleBackColor = true;
            this.btnGenerarP.Click += new System.EventHandler(this.btnGenerarP_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNp,
            this.colSem1,
            this.colSem2,
            this.colProducto,
            this.colNumPP});
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 327);
            this.dataGridView1.TabIndex = 5;
            // 
            // colNp
            // 
            this.colNp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNp.HeaderText = "N";
            this.colNp.Name = "colNp";
            this.colNp.ReadOnly = true;
            // 
            // colSem1
            // 
            this.colSem1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSem1.HeaderText = "Semilla 1";
            this.colSem1.Name = "colSem1";
            this.colSem1.ReadOnly = true;
            // 
            // colSem2
            // 
            this.colSem2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSem2.HeaderText = "Semilla2";
            this.colSem2.Name = "colSem2";
            this.colSem2.ReadOnly = true;
            // 
            // colProducto
            // 
            this.colProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colNumPP
            // 
            this.colNumPP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNumPP.HeaderText = "N. P.";
            this.colNumPP.Name = "colNumPP";
            this.colNumPP.ReadOnly = true;
            // 
            // colN
            // 
            this.colN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colN.HeaderText = "n";
            this.colN.Name = "colN";
            this.colN.ReadOnly = true;
            // 
            // colSemC
            // 
            this.colSemC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSemC.HeaderText = "Semilla";
            this.colSemC.Name = "colSemC";
            this.colSemC.ReadOnly = true;
            // 
            // colNuevaS
            // 
            this.colNuevaS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNuevaS.HeaderText = "Xn+1";
            this.colNuevaS.Name = "colNuevaS";
            this.colNuevaS.ReadOnly = true;
            // 
            // colNumP
            // 
            this.colNumP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNumP.HeaderText = "N. P.";
            this.colNumP.Name = "colNumP";
            this.colNumP.ReadOnly = true;
            // 
            // coli
            // 
            this.coli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coli.HeaderText = "n";
            this.coli.Name = "coli";
            this.coli.ReadOnly = true;
            // 
            // colSemilla
            // 
            this.colSemilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSemilla.HeaderText = "Semilla";
            this.colSemilla.Name = "colSemilla";
            this.colSemilla.ReadOnly = true;
            // 
            // colNew
            // 
            this.colNew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNew.HeaderText = "Xn+1";
            this.colNew.Name = "colNew";
            this.colNew.ReadOnly = true;
            // 
            // colPseudo
            // 
            this.colPseudo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPseudo.HeaderText = "N. P.";
            this.colPseudo.Name = "colPseudo";
            this.colPseudo.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 427);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Generadores de Números Pseudo-aleatorios";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuadrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMultiplicador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarC;
        private System.Windows.Forms.TextBox txtSemillaC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCuadrados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumPP;
        private System.Windows.Forms.Button btnGenerarP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSemilla2;
        private System.Windows.Forms.TextBox txtSemilla1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn coli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSemilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPseudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSemC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNuevaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumP;
    }
}

