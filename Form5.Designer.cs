﻿namespace proyecto_final_PED
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
            label6 = new Label();
            apeynomtxt = new TextBox();
            examenSeleccionadobtn = new Button();
            groupBox2 = new GroupBox();
            volvermenubtn = new Button();
            finalizarcorreccionbtn = new Button();
            label5 = new Label();
            respuestaUpDown = new NumericUpDown();
            labelTituloPregunta = new Label();
            siguientePreguntabtn = new Button();
            idPreguntalbl = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)respuestaUpDown).BeginInit();
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
            dataGridView1.Size = new Size(279, 214);
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
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(apeynomtxt);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(115, 323);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 3;
            label6.Text = "Nombre y Apellido";
            // 
            // apeynomtxt
            // 
            apeynomtxt.Location = new Point(92, 341);
            apeynomtxt.Name = "apeynomtxt";
            apeynomtxt.Size = new Size(155, 23);
            apeynomtxt.TabIndex = 2;
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
            groupBox2.Controls.Add(volvermenubtn);
            groupBox2.Controls.Add(finalizarcorreccionbtn);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(respuestaUpDown);
            groupBox2.Controls.Add(labelTituloPregunta);
            groupBox2.Controls.Add(siguientePreguntabtn);
            groupBox2.Controls.Add(idPreguntalbl);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(388, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(419, 563);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "idExamen";
            // 
            // volvermenubtn
            // 
            volvermenubtn.Location = new Point(273, 267);
            volvermenubtn.Name = "volvermenubtn";
            volvermenubtn.Size = new Size(75, 51);
            volvermenubtn.TabIndex = 10;
            volvermenubtn.Text = "Volver al menu";
            volvermenubtn.UseVisualStyleBackColor = true;
            volvermenubtn.Click += volvermenubtn_Click;
            // 
            // finalizarcorreccionbtn
            // 
            finalizarcorreccionbtn.Location = new Point(219, 372);
            finalizarcorreccionbtn.Name = "finalizarcorreccionbtn";
            finalizarcorreccionbtn.Size = new Size(75, 23);
            finalizarcorreccionbtn.TabIndex = 7;
            finalizarcorreccionbtn.Text = "Finalizar";
            finalizarcorreccionbtn.UseVisualStyleBackColor = true;
            finalizarcorreccionbtn.Click += finalizarcorreccionbtn_Click_1;
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
            // respuestaUpDown
            // 
            respuestaUpDown.Location = new Point(92, 186);
            respuestaUpDown.Name = "respuestaUpDown";
            respuestaUpDown.Size = new Size(120, 23);
            respuestaUpDown.TabIndex = 5;
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
            siguientePreguntabtn.Location = new Point(110, 372);
            siguientePreguntabtn.Name = "siguientePreguntabtn";
            siguientePreguntabtn.Size = new Size(75, 23);
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
            ((System.ComponentModel.ISupportInitialize)respuestaUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label preguntaLabel;
        private Button examenSeleccionadobtn;
        private Label idPreguntalbl;
        private Label label5;
        private NumericUpDown respuestaUpDown;
        private Label labelTituloPregunta;
        private Button siguientePreguntabtn;
        private Button finalizarcorreccionbtn;
        private Label label6;
        private TextBox apeynomtxt;
        private Button volvermenubtn;
    }
}