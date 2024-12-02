namespace SistemasContables.Views
{
    partial class AgregarDireccionForm
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
            this.components = new System.ComponentModel.Container();
            this.gunaDragPanelTop = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragTitulo = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaResize = new Guna.UI.WinForms.GunaResize(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new Guna.UI.WinForms.GunaTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLinea2 = new Guna.UI.WinForms.GunaTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLinea1 = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdDireccion = new Guna.UI.WinForms.GunaTextBox();
            this.cbDistrito = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaDragPanelTop
            // 
            this.gunaDragPanelTop.TargetControl = null;
            // 
            // gunaDragTitulo
            // 
            this.gunaDragTitulo.TargetControl = null;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 10;
            this.gunaElipse2.TargetControl = this;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 10;
            this.gunaElipse3.TargetControl = this;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.Radius = 10;
            this.gunaElipse4.TargetControl = this;
            // 
            // gunaResize
            // 
            this.gunaResize.TargetForm = null;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panelTop.Controls.Add(this.lblTitulo);
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(648, 40);
            this.panelTop.TabIndex = 177;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 40);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Texto Accion";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 35;
            this.btnMinimizar.Location = new System.Drawing.Point(546, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(51, 40);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(47)))), ((int)(((byte)(6)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 35;
            this.btnExit.Location = new System.Drawing.Point(597, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(97, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(351, 23);
            this.label13.TabIndex = 183;
            this.label13.Text = "Codigo Postal";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoPostal.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigoPostal.BaseColor = System.Drawing.Color.White;
            this.txtCodigoPostal.BorderColor = System.Drawing.Color.Silver;
            this.txtCodigoPostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoPostal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCodigoPostal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtCodigoPostal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigoPostal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCodigoPostal.Location = new System.Drawing.Point(101, 318);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.PasswordChar = '\0';
            this.txtCodigoPostal.Radius = 5;
            this.txtCodigoPostal.Size = new System.Drawing.Size(261, 35);
            this.txtCodigoPostal.TabIndex = 182;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(97, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(351, 23);
            this.label11.TabIndex = 181;
            this.label11.Text = "Linea2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLinea2
            // 
            this.txtLinea2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLinea2.BackColor = System.Drawing.Color.Transparent;
            this.txtLinea2.BaseColor = System.Drawing.Color.White;
            this.txtLinea2.BorderColor = System.Drawing.Color.Silver;
            this.txtLinea2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLinea2.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLinea2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtLinea2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLinea2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLinea2.Location = new System.Drawing.Point(101, 244);
            this.txtLinea2.Name = "txtLinea2";
            this.txtLinea2.PasswordChar = '\0';
            this.txtLinea2.Radius = 5;
            this.txtLinea2.Size = new System.Drawing.Size(433, 35);
            this.txtLinea2.TabIndex = 180;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(97, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(351, 23);
            this.label12.TabIndex = 179;
            this.label12.Text = "Linea1";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLinea1
            // 
            this.txtLinea1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLinea1.BackColor = System.Drawing.Color.Transparent;
            this.txtLinea1.BaseColor = System.Drawing.Color.White;
            this.txtLinea1.BorderColor = System.Drawing.Color.Silver;
            this.txtLinea1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLinea1.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLinea1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtLinea1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLinea1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLinea1.Location = new System.Drawing.Point(101, 156);
            this.txtLinea1.Name = "txtLinea1";
            this.txtLinea1.PasswordChar = '\0';
            this.txtLinea1.Radius = 5;
            this.txtLinea1.Size = new System.Drawing.Size(433, 35);
            this.txtLinea1.TabIndex = 178;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(97, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 185;
            this.label4.Text = "ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdDireccion
            // 
            this.txtIdDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdDireccion.BackColor = System.Drawing.Color.Transparent;
            this.txtIdDireccion.BaseColor = System.Drawing.Color.White;
            this.txtIdDireccion.BorderColor = System.Drawing.Color.Silver;
            this.txtIdDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdDireccion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdDireccion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtIdDireccion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdDireccion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIdDireccion.Location = new System.Drawing.Point(101, 80);
            this.txtIdDireccion.Name = "txtIdDireccion";
            this.txtIdDireccion.PasswordChar = '\0';
            this.txtIdDireccion.Radius = 5;
            this.txtIdDireccion.ReadOnly = true;
            this.txtIdDireccion.Size = new System.Drawing.Size(94, 35);
            this.txtIdDireccion.TabIndex = 184;
            // 
            // cbDistrito
            // 
            this.cbDistrito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDistrito.BackColor = System.Drawing.Color.Transparent;
            this.cbDistrito.BaseColor = System.Drawing.Color.White;
            this.cbDistrito.BorderColor = System.Drawing.Color.Silver;
            this.cbDistrito.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistrito.FocusedColor = System.Drawing.Color.Empty;
            this.cbDistrito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDistrito.ForeColor = System.Drawing.Color.Black;
            this.cbDistrito.FormattingEnabled = true;
            this.cbDistrito.ItemHeight = 28;
            this.cbDistrito.Location = new System.Drawing.Point(101, 404);
            this.cbDistrito.Name = "cbDistrito";
            this.cbDistrito.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.cbDistrito.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbDistrito.Radius = 5;
            this.cbDistrito.Size = new System.Drawing.Size(433, 34);
            this.cbDistrito.TabIndex = 187;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(97, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 186;
            this.label6.Text = "Distrito";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 40;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(398, 489);
            this.btnGuardar.MaximumSize = new System.Drawing.Size(150, 50);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 50);
            this.btnGuardar.TabIndex = 189;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(101, 489);
            this.iconButton2.MaximumSize = new System.Drawing.Size(150, 50);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(132, 50);
            this.iconButton2.TabIndex = 188;
            this.iconButton2.Text = "Cancelar";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // AgregarDireccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 576);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.cbDistrito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdDireccion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLinea2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLinea1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarDireccionForm";
            this.Text = "AgregarDireccionForm";
            this.Load += new System.EventHandler(this.AgregarDireccionForm_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gunaDragPanelTop;
        private Guna.UI.WinForms.GunaDragControl gunaDragTitulo;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private Guna.UI.WinForms.GunaResize gunaResize;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label label13;
        public Guna.UI.WinForms.GunaTextBox txtCodigoPostal;
        private System.Windows.Forms.Label label11;
        public Guna.UI.WinForms.GunaTextBox txtLinea2;
        private System.Windows.Forms.Label label12;
        public Guna.UI.WinForms.GunaTextBox txtLinea1;
        private System.Windows.Forms.Label label4;
        public Guna.UI.WinForms.GunaTextBox txtIdDireccion;
        public Guna.UI.WinForms.GunaComboBox cbDistrito;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}