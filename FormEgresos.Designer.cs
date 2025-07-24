namespace proyecto_final_PED
{
    partial class FormEgresos
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
            Nombre = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label2 = new Label();
            fechacal = new MonthCalendar();
            stockud = new NumericUpDown();
            groupBox2 = new GroupBox();
            egresobtn = new Button();
            label1 = new Label();
            observacionestxt = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockud).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(observacionestxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(51, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 409);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Stock });
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(405, 273);
            dataGridView1.TabIndex = 0;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(480, 92);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 24;
            label6.Text = "Fecha egreso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 38);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 23;
            label2.Text = "Stock Saliente";
            // 
            // fechacal
            // 
            fechacal.Location = new Point(480, 113);
            fechacal.MinDate = new DateTime(1999, 1, 1, 0, 0, 0, 0);
            fechacal.Name = "fechacal";
            fechacal.TabIndex = 22;
            // 
            // stockud
            // 
            stockud.Location = new Point(480, 61);
            stockud.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            stockud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            stockud.Name = "stockud";
            stockud.Size = new Size(150, 27);
            stockud.TabIndex = 21;
            stockud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(egresobtn);
            groupBox2.Location = new Point(480, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 409);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // egresobtn
            // 
            egresobtn.Location = new Point(18, 333);
            egresobtn.Name = "egresobtn";
            egresobtn.Size = new Size(118, 70);
            egresobtn.TabIndex = 0;
            egresobtn.Text = "Confirmar";
            egresobtn.UseVisualStyleBackColor = true;
            egresobtn.Click += egresobtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 302);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 27;
            label1.Text = "Observaciones";
            // 
            // observacionestxt
            // 
            observacionestxt.Location = new Point(28, 325);
            observacionestxt.Multiline = true;
            observacionestxt.Name = "observacionestxt";
            observacionestxt.Size = new Size(361, 68);
            observacionestxt.TabIndex = 28;
            // 
            // FormEgresos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(fechacal);
            Controls.Add(stockud);
            Controls.Add(groupBox2);
            Name = "FormEgresos";
            Text = "FormEgresos";
            Load += FormEgresos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockud).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckedListBox proveedoreslstbx;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Stock;
        private Label label6;
        private Label label2;
        private MonthCalendar fechacal;
        private NumericUpDown stockud;
        private GroupBox groupBox2;
        private Button egresobtn;
        private TextBox observacionestxt;
        private Label label1;
    }
}