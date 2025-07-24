namespace proyecto_final_PED
{
    partial class SeleccionarProveedorForm
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
            listBox1 = new ListBox();
            aceptarbtn = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 0;
            // 
            // aceptarbtn
            // 
            aceptarbtn.Location = new Point(36, 131);
            aceptarbtn.Name = "aceptarbtn";
            aceptarbtn.Size = new Size(94, 29);
            aceptarbtn.TabIndex = 1;
            aceptarbtn.Text = "Aceptar";
            aceptarbtn.UseVisualStyleBackColor = true;
            aceptarbtn.Click += aceptarbtn_Click_1;
            // 
            // SeleccionarProveedorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(177, 170);
            Controls.Add(aceptarbtn);
            Controls.Add(listBox1);
            Name = "SeleccionarProveedorForm";
            Text = "SeleccionarProveedorForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button aceptarbtn;
    }
}