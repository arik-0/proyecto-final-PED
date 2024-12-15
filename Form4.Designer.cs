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
            dataGridView1 = new DataGridView();
            volverAlMenubtn = new Button();
            generarImpresionbtn = new Button();
            datosUniversidadtxt = new TextBox();
            label1 = new Label();
            carreratxt = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(385, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(403, 333);
            dataGridView1.TabIndex = 22;
            // 
            // volverAlMenubtn
            // 
            volverAlMenubtn.Location = new Point(713, 383);
            volverAlMenubtn.Name = "volverAlMenubtn";
            volverAlMenubtn.Size = new Size(75, 65);
            volverAlMenubtn.TabIndex = 23;
            volverAlMenubtn.Text = "Volver al menu";
            volverAlMenubtn.UseVisualStyleBackColor = true;
            volverAlMenubtn.Click += volverAlMenubtn_Click;
            // 
            // generarImpresionbtn
            // 
            generarImpresionbtn.Location = new Point(60, 261);
            generarImpresionbtn.Name = "generarImpresionbtn";
            generarImpresionbtn.Size = new Size(210, 57);
            generarImpresionbtn.TabIndex = 0;
            generarImpresionbtn.Text = "Generar Impresion";
            generarImpresionbtn.UseVisualStyleBackColor = true;
            generarImpresionbtn.Click += generarImpresionbtn_Click;
            // 
            // datosUniversidadtxt
            // 
            datosUniversidadtxt.Location = new Point(79, 101);
            datosUniversidadtxt.Name = "datosUniversidadtxt";
            datosUniversidadtxt.Size = new Size(173, 23);
            datosUniversidadtxt.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(16, 43);
            label1.Name = "label1";
            label1.Size = new Size(299, 37);
            label1.TabIndex = 25;
            label1.Text = "Datos de la Universidad";
            // 
            // carreratxt
            // 
            carreratxt.Location = new Point(79, 195);
            carreratxt.Name = "carreratxt";
            carreratxt.Size = new Size(173, 23);
            carreratxt.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(114, 144);
            label2.Name = "label2";
            label2.Size = new Size(103, 37);
            label2.TabIndex = 27;
            label2.Text = "Carrera";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(carreratxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(datosUniversidadtxt);
            groupBox1.Controls.Add(generarImpresionbtn);
            groupBox1.Location = new Point(37, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 333);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(volverAlMenubtn);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button volverAlMenubtn;
        private Button generarImpresionbtn;
        private TextBox datosUniversidadtxt;
        private Label label1;
        private TextBox carreratxt;
        private Label label2;
        private GroupBox groupBox1;
    }
}