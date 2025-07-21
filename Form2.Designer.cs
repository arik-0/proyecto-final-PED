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
            volverAlMenubtn = new Button();
            label1 = new Label();
            consultaProductosbtn = new Button();
            modificarProductobtn = new Button();
            eliminarProductosbtn = new Button();
            agregarProductosbtn = new Button();
            SuspendLayout();
            // 
            // volverAlMenubtn
            // 
            volverAlMenubtn.Location = new Point(816, 500);
            volverAlMenubtn.Margin = new Padding(3, 4, 3, 4);
            volverAlMenubtn.Name = "volverAlMenubtn";
            volverAlMenubtn.Size = new Size(86, 87);
            volverAlMenubtn.TabIndex = 0;
            volverAlMenubtn.Text = "Volver al menu";
            volverAlMenubtn.UseVisualStyleBackColor = true;
            volverAlMenubtn.Click += volverAlMenubtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 124);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 4;
            label1.Text = "Gestion de Productos";
            // 
            // consultaProductosbtn
            // 
            consultaProductosbtn.Location = new Point(463, 304);
            consultaProductosbtn.Margin = new Padding(3, 4, 3, 4);
            consultaProductosbtn.Name = "consultaProductosbtn";
            consultaProductosbtn.Size = new Size(107, 76);
            consultaProductosbtn.TabIndex = 9;
            consultaProductosbtn.Text = "Consultar Productos";
            consultaProductosbtn.UseVisualStyleBackColor = true;
            consultaProductosbtn.Click += consultaProductosbtn_Click;
            // 
            // modificarProductobtn
            // 
            modificarProductobtn.Location = new Point(345, 304);
            modificarProductobtn.Margin = new Padding(3, 4, 3, 4);
            modificarProductobtn.Name = "modificarProductobtn";
            modificarProductobtn.Size = new Size(109, 76);
            modificarProductobtn.TabIndex = 8;
            modificarProductobtn.Text = "Modificar Producto";
            modificarProductobtn.UseVisualStyleBackColor = true;
            modificarProductobtn.Click += modificarProductobtn_Click;
            // 
            // eliminarProductosbtn
            // 
            eliminarProductosbtn.Location = new Point(463, 220);
            eliminarProductosbtn.Margin = new Padding(3, 4, 3, 4);
            eliminarProductosbtn.Name = "eliminarProductosbtn";
            eliminarProductosbtn.Size = new Size(107, 76);
            eliminarProductosbtn.TabIndex = 7;
            eliminarProductosbtn.Text = "Eliminar Productos";
            eliminarProductosbtn.UseVisualStyleBackColor = true;
            eliminarProductosbtn.Click += eliminarProductosbtn_Click;
            // 
            // agregarProductosbtn
            // 
            agregarProductosbtn.Location = new Point(345, 220);
            agregarProductosbtn.Margin = new Padding(3, 4, 3, 4);
            agregarProductosbtn.Name = "agregarProductosbtn";
            agregarProductosbtn.Size = new Size(109, 76);
            agregarProductosbtn.TabIndex = 6;
            agregarProductosbtn.Text = "Agregar Productos";
            agregarProductosbtn.UseVisualStyleBackColor = true;
            agregarProductosbtn.Click += agregarProductosbtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(consultaProductosbtn);
            Controls.Add(modificarProductobtn);
            Controls.Add(eliminarProductosbtn);
            Controls.Add(agregarProductosbtn);
            Controls.Add(label1);
            Controls.Add(volverAlMenubtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button volverAlMenubtn;
        private DataGridViewTextBoxColumn subUnidadDataGridViewTextBoxColumn;
        private Label label1;
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
        private Button consultaProductosbtn;
        private Button modificarProductobtn;
        private Button eliminarProductosbtn;
        private Button agregarProductosbtn;
    }
}