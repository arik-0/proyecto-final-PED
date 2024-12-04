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
            asignaturaselect = new CheckedListBox();
            dataGridView1 = new DataGridView();
            preguntaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            txtPreguntaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            respuesta1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            respuesta2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            respuesta3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            respuesta4DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            respuestaCorrectaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            asignaturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            preguntaBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)correctaupdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unidadupdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subunidadupdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)preguntaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // volverAlMenubtn
            // 
            volverAlMenubtn.Location = new Point(697, 203);
            volverAlMenubtn.Name = "volverAlMenubtn";
            volverAlMenubtn.Size = new Size(75, 65);
            volverAlMenubtn.TabIndex = 0;
            volverAlMenubtn.Text = "Volver al menu";
            volverAlMenubtn.UseVisualStyleBackColor = true;
            volverAlMenubtn.Click += volverAlMenubtn_Click;
            // 
            // crearpreguntabtn
            // 
            crearpreguntabtn.Location = new Point(65, 245);
            crearpreguntabtn.Name = "crearpreguntabtn";
            crearpreguntabtn.Size = new Size(122, 23);
            crearpreguntabtn.TabIndex = 2;
            crearpreguntabtn.Text = "Crear pregunta";
            crearpreguntabtn.UseVisualStyleBackColor = true;
            crearpreguntabtn.Click += crearpreguntabtn_Click;
            // 
            // preguntatxt
            // 
            preguntatxt.Location = new Point(56, 91);
            preguntatxt.Name = "preguntatxt";
            preguntatxt.Size = new Size(212, 23);
            preguntatxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 63);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Pregunta";
            label1.Click += label1_Click;
            // 
            // respuesta4txt
            // 
            respuesta4txt.Location = new Point(162, 183);
            respuesta4txt.Name = "respuesta4txt";
            respuesta4txt.Size = new Size(100, 23);
            respuesta4txt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 165);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Respuesta 4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 117);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Respuesta 1";
            // 
            // respuesta1txt
            // 
            respuesta1txt.Location = new Point(56, 135);
            respuesta1txt.Name = "respuesta1txt";
            respuesta1txt.Size = new Size(100, 23);
            respuesta1txt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 165);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 10;
            label4.Text = "Respuesta 3";
            // 
            // respuesta3txt
            // 
            respuesta3txt.Location = new Point(56, 183);
            respuesta3txt.Name = "respuesta3txt";
            respuesta3txt.Size = new Size(100, 23);
            respuesta3txt.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 117);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 12;
            label5.Text = "Respuesta 2";
            // 
            // respuesta2txt
            // 
            respuesta2txt.Location = new Point(162, 135);
            respuesta2txt.Name = "respuesta2txt";
            respuesta2txt.Size = new Size(100, 23);
            respuesta2txt.TabIndex = 11;
            // 
            // modificarPregbtn
            // 
            modificarPregbtn.Location = new Point(193, 245);
            modificarPregbtn.Name = "modificarPregbtn";
            modificarPregbtn.Size = new Size(122, 23);
            modificarPregbtn.TabIndex = 13;
            modificarPregbtn.Text = "Modificar Pregunta";
            modificarPregbtn.UseVisualStyleBackColor = true;
            modificarPregbtn.Click += modificarPregbtn_Click;
            // 
            // borrarPregbtn
            // 
            borrarPregbtn.Location = new Point(321, 245);
            borrarPregbtn.Name = "borrarPregbtn";
            borrarPregbtn.Size = new Size(122, 23);
            borrarPregbtn.TabIndex = 14;
            borrarPregbtn.Text = "Borrar pregunta";
            borrarPregbtn.UseVisualStyleBackColor = true;
            borrarPregbtn.Click += borrarPregbtn_Click;
            // 
            // correctaupdown
            // 
            correctaupdown.Location = new Point(319, 80);
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
            label6.Location = new Point(288, 47);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 16;
            label6.Text = "Respuesta correcta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(304, 142);
            label7.Name = "label7";
            label7.Size = new Size(112, 15);
            label7.TabIndex = 18;
            label7.Text = "unidad y subunidad";
            // 
            // unidadupdown
            // 
            unidadupdown.Location = new Point(309, 175);
            unidadupdown.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            unidadupdown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            unidadupdown.Name = "unidadupdown";
            unidadupdown.Size = new Size(39, 23);
            unidadupdown.TabIndex = 17;
            unidadupdown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // subunidadupdown
            // 
            subunidadupdown.Location = new Point(365, 175);
            subunidadupdown.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            subunidadupdown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            subunidadupdown.Name = "subunidadupdown";
            subunidadupdown.Size = new Size(39, 23);
            subunidadupdown.TabIndex = 19;
            subunidadupdown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // asignaturaselect
            // 
            asignaturaselect.FormattingEnabled = true;
            asignaturaselect.Items.AddRange(new object[] { "Calculo I", "Programacion y Estructuras de datos", "Arquitectura de la Computacion II", "Historia de la Ciencia y la Tecnica" });
            asignaturaselect.Location = new Point(459, 80);
            asignaturaselect.Name = "asignaturaselect";
            asignaturaselect.Size = new Size(227, 94);
            asignaturaselect.TabIndex = 20;
            asignaturaselect.UseCompatibleTextRendering = true;
            asignaturaselect.ItemCheck += asignaturaselect_ItemCheck;
            asignaturaselect.SelectedIndexChanged += asignaturaselect_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { preguntaIdDataGridViewTextBoxColumn, txtPreguntaDataGridViewTextBoxColumn, respuesta1DataGridViewTextBoxColumn, respuesta2DataGridViewTextBoxColumn, respuesta3DataGridViewTextBoxColumn, respuesta4DataGridViewTextBoxColumn, respuestaCorrectaDataGridViewTextBoxColumn, asignaturaDataGridViewTextBoxColumn, unidadDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = preguntaBindingSource;
            dataGridView1.Location = new Point(12, 286);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 152);
            dataGridView1.TabIndex = 21;
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
            // respuesta1DataGridViewTextBoxColumn
            // 
            respuesta1DataGridViewTextBoxColumn.DataPropertyName = "Respuesta1";
            respuesta1DataGridViewTextBoxColumn.HeaderText = "Respuesta1";
            respuesta1DataGridViewTextBoxColumn.Name = "respuesta1DataGridViewTextBoxColumn";
            // 
            // respuesta2DataGridViewTextBoxColumn
            // 
            respuesta2DataGridViewTextBoxColumn.DataPropertyName = "Respuesta2";
            respuesta2DataGridViewTextBoxColumn.HeaderText = "Respuesta2";
            respuesta2DataGridViewTextBoxColumn.Name = "respuesta2DataGridViewTextBoxColumn";
            // 
            // respuesta3DataGridViewTextBoxColumn
            // 
            respuesta3DataGridViewTextBoxColumn.DataPropertyName = "Respuesta3";
            respuesta3DataGridViewTextBoxColumn.HeaderText = "Respuesta3";
            respuesta3DataGridViewTextBoxColumn.Name = "respuesta3DataGridViewTextBoxColumn";
            // 
            // respuesta4DataGridViewTextBoxColumn
            // 
            respuesta4DataGridViewTextBoxColumn.DataPropertyName = "Respuesta4";
            respuesta4DataGridViewTextBoxColumn.HeaderText = "Respuesta4";
            respuesta4DataGridViewTextBoxColumn.Name = "respuesta4DataGridViewTextBoxColumn";
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Subunidad";
            dataGridViewTextBoxColumn1.HeaderText = "Subunidad";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // preguntaBindingSource
            // 
            preguntaBindingSource.DataSource = typeof(Pregunta);
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(asignaturaselect);
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
            Controls.Add(volverAlMenubtn);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)correctaupdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)unidadupdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)subunidadupdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)preguntaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button volverAlMenubtn;
        private DataGridViewTextBoxColumn subUnidadDataGridViewTextBoxColumn;
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
        private CheckedListBox asignaturaselect;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn preguntaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn txtPreguntaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn respuesta1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn respuesta2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn respuesta3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn respuesta4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn respuestaCorrectaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn asignaturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private BindingSource preguntaBindingSource;
    }
}