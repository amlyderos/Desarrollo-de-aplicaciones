﻿namespace _02_Desafio_GUI
{
    partial class Form1
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
            lblNombre = new Label();
            lblCursoo = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombreEstudiante = new TextBox();
            cboCurso = new ComboBox();
            cboSeccion = new ComboBox();
            cboArea = new ComboBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            btnSalir = new Button();
            label4 = new Label();
            label5 = new Label();
            rdbMasculino = new RadioButton();
            rdbFemenino = new RadioButton();
            lblNotas = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblPromedio = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtNota4 = new TextBox();
            txtPromedio = new TextBox();
            label1 = new Label();
            txtStatus = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Berlin Sans FB", 14F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(46, 82);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(124, 31);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
            // 
            // lblCursoo
            // 
            lblCursoo.AutoSize = true;
            lblCursoo.BackColor = Color.Transparent;
            lblCursoo.Font = new Font("Berlin Sans FB", 14F);
            lblCursoo.ForeColor = SystemColors.ButtonHighlight;
            lblCursoo.Location = new Point(508, 81);
            lblCursoo.Margin = new Padding(4, 0, 4, 0);
            lblCursoo.Name = "lblCursoo";
            lblCursoo.Size = new Size(90, 31);
            lblCursoo.TabIndex = 1;
            lblCursoo.Text = "Curso: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Berlin Sans FB", 14F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(46, 223);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 31);
            label2.TabIndex = 2;
            label2.Text = "Seccion: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Berlin Sans FB", 14F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(997, 80);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 3;
            label3.Text = "Area:";
            // 
            // txtNombreEstudiante
            // 
            txtNombreEstudiante.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtNombreEstudiante.Location = new Point(46, 117);
            txtNombreEstudiante.Margin = new Padding(4, 5, 4, 5);
            txtNombreEstudiante.Name = "txtNombreEstudiante";
            txtNombreEstudiante.Size = new Size(381, 39);
            txtNombreEstudiante.TabIndex = 4;
            // 
            // cboCurso
            // 
            cboCurso.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cboCurso.FormattingEnabled = true;
            cboCurso.Items.AddRange(new object[] { "4to", "5to", "6to" });
            cboCurso.Location = new Point(508, 116);
            cboCurso.Margin = new Padding(4, 5, 4, 5);
            cboCurso.Name = "cboCurso";
            cboCurso.Size = new Size(381, 40);
            cboCurso.TabIndex = 5;
            cboCurso.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cboSeccion
            // 
            cboSeccion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cboSeccion.FormattingEnabled = true;
            cboSeccion.Items.AddRange(new object[] { "A-1", "A-2", "A-3", "A-4", "B", "C-1", "C-2", "D-1", "D-2", "E" });
            cboSeccion.Location = new Point(46, 258);
            cboSeccion.Margin = new Padding(4, 5, 4, 5);
            cboSeccion.Name = "cboSeccion";
            cboSeccion.Size = new Size(381, 40);
            cboSeccion.TabIndex = 6;
            // 
            // cboArea
            // 
            cboArea.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Enfermeria", "Contabilidad", "Gastronomia", "Informatica", "Electrecidad" });
            cboArea.Location = new Point(997, 116);
            cboArea.Margin = new Padding(4, 5, 4, 5);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(381, 40);
            cboArea.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 100, 90);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 100, 90);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(422, 126);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 37);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button1_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 100, 90);
            btnCalcular.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 100, 90);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.ForeColor = SystemColors.ControlLightLight;
            btnCalcular.Location = new Point(477, 200);
            btnCalcular.Margin = new Padding(4, 5, 4, 5);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(274, 40);
            btnCalcular.TabIndex = 20;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button2_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(0, 90, 204);
            btnSalir.BackgroundImageLayout = ImageLayout.Center;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(78, 279);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(673, 45);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(688, 40);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(440, 41);
            label4.TabIndex = 22;
            label4.Text = "STATUS DE ESTUDIANTES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Berlin Sans FB", 14F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(503, 216);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 31);
            label5.TabIndex = 23;
            label5.Text = "Sexo:";
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.BackColor = Color.Transparent;
            rdbMasculino.Font = new Font("Segoe UI", 12F);
            rdbMasculino.ForeColor = Color.White;
            rdbMasculino.Location = new Point(772, 280);
            rdbMasculino.Margin = new Padding(4, 5, 4, 5);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(148, 36);
            rdbMasculino.TabIndex = 24;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = false;
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.BackColor = Color.Transparent;
            rdbFemenino.Font = new Font("Segoe UI", 12F);
            rdbFemenino.ForeColor = SystemColors.ControlLightLight;
            rdbFemenino.Location = new Point(503, 280);
            rdbFemenino.Margin = new Padding(4, 5, 4, 5);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(146, 36);
            rdbFemenino.TabIndex = 25;
            rdbFemenino.TabStop = true;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = false;
            rdbFemenino.CheckedChanged += rdbFemenino_CheckedChanged;
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.BackColor = Color.Transparent;
            lblNotas.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotas.ForeColor = Color.White;
            lblNotas.Location = new Point(105, 24);
            lblNotas.Margin = new Padding(4, 0, 4, 0);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(111, 41);
            lblNotas.TabIndex = 26;
            lblNotas.Text = "Notas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(253, 83);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 28);
            label7.TabIndex = 27;
            label7.Text = "Nota 2: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(78, 83);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 28);
            label8.TabIndex = 28;
            label8.Text = "Nota 1:  ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(432, 83);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(81, 28);
            label9.TabIndex = 29;
            label9.Text = "Nota 3: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(606, 83);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(81, 28);
            label10.TabIndex = 30;
            label10.Text = "Nota 4: ";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.BackColor = Color.Transparent;
            lblPromedio.Font = new Font("Segoe UI", 10F);
            lblPromedio.ForeColor = Color.White;
            lblPromedio.Location = new Point(78, 174);
            lblPromedio.Margin = new Padding(4, 0, 4, 0);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(107, 28);
            lblPromedio.TabIndex = 31;
            lblPromedio.Text = "Promedio: ";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(78, 120);
            txtNota1.Margin = new Padding(4, 5, 4, 5);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(145, 31);
            txtNota1.TabIndex = 32;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(253, 120);
            txtNota2.Margin = new Padding(4, 5, 4, 5);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(144, 31);
            txtNota2.TabIndex = 33;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(432, 120);
            txtNota3.Margin = new Padding(4, 5, 4, 5);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(145, 31);
            txtNota3.TabIndex = 34;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(606, 120);
            txtNota4.Margin = new Padding(4, 5, 4, 5);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(145, 31);
            txtNota4.TabIndex = 35;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(78, 205);
            txtPromedio.Margin = new Padding(4, 5, 4, 5);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(248, 31);
            txtPromedio.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Berlin Sans FB", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(267, 31);
            label1.TabIndex = 37;
            label1.Text = "Estadodel Estudiante:";
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI", 9F);
            txtStatus.Location = new Point(39, 132);
            txtStatus.Margin = new Padding(4, 5, 4, 5);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(346, 31);
            txtStatus.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 16, 28);
            panel1.Controls.Add(rdbFemenino);
            panel1.Controls.Add(rdbMasculino);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cboArea);
            panel1.Controls.Add(cboSeccion);
            panel1.Controls.Add(cboCurso);
            panel1.Controls.Add(txtNombreEstudiante);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblCursoo);
            panel1.Controls.Add(lblNombre);
            panel1.Location = new Point(82, 143);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1427, 365);
            panel1.TabIndex = 39;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 16, 28);
            panel2.Controls.Add(txtPromedio);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(txtNota4);
            panel2.Controls.Add(txtNota3);
            panel2.Controls.Add(txtNota2);
            panel2.Controls.Add(lblNotas);
            panel2.Controls.Add(btnCalcular);
            panel2.Controls.Add(txtNota1);
            panel2.Controls.Add(lblPromedio);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(82, 536);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 370);
            panel2.TabIndex = 40;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 16, 28);
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnLimpiar);
            panel3.Location = new Point(928, 536);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(581, 214);
            panel3.TabIndex = 41;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 90, 204);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1843, 120);
            panel4.TabIndex = 42;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1556, 1023);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private Label lblCursoo;
        private Label label2;
        private Label label3;
        private TextBox txtNombreEstudiante;
        private ComboBox cboCurso;
        private ComboBox cboSeccion;
        private ComboBox cboArea;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Button btnSalir;
        private Label label4;
        private Label label5;
        private RadioButton rdbMasculino;
        private RadioButton rdbFemenino;
        private Label lblNotas;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblPromedio;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtNota4;
        private TextBox txtPromedio;
        private Label label1;
        private TextBox txtStatus;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;



      

    }
}
