namespace BackupSkateShop.UIWindows
{
    partial class frmProveedoresMantenimiento
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
            this.gpProductoAgregar = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtTelefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRazonSocial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRUC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.gpProductoAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Location = new System.Drawing.Point(285, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 32);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gpProductoAgregar
            // 
            this.gpProductoAgregar.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpProductoAgregar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpProductoAgregar.Controls.Add(this.txtTelefono);
            this.gpProductoAgregar.Controls.Add(this.txtRazonSocial);
            this.gpProductoAgregar.Controls.Add(this.txtRUC);
            this.gpProductoAgregar.Controls.Add(this.label4);
            this.gpProductoAgregar.Controls.Add(this.label3);
            this.gpProductoAgregar.Controls.Add(this.label2);
            this.gpProductoAgregar.Location = new System.Drawing.Point(12, 12);
            this.gpProductoAgregar.Name = "gpProductoAgregar";
            this.gpProductoAgregar.Size = new System.Drawing.Size(372, 153);
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
            this.gpProductoAgregar.TabIndex = 6;
            this.gpProductoAgregar.Text = "Usuario";
            // 
            // txtTelefono
            // 
            // 
            // 
            // 
            this.txtTelefono.Border.Class = "TextBoxBorder";
            this.txtTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTelefono.Location = new System.Drawing.Point(165, 88);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(171, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtRazonSocial
            // 
            // 
            // 
            // 
            this.txtRazonSocial.Border.Class = "TextBoxBorder";
            this.txtRazonSocial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRazonSocial.Location = new System.Drawing.Point(165, 59);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(171, 20);
            this.txtRazonSocial.TabIndex = 7;
            // 
            // txtRUC
            // 
            // 
            // 
            // 
            this.txtRUC.Border.Class = "TextBoxBorder";
            this.txtRUC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRUC.Location = new System.Drawing.Point(165, 31);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(171, 20);
            this.txtRUC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(45, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(45, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razon Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(45, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUC";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGuardar.Location = new System.Drawing.Point(169, 181);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 32);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // frmProveedoresMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 234);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpProductoAgregar);
            this.DoubleBuffered = true;
            this.Name = "frmProveedoresMantenimiento";
            this.Text = "frmProveedoresMantenimiento";
            this.Load += new System.EventHandler(this.frmProveedoresMantenimiento_Load);
            this.gpProductoAgregar.ResumeLayout(false);
            this.gpProductoAgregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.Controls.GroupPanel gpProductoAgregar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTelefono;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRazonSocial;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRUC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
    }
}