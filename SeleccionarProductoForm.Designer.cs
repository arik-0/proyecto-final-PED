namespace proyecto_final_PED
{
    partial class SeleccionarProductoForm
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
            aceptarbtn = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // aceptarbtn
            // 
            aceptarbtn.Location = new Point(36, 122);
            aceptarbtn.Name = "aceptarbtn";
            aceptarbtn.Size = new Size(94, 29);
            aceptarbtn.TabIndex = 3;
            aceptarbtn.Text = "Aceptar";
            aceptarbtn.UseVisualStyleBackColor = true;
            aceptarbtn.Click += aceptarbtn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 2;
            // 
            // SeleccionarProductoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(173, 157);
            Controls.Add(aceptarbtn);
            Controls.Add(listBox1);
            Name = "SeleccionarProductoForm";
            Text = "SeleccionarProductoForm";
            ResumeLayout(false);
        }

        #endregion

        private Button aceptarbtn;
        private ListBox listBox1;
    }
}