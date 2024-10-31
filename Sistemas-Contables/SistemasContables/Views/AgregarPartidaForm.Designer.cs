namespace SistemasContables.Views
{
    partial class AgregarPartidaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.licensing1 = new Guna.UI.WinForms.Licensing();
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
            this.btnRestoreWindow = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.rbDebito = new Guna.UI.WinForms.GunaRadioButton();
            this.rbCredito = new Guna.UI.WinForms.GunaRadioButton();
            this.cbCuenta = new Guna.UI.WinForms.GunaComboBox();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.rbIncluido = new Guna.UI.WinForms.GunaRadioButton();
            this.rbMasIva = new Guna.UI.WinForms.GunaRadioButton();
            this.rbExcento = new Guna.UI.WinForms.GunaRadioButton();
            this.dpFecha = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new Guna.UI.WinForms.GunaTextBox();
            this.txtDescripcion = new Guna.UI.WinForms.GunaTextBox();
            this.txtMonto = new Guna.UI.WinForms.GunaTextBox();
            this.cbTipoTransaccion = new Guna.UI.WinForms.GunaComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPartida = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarPartida = new FontAwesome.Sharp.IconButton();
            this.btnEditarPartida = new FontAwesome.Sharp.IconButton();
            this.btnNuevaCuenta = new FontAwesome.Sharp.IconButton();
            this.btnEliminarCuenta = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablePartidas = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // licensing1
            // 
            this.licensing1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.licensing1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.licensing1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.licensing1.Location = new System.Drawing.Point(0, 0);
            this.licensing1.Margin = new System.Windows.Forms.Padding(6);
            this.licensing1.Name = "licensing1";
            this.licensing1.Size = new System.Drawing.Size(405, 500);
            this.licensing1.TabIndex = 0;
            // 
            // gunaDragPanelTop
            // 
            this.gunaDragPanelTop.TargetControl = this.panelTop;
            // 
            // gunaDragTitulo
            // 
            this.gunaDragTitulo.TargetControl = this.lblTitulo;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this.btnAgregarPartida;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 10;
            this.gunaElipse2.TargetControl = this.btnEditarPartida;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 10;
            this.gunaElipse3.TargetControl = this.btnNuevaCuenta;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.Radius = 10;
            this.gunaElipse4.TargetControl = this.btnEliminarCuenta;
            // 
            // gunaResize
            // 
            this.gunaResize.TargetForm = this;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panelTop.Controls.Add(this.lblTitulo);
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnRestoreWindow);
            this.panelTop.Controls.Add(this.btnMaximizar);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1006, 40);
            this.panelTop.TabIndex = 115;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 40);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Texto Accion";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 35;
            this.btnMinimizar.Location = new System.Drawing.Point(802, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Rotation = 0D;
            this.btnMinimizar.Size = new System.Drawing.Size(51, 40);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestoreWindow
            // 
            this.btnRestoreWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestoreWindow.FlatAppearance.BorderSize = 0;
            this.btnRestoreWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreWindow.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRestoreWindow.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestoreWindow.IconColor = System.Drawing.Color.White;
            this.btnRestoreWindow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestoreWindow.IconSize = 35;
            this.btnRestoreWindow.Location = new System.Drawing.Point(853, 0);
            this.btnRestoreWindow.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreWindow.Name = "btnRestoreWindow";
            this.btnRestoreWindow.Rotation = 0D;
            this.btnRestoreWindow.Size = new System.Drawing.Size(51, 40);
            this.btnRestoreWindow.TabIndex = 3;
            this.btnRestoreWindow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestoreWindow.UseVisualStyleBackColor = true;
            this.btnRestoreWindow.Visible = false;
            this.btnRestoreWindow.Click += new System.EventHandler(this.btnRestoreWindow_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.White;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 35;
            this.btnMaximizar.Location = new System.Drawing.Point(904, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Rotation = 0D;
            this.btnMaximizar.Size = new System.Drawing.Size(51, 40);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
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
            this.btnExit.Location = new System.Drawing.Point(955, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(51, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.White;
            this.gunaGroupBox2.Controls.Add(this.rbDebito);
            this.gunaGroupBox2.Controls.Add(this.rbCredito);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.White;
            this.gunaGroupBox2.Location = new System.Drawing.Point(507, 105);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(125, 139);
            this.gunaGroupBox2.TabIndex = 114;
            this.gunaGroupBox2.Text = "Tipo de pago";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(0, 8);
            // 
            // rbDebito
            // 
            this.rbDebito.BaseColor = System.Drawing.SystemColors.Control;
            this.rbDebito.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbDebito.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.rbDebito.Enabled = false;
            this.rbDebito.FillColor = System.Drawing.Color.White;
            this.rbDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDebito.Location = new System.Drawing.Point(6, 35);
            this.rbDebito.Name = "rbDebito";
            this.rbDebito.Size = new System.Drawing.Size(79, 22);
            this.rbDebito.TabIndex = 1;
            this.rbDebito.Text = "Debito";
            // 
            // rbCredito
            // 
            this.rbCredito.BaseColor = System.Drawing.SystemColors.Control;
            this.rbCredito.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbCredito.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.rbCredito.Enabled = false;
            this.rbCredito.FillColor = System.Drawing.Color.White;
            this.rbCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCredito.Location = new System.Drawing.Point(6, 75);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(85, 22);
            this.rbCredito.TabIndex = 0;
            this.rbCredito.Text = "Credito";
            // 
            // cbCuenta
            // 
            this.cbCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCuenta.BackColor = System.Drawing.Color.Transparent;
            this.cbCuenta.BaseColor = System.Drawing.Color.White;
            this.cbCuenta.BorderColor = System.Drawing.Color.Silver;
            this.cbCuenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuenta.FocusedColor = System.Drawing.Color.Empty;
            this.cbCuenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCuenta.ForeColor = System.Drawing.Color.Black;
            this.cbCuenta.FormattingEnabled = true;
            this.cbCuenta.ItemHeight = 28;
            this.cbCuenta.Items.AddRange(new object[] {
            "Seleccione",
            "Debe",
            "Haber"});
            this.cbCuenta.Location = new System.Drawing.Point(672, 210);
            this.cbCuenta.Name = "cbCuenta";
            this.cbCuenta.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.cbCuenta.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbCuenta.Radius = 5;
            this.cbCuenta.Size = new System.Drawing.Size(278, 34);
            this.cbCuenta.StartIndex = 0;
            this.cbCuenta.TabIndex = 129;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.White;
            this.gunaGroupBox1.Controls.Add(this.rbIncluido);
            this.gunaGroupBox1.Controls.Add(this.rbMasIva);
            this.gunaGroupBox1.Controls.Add(this.rbExcento);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.White;
            this.gunaGroupBox1.Location = new System.Drawing.Point(290, 105);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(194, 139);
            this.gunaGroupBox1.TabIndex = 113;
            this.gunaGroupBox1.Text = "Configuracion del IVA";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(0, 8);
            // 
            // rbIncluido
            // 
            this.rbIncluido.BaseColor = System.Drawing.SystemColors.Control;
            this.rbIncluido.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbIncluido.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.rbIncluido.FillColor = System.Drawing.Color.White;
            this.rbIncluido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIncluido.Location = new System.Drawing.Point(6, 115);
            this.rbIncluido.Name = "rbIncluido";
            this.rbIncluido.Size = new System.Drawing.Size(88, 22);
            this.rbIncluido.TabIndex = 2;
            this.rbIncluido.Text = "Incluido";
            this.rbIncluido.CheckedChanged += new System.EventHandler(this.rbIncluido_CheckedChanged);
            // 
            // rbMasIva
            // 
            this.rbMasIva.BaseColor = System.Drawing.SystemColors.Control;
            this.rbMasIva.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbMasIva.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.rbMasIva.FillColor = System.Drawing.Color.White;
            this.rbMasIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasIva.Location = new System.Drawing.Point(6, 75);
            this.rbMasIva.Name = "rbMasIva";
            this.rbMasIva.Size = new System.Drawing.Size(68, 22);
            this.rbMasIva.TabIndex = 1;
            this.rbMasIva.Text = "+IVA";
            this.rbMasIva.CheckedChanged += new System.EventHandler(this.rbMasIva_CheckedChanged);
            // 
            // rbExcento
            // 
            this.rbExcento.BaseColor = System.Drawing.SystemColors.Control;
            this.rbExcento.Checked = true;
            this.rbExcento.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbExcento.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.rbExcento.FillColor = System.Drawing.Color.White;
            this.rbExcento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExcento.Location = new System.Drawing.Point(6, 35);
            this.rbExcento.Name = "rbExcento";
            this.rbExcento.Size = new System.Drawing.Size(91, 22);
            this.rbExcento.TabIndex = 0;
            this.rbExcento.Text = "Excento";
            this.rbExcento.CheckedChanged += new System.EventHandler(this.rbExcento_CheckedChanged);
            // 
            // dpFecha
            // 
            this.dpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dpFecha.BackColor = System.Drawing.Color.Transparent;
            this.dpFecha.BaseColor = System.Drawing.Color.White;
            this.dpFecha.BorderColor = System.Drawing.Color.Silver;
            this.dpFecha.CustomFormat = null;
            this.dpFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpFecha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.dpFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFecha.ForeColor = System.Drawing.Color.Black;
            this.dpFecha.Location = new System.Drawing.Point(40, 492);
            this.dpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.OnHoverBaseColor = System.Drawing.Color.White;
            this.dpFecha.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.dpFecha.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.dpFecha.OnPressedColor = System.Drawing.Color.Black;
            this.dpFecha.Radius = 5;
            this.dpFecha.Size = new System.Drawing.Size(304, 35);
            this.dpFecha.TabIndex = 128;
            this.dpFecha.Text = "domingo, 6 de diciembre de 2020";
            this.dpFecha.Value = new System.DateTime(2020, 12, 6, 18, 27, 36, 583);
            this.dpFecha.ValueChanged += new System.EventHandler(this.dpFecha_onValueChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(668, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 127;
            this.label4.Text = "Buscar cuenta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BaseColor = System.Drawing.Color.White;
            this.txtBuscar.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtBuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(672, 136);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.Radius = 5;
            this.txtBuscar.Size = new System.Drawing.Size(278, 35);
            this.txtBuscar.TabIndex = 126;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.BaseColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderColor = System.Drawing.Color.Silver;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescripcion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtDescripcion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDescripcion.Location = new System.Drawing.Point(40, 580);
            this.txtDescripcion.MultiLine = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.Radius = 5;
            this.txtDescripcion.Size = new System.Drawing.Size(912, 88);
            this.txtDescripcion.TabIndex = 125;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.Transparent;
            this.txtMonto.BaseColor = System.Drawing.Color.White;
            this.txtMonto.BorderColor = System.Drawing.Color.Silver;
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMonto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtMonto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMonto.Location = new System.Drawing.Point(40, 136);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.Radius = 5;
            this.txtMonto.Size = new System.Drawing.Size(216, 35);
            this.txtMonto.TabIndex = 124;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // cbTipoTransaccion
            // 
            this.cbTipoTransaccion.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoTransaccion.BaseColor = System.Drawing.Color.White;
            this.cbTipoTransaccion.BorderColor = System.Drawing.Color.Silver;
            this.cbTipoTransaccion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoTransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTransaccion.FocusedColor = System.Drawing.Color.Empty;
            this.cbTipoTransaccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoTransaccion.ForeColor = System.Drawing.Color.Black;
            this.cbTipoTransaccion.FormattingEnabled = true;
            this.cbTipoTransaccion.ItemHeight = 28;
            this.cbTipoTransaccion.Items.AddRange(new object[] {
            "Seleccione",
            "Debe",
            "Haber"});
            this.cbTipoTransaccion.Location = new System.Drawing.Point(40, 210);
            this.cbTipoTransaccion.Name = "cbTipoTransaccion";
            this.cbTipoTransaccion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.cbTipoTransaccion.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTipoTransaccion.Radius = 5;
            this.cbTipoTransaccion.Size = new System.Drawing.Size(216, 34);
            this.cbTipoTransaccion.StartIndex = 0;
            this.cbTipoTransaccion.TabIndex = 123;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(36, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 23);
            this.label10.TabIndex = 122;
            this.label10.Text = "Tipo de transacción";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartida
            // 
            this.lblPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblPartida.ForeColor = System.Drawing.Color.Black;
            this.lblPartida.Location = new System.Drawing.Point(36, 60);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(179, 23);
            this.lblPartida.TabIndex = 117;
            this.lblPartida.Text = "Partida No ";
            this.lblPartida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(39, 543);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 23);
            this.label12.TabIndex = 121;
            this.label12.Text = "Descripcion / Detalle";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 120;
            this.label3.Text = "Fecha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnAgregarPartida);
            this.flowLayoutPanel1.Controls.Add(this.btnEditarPartida);
            this.flowLayoutPanel1.Controls.Add(this.btnNuevaCuenta);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminarCuenta);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(149, 706);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(807, 55);
            this.flowLayoutPanel1.TabIndex = 119;
            // 
            // btnAgregarPartida
            // 
            this.btnAgregarPartida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAgregarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPartida.FlatAppearance.BorderSize = 0;
            this.btnAgregarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPartida.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPartida.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPartida.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAgregarPartida.IconColor = System.Drawing.Color.White;
            this.btnAgregarPartida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarPartida.IconSize = 40;
            this.btnAgregarPartida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPartida.Location = new System.Drawing.Point(614, 3);
            this.btnAgregarPartida.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnAgregarPartida.Name = "btnAgregarPartida";
            this.btnAgregarPartida.Rotation = 0D;
            this.btnAgregarPartida.Size = new System.Drawing.Size(190, 50);
            this.btnAgregarPartida.TabIndex = 16;
            this.btnAgregarPartida.Text = "Agregar Partida";
            this.btnAgregarPartida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarPartida.UseVisualStyleBackColor = false;
            this.btnAgregarPartida.Click += new System.EventHandler(this.btnAgregarPartida_Click);
            // 
            // btnEditarPartida
            // 
            this.btnEditarPartida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnEditarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPartida.FlatAppearance.BorderSize = 0;
            this.btnEditarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPartida.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEditarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPartida.ForeColor = System.Drawing.Color.White;
            this.btnEditarPartida.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarPartida.IconColor = System.Drawing.Color.White;
            this.btnEditarPartida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarPartida.IconSize = 40;
            this.btnEditarPartida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPartida.Location = new System.Drawing.Point(418, 3);
            this.btnEditarPartida.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnEditarPartida.Name = "btnEditarPartida";
            this.btnEditarPartida.Rotation = 0D;
            this.btnEditarPartida.Size = new System.Drawing.Size(190, 50);
            this.btnEditarPartida.TabIndex = 6;
            this.btnEditarPartida.Text = "Editar Partida";
            this.btnEditarPartida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarPartida.UseVisualStyleBackColor = false;
            this.btnEditarPartida.Click += new System.EventHandler(this.btnEditarPartida_Click);
            // 
            // btnNuevaCuenta
            // 
            this.btnNuevaCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnNuevaCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaCuenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCuenta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNuevaCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCuenta.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCuenta.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevaCuenta.IconColor = System.Drawing.Color.White;
            this.btnNuevaCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaCuenta.IconSize = 40;
            this.btnNuevaCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCuenta.Location = new System.Drawing.Point(222, 3);
            this.btnNuevaCuenta.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnNuevaCuenta.Name = "btnNuevaCuenta";
            this.btnNuevaCuenta.Rotation = 0D;
            this.btnNuevaCuenta.Size = new System.Drawing.Size(190, 50);
            this.btnNuevaCuenta.TabIndex = 15;
            this.btnNuevaCuenta.Text = "Nueva cuenta";
            this.btnNuevaCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaCuenta.UseVisualStyleBackColor = false;
            this.btnNuevaCuenta.Click += new System.EventHandler(this.btnNuevaCuenta_Click);
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.btnEliminarCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCuenta.FlatAppearance.BorderSize = 0;
            this.btnEliminarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCuenta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEliminarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCuenta.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCuenta.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarCuenta.IconColor = System.Drawing.Color.White;
            this.btnEliminarCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCuenta.IconSize = 40;
            this.btnEliminarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCuenta.Location = new System.Drawing.Point(18, 3);
            this.btnEliminarCuenta.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Rotation = 0D;
            this.btnEliminarCuenta.Size = new System.Drawing.Size(198, 50);
            this.btnEliminarCuenta.TabIndex = 13;
            this.btnEliminarCuenta.Text = "Eliminar Cuenta";
            this.btnEliminarCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCuenta.UseVisualStyleBackColor = false;
            this.btnEliminarCuenta.Click += new System.EventHandler(this.btnEliminarCuenta_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(668, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 23);
            this.label14.TabIndex = 118;
            this.label14.Text = "Tipo de cuenta";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 37);
            this.label1.TabIndex = 116;
            this.label1.Text = "Monto ($)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tablePartidas);
            this.panel1.Location = new System.Drawing.Point(40, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 185);
            this.panel1.TabIndex = 112;
            // 
            // tablePartidas
            // 
            this.tablePartidas.AllowUserToAddRows = false;
            this.tablePartidas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.White;
            this.tablePartidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
            this.tablePartidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePartidas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablePartidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablePartidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablePartidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(88)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.tablePartidas.ColumnHeadersHeight = 40;
            this.tablePartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFecha,
            this.ColumnCodigo,
            this.ColumnDetalle,
            this.ColumnDebe,
            this.ColumnHaber});
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePartidas.DefaultCellStyle = dataGridViewCellStyle48;
            this.tablePartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePartidas.EnableHeadersVisualStyles = false;
            this.tablePartidas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablePartidas.Location = new System.Drawing.Point(0, 0);
            this.tablePartidas.Name = "tablePartidas";
            this.tablePartidas.ReadOnly = true;
            this.tablePartidas.RowHeadersVisible = false;
            this.tablePartidas.RowHeadersWidth = 40;
            this.tablePartidas.RowTemplate.Height = 40;
            this.tablePartidas.RowTemplate.ReadOnly = true;
            this.tablePartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablePartidas.Size = new System.Drawing.Size(912, 185);
            this.tablePartidas.TabIndex = 2;
            this.tablePartidas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tablePartidas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablePartidas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablePartidas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablePartidas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablePartidas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablePartidas.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tablePartidas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablePartidas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.tablePartidas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablePartidas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablePartidas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablePartidas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablePartidas.ThemeStyle.HeaderStyle.Height = 40;
            this.tablePartidas.ThemeStyle.ReadOnly = true;
            this.tablePartidas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablePartidas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablePartidas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tablePartidas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablePartidas.ThemeStyle.RowsStyle.Height = 40;
            this.tablePartidas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablePartidas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.FillWeight = 50F;
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.FillWeight = 60F;
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnDetalle
            // 
            this.ColumnDetalle.FillWeight = 230F;
            this.ColumnDetalle.HeaderText = "Detalle";
            this.ColumnDetalle.Name = "ColumnDetalle";
            this.ColumnDetalle.ReadOnly = true;
            // 
            // ColumnDebe
            // 
            this.ColumnDebe.FillWeight = 80F;
            this.ColumnDebe.HeaderText = "Debe";
            this.ColumnDebe.Name = "ColumnDebe";
            this.ColumnDebe.ReadOnly = true;
            // 
            // ColumnHaber
            // 
            this.ColumnHaber.FillWeight = 80F;
            this.ColumnHaber.HeaderText = "Haber";
            this.ColumnHaber.Name = "ColumnHaber";
            this.ColumnHaber.ReadOnly = true;
            // 
            // AgregarPartidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 776);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.cbCuenta);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.cbTipoTransaccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPartida);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1006, 773);
            this.Name = "AgregarPartidaForm";
            this.Text = "AgregarPartidaForm";
            this.panelTop.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePartidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.Licensing licensing1;
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
        private FontAwesome.Sharp.IconButton btnRestoreWindow;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnExit;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaRadioButton rbDebito;
        private Guna.UI.WinForms.GunaRadioButton rbCredito;
        private Guna.UI.WinForms.GunaComboBox cbCuenta;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaRadioButton rbIncluido;
        private Guna.UI.WinForms.GunaRadioButton rbMasIva;
        private Guna.UI.WinForms.GunaRadioButton rbExcento;
        private Guna.UI.WinForms.GunaDateTimePicker dpFecha;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtBuscar;
        private Guna.UI.WinForms.GunaTextBox txtDescripcion;
        private Guna.UI.WinForms.GunaTextBox txtMonto;
        private Guna.UI.WinForms.GunaComboBox cbTipoTransaccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPartida;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnAgregarPartida;
        private FontAwesome.Sharp.IconButton btnEditarPartida;
        private FontAwesome.Sharp.IconButton btnNuevaCuenta;
        private FontAwesome.Sharp.IconButton btnEliminarCuenta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView tablePartidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHaber;
    }
}