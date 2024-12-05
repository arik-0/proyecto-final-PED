namespace proyecto_final_PED
{
    partial class Form4
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
            generarImpresionbtn = new Button();
            dataGridView1 = new DataGridView();
            volverAlMenubtn = new Button();
            datosUniversidadtxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            carreratxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // generarImpresionbtn
            // 
            generarImpresionbtn.Location = new Point(259, 191);
            generarImpresionbtn.Name = "generarImpresionbtn";
            generarImpresionbtn.Size = new Size(75, 23);
            generarImpresionbtn.TabIndex = 0;
            generarImpresionbtn.Text = "Generar Impresion";
            generarImpresionbtn.UseVisualStyleBackColor = true;
            generarImpresionbtn.Click += generarImpresionbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 187);
            dataGridView1.TabIndex = 22;
            // 
            // volverAlMenubtn
            // 
            volverAlMenubtn.Location = new Point(437, 170);
            volverAlMenubtn.Name = "volverAlMenubtn";
            volverAlMenubtn.Size = new Size(75, 65);
            volverAlMenubtn.TabIndex = 23;
            volverAlMenubtn.Text = "Volver al menu";
            volverAlMenubtn.UseVisualStyleBackColor = true;
            volverAlMenubtn.Click += volverAlMenubtn_Click;
            // 
            // datosUniversidadtxt
            // 
            datosUniversidadtxt.Location = new Point(68, 123);
            datosUniversidadtxt.Name = "datosUniversidadtxt";
            datosUniversidadtxt.Size = new Size(130, 23);
            datosUniversidadtxt.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 83);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 25;
            label1.Text = "Datos de la Universidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 83);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 27;
            label2.Text = "Carrera";
            // 
            // carreratxt
            // 
            carreratxt.Location = new Point(234, 123);
            carreratxt.Name = "carreratxt";
            carreratxt.Size = new Size(100, 23);
            carreratxt.TabIndex = 26;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(carreratxt);
            Controls.Add(label1);
            Controls.Add(datosUniversidadtxt);
            Controls.Add(volverAlMenubtn);
            Controls.Add(dataGridView1);
            Controls.Add(generarImpresionbtn);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generarImpresionbtn;
        private DataGridView dataGridView1;
        private Button volverAlMenubtn;
        private TextBox datosUniversidadtxt;
        private Label label1;
        private Label label2;
        private TextBox carreratxt;
    }
}