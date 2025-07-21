namespace proyecto_final_PED
{
    partial class Form3
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
            generarRubrobtn = new Button();
            label1 = new Label();
            nombreRubrotxt = new TextBox();
            label2 = new Label();
            descripcionRubrotxt = new TextBox();
            volvermenubtn = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // generarRubrobtn
            // 
            generarRubrobtn.Location = new Point(91, 393);
            generarRubrobtn.Margin = new Padding(3, 4, 3, 4);
            generarRubrobtn.Name = "generarRubrobtn";
            generarRubrobtn.Size = new Size(201, 92);
            generarRubrobtn.TabIndex = 0;
            generarRubrobtn.Text = "Generar Rubro";
            generarRubrobtn.UseVisualStyleBackColor = true;
            generarRubrobtn.Click += generarRubrobtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(77, 150);
            label1.Name = "label1";
            label1.Size = new Size(200, 28);
            label1.TabIndex = 2;
            label1.Text = "Descripcion de Rubro";
            // 
            // nombreRubrotxt
            // 
            nombreRubrotxt.Location = new Point(48, 164);
            nombreRubrotxt.Margin = new Padding(3, 4, 3, 4);
            nombreRubrotxt.Name = "nombreRubrotxt";
            nombreRubrotxt.Size = new Size(278, 27);
            nombreRubrotxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(101, 113);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 4;
            label2.Text = "Nombre de rubro";
            // 
            // descripcionRubrotxt
            // 
            descripcionRubrotxt.Location = new Point(34, 191);
            descripcionRubrotxt.Margin = new Padding(3, 4, 3, 4);
            descripcionRubrotxt.Multiline = true;
            descripcionRubrotxt.Name = "descripcionRubrotxt";
            descripcionRubrotxt.Size = new Size(278, 95);
            descripcionRubrotxt.TabIndex = 5;
            // 
            // volvermenubtn
            // 
            volvermenubtn.Location = new Point(271, 519);
            volvermenubtn.Margin = new Padding(3, 4, 3, 4);
            volvermenubtn.Name = "volvermenubtn";
            volvermenubtn.Size = new Size(86, 68);
            volvermenubtn.TabIndex = 9;
            volvermenubtn.Text = "Volver al menu";
            volvermenubtn.UseVisualStyleBackColor = true;
            volvermenubtn.Click += volvermenubtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(descripcionRubrotxt);
            groupBox1.Location = new Point(14, 81);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(343, 412);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(374, 600);
            Controls.Add(volvermenubtn);
            Controls.Add(label2);
            Controls.Add(nombreRubrotxt);
            Controls.Add(generarRubrobtn);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generarRubrobtn;
        private Label label1;
        private TextBox nombreRubrotxt;
        private Label label2;
        private TextBox descripcionRubrotxt;
        private Button volvermenubtn;
        private GroupBox groupBox1;
    }
}