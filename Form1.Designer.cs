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
            generadorArchivosbtn = new Button();
            borrardatosbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(190, 96);
            label1.Name = "label1";
            label1.Size = new Size(420, 37);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al gestor de examenes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(262, 160);
            label2.Name = "label2";
            label2.Size = new Size(276, 37);
            label2.TabIndex = 1;
            label2.Text = "Seleccione el modulo:";
            // 
            // adminPregbtn
            // 
            adminPregbtn.Location = new Point(302, 228);
            adminPregbtn.Name = "adminPregbtn";
            adminPregbtn.Size = new Size(95, 57);
            adminPregbtn.TabIndex = 2;
            adminPregbtn.Text = "Administrador de Preguntas";
            adminPregbtn.UseVisualStyleBackColor = true;
            adminPregbtn.Click += adminPregbtn_Click;
            // 
            // generadorExambtn
            // 
            generadorExambtn.Location = new Point(405, 228);
            generadorExambtn.Name = "generadorExambtn";
            generadorExambtn.Size = new Size(94, 57);
            generadorExambtn.TabIndex = 3;
            generadorExambtn.Text = "Generador de examenes";
            generadorExambtn.UseVisualStyleBackColor = true;
            generadorExambtn.Click += generadorExambtn_Click;
            // 
            // Correctorbtn
            // 
            Correctorbtn.Location = new Point(302, 291);
            Correctorbtn.Name = "Correctorbtn";
            Correctorbtn.Size = new Size(95, 57);
            Correctorbtn.TabIndex = 4;
            Correctorbtn.Text = "Corrector de examenes";
            Correctorbtn.UseVisualStyleBackColor = true;
            Correctorbtn.Click += Correctorbtn_Click;
            // 
            // generadorArchivosbtn
            // 
            generadorArchivosbtn.Location = new Point(405, 291);
            generadorArchivosbtn.Name = "generadorArchivosbtn";
            generadorArchivosbtn.Size = new Size(94, 57);
            generadorArchivosbtn.TabIndex = 5;
            generadorArchivosbtn.Text = "Generacion de Archivos \"examen\"";
            generadorArchivosbtn.UseVisualStyleBackColor = true;
            generadorArchivosbtn.Click += generadorArchivosbtn_Click;
            // 
            // borrardatosbtn
            // 
            borrardatosbtn.Location = new Point(702, 394);
            borrardatosbtn.Name = "borrardatosbtn";
            borrardatosbtn.Size = new Size(75, 44);
            borrardatosbtn.TabIndex = 6;
            borrardatosbtn.Text = "Borrar datos";
            borrardatosbtn.UseVisualStyleBackColor = true;
            borrardatosbtn.Click += borrardatosbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(borrardatosbtn);
            Controls.Add(generadorArchivosbtn);
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
        private Button generadorArchivosbtn;
        private Button borrardatosbtn;
    }
}
