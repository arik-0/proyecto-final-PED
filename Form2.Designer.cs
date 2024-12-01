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
            preguntaBindingSource = new BindingSource(components);
            preguntaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            txtPreguntaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            respuestaCorrectaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            asignaturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subUnidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            crearpreguntabtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)preguntaBindingSource).BeginInit();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { preguntaIdDataGridViewTextBoxColumn, txtPreguntaDataGridViewTextBoxColumn, respuestaCorrectaDataGridViewTextBoxColumn, asignaturaDataGridViewTextBoxColumn, unidadDataGridViewTextBoxColumn, subUnidadDataGridViewTextBoxColumn });
            dataGridView1.DataSource = preguntaBindingSource;
            dataGridView1.Location = new Point(12, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 78);
            dataGridView1.TabIndex = 1;
            // 
            // preguntaBindingSource
            // 
            preguntaBindingSource.DataSource = typeof(Pregunta);
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
            // subUnidadDataGridViewTextBoxColumn
            // 
            subUnidadDataGridViewTextBoxColumn.DataPropertyName = "SubUnidad";
            subUnidadDataGridViewTextBoxColumn.HeaderText = "SubUnidad";
            subUnidadDataGridViewTextBoxColumn.Name = "subUnidadDataGridViewTextBoxColumn";
            // 
            // crearpreguntabtn
            // 
            crearpreguntabtn.Location = new Point(65, 283);
            crearpreguntabtn.Name = "crearpreguntabtn";
            crearpreguntabtn.Size = new Size(122, 23);
            crearpreguntabtn.TabIndex = 2;
            crearpreguntabtn.Text = "Crear pregunta";
            crearpreguntabtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(crearpreguntabtn);
            Controls.Add(dataGridView1);
            Controls.Add(volverAlMenubtn);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)preguntaBindingSource).EndInit();
            ResumeLayout(false);
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
    }
}