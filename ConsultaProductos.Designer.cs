namespace proyecto_final_PED
{
    partial class ConsultaProductos
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            nombreProdtxt = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            rubroslstbx = new CheckedListBox();
            buscarbtn = new Button();
            volverAlMenubtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(479, 373);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 415);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nombreProdtxt);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(529, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(259, 197);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // nombreProdtxt
            // 
            nombreProdtxt.Location = new Point(54, 111);
            nombreProdtxt.Name = "nombreProdtxt";
            nombreProdtxt.Size = new Size(142, 27);
            nombreProdtxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 54);
            label1.Name = "label1";
            label1.Size = new Size(142, 40);
            label1.TabIndex = 0;
            label1.Text = "Ingrese nombre del \r\nproducto a buscar\r\n";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rubroslstbx);
            groupBox3.Location = new Point(529, 226);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(259, 176);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // rubroslstbx
            // 
            rubroslstbx.FormattingEnabled = true;
            rubroslstbx.Location = new Point(54, 31);
            rubroslstbx.Name = "rubroslstbx";
            rubroslstbx.Size = new Size(150, 114);
            rubroslstbx.TabIndex = 22;
            // 
            // buscarbtn
            // 
            buscarbtn.Location = new Point(794, 144);
            buscarbtn.Name = "buscarbtn";
            buscarbtn.Size = new Size(97, 76);
            buscarbtn.TabIndex = 4;
            buscarbtn.Text = "Buscar";
            buscarbtn.UseVisualStyleBackColor = true;
            buscarbtn.Click += buscarbtn_Click;
            // 
            // volverAlMenubtn
            // 
            volverAlMenubtn.Location = new Point(794, 49);
            volverAlMenubtn.Name = "volverAlMenubtn";
            volverAlMenubtn.Size = new Size(97, 76);
            volverAlMenubtn.TabIndex = 6;
            volverAlMenubtn.Text = "Volver al menu";
            volverAlMenubtn.UseVisualStyleBackColor = true;
            // 
            // ConsultaProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 460);
            Controls.Add(volverAlMenubtn);
            Controls.Add(buscarbtn);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "ConsultaProductos";
            Text = "ConsultaProductos";
            Load += ConsultaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Button buscarbtn;
        private Button volverAlMenubtn;
        private TextBox nombreProdtxt;
        private CheckedListBox rubroslstbx;
    }
}