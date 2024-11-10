namespace SistemasContables.Views
{
    partial class AgregarUsuarioForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.gunaDragPanelTop = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragTitulo = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaResize = new Guna.UI.WinForms.GunaResize(this.components);
            this.cbEmpleado = new Guna.UI.WinForms.GunaComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave = new Guna.UI.WinForms.GunaTextBox();
            this.cbEstado = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRol = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(800, 40);
            this.panelTop.TabIndex = 16;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 40);
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
            this.btnMinimizar.Location = new System.Drawing.Point(698, 0);
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
            this.btnExit.Location = new System.Drawing.Point(749, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // cbEmpleado
            // 
            this.cbEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.cbEmpleado.BaseColor = System.Drawing.Color.White;
            this.cbEmpleado.BorderColor = System.Drawing.Color.Silver;
            this.cbEmpleado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleado.FocusedColor = System.Drawing.Color.Empty;
            this.cbEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleado.ForeColor = System.Drawing.Color.Black;
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.ItemHeight = 28;
            this.cbEmpleado.Location = new System.Drawing.Point(181, 352);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.cbEmpleado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbEmpleado.Radius = 5;
            this.cbEmpleado.Size = new System.Drawing.Size(393, 34);
            this.cbEmpleado.StartIndex = 0;
            this.cbEmpleado.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(177, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 132;
            this.label4.Text = "ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtIdUsuario.BaseColor = System.Drawing.Color.White;
            this.txtIdUsuario.BorderColor = System.Drawing.Color.Silver;
            this.txtIdUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdUsuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdUsuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtIdUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIdUsuario.Location = new System.Drawing.Point(181, 86);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.PasswordChar = '\0';
            this.txtIdUsuario.Radius = 5;
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(92, 35);
            this.txtIdUsuario.TabIndex = 131;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(177, 497);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 23);
            this.label14.TabIndex = 130;
            this.label14.Text = "Estado";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(177, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 135;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.BaseColor = System.Drawing.Color.White;
            this.txtUsuario.BorderColor = System.Drawing.Color.Silver;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(181, 167);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.Radius = 5;
            this.txtUsuario.Size = new System.Drawing.Size(393, 35);
            this.txtUsuario.TabIndex = 134;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(177, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 137;
            this.label3.Text = "Clave";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClave.BackColor = System.Drawing.Color.Transparent;
            this.txtClave.BaseColor = System.Drawing.Color.White;
            this.txtClave.BorderColor = System.Drawing.Color.Silver;
            this.txtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClave.FocusedBaseColor = System.Drawing.Color.White;
            this.txtClave.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtClave.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtClave.Location = new System.Drawing.Point(181, 255);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '\0';
            this.txtClave.Radius = 5;
            this.txtClave.Size = new System.Drawing.Size(393, 35);
            this.txtClave.TabIndex = 136;
            // 
            // cbEstado
            // 
            this.cbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cbEstado.BaseColor = System.Drawing.Color.White;
            this.cbEstado.BorderColor = System.Drawing.Color.Silver;
            this.cbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FocusedColor = System.Drawing.Color.Empty;
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.ForeColor = System.Drawing.Color.Black;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.ItemHeight = 28;
            this.cbEstado.Location = new System.Drawing.Point(181, 538);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.cbEstado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbEstado.Radius = 5;
            this.cbEstado.Size = new System.Drawing.Size(393, 34);
            this.cbEstado.StartIndex = 0;
            this.cbEstado.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(177, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 138;
            this.label5.Text = "Empleado";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbRol
            // 
            this.cbRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRol.BackColor = System.Drawing.Color.Transparent;
            this.cbRol.BaseColor = System.Drawing.Color.White;
            this.cbRol.BorderColor = System.Drawing.Color.Silver;
            this.cbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.FocusedColor = System.Drawing.Color.Empty;
            this.cbRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.ForeColor = System.Drawing.Color.Black;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.ItemHeight = 28;
            this.cbRol.Location = new System.Drawing.Point(181, 448);
            this.cbRol.Name = "cbRol";
            this.cbRol.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.cbRol.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbRol.Radius = 5;
            this.cbRol.Size = new System.Drawing.Size(393, 34);
            this.cbRol.StartIndex = 0;
            this.cbRol.TabIndex = 141;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(177, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 140;
            this.label6.Text = "Rol";
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
            this.btnGuardar.Location = new System.Drawing.Point(438, 612);
            this.btnGuardar.MaximumSize = new System.Drawing.Size(150, 50);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 50);
            this.btnGuardar.TabIndex = 143;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 40;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(181, 612);
            this.btnCancel.MaximumSize = new System.Drawing.Size(150, 50);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 50);
            this.btnCancel.TabIndex = 142;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AgregarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarUsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuarioForm";
            this.Load += new System.EventHandler(this.AgregarUsuarioForm_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnExit;
        private Guna.UI.WinForms.GunaDragControl gunaDragPanelTop;
        private Guna.UI.WinForms.GunaDragControl gunaDragTitulo;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private Guna.UI.WinForms.GunaResize gunaResize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaTextBox txtUsuario;
        public Guna.UI.WinForms.GunaTextBox txtIdUsuario;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaTextBox txtClave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancel;
        public Guna.UI.WinForms.GunaComboBox cbEmpleado;
        public Guna.UI.WinForms.GunaComboBox cbRol;
        public Guna.UI.WinForms.GunaComboBox cbEstado;
    }
}