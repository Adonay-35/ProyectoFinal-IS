namespace SistemasContables.Views
{
    partial class BalanceGeneralForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblActivos = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableActivos = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnActivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidadActivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePasivosCapital = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnPasivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidadPasivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainerLbl = new System.Windows.Forms.SplitContainer();
            this.lblPasivosCapital = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePasivosCapital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLbl)).BeginInit();
            this.splitContainerLbl.Panel1.SuspendLayout();
            this.splitContainerLbl.Panel2.SuspendLayout();
            this.splitContainerLbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnExportar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.IconSize = 40;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(73, 143);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnExportar.MinimumSize = new System.Drawing.Size(140, 50);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(140, 50);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(368, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 33);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Balance General";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(174, 69);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(600, 32);
            this.lblPeriodo.TabIndex = 17;
            this.lblPeriodo.Text = "texto periodo";
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActivos
            // 
            this.lblActivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActivos.BackColor = System.Drawing.Color.White;
            this.lblActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.lblActivos.Location = new System.Drawing.Point(154, 0);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(228, 64);
            this.lblActivos.TabIndex = 18;
            this.lblActivos.Text = "total capital";
            this.lblActivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this.btnExportar;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(73, 209);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tableActivos);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tablePasivosCapital);
            this.splitContainer.Size = new System.Drawing.Size(800, 389);
            this.splitContainer.SplitterDistance = 380;
            this.splitContainer.SplitterWidth = 40;
            this.splitContainer.TabIndex = 36;
            // 
            // tableActivos
            // 
            this.tableActivos.AllowUserToAddRows = false;
            this.tableActivos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.tableActivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tableActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableActivos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableActivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableActivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableActivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(88)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tableActivos.ColumnHeadersHeight = 40;
            this.tableActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnActivos,
            this.ColumnCantidadActivos});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableActivos.DefaultCellStyle = dataGridViewCellStyle9;
            this.tableActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableActivos.EnableHeadersVisualStyles = false;
            this.tableActivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableActivos.Location = new System.Drawing.Point(0, 0);
            this.tableActivos.Name = "tableActivos";
            this.tableActivos.ReadOnly = true;
            this.tableActivos.RowHeadersVisible = false;
            this.tableActivos.RowHeadersWidth = 40;
            this.tableActivos.RowTemplate.Height = 40;
            this.tableActivos.RowTemplate.ReadOnly = true;
            this.tableActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableActivos.Size = new System.Drawing.Size(380, 389);
            this.tableActivos.TabIndex = 36;
            this.tableActivos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tableActivos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableActivos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableActivos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableActivos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableActivos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableActivos.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tableActivos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableActivos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.tableActivos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableActivos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableActivos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableActivos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableActivos.ThemeStyle.HeaderStyle.Height = 40;
            this.tableActivos.ThemeStyle.ReadOnly = true;
            this.tableActivos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableActivos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableActivos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableActivos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableActivos.ThemeStyle.RowsStyle.Height = 40;
            this.tableActivos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableActivos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColumnActivos
            // 
            this.ColumnActivos.FillWeight = 135F;
            this.ColumnActivos.HeaderText = "Activos";
            this.ColumnActivos.Name = "ColumnActivos";
            this.ColumnActivos.ReadOnly = true;
            // 
            // ColumnCantidadActivos
            // 
            this.ColumnCantidadActivos.FillWeight = 65F;
            this.ColumnCantidadActivos.HeaderText = "Cantidad ($)";
            this.ColumnCantidadActivos.Name = "ColumnCantidadActivos";
            this.ColumnCantidadActivos.ReadOnly = true;
            // 
            // tablePasivosCapital
            // 
            this.tablePasivosCapital.AllowUserToAddRows = false;
            this.tablePasivosCapital.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.tablePasivosCapital.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tablePasivosCapital.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePasivosCapital.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablePasivosCapital.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablePasivosCapital.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablePasivosCapital.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(88)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePasivosCapital.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tablePasivosCapital.ColumnHeadersHeight = 40;
            this.tablePasivosCapital.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPasivos,
            this.ColumnCantidadPasivos});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePasivosCapital.DefaultCellStyle = dataGridViewCellStyle12;
            this.tablePasivosCapital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePasivosCapital.EnableHeadersVisualStyles = false;
            this.tablePasivosCapital.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablePasivosCapital.Location = new System.Drawing.Point(0, 0);
            this.tablePasivosCapital.Name = "tablePasivosCapital";
            this.tablePasivosCapital.ReadOnly = true;
            this.tablePasivosCapital.RowHeadersVisible = false;
            this.tablePasivosCapital.RowHeadersWidth = 40;
            this.tablePasivosCapital.RowTemplate.Height = 40;
            this.tablePasivosCapital.RowTemplate.ReadOnly = true;
            this.tablePasivosCapital.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablePasivosCapital.Size = new System.Drawing.Size(380, 389);
            this.tablePasivosCapital.TabIndex = 36;
            this.tablePasivosCapital.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tablePasivosCapital.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablePasivosCapital.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablePasivosCapital.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablePasivosCapital.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablePasivosCapital.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablePasivosCapital.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tablePasivosCapital.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablePasivosCapital.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.tablePasivosCapital.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablePasivosCapital.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablePasivosCapital.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablePasivosCapital.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablePasivosCapital.ThemeStyle.HeaderStyle.Height = 40;
            this.tablePasivosCapital.ThemeStyle.ReadOnly = true;
            this.tablePasivosCapital.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablePasivosCapital.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablePasivosCapital.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tablePasivosCapital.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablePasivosCapital.ThemeStyle.RowsStyle.Height = 40;
            this.tablePasivosCapital.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablePasivosCapital.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColumnPasivos
            // 
            this.ColumnPasivos.FillWeight = 135F;
            this.ColumnPasivos.HeaderText = "Pasivos y Patrimonio";
            this.ColumnPasivos.Name = "ColumnPasivos";
            this.ColumnPasivos.ReadOnly = true;
            // 
            // ColumnCantidadPasivos
            // 
            this.ColumnCantidadPasivos.FillWeight = 65F;
            this.ColumnCantidadPasivos.HeaderText = "Cantidad ($)";
            this.ColumnCantidadPasivos.Name = "ColumnCantidadPasivos";
            this.ColumnCantidadPasivos.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 64);
            this.label1.TabIndex = 37;
            this.label1.Text = "Total Activos = ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 64);
            this.label2.TabIndex = 39;
            this.label2.Text = "Total Pasivos + Patrimonio = ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainerLbl
            // 
            this.splitContainerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerLbl.Location = new System.Drawing.Point(73, 615);
            this.splitContainerLbl.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerLbl.Name = "splitContainerLbl";
            // 
            // splitContainerLbl.Panel1
            // 
            this.splitContainerLbl.Panel1.Controls.Add(this.label1);
            this.splitContainerLbl.Panel1.Controls.Add(this.lblActivos);
            // 
            // splitContainerLbl.Panel2
            // 
            this.splitContainerLbl.Panel2.Controls.Add(this.lblPasivosCapital);
            this.splitContainerLbl.Panel2.Controls.Add(this.label2);
            this.splitContainerLbl.Size = new System.Drawing.Size(800, 64);
            this.splitContainerLbl.SplitterDistance = 380;
            this.splitContainerLbl.SplitterWidth = 40;
            this.splitContainerLbl.TabIndex = 40;
            // 
            // lblPasivosCapital
            // 
            this.lblPasivosCapital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPasivosCapital.BackColor = System.Drawing.Color.White;
            this.lblPasivosCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasivosCapital.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.lblPasivosCapital.Location = new System.Drawing.Point(159, 0);
            this.lblPasivosCapital.Name = "lblPasivosCapital";
            this.lblPasivosCapital.Size = new System.Drawing.Size(185, 64);
            this.lblPasivosCapital.TabIndex = 40;
            this.lblPasivosCapital.Text = "total pasivos + capital";
            this.lblPasivosCapital.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.Location = new System.Drawing.Point(228, 115);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(500, 50);
            this.lblSubTitulo.TabIndex = 41;
            this.lblSubTitulo.Text = "EXPRESADO EN DOLARES DE LOS ESTADOS UNIDOS DE NORTEAMERICA";
            this.lblSubTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BalanceGeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 710);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.splitContainerLbl);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BalanceGeneralForm";
            this.Text = "BalanceGeneralForm";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePasivosCapital)).EndInit();
            this.splitContainerLbl.Panel1.ResumeLayout(false);
            this.splitContainerLbl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLbl)).EndInit();
            this.splitContainerLbl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPeriodo;
        private FontAwesome.Sharp.IconButton btnExportar;
        private System.Windows.Forms.Label lblActivos;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Guna.UI.WinForms.GunaDataGridView tableActivos;
        private Guna.UI.WinForms.GunaDataGridView tablePasivosCapital;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidadActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPasivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidadPasivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainerLbl;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblPasivosCapital;
    }
}