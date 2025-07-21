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
            gestionProdbtn = new Button();
            gestionRubrosbtn = new Button();
            gestionProveedoresbtn = new Button();
            gestionMovimientosbtn = new Button();
            borrardatosbtn = new Button();
            reportesbtn = new Button();
            salirbtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(217, 128);
            label1.Name = "label1";
            label1.Size = new Size(462, 46);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al gestor de Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(299, 213);
            label2.Name = "label2";
            label2.Size = new Size(346, 46);
            label2.TabIndex = 1;
            label2.Text = "Seleccione el modulo:";
            // 
            // gestionProdbtn
            // 
            gestionProdbtn.Location = new Point(345, 304);
            gestionProdbtn.Margin = new Padding(3, 4, 3, 4);
            gestionProdbtn.Name = "gestionProdbtn";
            gestionProdbtn.Size = new Size(109, 76);
            gestionProdbtn.TabIndex = 2;
            gestionProdbtn.Text = "Gestión de Productos";
            gestionProdbtn.UseVisualStyleBackColor = true;
            gestionProdbtn.Click += gestionProdbtn_Click_1;
            // 
            // gestionRubrosbtn
            // 
            gestionRubrosbtn.Location = new Point(463, 304);
            gestionRubrosbtn.Margin = new Padding(3, 4, 3, 4);
            gestionRubrosbtn.Name = "gestionRubrosbtn";
            gestionRubrosbtn.Size = new Size(107, 76);
            gestionRubrosbtn.TabIndex = 3;
            gestionRubrosbtn.Text = "Gestion de Rubros";
            gestionRubrosbtn.UseVisualStyleBackColor = true;
            gestionRubrosbtn.Click += gestionRubrosbtn_Click;
            // 
            // gestionProveedoresbtn
            // 
            gestionProveedoresbtn.Location = new Point(345, 388);
            gestionProveedoresbtn.Margin = new Padding(3, 4, 3, 4);
            gestionProveedoresbtn.Name = "gestionProveedoresbtn";
            gestionProveedoresbtn.Size = new Size(109, 76);
            gestionProveedoresbtn.TabIndex = 4;
            gestionProveedoresbtn.Text = "Gestion de Proveedores";
            gestionProveedoresbtn.UseVisualStyleBackColor = true;
            gestionProveedoresbtn.Click += Correctorbtn_Click;
            // 
            // gestionMovimientosbtn
            // 
            gestionMovimientosbtn.Location = new Point(463, 388);
            gestionMovimientosbtn.Margin = new Padding(3, 4, 3, 4);
            gestionMovimientosbtn.Name = "gestionMovimientosbtn";
            gestionMovimientosbtn.Size = new Size(107, 76);
            gestionMovimientosbtn.TabIndex = 5;
            gestionMovimientosbtn.Text = "Gestion de Movimientos de Stock";
            gestionMovimientosbtn.UseVisualStyleBackColor = true;
            gestionMovimientosbtn.Click += generadorArchivosbtn_Click;
            // 
            // borrardatosbtn
            // 
            borrardatosbtn.Location = new Point(802, 525);
            borrardatosbtn.Margin = new Padding(3, 4, 3, 4);
            borrardatosbtn.Name = "borrardatosbtn";
            borrardatosbtn.Size = new Size(86, 59);
            borrardatosbtn.TabIndex = 6;
            borrardatosbtn.Text = "Borrar datos";
            borrardatosbtn.UseVisualStyleBackColor = true;
            // 
            // reportesbtn
            // 
            reportesbtn.Location = new Point(406, 472);
            reportesbtn.Margin = new Padding(3, 4, 3, 4);
            reportesbtn.Name = "reportesbtn";
            reportesbtn.Size = new Size(107, 76);
            reportesbtn.TabIndex = 7;
            reportesbtn.Text = "Reportes";
            reportesbtn.UseVisualStyleBackColor = true;
            // 
            // salirbtn
            // 
            salirbtn.Location = new Point(865, 13);
            salirbtn.Margin = new Padding(3, 4, 3, 4);
            salirbtn.Name = "salirbtn";
            salirbtn.Size = new Size(37, 29);
            salirbtn.TabIndex = 8;
            salirbtn.Text = "x";
            salirbtn.UseVisualStyleBackColor = true;
            salirbtn.Click += salirbtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 528);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 59);
            button1.TabIndex = 9;
            button1.Text = "Creditos";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(salirbtn);
            Controls.Add(reportesbtn);
            Controls.Add(borrardatosbtn);
            Controls.Add(gestionMovimientosbtn);
            Controls.Add(gestionProveedoresbtn);
            Controls.Add(gestionRubrosbtn);
            Controls.Add(gestionProdbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button gestionProdbtn;
        private Button gestionRubrosbtn;
        private Button gestionProveedoresbtn;
        private Button gestionMovimientosbtn;
        private Button borrardatosbtn;
        private Button reportesbtn;
        private Button salirbtn;
        private Button button1;
    }
}
