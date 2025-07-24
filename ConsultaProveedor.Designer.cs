namespace proyecto_final_PED
{
    partial class ConsultaProveedor
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
            buscarbtn = new Button();
            groupBox2 = new GroupBox();
            nombreProvtxt = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // volverAlMenubtn
            // 
            volverAlMenubtn.Location = new Point(789, 44);
            volverAlMenubtn.Name = "volverAlMenubtn";
            volverAlMenubtn.Size = new Size(97, 76);
            volverAlMenubtn.TabIndex = 12;
            volverAlMenubtn.Text = "Volver al menu";
            volverAlMenubtn.UseVisualStyleBackColor = true;
            // 
            // buscarbtn
            // 
            buscarbtn.Location = new Point(789, 139);
            buscarbtn.Name = "buscarbtn";
            buscarbtn.Size = new Size(97, 76);
            buscarbtn.TabIndex = 11;
            buscarbtn.Text = "Buscar";
            buscarbtn.UseVisualStyleBackColor = true;
            buscarbtn.Click += buscarbtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nombreProvtxt);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(524, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(259, 197);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // nombreProvtxt
            // 
            nombreProvtxt.Location = new Point(54, 111);
            nombreProvtxt.Name = "nombreProvtxt";
            nombreProvtxt.Size = new Size(142, 27);
            nombreProvtxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 54);
            label1.Name = "label1";
            label1.Size = new Size(117, 40);
            label1.TabIndex = 0;
            label1.Text = "Ingrese nombre \r\ndel proveedor";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(479, 373);
            dataGridView1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(7, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 415);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // ConsultaProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 450);
            Controls.Add(volverAlMenubtn);
            Controls.Add(buscarbtn);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "ConsultaProveedor";
            Text = "ConsultaProveedor";
            Load += ConsultaProveedor_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button volverAlMenubtn;
        private Button buscarbtn;
        private GroupBox groupBox2;
        private TextBox nombreProvtxt;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
    }
}