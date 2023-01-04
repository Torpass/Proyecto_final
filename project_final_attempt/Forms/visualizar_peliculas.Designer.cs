namespace project_final_attempt.Forms
{
    partial class visualizar_peliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visualizar_peliculas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.insidePanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.ContenedorYear = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnBuscarYear = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.year_2 = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.year_1 = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.btnReiniciar = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.ContenedorPersonaje = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.btnPersonaje = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.ContenedorUniverso = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.btnUniverso = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.ContenedorRecaudo = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnBuscarMonto = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.txtMonto = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtBuscar = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.DataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Universo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Directores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recaudacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personajes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insidePanel.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.ContenedorYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.year_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_1)).BeginInit();
            this.ContenedorPersonaje.SuspendLayout();
            this.ContenedorUniverso.SuspendLayout();
            this.ContenedorRecaudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // insidePanel
            // 
            this.insidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.insidePanel.Controls.Add(this.siticonePanel1);
            this.insidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insidePanel.Location = new System.Drawing.Point(0, 0);
            this.insidePanel.Name = "insidePanel";
            this.insidePanel.Size = new System.Drawing.Size(1036, 723);
            this.insidePanel.TabIndex = 2;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.ContenedorYear);
            this.siticonePanel1.Controls.Add(this.btnReiniciar);
            this.siticonePanel1.Controls.Add(this.ContenedorPersonaje);
            this.siticonePanel1.Controls.Add(this.ContenedorUniverso);
            this.siticonePanel1.Controls.Add(this.ContenedorRecaudo);
            this.siticonePanel1.Controls.Add(this.txtBuscar);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel5);
            this.siticonePanel1.Controls.Add(this.DataGridView);
            this.siticonePanel1.Location = new System.Drawing.Point(-4, -2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(1044, 727);
            this.siticonePanel1.TabIndex = 2;
            // 
            // ContenedorYear
            // 
            this.ContenedorYear.Controls.Add(this.btnBuscarYear);
            this.ContenedorYear.Controls.Add(this.siticoneHtmlLabel1);
            this.ContenedorYear.Controls.Add(this.year_2);
            this.ContenedorYear.Controls.Add(this.year_1);
            this.ContenedorYear.Controls.Add(this.siticoneHtmlLabel4);
            this.ContenedorYear.Location = new System.Drawing.Point(25, 97);
            this.ContenedorYear.Name = "ContenedorYear";
            this.ContenedorYear.Size = new System.Drawing.Size(297, 76);
            this.ContenedorYear.TabIndex = 32;
            this.ContenedorYear.Visible = false;
            // 
            // btnBuscarYear
            // 
            this.btnBuscarYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarYear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarYear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarYear.FillColor = System.Drawing.Color.Red;
            this.btnBuscarYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarYear.ForeColor = System.Drawing.Color.White;
            this.btnBuscarYear.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarYear.Image")));
            this.btnBuscarYear.Location = new System.Drawing.Point(243, 35);
            this.btnBuscarYear.Name = "btnBuscarYear";
            this.btnBuscarYear.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnBuscarYear.Size = new System.Drawing.Size(42, 36);
            this.btnBuscarYear.TabIndex = 30;
            this.btnBuscarYear.Click += new System.EventHandler(this.btnBuscarYear_Click);
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(107, 40);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(12, 27);
            this.siticoneHtmlLabel1.TabIndex = 20;
            this.siticoneHtmlLabel1.Text = "a";
            this.siticoneHtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // year_2
            // 
            this.year_2.BackColor = System.Drawing.Color.Transparent;
            this.year_2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.year_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.year_2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.year_2.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.year_2.FocusedState.UpDownButtonFillColor = System.Drawing.Color.Transparent;
            this.year_2.FocusedState.UpDownButtonForeColor = System.Drawing.Color.Transparent;
            this.year_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.year_2.ForeColor = System.Drawing.Color.Gray;
            this.year_2.Location = new System.Drawing.Point(144, 35);
            this.year_2.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.year_2.Minimum = new decimal(new int[] {
            1953,
            0,
            0,
            0});
            this.year_2.Name = "year_2";
            this.year_2.Size = new System.Drawing.Size(93, 37);
            this.year_2.TabIndex = 24;
            this.year_2.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.year_2.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // year_1
            // 
            this.year_1.BackColor = System.Drawing.Color.Transparent;
            this.year_1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.year_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.year_1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.year_1.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.year_1.FocusedState.UpDownButtonFillColor = System.Drawing.Color.Transparent;
            this.year_1.FocusedState.UpDownButtonForeColor = System.Drawing.Color.Transparent;
            this.year_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.year_1.ForeColor = System.Drawing.Color.Gray;
            this.year_1.Location = new System.Drawing.Point(3, 36);
            this.year_1.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.year_1.Minimum = new decimal(new int[] {
            1953,
            0,
            0,
            0});
            this.year_1.Name = "year_1";
            this.year_1.Size = new System.Drawing.Size(93, 37);
            this.year_1.TabIndex = 23;
            this.year_1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.year_1.Value = new decimal(new int[] {
            1953,
            0,
            0,
            0});
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(3, 7);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(241, 27);
            this.siticoneHtmlLabel4.TabIndex = 22;
            this.siticoneHtmlLabel4.Text = "Buscar Peliculas entre los años\r\n";
            this.siticoneHtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReiniciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReiniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReiniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReiniciar.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnReiniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnReiniciar.Image")));
            this.btnReiniciar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReiniciar.Location = new System.Drawing.Point(968, 113);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnReiniciar.Size = new System.Drawing.Size(60, 60);
            this.btnReiniciar.TabIndex = 31;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // ContenedorPersonaje
            // 
            this.ContenedorPersonaje.Controls.Add(this.siticoneHtmlLabel2);
            this.ContenedorPersonaje.Controls.Add(this.btnPersonaje);
            this.ContenedorPersonaje.Location = new System.Drawing.Point(25, 94);
            this.ContenedorPersonaje.Name = "ContenedorPersonaje";
            this.ContenedorPersonaje.Size = new System.Drawing.Size(309, 83);
            this.ContenedorPersonaje.TabIndex = 30;
            this.ContenedorPersonaje.Visible = false;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(3, 3);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(241, 27);
            this.siticoneHtmlLabel2.TabIndex = 29;
            this.siticoneHtmlLabel2.Text = "Buscar peliculas por personaje\r\n\r\n";
            this.siticoneHtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPersonaje
            // 
            this.btnPersonaje.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonaje.BorderColor = System.Drawing.Color.Transparent;
            this.btnPersonaje.BorderRadius = 15;
            this.btnPersonaje.BorderThickness = 0;
            this.btnPersonaje.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btnPersonaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnPersonaje.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.btnPersonaje.FocusedColor = System.Drawing.Color.Transparent;
            this.btnPersonaje.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPersonaje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPersonaje.ForeColor = System.Drawing.Color.Gray;
            this.btnPersonaje.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPersonaje.ItemHeight = 30;
            this.btnPersonaje.Location = new System.Drawing.Point(3, 36);
            this.btnPersonaje.Name = "btnPersonaje";
            this.btnPersonaje.Size = new System.Drawing.Size(294, 36);
            this.btnPersonaje.TabIndex = 33;
            this.btnPersonaje.SelectedIndexChanged += new System.EventHandler(this.btnPersonaje_SelectedIndexChanged);
            // 
            // ContenedorUniverso
            // 
            this.ContenedorUniverso.Controls.Add(this.siticoneHtmlLabel3);
            this.ContenedorUniverso.Controls.Add(this.btnUniverso);
            this.ContenedorUniverso.Location = new System.Drawing.Point(29, 94);
            this.ContenedorUniverso.Name = "ContenedorUniverso";
            this.ContenedorUniverso.Size = new System.Drawing.Size(297, 76);
            this.ContenedorUniverso.TabIndex = 29;
            this.ContenedorUniverso.Visible = false;
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(3, 3);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(256, 27);
            this.siticoneHtmlLabel3.TabIndex = 29;
            this.siticoneHtmlLabel3.Text = "Buscar peliculas por su Universo\r\n";
            this.siticoneHtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnUniverso
            // 
            this.btnUniverso.BackColor = System.Drawing.Color.Transparent;
            this.btnUniverso.BorderColor = System.Drawing.Color.Transparent;
            this.btnUniverso.BorderRadius = 15;
            this.btnUniverso.BorderThickness = 0;
            this.btnUniverso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btnUniverso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnUniverso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.btnUniverso.FocusedColor = System.Drawing.Color.Transparent;
            this.btnUniverso.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnUniverso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUniverso.ForeColor = System.Drawing.Color.Gray;
            this.btnUniverso.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUniverso.ItemHeight = 30;
            this.btnUniverso.Items.AddRange(new object[] {
            "Marvel",
            "DC"});
            this.btnUniverso.Location = new System.Drawing.Point(3, 36);
            this.btnUniverso.Name = "btnUniverso";
            this.btnUniverso.Size = new System.Drawing.Size(188, 36);
            this.btnUniverso.TabIndex = 28;
            this.btnUniverso.SelectedIndexChanged += new System.EventHandler(this.btnUniverso_SelectedIndexChanged);
            // 
            // ContenedorRecaudo
            // 
            this.ContenedorRecaudo.Controls.Add(this.btnBuscarMonto);
            this.ContenedorRecaudo.Controls.Add(this.txtMonto);
            this.ContenedorRecaudo.Controls.Add(this.siticoneHtmlLabel7);
            this.ContenedorRecaudo.Location = new System.Drawing.Point(25, 97);
            this.ContenedorRecaudo.Name = "ContenedorRecaudo";
            this.ContenedorRecaudo.Size = new System.Drawing.Size(373, 76);
            this.ContenedorRecaudo.TabIndex = 19;
            this.ContenedorRecaudo.Visible = false;
            // 
            // btnBuscarMonto
            // 
            this.btnBuscarMonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMonto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarMonto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarMonto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarMonto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarMonto.FillColor = System.Drawing.Color.Red;
            this.btnBuscarMonto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarMonto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMonto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarMonto.Image")));
            this.btnBuscarMonto.Location = new System.Drawing.Point(309, 36);
            this.btnBuscarMonto.Name = "btnBuscarMonto";
            this.btnBuscarMonto.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnBuscarMonto.Size = new System.Drawing.Size(42, 36);
            this.btnBuscarMonto.TabIndex = 30;
            this.btnBuscarMonto.Click += new System.EventHandler(this.btnBuscarMonto_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.Transparent;
            this.txtMonto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.DecimalPlaces = 2;
            this.txtMonto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtMonto.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtMonto.FocusedState.UpDownButtonFillColor = System.Drawing.Color.Transparent;
            this.txtMonto.FocusedState.UpDownButtonForeColor = System.Drawing.Color.Transparent;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonto.ForeColor = System.Drawing.Color.Gray;
            this.txtMonto.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtMonto.Location = new System.Drawing.Point(3, 36);
            this.txtMonto.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(286, 37);
            this.txtMonto.TabIndex = 23;
            this.txtMonto.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            // 
            // siticoneHtmlLabel7
            // 
            this.siticoneHtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel7.Location = new System.Drawing.Point(3, 3);
            this.siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            this.siticoneHtmlLabel7.Size = new System.Drawing.Size(365, 27);
            this.siticoneHtmlLabel7.TabIndex = 22;
            this.siticoneHtmlLabel7.Text = "Buscar peliculas que hayan recaudado más de\r\n";
            this.siticoneHtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BorderColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BorderRadius = 15;
            this.txtBuscar.BorderThickness = 0;
            this.txtBuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.txtBuscar.FocusedColor = System.Drawing.Color.Transparent;
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtBuscar.ItemHeight = 30;
            this.txtBuscar.Items.AddRange(new object[] {
            "Año de presentancion",
            "Universo",
            "Monto recaudado",
            "Personaje"});
            this.txtBuscar.Location = new System.Drawing.Point(16, 51);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(254, 36);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.SelectedIndexChanged += new System.EventHandler(this.txtBuscar_SelectedIndexChanged);
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(25, 18);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(125, 27);
            this.siticoneHtmlLabel5.TabIndex = 17;
            this.siticoneHtmlLabel5.Text = "Buscar Peliculas";
            this.siticoneHtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.ColumnHeadersHeight = 65;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Presentacion,
            this.Universo,
            this.Directores,
            this.Recaudacion,
            this.Personajes});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.Location = new System.Drawing.Point(21, 179);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.RowTemplate.Height = 50;
            this.DataGridView.Size = new System.Drawing.Size(1003, 520);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView.ThemeStyle.HeaderStyle.Height = 65;
            this.DataGridView.ThemeStyle.ReadOnly = true;
            this.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.RowsStyle.Height = 50;
            this.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Presentacion
            // 
            this.Presentacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Presentacion.HeaderText = "Año Presentacion";
            this.Presentacion.MinimumWidth = 8;
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.ReadOnly = true;
            // 
            // Universo
            // 
            this.Universo.HeaderText = "Universo";
            this.Universo.MinimumWidth = 8;
            this.Universo.Name = "Universo";
            this.Universo.ReadOnly = true;
            // 
            // Directores
            // 
            this.Directores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Directores.HeaderText = "Directores";
            this.Directores.MinimumWidth = 8;
            this.Directores.Name = "Directores";
            this.Directores.ReadOnly = true;
            this.Directores.Width = 8;
            // 
            // Recaudacion
            // 
            this.Recaudacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Recaudacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Recaudacion.HeaderText = "Recaudacion";
            this.Recaudacion.MinimumWidth = 8;
            this.Recaudacion.Name = "Recaudacion";
            this.Recaudacion.ReadOnly = true;
            // 
            // Personajes
            // 
            this.Personajes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Personajes.HeaderText = "Personajes";
            this.Personajes.MinimumWidth = 8;
            this.Personajes.Name = "Personajes";
            this.Personajes.ReadOnly = true;
            this.Personajes.Width = 8;
            // 
            // visualizar_peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 723);
            this.Controls.Add(this.insidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "visualizar_peliculas";
            this.Text = "visualizar_peliculas";
            this.insidePanel.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ContenedorYear.ResumeLayout(false);
            this.ContenedorYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.year_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_1)).EndInit();
            this.ContenedorPersonaje.ResumeLayout(false);
            this.ContenedorPersonaje.PerformLayout();
            this.ContenedorUniverso.ResumeLayout(false);
            this.ContenedorUniverso.PerformLayout();
            this.ContenedorRecaudo.ResumeLayout(false);
            this.ContenedorRecaudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel insidePanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnReiniciar;
        private FlowLayoutPanel ContenedorUniverso;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox btnUniverso;
        private Siticone.Desktop.UI.WinForms.SiticonePanel ContenedorRecaudo;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnBuscarMonto;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown txtMonto;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox txtBuscar;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView DataGridView;
        private Siticone.Desktop.UI.WinForms.SiticonePanel ContenedorYear;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnBuscarYear;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown year_2;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown year_1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private FlowLayoutPanel ContenedorPersonaje;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Presentacion;
        private DataGridViewTextBoxColumn Universo;
        private DataGridViewTextBoxColumn Directores;
        private DataGridViewTextBoxColumn Recaudacion;
        private DataGridViewTextBoxColumn Personajes;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox btnPersonaje;
    }
}