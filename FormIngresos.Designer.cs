namespace proyecto_final_PED
{
    partial class FormIngresos
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
            label6 = new Label();
            label2 = new Label();
            fechavtocal = new MonthCalendar();
            stockud = new NumericUpDown();
            groupBox1 = new GroupBox();
            proveedoreslstbx = new CheckedListBox();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            ingresarbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)stockud).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(462, 122);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 18;
            label6.Text = "Fecha vto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 55);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 17;
            label2.Text = "Stock Entrante";
            // 
            // fechavtocal
            // 
            fechavtocal.Location = new Point(462, 143);
            fechavtocal.MinDate = new DateTime(2025, 7, 22, 0, 0, 0, 0);
            fechavtocal.Name = "fechavtocal";
            fechavtocal.TabIndex = 16;
            // 
            // stockud
            // 
            stockud.Location = new Point(462, 78);
            stockud.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            stockud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            stockud.Name = "stockud";
            stockud.Size = new Size(150, 27);
            stockud.TabIndex = 15;
            stockud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(proveedoreslstbx);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(33, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 409);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // proveedoreslstbx
            // 
            proveedoreslstbx.FormattingEnabled = true;
            proveedoreslstbx.Location = new Point(17, 240);
            proveedoreslstbx.Name = "proveedoreslstbx";
            proveedoreslstbx.Size = new Size(375, 136);
            proveedoreslstbx.TabIndex = 1;
            proveedoreslstbx.ItemCheck += proveedoreslstbx_ItemCheck;
            proveedoreslstbx.SelectedIndexChanged += proveedoreslstbx_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Stock });
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(405, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.Width = 125;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ingresarbtn);
            groupBox2.Location = new Point(456, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 409);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // ingresarbtn
            // 
            ingresarbtn.Location = new Point(18, 333);
            ingresarbtn.Name = "ingresarbtn";
            ingresarbtn.Size = new Size(118, 70);
            ingresarbtn.TabIndex = 0;
            ingresarbtn.Text = "Ingresar";
            ingresarbtn.UseVisualStyleBackColor = true;
            ingresarbtn.Click += ingresarbtn_Click;
            // 
            // FormIngresos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 450);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(fechavtocal);
            Controls.Add(stockud);
            Controls.Add(groupBox2);
            Name = "FormIngresos";
            Text = "FormIngresos";
            Load += FormIngresos_Load;
            ((System.ComponentModel.ISupportInitialize)stockud).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label2;
        private MonthCalendar fechavtocal;
        private NumericUpDown stockud;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private CheckedListBox proveedoreslstbx;
        private GroupBox groupBox2;
        private Button ingresarbtn;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Stock;
    }
}