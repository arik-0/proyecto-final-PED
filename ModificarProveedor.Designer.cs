namespace proyecto_final_PED
{
    partial class ModificarProveedor
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
            groupBox2 = new GroupBox();
            direcciontxt = new TextBox();
            label4 = new Label();
            telefonotxt = new TextBox();
            contactotxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            modificarRubrobtn = new Button();
            nombretxt = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(direcciontxt);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(telefonotxt);
            groupBox2.Controls.Add(contactotxt);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(modificarRubrobtn);
            groupBox2.Controls.Add(nombretxt);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(491, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(196, 426);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // direcciontxt
            // 
            direcciontxt.Location = new Point(4, 244);
            direcciontxt.Name = "direcciontxt";
            direcciontxt.Size = new Size(125, 27);
            direcciontxt.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 224);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 30;
            label4.Text = "Direccion";
            // 
            // telefonotxt
            // 
            telefonotxt.Location = new Point(4, 178);
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(125, 27);
            telefonotxt.TabIndex = 23;
            // 
            // contactotxt
            // 
            contactotxt.Location = new Point(4, 117);
            contactotxt.Name = "contactotxt";
            contactotxt.Size = new Size(125, 27);
            contactotxt.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 158);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 24;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 97);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 28;
            label2.Text = "Contacto";
            // 
            // modificarRubrobtn
            // 
            modificarRubrobtn.Location = new Point(6, 333);
            modificarRubrobtn.Name = "modificarRubrobtn";
            modificarRubrobtn.Size = new Size(91, 87);
            modificarRubrobtn.TabIndex = 15;
            modificarRubrobtn.Text = "Modificar Rubro";
            modificarRubrobtn.UseVisualStyleBackColor = true;
            modificarRubrobtn.Click += modificarRubrobtn_Click;
            // 
            // nombretxt
            // 
            nombretxt.Location = new Point(4, 60);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(125, 27);
            nombretxt.TabIndex = 16;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(113, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 426);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(360, 394);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // ModificarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ModificarProveedor";
            Text = "ModificarProveedor";
            Load += ModificarProveedor_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button modificarRubrobtn;
        private TextBox nombretxt;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox direcciontxt;
        private Label label4;
        private TextBox telefonotxt;
        private TextBox contactotxt;
        private Label label3;
        private Label label2;
    }
}