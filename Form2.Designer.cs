namespace proyecto_final_PED
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            volverAlMenubtn = new Button();
            dataGridView1 = new DataGridView();
            preguntaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            txtPreguntaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            respuestaCorrectaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            asignaturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            preguntaBindingSource = new BindingSource(components);
            crearpreguntabtn = new Button();
            preguntatxt = new TextBox();
            label1 = new Label();
            respuesta4txt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            respuesta1txt = new TextBox();
            label4 = new Label();
            respuesta3txt = new TextBox();
            label5 = new Label();
            respuesta2txt = new TextBox();
            modificarPregbtn = new Button();
            borrarPregbtn = new Button();
            correctaupdown = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            unidadupdown = new NumericUpDown();
            subunidadupdown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)preguntaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)correctaupdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unidadupdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subunidadupdown).BeginInit();
            SuspendLayout();
            // 
            // volverAlMenubtn
            // 
            volverAlMenubtn.Location = new Point(687, 359);
            volverAlMenubtn.Name = "volverAlMenubtn";
            volverAlMenubtn.Size = new Size(75, 65);
            volverAlMenubtn.TabIndex = 0;
            volverAlMenubtn.Text = "Volver al menu";
            volverAlMenubtn.UseVisualStyleBackColor = true;
            volverAlMenubtn.Click += volverAlMenubtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { preguntaIdDataGridViewTextBoxColumn, txtPreguntaDataGridViewTextBoxColumn, respuestaCorrectaDataGridViewTextBoxColumn, asignaturaDataGridViewTextBoxColumn, unidadDataGridViewTextBoxColumn });
            dataGridView1.DataSource = preguntaBindingSource;
            dataGridView1.Location = new Point(12, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 78);
            dataGridView1.TabIndex = 1;
            // 
            // preguntaIdDataGridViewTextBoxColumn
            // 
            preguntaIdDataGridViewTextBoxColumn.DataPropertyName = "PreguntaId";
            preguntaIdDataGridViewTextBoxColumn.HeaderText = "PreguntaId";
            preguntaIdDataGridViewTextBoxColumn.Name = "preguntaIdDataGridViewTextBoxColumn";
            // 
            // txtPreguntaDataGridViewTextBoxColumn
            // 
            txtPreguntaDataGridViewTextBoxColumn.DataPropertyName = "TxtPregunta";
            txtPreguntaDataGridViewTextBoxColumn.HeaderText = "TxtPregunta";
            txtPreguntaDataGridViewTextBoxColumn.Name = "txtPreguntaDataGridViewTextBoxColumn";
            // 
            // respuestaCorrectaDataGridViewTextBoxColumn
            // 
            respuestaCorrectaDataGridViewTextBoxColumn.DataPropertyName = "RespuestaCorrecta";
            respuestaCorrectaDataGridViewTextBoxColumn.HeaderText = "RespuestaCorrecta";
            respuestaCorrectaDataGridViewTextBoxColumn.Name = "respuestaCorrectaDataGridViewTextBoxColumn";
            // 
            // asignaturaDataGridViewTextBoxColumn
            // 
            asignaturaDataGridViewTextBoxColumn.DataPropertyName = "Asignatura";
            asignaturaDataGridViewTextBoxColumn.HeaderText = "Asignatura";
            asignaturaDataGridViewTextBoxColumn.Name = "asignaturaDataGridViewTextBoxColumn";
            // 
            // unidadDataGridViewTextBoxColumn
            // 
            unidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad";
            unidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
            unidadDataGridViewTextBoxColumn.Name = "unidadDataGridViewTextBoxColumn";
            // 
            // preguntaBindingSource
            // 
            preguntaBindingSource.DataSource = typeof(Pregunta);
            // 
            // crearpreguntabtn
            // 
            crearpreguntabtn.Location = new Point(65, 283);
            crearpreguntabtn.Name = "crearpreguntabtn";
            crearpreguntabtn.Size = new Size(122, 23);
            crearpreguntabtn.TabIndex = 2;
            crearpreguntabtn.Text = "Crear pregunta";
            crearpreguntabtn.UseVisualStyleBackColor = true;
            crearpreguntabtn.Click += crearpreguntabtn_Click;
            // 
            // preguntatxt
            // 
            preguntatxt.Location = new Point(65, 115);
            preguntatxt.Name = "preguntatxt";
            preguntatxt.Size = new Size(212, 23);
            preguntatxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 85);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Pregunta";
            label1.Click += label1_Click;
            // 
            // respuesta4txt
            // 
            respuesta4txt.Location = new Point(162, 221);
            respuesta4txt.Name = "respuesta4txt";
            respuesta4txt.Size = new Size(100, 23);
            respuesta4txt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 203);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Respuesta 4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 155);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Respuesta 1";
            // 
            // respuesta1txt
            // 
            respuesta1txt.Location = new Point(56, 173);
            respuesta1txt.Name = "respuesta1txt";
            respuesta1txt.Size = new Size(100, 23);
            respuesta1txt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 203);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 10;
            label4.Text = "Respuesta 3";
            // 
            // respuesta3txt
            // 
            respuesta3txt.Location = new Point(56, 221);
            respuesta3txt.Name = "respuesta3txt";
            respuesta3txt.Size = new Size(100, 23);
            respuesta3txt.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 155);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 12;
            label5.Text = "Respuesta 2";
            // 
            // respuesta2txt
            // 
            respuesta2txt.Location = new Point(162, 173);
            respuesta2txt.Name = "respuesta2txt";
            respuesta2txt.Size = new Size(100, 23);
            respuesta2txt.TabIndex = 11;
            // 
            // modificarPregbtn
            // 
            modificarPregbtn.Location = new Point(193, 283);
            modificarPregbtn.Name = "modificarPregbtn";
            modificarPregbtn.Size = new Size(122, 23);
            modificarPregbtn.TabIndex = 13;
            modificarPregbtn.Text = "Modificar Pregunta";
            modificarPregbtn.UseVisualStyleBackColor = true;
            // 
            // borrarPregbtn
            // 
            borrarPregbtn.Location = new Point(321, 283);
            borrarPregbtn.Name = "borrarPregbtn";
            borrarPregbtn.Size = new Size(122, 23);
            borrarPregbtn.TabIndex = 14;
            borrarPregbtn.Text = "Borrar pregunta";
            borrarPregbtn.UseVisualStyleBackColor = true;
            // 
            // correctaupdown
            // 
            correctaupdown.Location = new Point(319, 118);
            correctaupdown.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            correctaupdown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            correctaupdown.Name = "correctaupdown";
            correctaupdown.Size = new Size(39, 23);
            correctaupdown.TabIndex = 15;
            correctaupdown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(288, 85);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 16;
            label6.Text = "Respuesta correcta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(314, 173);
            label7.Name = "label7";
            label7.Size = new Size(112, 15);
            label7.TabIndex = 18;
            label7.Text = "unidad y subunidad";
            // 
            // unidadupdown
            // 
            unidadupdown.Location = new Point(319, 206);
            unidadupdown.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            unidadupdown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            unidadupdown.Name = "unidadupdown";
            unidadupdown.Size = new Size(39, 23);
            unidadupdown.TabIndex = 17;
            unidadupdown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // subunidadupdown
            // 
            subunidadupdown.Location = new Point(375, 206);
            subunidadupdown.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            subunidadupdown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            subunidadupdown.Name = "subunidadupdown";
            subunidadupdown.Size = new Size(39, 23);
            subunidadupdown.TabIndex = 19;
            subunidadupdown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(subunidadupdown);
            Controls.Add(label7);
            Controls.Add(unidadupdown);
            Controls.Add(label6);
            Controls.Add(correctaupdown);
            Controls.Add(borrarPregbtn);
            Controls.Add(modificarPregbtn);
            Controls.Add(label5);
            Controls.Add(respuesta2txt);
            Controls.Add(label4);
            Controls.Add(respuesta3txt);
            Controls.Add(label3);
            Controls.Add(respuesta1txt);
            Controls.Add(label2);
            Controls.Add(respuesta4txt);
            Controls.Add(label1);
            Controls.Add(preguntatxt);
            Controls.Add(crearpreguntabtn);
            Controls.Add(dataGridView1);
            Controls.Add(volverAlMenubtn);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)preguntaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)correctaupdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)unidadupdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)subunidadupdown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button volverAlMenubtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn preguntaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn txtPreguntaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn respuestaCorrectaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn asignaturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subUnidadDataGridViewTextBoxColumn;
        private BindingSource preguntaBindingSource;
        private Button crearpreguntabtn;
        private TextBox preguntatxt;
        private Label label1;
        private TextBox respuesta4txt;
        private Label label2;
        private Label label3;
        private TextBox respuesta1txt;
        private Label label4;
        private TextBox respuesta3txt;
        private Label label5;
        private TextBox respuesta2txt;
        private Button modificarPregbtn;
        private Button borrarPregbtn;
        private NumericUpDown correctaupdown;
        private Label label6;
        private Label label7;
        private NumericUpDown unidadupdown;
        private NumericUpDown subunidadupdown;
    }
}