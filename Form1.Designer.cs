
namespace MatrizNotas1
{
    partial class frmNotas
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
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNota5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDefinitiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre,
            this.clmCodigo,
            this.clmNota1,
            this.clmNota2,
            this.clmNota3,
            this.clmNota4,
            this.clmNota5,
            this.clmDefinitiva,
            this.clmResultado});
            this.dgvNotas.Location = new System.Drawing.Point(29, 12);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.Size = new System.Drawing.Size(915, 244);
            this.dgvNotas.TabIndex = 0;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Codigo";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmNota1
            // 
            this.clmNota1.HeaderText = "Nota1";
            this.clmNota1.Name = "clmNota1";
            this.clmNota1.ReadOnly = true;
            this.clmNota1.Width = 70;
            // 
            // clmNota2
            // 
            this.clmNota2.HeaderText = "Nota2";
            this.clmNota2.Name = "clmNota2";
            this.clmNota2.ReadOnly = true;
            // 
            // clmNota3
            // 
            this.clmNota3.HeaderText = "Nota3";
            this.clmNota3.Name = "clmNota3";
            this.clmNota3.ReadOnly = true;
            // 
            // clmNota4
            // 
            this.clmNota4.HeaderText = "Nota4";
            this.clmNota4.Name = "clmNota4";
            this.clmNota4.ReadOnly = true;
            // 
            // clmNota5
            // 
            this.clmNota5.HeaderText = "Nota5";
            this.clmNota5.Name = "clmNota5";
            this.clmNota5.ReadOnly = true;
            // 
            // clmDefinitiva
            // 
            this.clmDefinitiva.HeaderText = "Definitiva";
            this.clmDefinitiva.Name = "clmDefinitiva";
            this.clmDefinitiva.ReadOnly = true;
            // 
            // clmResultado
            // 
            this.clmResultado.HeaderText = "Resultado";
            this.clmResultado.Name = "clmResultado";
            this.clmResultado.ReadOnly = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.Location = new System.Drawing.Point(29, 278);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(162, 36);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(388, 278);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(162, 36);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(771, 278);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 36);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(989, 356);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dgvNotas);
            this.Name = "frmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de Notas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNota5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDefinitiva;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmResultado;
    }
}

