namespace proyecto_final_PED
{
    partial class ModificarProductos
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            label6 = new Label();
            fechavtocal = new MonthCalendar();
            label5 = new Label();
            modificarProductosbtn = new Button();
            label4 = new Label();
            nombretxt = new TextBox();
            label3 = new Label();
            descripciontxt = new TextBox();
            label2 = new Label();
            stockud = new NumericUpDown();
            label1 = new Label();
            precioCompraud = new NumericUpDown();
            rubroslstbx = new CheckedListBox();
            codigotxt = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)precioCompraud).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(360, 394);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(codigotxt);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(fechavtocal);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(modificarProductosbtn);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(nombretxt);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(descripciontxt);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(stockud);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(precioCompraud);
            groupBox2.Controls.Add(rubroslstbx);
            groupBox2.Location = new Point(404, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 144);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 27;
            label6.Text = "Fecha vto";
            // 
            // fechavtocal
            // 
            fechavtocal.Location = new Point(178, 165);
            fechavtocal.Name = "fechavtocal";
            fechavtocal.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 41);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 26;
            label5.Text = "Descripcion";
            // 
            // modificarProductosbtn
            // 
            modificarProductosbtn.Location = new Point(347, 54);
            modificarProductosbtn.Name = "modificarProductosbtn";
            modificarProductosbtn.Size = new Size(91, 87);
            modificarProductosbtn.TabIndex = 15;
            modificarProductosbtn.Text = "Modificar Producto";
            modificarProductosbtn.UseVisualStyleBackColor = true;
            modificarProductosbtn.Click += modificarProductosbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 220);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 25;
            label4.Text = "Rubros";
            // 
            // nombretxt
            // 
            nombretxt.Location = new Point(4, 60);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(125, 27);
            nombretxt.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 155);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 24;
            label3.Text = "Precio de Compra";
            // 
            // descripciontxt
            // 
            descripciontxt.Location = new Point(181, 64);
            descripciontxt.Multiline = true;
            descripciontxt.Name = "descripciontxt";
            descripciontxt.Size = new Size(159, 66);
            descripciontxt.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 99);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 23;
            label2.Text = "Stock";
            // 
            // stockud
            // 
            stockud.Location = new Point(6, 122);
            stockud.Name = "stockud";
            stockud.Size = new Size(150, 27);
            stockud.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 40);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 22;
            label1.Text = "Nombre";
            // 
            // precioCompraud
            // 
            precioCompraud.Location = new Point(6, 178);
            precioCompraud.Name = "precioCompraud";
            precioCompraud.Size = new Size(150, 27);
            precioCompraud.TabIndex = 19;
            // 
            // rubroslstbx
            // 
            rubroslstbx.FormattingEnabled = true;
            rubroslstbx.Location = new Point(6, 243);
            rubroslstbx.Name = "rubroslstbx";
            rubroslstbx.Size = new Size(150, 114);
            rubroslstbx.TabIndex = 21;
            // 
            // codigotxt
            // 
            codigotxt.Location = new Point(6, 380);
            codigotxt.Name = "codigotxt";
            codigotxt.Size = new Size(125, 27);
            codigotxt.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 360);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 29;
            label7.Text = "Codigo";
            // 
            // ModificarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ModificarProductos";
            Text = "Form6";
            Load += ModificarProductos_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockud).EndInit();
            ((System.ComponentModel.ISupportInitialize)precioCompraud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Label label6;
        private MonthCalendar fechavtocal;
        private Label label5;
        private Button modificarProductosbtn;
        private Label label4;
        private TextBox nombretxt;
        private Label label3;
        private TextBox descripciontxt;
        private Label label2;
        private NumericUpDown stockud;
        private Label label1;
        private NumericUpDown precioCompraud;
        private CheckedListBox rubroslstbx;
        private TextBox codigotxt;
        private Label label7;
    }
}