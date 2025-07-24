namespace proyecto_final_PED
{
    partial class Form4
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
            consultarProveedoresbtn = new Button();
            modificarProveedorbtn = new Button();
            agregarProveedorbtn = new Button();
            eliminarProveedorbtn = new Button();
            SuspendLayout();
            // 
            // consultarProveedoresbtn
            // 
            consultarProveedoresbtn.Location = new Point(442, 184);
            consultarProveedoresbtn.Name = "consultarProveedoresbtn";
            consultarProveedoresbtn.Size = new Size(103, 78);
            consultarProveedoresbtn.TabIndex = 3;
            consultarProveedoresbtn.Text = "Consultar Proveedores";
            consultarProveedoresbtn.UseVisualStyleBackColor = true;
            consultarProveedoresbtn.Click += consultarProveedoresbtn_Click;
            // 
            // modificarProveedorbtn
            // 
            modificarProveedorbtn.Location = new Point(342, 184);
            modificarProveedorbtn.Name = "modificarProveedorbtn";
            modificarProveedorbtn.Size = new Size(103, 78);
            modificarProveedorbtn.TabIndex = 4;
            modificarProveedorbtn.Text = "Modificar Proveedor";
            modificarProveedorbtn.UseVisualStyleBackColor = true;
            modificarProveedorbtn.Click += modificarProveedorbtn_Click;
            // 
            // agregarProveedorbtn
            // 
            agregarProveedorbtn.Location = new Point(342, 100);
            agregarProveedorbtn.Name = "agregarProveedorbtn";
            agregarProveedorbtn.Size = new Size(103, 78);
            agregarProveedorbtn.TabIndex = 5;
            agregarProveedorbtn.Text = "Agregar proveedor";
            agregarProveedorbtn.UseVisualStyleBackColor = true;
            agregarProveedorbtn.Click += agregarProveedorbtn_Click;
            // 
            // eliminarProveedorbtn
            // 
            eliminarProveedorbtn.Location = new Point(442, 100);
            eliminarProveedorbtn.Name = "eliminarProveedorbtn";
            eliminarProveedorbtn.Size = new Size(103, 78);
            eliminarProveedorbtn.TabIndex = 6;
            eliminarProveedorbtn.Text = "Eliminar Proveedor";
            eliminarProveedorbtn.UseVisualStyleBackColor = true;
            eliminarProveedorbtn.Click += eliminarProveedorbtn_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 403);
            Controls.Add(eliminarProveedorbtn);
            Controls.Add(agregarProveedorbtn);
            Controls.Add(modificarProveedorbtn);
            Controls.Add(consultarProveedoresbtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button consultarProveedoresbtn;
        private Button modificarProveedorbtn;
        private Button agregarProveedorbtn;
        private Button eliminarProveedorbtn;
    }
}