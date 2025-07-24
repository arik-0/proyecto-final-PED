namespace proyecto_final_PED
{
    partial class ModificarRubro
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
            label5 = new Label();
            modificarRubrobtn = new Button();
            nombretxt = new TextBox();
            descripciontxt = new TextBox();
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
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(modificarRubrobtn);
            groupBox2.Controls.Add(nombretxt);
            groupBox2.Controls.Add(descripciontxt);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(389, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(196, 426);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 95);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 26;
            label5.Text = "Descripcion";
            // 
            // modificarRubrobtn
            // 
            modificarRubrobtn.Location = new Point(6, 221);
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
            // descripciontxt
            // 
            descripciontxt.Location = new Point(6, 118);
            descripciontxt.Multiline = true;
            descripciontxt.Name = "descripciontxt";
            descripciontxt.Size = new Size(159, 66);
            descripciontxt.TabIndex = 17;
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
            groupBox1.Location = new Point(11, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 426);
            groupBox1.TabIndex = 2;
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
            // ModificarRubro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ModificarRubro";
            Text = "ModificarRubro";
            Load += ModificarRubro_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label5;
        private Button modificarRubrobtn;
        private TextBox nombretxt;
        private TextBox descripciontxt;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}