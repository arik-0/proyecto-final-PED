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
            examenSeleccionadobtn = new Button();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label5 = new Label();
            respuestaNumericUpDown = new NumericUpDown();
            label4 = new Label();
            siguientePregunta = new Button();
            label3 = new Label();
            preguntaLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)respuestaNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 119);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(319, 364);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 57);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione examen";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(examenSeleccionadobtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(14, 21);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(413, 563);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // examenSeleccionadobtn
            // 
            examenSeleccionadobtn.Location = new Point(278, 509);
            examenSeleccionadobtn.Margin = new Padding(3, 4, 3, 4);
            examenSeleccionadobtn.Name = "examenSeleccionadobtn";
            examenSeleccionadobtn.Size = new Size(86, 31);
            examenSeleccionadobtn.TabIndex = 1;
            examenSeleccionadobtn.Text = "Seleccionar";
            examenSeleccionadobtn.UseVisualStyleBackColor = true;
            examenSeleccionadobtn.Click += examenSeleccionadobtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(respuestaNumericUpDown);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(siguientePregunta);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(preguntaLabel);
            groupBox2.Location = new Point(443, 21);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(419, 563);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "idExamen";
            // 
            // button1
            // 
            button1.Location = new Point(250, 496);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 7;
            button1.Text = "Finalizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 187);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 6;
            label5.Text = "Respuesta del Alumno:";
            // 
            // respuestaNumericUpDown
            // 
            respuestaNumericUpDown.Location = new Point(105, 248);
            respuestaNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            respuestaNumericUpDown.Name = "respuestaNumericUpDown";
            respuestaNumericUpDown.Size = new Size(137, 27);
            respuestaNumericUpDown.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 112);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 4;
            label4.Text = "TituloPregunta";
            // 
            // siguientePregunta
            // 
            siguientePregunta.Location = new Point(126, 496);
            siguientePregunta.Margin = new Padding(3, 4, 3, 4);
            siguientePregunta.Name = "siguientePregunta";
            siguientePregunta.Size = new Size(86, 31);
            siguientePregunta.TabIndex = 3;
            siguientePregunta.Text = "Siguiente";
            siguientePregunta.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 59);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 1;
            label3.Text = "idpregunta";
            // 
            // preguntaLabel
            // 
            preguntaLabel.AutoSize = true;
            preguntaLabel.Location = new Point(35, 57);
            preguntaLabel.Name = "preguntaLabel";
            preguntaLabel.Size = new Size(68, 20);
            preguntaLabel.TabIndex = 0;
            preguntaLabel.Text = "Pregunta";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)respuestaNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label preguntaLabel;
        private Button examenSeleccionadobtn;
        private Label label3;
        private Label label5;
        private NumericUpDown respuestaNumericUpDown;
        private Label label4;
        private Button siguientePregunta;
        private Button button1;
    }
}