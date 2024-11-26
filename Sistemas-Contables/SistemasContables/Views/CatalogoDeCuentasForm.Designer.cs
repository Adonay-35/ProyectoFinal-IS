
namespace SistemasContables.Views
{
    partial class CatalogoDeCuentasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableCatalogoDeCuentas = new Guna.UI.WinForms.GunaDataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textCodigoCuenta = new Guna.UI.WinForms.GunaTextBox();
            this.textNombreCuenta = new Guna.UI.WinForms.GunaTextBox();
            this.cbTipoCuenta = new Guna.UI.WinForms.GunaComboBox();
            this.textSeleccionarArchivo = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeleccionarArchivo = new Guna.UI.WinForms.GunaButton();
            this.btnAgregarCuenta = new FontAwesome.Sharp.IconButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnCargarCatalogo = new FontAwesome.Sharp.IconButton();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaImageReplaceColor1 = new Guna.UI.WinForms.GunaImageReplaceColor(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ColumnIdCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableCatalogoDeCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableCatalogoDeCuentas
            // 
            this.tableCatalogoDeCuentas.AllowUserToAddRows = false;
            this.tableCatalogoDeCuentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tableCatalogoDeCuentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableCatalogoDeCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableCatalogoDeCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableCatalogoDeCuentas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableCatalogoDeCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableCatalogoDeCuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableCatalogoDeCuentas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.tableCatalogoDeCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(88)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableCatalogoDeCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableCatalogoDeCuentas.ColumnHeadersHeight = 40;
            this.tableCatalogoDeCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdCuenta,
            this.Codigo,
            this.Cuenta,
            this.Nivel,
            this.Tipo,
            this.ColumnEdit,
            this.ColumnSelect});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableCatalogoDeCuentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableCatalogoDeCuentas.EnableHeadersVisualStyles = false;
            this.tableCatalogoDeCuentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableCatalogoDeCuentas.Location = new System.Drawing.Point(76, 310);
            this.tableCatalogoDeCuentas.Name = "tableCatalogoDeCuentas";
            this.tableCatalogoDeCuentas.RowHeadersVisible = false;
            this.tableCatalogoDeCuentas.RowHeadersWidth = 40;
            this.tableCatalogoDeCuentas.RowTemplate.Height = 40;
            this.tableCatalogoDeCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableCatalogoDeCuentas.Size = new System.Drawing.Size(800, 354);
            this.tableCatalogoDeCuentas.TabIndex = 36;
            this.tableCatalogoDeCuentas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tableCatalogoDeCuentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableCatalogoDeCuentas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableCatalogoDeCuentas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableCatalogoDeCuentas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableCatalogoDeCuentas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableCatalogoDeCuentas.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tableCatalogoDeCuentas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableCatalogoDeCuentas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.tableCatalogoDeCuentas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableCatalogoDeCuentas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableCatalogoDeCuentas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableCatalogoDeCuentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableCatalogoDeCuentas.ThemeStyle.HeaderStyle.Height = 40;
            this.tableCatalogoDeCuentas.ThemeStyle.ReadOnly = false;
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.Height = 40;
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableCatalogoDeCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableCatalogoDeCuentas_CellClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(324, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 33);
            this.lblTitulo.TabIndex = 37;
            this.lblTitulo.Text = "Catalogo de Cuentas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textCodigoCuenta
            // 
            this.textCodigoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.textCodigoCuenta.BaseColor = System.Drawing.Color.White;
            this.textCodigoCuenta.BorderColor = System.Drawing.Color.Silver;
            this.textCodigoCuenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCodigoCuenta.FocusedBaseColor = System.Drawing.Color.White;
            this.textCodigoCuenta.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.textCodigoCuenta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textCodigoCuenta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textCodigoCuenta.Location = new System.Drawing.Point(71, 185);
            this.textCodigoCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.textCodigoCuenta.Name = "textCodigoCuenta";
            this.textCodigoCuenta.PasswordChar = '\0';
            this.textCodigoCuenta.Radius = 5;
            this.textCodigoCuenta.Size = new System.Drawing.Size(164, 37);
            this.textCodigoCuenta.TabIndex = 0;
            this.textCodigoCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodigoCuenta_KeyPress);
            // 
            // textNombreCuenta
            // 
            this.textNombreCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNombreCuenta.BackColor = System.Drawing.Color.Transparent;
            this.textNombreCuenta.BaseColor = System.Drawing.Color.White;
            this.textNombreCuenta.BorderColor = System.Drawing.Color.Silver;
            this.textNombreCuenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNombreCuenta.FocusedBaseColor = System.Drawing.Color.White;
            this.textNombreCuenta.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.textNombreCuenta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textNombreCuenta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textNombreCuenta.Location = new System.Drawing.Point(251, 185);
            this.textNombreCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.textNombreCuenta.Name = "textNombreCuenta";
            this.textNombreCuenta.PasswordChar = '\0';
            this.textNombreCuenta.Radius = 5;
            this.textNombreCuenta.Size = new System.Drawing.Size(262, 37);
            this.textNombreCuenta.TabIndex = 1;
            // 
            // cbTipoCuenta
            // 
            this.cbTipoCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoCuenta.BaseColor = System.Drawing.Color.White;
            this.cbTipoCuenta.BorderColor = System.Drawing.Color.Silver;
            this.cbTipoCuenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCuenta.FocusedColor = System.Drawing.Color.Empty;
            this.cbTipoCuenta.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbTipoCuenta.ForeColor = System.Drawing.Color.Black;
            this.cbTipoCuenta.FormattingEnabled = true;
            this.cbTipoCuenta.Items.AddRange(new object[] {
            "Tipo de Saldo",
            "Deudor",
            "Acreedor"});
            this.cbTipoCuenta.Location = new System.Drawing.Point(526, 185);
            this.cbTipoCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoCuenta.Name = "cbTipoCuenta";
            this.cbTipoCuenta.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.cbTipoCuenta.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTipoCuenta.Size = new System.Drawing.Size(146, 33);
            this.cbTipoCuenta.StartIndex = 0;
            this.cbTipoCuenta.TabIndex = 3;
            // 
            // textSeleccionarArchivo
            // 
            this.textSeleccionarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSeleccionarArchivo.BackColor = System.Drawing.Color.Transparent;
            this.textSeleccionarArchivo.BaseColor = System.Drawing.Color.White;
            this.textSeleccionarArchivo.BorderColor = System.Drawing.Color.Silver;
            this.textSeleccionarArchivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSeleccionarArchivo.FocusedBaseColor = System.Drawing.Color.White;
            this.textSeleccionarArchivo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.textSeleccionarArchivo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textSeleccionarArchivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textSeleccionarArchivo.Location = new System.Drawing.Point(71, 257);
            this.textSeleccionarArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.textSeleccionarArchivo.Name = "textSeleccionarArchivo";
            this.textSeleccionarArchivo.PasswordChar = '\0';
            this.textSeleccionarArchivo.Radius = 5;
            this.textSeleccionarArchivo.Size = new System.Drawing.Size(344, 37);
            this.textSeleccionarArchivo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(69, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cargar catalogo desde un archivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(67, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 34);
            this.label2.TabIndex = 41;
            this.label2.Text = "Agregar Cuenta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarArchivo.AnimationHoverSpeed = 0.07F;
            this.btnSeleccionarArchivo.AnimationSpeed = 0.03F;
            this.btnSeleccionarArchivo.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarArchivo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSeleccionarArchivo.BorderColor = System.Drawing.Color.Black;
            this.btnSeleccionarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarArchivo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeleccionarArchivo.FocusedColor = System.Drawing.Color.Empty;
            this.btnSeleccionarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarArchivo.Image = global::SistemasContables.Properties.Resources.excel;
            this.btnSeleccionarArchivo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(431, 257);
            this.btnSeleccionarArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSeleccionarArchivo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSeleccionarArchivo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSeleccionarArchivo.OnHoverImage = null;
            this.btnSeleccionarArchivo.OnPressedColor = System.Drawing.Color.Black;
            this.btnSeleccionarArchivo.Radius = 5;
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(125, 35);
            this.btnSeleccionarArchivo.TabIndex = 2;
            this.btnSeleccionarArchivo.Text = "Explorar";
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAgregarCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCuenta.FlatAppearance.BorderSize = 0;
            this.btnAgregarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCuenta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCuenta.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregarCuenta.IconColor = System.Drawing.Color.White;
            this.btnAgregarCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCuenta.IconSize = 30;
            this.btnAgregarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCuenta.Location = new System.Drawing.Point(692, 185);
            this.btnAgregarCuenta.MinimumSize = new System.Drawing.Size(115, 35);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.Size = new System.Drawing.Size(177, 35);
            this.btnAgregarCuenta.TabIndex = 42;
            this.btnAgregarCuenta.Text = "Agregar cuenta";
            this.btnAgregarCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCuenta.UseVisualStyleBackColor = false;
            this.btnAgregarCuenta.Click += new System.EventHandler(this.btnAgregarCuenta_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.btnAgregarCuenta;
            // 
            // btnCargarCatalogo
            // 
            this.btnCargarCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCargarCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarCatalogo.FlatAppearance.BorderSize = 0;
            this.btnCargarCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnCargarCatalogo.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnCargarCatalogo.IconColor = System.Drawing.Color.White;
            this.btnCargarCatalogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarCatalogo.IconSize = 30;
            this.btnCargarCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarCatalogo.Location = new System.Drawing.Point(561, 257);
            this.btnCargarCatalogo.MinimumSize = new System.Drawing.Size(115, 35);
            this.btnCargarCatalogo.Name = "btnCargarCatalogo";
            this.btnCargarCatalogo.Size = new System.Drawing.Size(177, 35);
            this.btnCargarCatalogo.TabIndex = 43;
            this.btnCargarCatalogo.Text = "Cargar catalago";
            this.btnCargarCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarCatalogo.UseVisualStyleBackColor = false;
            this.btnCargarCatalogo.Click += new System.EventHandler(this.btnCargarCatalogo_Click);
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.btnCargarCatalogo;
            // 
            // gunaImageReplaceColor1
            // 
            this.gunaImageReplaceColor1.Image = null;
            this.gunaImageReplaceColor1.NewColor = System.Drawing.Color.Empty;
            this.gunaImageReplaceColor1.OldColor = System.Drawing.Color.White;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(67, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 34);
            this.label3.TabIndex = 44;
            this.label3.Text = "Codigo de la cuenta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(247, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 34);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nombre de la cuenta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(744, 259);
            this.btnEliminar.MinimumSize = new System.Drawing.Size(125, 35);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 35);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.btnEliminar;
            // 
            // ColumnIdCuenta
            // 
            this.ColumnIdCuenta.FillWeight = 50F;
            this.ColumnIdCuenta.HeaderText = "Id Cuenta";
            this.ColumnIdCuenta.Name = "ColumnIdCuenta";
            this.ColumnIdCuenta.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 50F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Cuenta
            // 
            this.Cuenta.FillWeight = 150F;
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 6;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            // 
            // Nivel
            // 
            this.Nivel.FillWeight = 25F;
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.MinimumWidth = 6;
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo de Saldo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.FillWeight = 25F;
            this.ColumnEdit.HeaderText = "";
            this.ColumnEdit.Image = global::SistemasContables.Properties.Resources.edit;
            this.ColumnEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.FillWeight = 25F;
            this.ColumnSelect.HeaderText = "";
            this.ColumnSelect.Name = "ColumnSelect";
            // 
            // CatalogoDeCuentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 710);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCargarCatalogo);
            this.Controls.Add(this.btnAgregarCuenta);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.textSeleccionarArchivo);
            this.Controls.Add(this.cbTipoCuenta);
            this.Controls.Add(this.textNombreCuenta);
            this.Controls.Add(this.textCodigoCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tableCatalogoDeCuentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CatalogoDeCuentasForm";
            this.Text = "CatalogoDeCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.tableCatalogoDeCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView tableCatalogoDeCuentas;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI.WinForms.GunaTextBox textCodigoCuenta;
        private Guna.UI.WinForms.GunaTextBox textNombreCuenta;
        private Guna.UI.WinForms.GunaTextBox textSeleccionarArchivo;
        private Guna.UI.WinForms.GunaButton btnSeleccionarArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox cbTipoCuenta;
        private FontAwesome.Sharp.IconButton btnAgregarCuenta;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private FontAwesome.Sharp.IconButton btnCargarCatalogo;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaImageReplaceColor gunaImageReplaceColor1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelect;
    }
}