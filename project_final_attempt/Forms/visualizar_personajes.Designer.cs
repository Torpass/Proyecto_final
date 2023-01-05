namespace project_final_attempt.Forms
{
    partial class visualizar_personajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visualizar_personajes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.insidePanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneCircleButton1 = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.btnRegresar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnReiniciar = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.ContenedorSexo = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.btnSexo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.ContenedorRol = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.btnRol = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.ContenedorEdades = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnBuscar = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.edad_2 = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.edad_1 = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtBuscar = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.DataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Universo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.insidePanel.SuspendLayout();
            this.ContenedorSexo.SuspendLayout();
            this.ContenedorRol.SuspendLayout();
            this.ContenedorEdades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edad_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edad_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // insidePanel
            // 
            this.insidePanel.AutoSize = true;
            this.insidePanel.Controls.Add(this.siticoneCircleButton1);
            this.insidePanel.Controls.Add(this.btnRegresar);
            this.insidePanel.Controls.Add(this.btnReiniciar);
            this.insidePanel.Controls.Add(this.ContenedorSexo);
            this.insidePanel.Controls.Add(this.ContenedorRol);
            this.insidePanel.Controls.Add(this.ContenedorEdades);
            this.insidePanel.Controls.Add(this.txtBuscar);
            this.insidePanel.Controls.Add(this.siticoneHtmlLabel5);
            this.insidePanel.Controls.Add(this.DataGridView);
            this.insidePanel.Location = new System.Drawing.Point(-3, -1);
            this.insidePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insidePanel.Name = "insidePanel";
            this.insidePanel.Size = new System.Drawing.Size(731, 436);
            this.insidePanel.TabIndex = 0;
            // 
            // siticoneCircleButton1
            // 
            this.siticoneCircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneCircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.siticoneCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneCircleButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton1.HoverState.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.siticoneCircleButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.siticoneCircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCircleButton1.Image")));
            this.siticoneCircleButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.siticoneCircleButton1.Location = new System.Drawing.Point(666, 7);
            this.siticoneCircleButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneCircleButton1.Name = "siticoneCircleButton1";
            this.siticoneCircleButton1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton1.Size = new System.Drawing.Size(51, 43);
            this.siticoneCircleButton1.TabIndex = 36;
            this.siticoneCircleButton1.Click += new System.EventHandler(this.siticoneCircleButton1_Click);
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
            this.btnRegresar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRegresar.Location = new System.Drawing.Point(15, 4);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(42, 43);
            this.btnRegresar.TabIndex = 33;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
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
            this.btnReiniciar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnReiniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnReiniciar.Image")));
            this.btnReiniciar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReiniciar.Location = new System.Drawing.Point(667, 58);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnReiniciar.Size = new System.Drawing.Size(50, 45);
            this.btnReiniciar.TabIndex = 31;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // ContenedorSexo
            // 
            this.ContenedorSexo.Controls.Add(this.siticoneHtmlLabel3);
            this.ContenedorSexo.Controls.Add(this.btnSexo);
            this.ContenedorSexo.Location = new System.Drawing.Point(207, 35);
            this.ContenedorSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContenedorSexo.Name = "ContenedorSexo";
            this.ContenedorSexo.Size = new System.Drawing.Size(174, 64);
            this.ContenedorSexo.TabIndex = 29;
            this.ContenedorSexo.Visible = false;
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(2, 2);
            this.siticoneHtmlLabel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(161, 17);
            this.siticoneHtmlLabel3.TabIndex = 29;
            this.siticoneHtmlLabel3.Text = "Buscar personajes por su Sexo";
            this.siticoneHtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSexo
            // 
            this.btnSexo.BackColor = System.Drawing.Color.Transparent;
            this.btnSexo.BorderColor = System.Drawing.Color.Transparent;
            this.btnSexo.BorderRadius = 15;
            this.btnSexo.BorderThickness = 0;
            this.btnSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btnSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnSexo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.btnSexo.FocusedColor = System.Drawing.Color.Transparent;
            this.btnSexo.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSexo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSexo.ForeColor = System.Drawing.Color.Gray;
            this.btnSexo.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSexo.ItemHeight = 30;
            this.btnSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Desconocido",
            "Alien"});
            this.btnSexo.Location = new System.Drawing.Point(2, 23);
            this.btnSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSexo.Name = "btnSexo";
            this.btnSexo.Size = new System.Drawing.Size(133, 36);
            this.btnSexo.TabIndex = 28;
            this.btnSexo.SelectedIndexChanged += new System.EventHandler(this.btnSexo_SelectedIndexChanged_1);
            // 
            // ContenedorRol
            // 
            this.ContenedorRol.Controls.Add(this.siticoneHtmlLabel2);
            this.ContenedorRol.Controls.Add(this.btnRol);
            this.ContenedorRol.Location = new System.Drawing.Point(208, 33);
            this.ContenedorRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContenedorRol.Name = "ContenedorRol";
            this.ContenedorRol.Size = new System.Drawing.Size(172, 63);
            this.ContenedorRol.TabIndex = 28;
            this.ContenedorRol.Visible = false;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(2, 2);
            this.siticoneHtmlLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(153, 17);
            this.siticoneHtmlLabel2.TabIndex = 27;
            this.siticoneHtmlLabel2.Text = "Buscar personajes por su Rol";
            this.siticoneHtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRol
            // 
            this.btnRol.BackColor = System.Drawing.Color.Transparent;
            this.btnRol.BorderColor = System.Drawing.Color.Transparent;
            this.btnRol.BorderRadius = 15;
            this.btnRol.BorderThickness = 0;
            this.btnRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btnRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnRol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.btnRol.FocusedColor = System.Drawing.Color.Transparent;
            this.btnRol.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRol.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRol.ForeColor = System.Drawing.Color.Gray;
            this.btnRol.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRol.ItemHeight = 30;
            this.btnRol.Items.AddRange(new object[] {
            "Heroe",
            "Antiheroe",
            "Villano"});
            this.btnRol.Location = new System.Drawing.Point(2, 23);
            this.btnRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(133, 36);
            this.btnRol.TabIndex = 26;
            this.btnRol.SelectedIndexChanged += new System.EventHandler(this.btnRol_SelectedIndexChanged);
            // 
            // ContenedorEdades
            // 
            this.ContenedorEdades.Controls.Add(this.btnBuscar);
            this.ContenedorEdades.Controls.Add(this.siticoneHtmlLabel1);
            this.ContenedorEdades.Controls.Add(this.edad_2);
            this.ContenedorEdades.Controls.Add(this.edad_1);
            this.ContenedorEdades.Controls.Add(this.siticoneHtmlLabel7);
            this.ContenedorEdades.Location = new System.Drawing.Point(210, 34);
            this.ContenedorEdades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContenedorEdades.Name = "ContenedorEdades";
            this.ContenedorEdades.Size = new System.Drawing.Size(228, 46);
            this.ContenedorEdades.TabIndex = 19;
            this.ContenedorEdades.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.FillColor = System.Drawing.Color.Red;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(170, 22);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnBuscar.Size = new System.Drawing.Size(29, 22);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(71, 24);
            this.siticoneHtmlLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(9, 17);
            this.siticoneHtmlLabel1.TabIndex = 20;
            this.siticoneHtmlLabel1.Text = "a";
            this.siticoneHtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // edad_2
            // 
            this.edad_2.BackColor = System.Drawing.Color.Transparent;
            this.edad_2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.edad_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edad_2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.edad_2.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.edad_2.FocusedState.UpDownButtonFillColor = System.Drawing.Color.Transparent;
            this.edad_2.FocusedState.UpDownButtonForeColor = System.Drawing.Color.Transparent;
            this.edad_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edad_2.ForeColor = System.Drawing.Color.Gray;
            this.edad_2.Location = new System.Drawing.Point(102, 22);
            this.edad_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edad_2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.edad_2.Name = "edad_2";
            this.edad_2.Size = new System.Drawing.Size(56, 22);
            this.edad_2.TabIndex = 24;
            this.edad_2.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            // 
            // edad_1
            // 
            this.edad_1.BackColor = System.Drawing.Color.Transparent;
            this.edad_1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.edad_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edad_1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.edad_1.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.edad_1.FocusedState.UpDownButtonFillColor = System.Drawing.Color.Transparent;
            this.edad_1.FocusedState.UpDownButtonForeColor = System.Drawing.Color.Transparent;
            this.edad_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edad_1.ForeColor = System.Drawing.Color.Gray;
            this.edad_1.Location = new System.Drawing.Point(2, 22);
            this.edad_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edad_1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.edad_1.Name = "edad_1";
            this.edad_1.Size = new System.Drawing.Size(56, 22);
            this.edad_1.TabIndex = 23;
            this.edad_1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            // 
            // siticoneHtmlLabel7
            // 
            this.siticoneHtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel7.Location = new System.Drawing.Point(2, 2);
            this.siticoneHtmlLabel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            this.siticoneHtmlLabel7.Size = new System.Drawing.Size(206, 17);
            this.siticoneHtmlLabel7.TabIndex = 22;
            this.siticoneHtmlLabel7.Text = "Buscar personajes con edades de entre";
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
            "Edad",
            "Tipo de Personaje",
            "Sexo"});
            this.txtBuscar.Location = new System.Drawing.Point(8, 65);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 36);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.SelectedIndexChanged += new System.EventHandler(this.txtUniverso_SelectedIndexChanged);
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(15, 46);
            this.siticoneHtmlLabel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(97, 17);
            this.siticoneHtmlLabel5.TabIndex = 17;
            this.siticoneHtmlLabel5.Text = "Buscar Personajes";
            this.siticoneHtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
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
            this.Identidad,
            this.Universo,
            this.Actitud,
            this.Edad,
            this.colum_sexo,
            this.Imagen});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.Location = new System.Drawing.Point(15, 107);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.RowTemplate.Height = 35;
            this.DataGridView.Size = new System.Drawing.Size(702, 312);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView.ThemeStyle.HeaderStyle.Height = 65;
            this.DataGridView.ThemeStyle.ReadOnly = true;
            this.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Identidad
            // 
            this.Identidad.HeaderText = "Identidad";
            this.Identidad.MinimumWidth = 8;
            this.Identidad.Name = "Identidad";
            this.Identidad.ReadOnly = true;
            // 
            // Universo
            // 
            this.Universo.HeaderText = "Universo";
            this.Universo.MinimumWidth = 8;
            this.Universo.Name = "Universo";
            this.Universo.ReadOnly = true;
            // 
            // Actitud
            // 
            this.Actitud.HeaderText = "Actitud";
            this.Actitud.MinimumWidth = 8;
            this.Actitud.Name = "Actitud";
            this.Actitud.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 8;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // colum_sexo
            // 
            this.colum_sexo.HeaderText = "Sexo";
            this.colum_sexo.MinimumWidth = 8;
            this.colum_sexo.Name = "colum_sexo";
            this.colum_sexo.ReadOnly = true;
            // 
            // Imagen
            // 
            this.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Imagen.HeaderText = "Foto";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagen.MinimumWidth = 100;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            // 
            // visualizar_personajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(725, 434);
            this.Controls.Add(this.insidePanel);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "visualizar_personajes";
            this.insidePanel.ResumeLayout(false);
            this.insidePanel.PerformLayout();
            this.ContenedorSexo.ResumeLayout(false);
            this.ContenedorSexo.PerformLayout();
            this.ContenedorRol.ResumeLayout(false);
            this.ContenedorRol.PerformLayout();
            this.ContenedorEdades.ResumeLayout(false);
            this.ContenedorEdades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edad_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edad_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel insidePanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView DataGridView;
        private Siticone.Desktop.UI.WinForms.SiticonePanel ContenedorEdades;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox txtBuscar;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown edad_1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown edad_2;
        private FlowLayoutPanel ContenedorSexo;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox btnSexo;
        private FlowLayoutPanel ContenedorRol;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox btnRol;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnBuscar;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnReiniciar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Identidad;
        private DataGridViewTextBoxColumn Universo;
        private DataGridViewTextBoxColumn Actitud;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn colum_sexo;
        private DataGridViewImageColumn Imagen;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnRegresar;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton siticoneCircleButton1;
    }
}