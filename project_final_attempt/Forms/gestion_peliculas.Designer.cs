namespace project_final_attempt.Forms
{
    partial class gestion_peliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestion_peliculas));
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.peliculas = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.insidePanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnActualizar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnEditar = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.btnEliminar = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.btnBuscar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnEnviar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtPersonajes = new System.Windows.Forms.ListBox();
            this.txtMonto = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtDirectores = new System.Windows.Forms.ListBox();
            this.txtPresentacion = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtUniverso = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtNombre = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtBuscar = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnRegresar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.peliculas.SuspendLayout();
            this.insidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // peliculas
            // 
            this.peliculas.Controls.Add(this.insidePanel);
            this.peliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peliculas.Location = new System.Drawing.Point(0, 0);
            this.peliculas.Name = "peliculas";
            this.peliculas.Size = new System.Drawing.Size(1036, 723);
            this.peliculas.TabIndex = 0;
            // 
            // insidePanel
            // 
            this.insidePanel.Controls.Add(this.btnActualizar);
            this.insidePanel.Controls.Add(this.btnEditar);
            this.insidePanel.Controls.Add(this.btnEliminar);
            this.insidePanel.Controls.Add(this.btnBuscar);
            this.insidePanel.Controls.Add(this.btnEnviar);
            this.insidePanel.Controls.Add(this.siticoneHtmlLabel6);
            this.insidePanel.Controls.Add(this.txtPersonajes);
            this.insidePanel.Controls.Add(this.txtMonto);
            this.insidePanel.Controls.Add(this.siticoneHtmlLabel4);
            this.insidePanel.Controls.Add(this.siticoneHtmlLabel3);
            this.insidePanel.Controls.Add(this.txtDirectores);
            this.insidePanel.Controls.Add(this.txtPresentacion);
            this.insidePanel.Controls.Add(this.siticoneHtmlLabel7);
            this.insidePanel.Controls.Add(this.txtUniverso);
            this.insidePanel.Controls.Add(this.siticoneHtmlLabel5);
            this.insidePanel.Controls.Add(this.siticoneHtmlLabel2);
            this.insidePanel.Controls.Add(this.txtNombre);
            this.insidePanel.Controls.Add(this.txtBuscar);
            this.insidePanel.Controls.Add(this.btnRegresar);
            this.insidePanel.Controls.Add(this.siticoneSeparator1);
            this.insidePanel.Location = new System.Drawing.Point(0, 0);
            this.insidePanel.Name = "insidePanel";
            this.insidePanel.Size = new System.Drawing.Size(1036, 723);
            this.insidePanel.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BorderRadius = 27;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizar.Enabled = false;
            this.btnActualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(329, 600);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(381, 92);
            this.btnActualizar.TabIndex = 54;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.Enabled = false;
            this.btnEditar.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEditar.Location = new System.Drawing.Point(727, 610);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnEditar.Size = new System.Drawing.Size(70, 70);
            this.btnEditar.TabIndex = 53;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FillColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageSize = new System.Drawing.Size(43, 43);
            this.btnEliminar.Location = new System.Drawing.Point(239, 610);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnEliminar.Size = new System.Drawing.Size(70, 70);
            this.btnEliminar.TabIndex = 52;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageSize = new System.Drawing.Size(28, 28);
            this.btnBuscar.Location = new System.Drawing.Point(940, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 72);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BorderRadius = 27;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnviar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnviar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnviar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnviar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(329, 600);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(381, 92);
            this.btnEnviar.TabIndex = 50;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // siticoneHtmlLabel6
            // 
            this.siticoneHtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel6.Location = new System.Drawing.Point(387, 382);
            this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            this.siticoneHtmlLabel6.Size = new System.Drawing.Size(194, 27);
            this.siticoneHtmlLabel6.TabIndex = 49;
            this.siticoneHtmlLabel6.Text = "Personajes de la película";
            this.siticoneHtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPersonajes
            // 
            this.txtPersonajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtPersonajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonajes.ForeColor = System.Drawing.Color.Silver;
            this.txtPersonajes.FormattingEnabled = true;
            this.txtPersonajes.ItemHeight = 25;
            this.txtPersonajes.Location = new System.Drawing.Point(384, 415);
            this.txtPersonajes.Name = "txtPersonajes";
            this.txtPersonajes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.txtPersonajes.Size = new System.Drawing.Size(267, 125);
            this.txtPersonajes.Sorted = true;
            this.txtPersonajes.TabIndex = 48;
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
            this.txtMonto.Location = new System.Drawing.Point(29, 415);
            this.txtMonto.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(300, 37);
            this.txtMonto.TabIndex = 47;
            this.txtMonto.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtMonto.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(39, 382);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(146, 27);
            this.siticoneHtmlLabel4.TabIndex = 46;
            this.siticoneHtmlLabel4.Text = "Monto recaudado";
            this.siticoneHtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(699, 382);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(190, 27);
            this.siticoneHtmlLabel3.TabIndex = 45;
            this.siticoneHtmlLabel3.Text = "Directores de la película";
            this.siticoneHtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDirectores
            // 
            this.txtDirectores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtDirectores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDirectores.ForeColor = System.Drawing.Color.Silver;
            this.txtDirectores.FormattingEnabled = true;
            this.txtDirectores.ItemHeight = 25;
            this.txtDirectores.Items.AddRange(new object[] {
            "Abraham",
            "Andrés",
            "Felipe",
            "German",
            "Jose",
            "Luis",
            "Pastor",
            "Pedro"});
            this.txtDirectores.Location = new System.Drawing.Point(700, 415);
            this.txtDirectores.Name = "txtDirectores";
            this.txtDirectores.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.txtDirectores.Size = new System.Drawing.Size(309, 125);
            this.txtDirectores.Sorted = true;
            this.txtDirectores.TabIndex = 44;
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.BackColor = System.Drawing.Color.Transparent;
            this.txtPresentacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtPresentacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPresentacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtPresentacion.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtPresentacion.FocusedState.UpDownButtonFillColor = System.Drawing.Color.Transparent;
            this.txtPresentacion.FocusedState.UpDownButtonForeColor = System.Drawing.Color.Transparent;
            this.txtPresentacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPresentacion.ForeColor = System.Drawing.Color.Gray;
            this.txtPresentacion.Location = new System.Drawing.Point(373, 222);
            this.txtPresentacion.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.txtPresentacion.Minimum = new decimal(new int[] {
            1951,
            0,
            0,
            0});
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(300, 37);
            this.txtPresentacion.TabIndex = 43;
            this.txtPresentacion.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtPresentacion.UpDownButtonForeColor = System.Drawing.Color.White;
            this.txtPresentacion.Value = new decimal(new int[] {
            1951,
            0,
            0,
            0});
            // 
            // siticoneHtmlLabel7
            // 
            this.siticoneHtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel7.Location = new System.Drawing.Point(384, 182);
            this.siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            this.siticoneHtmlLabel7.Size = new System.Drawing.Size(167, 27);
            this.siticoneHtmlLabel7.TabIndex = 42;
            this.siticoneHtmlLabel7.Text = "Año de presentación";
            this.siticoneHtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUniverso
            // 
            this.txtUniverso.BackColor = System.Drawing.Color.Transparent;
            this.txtUniverso.BorderColor = System.Drawing.Color.Transparent;
            this.txtUniverso.BorderRadius = 15;
            this.txtUniverso.BorderThickness = 0;
            this.txtUniverso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtUniverso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUniverso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.txtUniverso.FocusedColor = System.Drawing.Color.Transparent;
            this.txtUniverso.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtUniverso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUniverso.ForeColor = System.Drawing.Color.Gray;
            this.txtUniverso.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtUniverso.ItemHeight = 30;
            this.txtUniverso.Items.AddRange(new object[] {
            "Marvel",
            "DC"});
            this.txtUniverso.Location = new System.Drawing.Point(696, 222);
            this.txtUniverso.Name = "txtUniverso";
            this.txtUniverso.Size = new System.Drawing.Size(313, 36);
            this.txtUniverso.TabIndex = 41;
            this.txtUniverso.SelectedIndexChanged += new System.EventHandler(this.txtUniverso_SelectedIndexChanged);
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(700, 182);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(178, 27);
            this.siticoneHtmlLabel5.TabIndex = 40;
            this.siticoneHtmlLabel5.Text = "Universo de la Película";
            this.siticoneHtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(39, 182);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(176, 27);
            this.siticoneHtmlLabel2.TabIndex = 39;
            this.siticoneHtmlLabel2.Text = "Nombre de la película";
            this.siticoneHtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Animated = true;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Location = new System.Drawing.Point(37, 222);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(300, 37);
            this.txtNombre.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.txtNombre.TabIndex = 38;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Animated = true;
            this.txtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.IconRight = ((System.Drawing.Image)(resources.GetObject("txtBuscar.IconRight")));
            this.txtBuscar.Location = new System.Drawing.Point(561, 27);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "Buscar Película";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(447, 72);
            this.txtBuscar.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.txtBuscar.TabIndex = 37;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRegresar.Location = new System.Drawing.Point(23, 13);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(74, 83);
            this.btnRegresar.TabIndex = 36;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Location = new System.Drawing.Point(24, 113);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(986, 13);
            this.siticoneSeparator1.TabIndex = 34;
            // 
            // gestion_peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1036, 723);
            this.Controls.Add(this.peliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestion_peliculas";
            this.Text = "gestion_peliculas";
            this.peliculas.ResumeLayout(false);
            this.insidePanel.ResumeLayout(false);
            this.insidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel peliculas;
        private Siticone.Desktop.UI.WinForms.SiticonePanel insidePanel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtBuscar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnRegresar;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private ListBox txtDirectores;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown txtPresentacion;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox txtUniverso;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNombre;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown txtMonto;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
        private ListBox txtPersonajes;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnEnviar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnBuscar;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnEditar;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnEliminar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnActualizar;
    }
}