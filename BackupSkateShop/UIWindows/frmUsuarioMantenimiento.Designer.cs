namespace BackupSkateShop.UIWindows
{
    partial class frmUsuarioMantenimiento
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
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.gpProductoAgregar = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAlias = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNombreUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gpProductoAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Location = new System.Drawing.Point(294, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 32);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGuardar.Location = new System.Drawing.Point(189, 204);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 32);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gpProductoAgregar
            // 
            this.gpProductoAgregar.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpProductoAgregar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpProductoAgregar.Controls.Add(this.txtTipoUsuario);
            this.gpProductoAgregar.Controls.Add(this.label1);
            this.gpProductoAgregar.Controls.Add(this.txtPassword);
            this.gpProductoAgregar.Controls.Add(this.txtAlias);
            this.gpProductoAgregar.Controls.Add(this.txtNombreUsuario);
            this.gpProductoAgregar.Controls.Add(this.label4);
            this.gpProductoAgregar.Controls.Add(this.label3);
            this.gpProductoAgregar.Controls.Add(this.label2);
            this.gpProductoAgregar.Location = new System.Drawing.Point(21, 9);
            this.gpProductoAgregar.Name = "gpProductoAgregar";
            this.gpProductoAgregar.Size = new System.Drawing.Size(372, 184);
            // 
            // 
            // 
            this.gpProductoAgregar.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpProductoAgregar.Style.BackColorGradientAngle = 90;
            this.gpProductoAgregar.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpProductoAgregar.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpProductoAgregar.Style.BorderBottomWidth = 1;
            this.gpProductoAgregar.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpProductoAgregar.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpProductoAgregar.Style.BorderLeftWidth = 1;
            this.gpProductoAgregar.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpProductoAgregar.Style.BorderRightWidth = 1;
            this.gpProductoAgregar.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpProductoAgregar.Style.BorderTopWidth = 1;
            this.gpProductoAgregar.Style.CornerDiameter = 4;
            this.gpProductoAgregar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpProductoAgregar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpProductoAgregar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpProductoAgregar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpProductoAgregar.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpProductoAgregar.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpProductoAgregar.TabIndex = 3;
            this.gpProductoAgregar.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(45, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo de Usuario";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Location = new System.Drawing.Point(165, 88);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(171, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtAlias
            // 
            // 
            // 
            // 
            this.txtAlias.Border.Class = "TextBoxBorder";
            this.txtAlias.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAlias.Location = new System.Drawing.Point(165, 59);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(171, 20);
            this.txtAlias.TabIndex = 7;
            // 
            // txtNombreUsuario
            // 
            // 
            // 
            // 
            this.txtNombreUsuario.Border.Class = "TextBoxBorder";
            this.txtNombreUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombreUsuario.Location = new System.Drawing.Point(165, 31);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(171, 20);
            this.txtNombreUsuario.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(45, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(45, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(45, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres y Apellidos";
            // 
            // txtTipoUsuario
            // 
            // 
            // 
            // 
            this.txtTipoUsuario.Border.Class = "TextBoxBorder";
            this.txtTipoUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTipoUsuario.Location = new System.Drawing.Point(165, 117);
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.Size = new System.Drawing.Size(171, 20);
            this.txtTipoUsuario.TabIndex = 9;
            // 
            // frmUsuarioMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(415, 250);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gpProductoAgregar);
            this.DoubleBuffered = true;
            this.Name = "frmUsuarioMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarioMantenimiento";
            this.Load += new System.EventHandler(this.frmUsuarioMantenimiento_Load);
            this.gpProductoAgregar.ResumeLayout(false);
            this.gpProductoAgregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.Controls.GroupPanel gpProductoAgregar;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAlias;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombreUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTipoUsuario;
    }
}