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
            volvermenubtn = new Button();
            agregarRubrosbtn = new Button();
            modificarRubrosbtn = new Button();
            eliminarRubrosbtn = new Button();
            consultarRubrosbtn = new Button();
            SuspendLayout();
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
            // agregarRubrosbtn
            // 
            agregarRubrosbtn.Location = new Point(75, 216);
            agregarRubrosbtn.Name = "agregarRubrosbtn";
            agregarRubrosbtn.Size = new Size(94, 57);
            agregarRubrosbtn.TabIndex = 10;
            agregarRubrosbtn.Text = "Agregar Rubros";
            agregarRubrosbtn.UseVisualStyleBackColor = true;
            agregarRubrosbtn.Click += agregarRubrosbtn_Click;
            // 
            // modificarRubrosbtn
            // 
            modificarRubrosbtn.Location = new Point(75, 274);
            modificarRubrosbtn.Name = "modificarRubrosbtn";
            modificarRubrosbtn.Size = new Size(94, 57);
            modificarRubrosbtn.TabIndex = 11;
            modificarRubrosbtn.Text = "Modificar Rubros";
            modificarRubrosbtn.UseVisualStyleBackColor = true;
            modificarRubrosbtn.Click += modificarRubrosbtn_Click;
            // 
            // eliminarRubrosbtn
            // 
            eliminarRubrosbtn.Location = new Point(175, 216);
            eliminarRubrosbtn.Name = "eliminarRubrosbtn";
            eliminarRubrosbtn.Size = new Size(94, 57);
            eliminarRubrosbtn.TabIndex = 12;
            eliminarRubrosbtn.Text = "Eliminar Rubros";
            eliminarRubrosbtn.UseVisualStyleBackColor = true;
            eliminarRubrosbtn.Click += eliminarRubrosbtn_Click;
            // 
            // consultarRubrosbtn
            // 
            consultarRubrosbtn.Location = new Point(175, 274);
            consultarRubrosbtn.Name = "consultarRubrosbtn";
            consultarRubrosbtn.Size = new Size(94, 57);
            consultarRubrosbtn.TabIndex = 13;
            consultarRubrosbtn.Text = "Consultar Rubros";
            consultarRubrosbtn.UseVisualStyleBackColor = true;
            consultarRubrosbtn.Click += consultarRubrosbtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(374, 600);
            Controls.Add(consultarRubrosbtn);
            Controls.Add(eliminarRubrosbtn);
            Controls.Add(modificarRubrosbtn);
            Controls.Add(agregarRubrosbtn);
            Controls.Add(volvermenubtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button volvermenubtn;
        private Button agregarRubrosbtn;
        private Button modificarRubrosbtn;
        private Button eliminarRubrosbtn;
        private Button consultarRubrosbtn;
    }
}