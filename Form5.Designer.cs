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
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            siguientePregunta = new Button();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(279, 273);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 43);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccione examen";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(examenSeleccionadobtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 422);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // examenSeleccionadobtn
            // 
            examenSeleccionadobtn.Location = new Point(243, 382);
            examenSeleccionadobtn.Name = "examenSeleccionadobtn";
            examenSeleccionadobtn.Size = new Size(75, 23);
            examenSeleccionadobtn.TabIndex = 1;
            examenSeleccionadobtn.Text = "Seleccionar";
            examenSeleccionadobtn.UseVisualStyleBackColor = true;
            examenSeleccionadobtn.Click += examenSeleccionadobtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(siguientePregunta);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(388, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 422);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "idExamen";
            // 
            // button1
            // 
            button1.Location = new Point(219, 372);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Finalizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 140);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 6;
            label5.Text = "Respuesta del Alumno:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(92, 186);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 84);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 4;
            label4.Text = "TituloPregunta";
            // 
            // siguientePregunta
            // 
            siguientePregunta.Location = new Point(110, 372);
            siguientePregunta.Name = "siguientePregunta";
            siguientePregunta.Size = new Size(75, 23);
            siguientePregunta.TabIndex = 3;
            siguientePregunta.Text = "Siguiente";
            siguientePregunta.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 44);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 1;
            label3.Text = "idpregunta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 43);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "Pregunta";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Button examenSeleccionadobtn;
        private Label label3;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Button siguientePregunta;
        private Button button1;
    }
}