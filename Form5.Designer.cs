namespace proyecto_final_PED
{
    partial class Form5
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            volvermenubtn = new Button();
            label6 = new Label();
            apeynomtxt = new TextBox();
            examenSeleccionadobtn = new Button();
            groupBox2 = new GroupBox();
            label5 = new Label();
            respuestaUpDown = new NumericUpDown();
            labelTituloPregunta = new Label();
            siguientePreguntabtn = new Button();
            idPreguntalbl = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)respuestaUpDown).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(279, 214);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(48, 33);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 1;
            label1.Text = "Seleccione examen:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(volvermenubtn);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(apeynomtxt);
            groupBox1.Controls.Add(examenSeleccionadobtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 422);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // volvermenubtn
            // 
            volvermenubtn.Location = new Point(6, 365);
            volvermenubtn.Name = "volvermenubtn";
            volvermenubtn.Size = new Size(75, 51);
            volvermenubtn.TabIndex = 10;
            volvermenubtn.Text = "Volver al menu";
            volvermenubtn.UseVisualStyleBackColor = true;
            volvermenubtn.Click += volvermenubtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 315);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 3;
            label6.Text = "Nombre y Apellido";
            // 
            // apeynomtxt
            // 
            apeynomtxt.Location = new Point(100, 333);
            apeynomtxt.Name = "apeynomtxt";
            apeynomtxt.Size = new Size(155, 23);
            apeynomtxt.TabIndex = 2;
            // 
            // examenSeleccionadobtn
            // 
            examenSeleccionadobtn.Location = new Point(243, 379);
            examenSeleccionadobtn.Name = "examenSeleccionadobtn";
            examenSeleccionadobtn.Size = new Size(75, 23);
            examenSeleccionadobtn.TabIndex = 1;
            examenSeleccionadobtn.Text = "Seleccionar";
            examenSeleccionadobtn.UseVisualStyleBackColor = true;
            examenSeleccionadobtn.Click += examenSeleccionadobtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(respuestaUpDown);
            groupBox2.Controls.Add(labelTituloPregunta);
            groupBox2.Controls.Add(siguientePreguntabtn);
            groupBox2.Controls.Add(idPreguntalbl);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(388, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 422);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "idExamen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(31, 199);
            label5.Name = "label5";
            label5.Size = new Size(209, 28);
            label5.TabIndex = 6;
            label5.Text = "Respuesta del Alumno:";
            // 
            // respuestaUpDown
            // 
            respuestaUpDown.Location = new Point(120, 255);
            respuestaUpDown.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            respuestaUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            respuestaUpDown.Name = "respuestaUpDown";
            respuestaUpDown.Size = new Size(120, 23);
            respuestaUpDown.TabIndex = 5;
            respuestaUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelTituloPregunta
            // 
            labelTituloPregunta.AutoSize = true;
            labelTituloPregunta.Location = new Point(77, 84);
            labelTituloPregunta.Name = "labelTituloPregunta";
            labelTituloPregunta.Size = new Size(85, 15);
            labelTituloPregunta.TabIndex = 4;
            labelTituloPregunta.Text = "TituloPregunta";
            // 
            // siguientePreguntabtn
            // 
            siguientePreguntabtn.Location = new Point(122, 323);
            siguientePreguntabtn.Name = "siguientePreguntabtn";
            siguientePreguntabtn.Size = new Size(118, 56);
            siguientePreguntabtn.TabIndex = 3;
            siguientePreguntabtn.Text = "Siguiente";
            siguientePreguntabtn.UseVisualStyleBackColor = true;
            siguientePreguntabtn.Click += siguientePreguntabtn_Click_1;
            // 
            // idPreguntalbl
            // 
            idPreguntalbl.AutoSize = true;
            idPreguntalbl.Location = new Point(92, 44);
            idPreguntalbl.Name = "idPreguntalbl";
            idPreguntalbl.Size = new Size(65, 15);
            idPreguntalbl.TabIndex = 1;
            idPreguntalbl.Text = "idpregunta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(31, 43);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 0;
            label2.Text = "Pregunta";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(0, 153);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(367, 269);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)respuestaUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Button examenSeleccionadobtn;
        private Label idPreguntalbl;
        private Label label5;
        private NumericUpDown respuestaUpDown;
        private Label labelTituloPregunta;
        private Button siguientePreguntabtn;
        private Label label6;
        private TextBox apeynomtxt;
        private Button volvermenubtn;
        private GroupBox groupBox3;
    }
}