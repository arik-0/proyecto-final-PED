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
            generarExamenbtn = new Button();
            label1 = new Label();
            asignaturatxt = new TextBox();
            label2 = new Label();
            unidadesIntervalotxt = new TextBox();
            SuspendLayout();
            // 
            // generarExamenbtn
            // 
            generarExamenbtn.Location = new Point(631, 92);
            generarExamenbtn.Name = "generarExamenbtn";
            generarExamenbtn.Size = new Size(75, 58);
            generarExamenbtn.TabIndex = 0;
            generarExamenbtn.Text = "Generar examen";
            generarExamenbtn.UseVisualStyleBackColor = true;
            generarExamenbtn.Click += generarExamenbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 90);
            label1.Name = "label1";
            label1.Size = new Size(213, 15);
            label1.TabIndex = 2;
            label1.Text = "Unidad de preguntas (en formato N-N)";
            // 
            // asignaturatxt
            // 
            asignaturatxt.Location = new Point(110, 124);
            asignaturatxt.Name = "asignaturatxt";
            asignaturatxt.Size = new Size(100, 23);
            asignaturatxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 90);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 4;
            label2.Text = "Asignatura a evaluar";
            // 
            // unidadesIntervalotxt
            // 
            unidadesIntervalotxt.Location = new Point(296, 127);
            unidadesIntervalotxt.Name = "unidadesIntervalotxt";
            unidadesIntervalotxt.Size = new Size(204, 23);
            unidadesIntervalotxt.TabIndex = 5;
            unidadesIntervalotxt.TextChanged += unidadesIntervalotxt_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(unidadesIntervalotxt);
            Controls.Add(label2);
            Controls.Add(asignaturatxt);
            Controls.Add(label1);
            Controls.Add(generarExamenbtn);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generarExamenbtn;
        private Label label1;
        private TextBox asignaturatxt;
        private Label label2;
        private TextBox unidadesIntervalotxt;
    }
}