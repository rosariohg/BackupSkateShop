namespace BackupSkateShop.UIWindows
{
    partial class frmProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.dgvProducto = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uni_min_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_Familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_Oferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_Temporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.btnEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducto
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Producto,
            this.cb_Producto,
            this.nom_Producto,
            this.prec_Producto,
            this.uni_min_Producto,
            this.activo_Producto,
            this.nom_Familia,
            this.nom_Oferta,
            this.nom_Temporada});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducto.EnableHeadersVisualStyles = false;
            this.dgvProducto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(217)))));
            this.dgvProducto.Location = new System.Drawing.Point(8, 32);
            this.dgvProducto.Name = "dgvProducto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducto.Size = new System.Drawing.Size(953, 188);
            this.dgvProducto.TabIndex = 0;
            // 
            // id_Producto
            // 
            this.id_Producto.DataPropertyName = "id_Producto";
            this.id_Producto.HeaderText = "ID";
            this.id_Producto.Name = "id_Producto";
            // 
            // cb_Producto
            // 
            this.cb_Producto.DataPropertyName = "cb_Producto";
            this.cb_Producto.HeaderText = "Codigo de Barras";
            this.cb_Producto.Name = "cb_Producto";
            // 
            // nom_Producto
            // 
            this.nom_Producto.DataPropertyName = "nom_Producto";
            this.nom_Producto.HeaderText = "Producto";
            this.nom_Producto.Name = "nom_Producto";
            // 
            // prec_Producto
            // 
            this.prec_Producto.DataPropertyName = "prec_Producto";
            this.prec_Producto.HeaderText = "Precio";
            this.prec_Producto.Name = "prec_Producto";
            // 
            // uni_min_Producto
            // 
            this.uni_min_Producto.DataPropertyName = "uni_min_Producto";
            this.uni_min_Producto.HeaderText = "Unidad minima Producto";
            this.uni_min_Producto.Name = "uni_min_Producto";
            // 
            // activo_Producto
            // 
            this.activo_Producto.DataPropertyName = "activo_Producto";
            this.activo_Producto.HeaderText = "Existencia del Producto";
            this.activo_Producto.Name = "activo_Producto";
            // 
            // nom_Familia
            // 
            this.nom_Familia.DataPropertyName = "nom_Familia";
            this.nom_Familia.HeaderText = "Familia";
            this.nom_Familia.Name = "nom_Familia";
            // 
            // nom_Oferta
            // 
            this.nom_Oferta.DataPropertyName = "nom_Oferta";
            this.nom_Oferta.HeaderText = "Oferta";
            this.nom_Oferta.Name = "nom_Oferta";
            // 
            // nom_Temporada
            // 
            this.nom_Temporada.DataPropertyName = "nom_Temporada";
            this.nom_Temporada.HeaderText = "Temporada";
            this.nom_Temporada.Name = "nom_Temporada";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(510, 236);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 36);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(668, 236);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(139, 36);
            this.btnEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(821, 236);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 36);
            this.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(965, 284);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProducto);
            this.DoubleBuffered = true;
            this.Name = "frmProducto";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvProducto;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.ButtonX btnEditar;
        private DevComponents.DotNetBar.ButtonX btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cb_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn uni_min_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_Familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_Oferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_Temporada;
    }
}