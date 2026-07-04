namespace RegistroEstudiantesEManosalvas
{
    partial class frmRegistroEstudiantes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCedula = new TextBox();
            lblCedula = new Label();
            lblNombres = new Label();
            txtNombres = new TextBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            lblCarrera = new Label();
            cmbCarrera = new ComboBox();
            cmbJornada = new ComboBox();
            lblJornada = new Label();
            btnGrabar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtCedula
            // 
            txtCedula.BackColor = SystemColors.ActiveCaption;
            txtCedula.ForeColor = SystemColors.Window;
            txtCedula.Location = new Point(205, 12);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(125, 27);
            txtCedula.TabIndex = 0;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(144, 12);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(55, 20);
            lblCedula.TabIndex = 3;
            lblCedula.Text = "Cédula";
            lblCedula.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(129, 45);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(70, 20);
            lblNombres.TabIndex = 5;
            lblNombres.Text = "Nombres";
            lblNombres.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombres
            // 
            txtNombres.BackColor = SystemColors.ActiveCaption;
            txtNombres.ForeColor = SystemColors.Window;
            txtNombres.Location = new Point(205, 45);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(239, 27);
            txtNombres.TabIndex = 4;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(127, 78);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(72, 20);
            lblApellidos.TabIndex = 7;
            lblApellidos.Text = "Apellidos";
            lblApellidos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = SystemColors.ActiveCaption;
            txtApellidos.ForeColor = SystemColors.Window;
            txtApellidos.Location = new Point(205, 78);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(239, 27);
            txtApellidos.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(205, 111);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(289, 27);
            dtpFechaNacimiento.TabIndex = 8;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(71, 112);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(128, 20);
            lblFechaNacimiento.TabIndex = 9;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            lblFechaNacimiento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(142, 145);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(57, 20);
            lblCarrera.TabIndex = 11;
            lblCarrera.Text = "Carrera";
            lblCarrera.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbCarrera
            // 
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Items.AddRange(new object[] { "Tecnología Superior en Acción Pastoral", "Tecnología Superior en Asitencia Pedagógica", "Tecnología Superior en Administración", "Tecnología Superior en Desarollo de Software" });
            cmbCarrera.Location = new Point(205, 144);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(344, 28);
            cmbCarrera.TabIndex = 12;
            // 
            // cmbJornada
            // 
            cmbJornada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJornada.FormattingEnabled = true;
            cmbJornada.Items.AddRange(new object[] { "Vespertina", "Nocturna" });
            cmbJornada.Location = new Point(205, 178);
            cmbJornada.Name = "cmbJornada";
            cmbJornada.Size = new Size(344, 28);
            cmbJornada.TabIndex = 14;
            // 
            // lblJornada
            // 
            lblJornada.AutoSize = true;
            lblJornada.Location = new Point(142, 179);
            lblJornada.Name = "lblJornada";
            lblJornada.Size = new Size(61, 20);
            lblJornada.TabIndex = 13;
            lblJornada.Text = "Jornada";
            lblJornada.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnGrabar
            // 
            btnGrabar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGrabar.ForeColor = Color.FromArgb(0, 192, 0);
            btnGrabar.Location = new Point(161, 233);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(94, 29);
            btnGrabar.TabIndex = 15;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Yellow;
            btnLimpiar.Location = new Point(261, 233);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(361, 233);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmRegistroEstudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(595, 310);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGrabar);
            Controls.Add(cmbJornada);
            Controls.Add(lblJornada);
            Controls.Add(cmbCarrera);
            Controls.Add(lblCarrera);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblApellidos);
            Controls.Add(txtApellidos);
            Controls.Add(lblNombres);
            Controls.Add(txtNombres);
            Controls.Add(lblCedula);
            Controls.Add(txtCedula);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRegistroEstudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro Estudiantes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCedula;
        private Label lblCedula;
        private Label lblNombres;
        private TextBox txtNombres;
        private Label lblApellidos;
        private TextBox txtApellidos;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblFechaNacimiento;
        private Label lblCarrera;
        private ComboBox cmbCarrera;
        private ComboBox cmbJornada;
        private Label lblJornada;
        private Button btnGrabar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
