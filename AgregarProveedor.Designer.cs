namespace proyecto_final_PED
{
    partial class AgregarProveedor
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
            label1 = new Label();
            nombretxt = new TextBox();
            agregarProveedorbtn = new Button();
            label2 = new Label();
            contactotxt = new TextBox();
            label3 = new Label();
            telefonotxt = new TextBox();
            label4 = new Label();
            direcciontxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 61);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 22;
            label1.Text = "Nombre";
            // 
            // nombretxt
            // 
            nombretxt.Location = new Point(183, 81);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(125, 27);
            nombretxt.TabIndex = 16;
            // 
            // agregarProveedorbtn
            // 
            agregarProveedorbtn.Location = new Point(526, 73);
            agregarProveedorbtn.Name = "agregarProveedorbtn";
            agregarProveedorbtn.Size = new Size(91, 87);
            agregarProveedorbtn.TabIndex = 15;
            agregarProveedorbtn.Text = "Agregar Proveedor";
            agregarProveedorbtn.UseVisualStyleBackColor = true;
            agregarProveedorbtn.Click += agregarProveedorbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 122);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 28;
            label2.Text = "Contacto";
            // 
            // contactotxt
            // 
            contactotxt.Location = new Point(183, 142);
            contactotxt.Name = "contactotxt";
            contactotxt.Size = new Size(125, 27);
            contactotxt.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 122);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 30;
            label3.Text = "Telefono";
            // 
            // telefonotxt
            // 
            telefonotxt.Location = new Point(350, 142);
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(125, 27);
            telefonotxt.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 61);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 32;
            label4.Text = "Direccion";
            // 
            // direcciontxt
            // 
            direcciontxt.Location = new Point(350, 81);
            direcciontxt.Name = "direcciontxt";
            direcciontxt.Size = new Size(125, 27);
            direcciontxt.TabIndex = 31;
            // 
            // AgregarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(direcciontxt);
            Controls.Add(label3);
            Controls.Add(telefonotxt);
            Controls.Add(label2);
            Controls.Add(contactotxt);
            Controls.Add(label1);
            Controls.Add(nombretxt);
            Controls.Add(agregarProveedorbtn);
            Name = "AgregarProveedor";
            Text = "AgregarProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox nombretxt;
        private Button agregarProveedorbtn;
        private Label label2;
        private TextBox contactotxt;
        private Label label3;
        private TextBox telefonotxt;
        private Label label4;
        private TextBox direcciontxt;
    }
}