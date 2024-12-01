namespace proyecto_final_PED
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            adminPregbtn = new Button();
            generadorExambtn = new Button();
            Correctorbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 92);
            label1.Name = "label1";
            label1.Size = new Size(186, 15);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al gestor de examenes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 157);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "Seleccione el modulo:";
            // 
            // adminPregbtn
            // 
            adminPregbtn.Location = new Point(161, 228);
            adminPregbtn.Name = "adminPregbtn";
            adminPregbtn.Size = new Size(154, 49);
            adminPregbtn.TabIndex = 2;
            adminPregbtn.Text = "Administrador de Preguntas";
            adminPregbtn.UseVisualStyleBackColor = true;
            adminPregbtn.Click += adminPregbtn_Click;
            // 
            // generadorExambtn
            // 
            generadorExambtn.Location = new Point(348, 228);
            generadorExambtn.Name = "generadorExambtn";
            generadorExambtn.Size = new Size(75, 23);
            generadorExambtn.TabIndex = 3;
            generadorExambtn.Text = "Generador de examenes";
            generadorExambtn.UseVisualStyleBackColor = true;
            // 
            // Correctorbtn
            // 
            Correctorbtn.Location = new Point(429, 228);
            Correctorbtn.Name = "Correctorbtn";
            Correctorbtn.Size = new Size(75, 23);
            Correctorbtn.TabIndex = 4;
            Correctorbtn.Text = "Corrector de examenes";
            Correctorbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Correctorbtn);
            Controls.Add(generadorExambtn);
            Controls.Add(adminPregbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button adminPregbtn;
        private Button generadorExambtn;
        private Button Correctorbtn;
    }
}
