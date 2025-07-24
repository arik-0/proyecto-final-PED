namespace proyecto_final_PED
{
    partial class Form5
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
            ingresobtn = new Button();
            egresobtn = new Button();
            consultaMovimientosbtn = new Button();
            SuspendLayout();
            // 
            // ingresobtn
            // 
            ingresobtn.Location = new Point(260, 158);
            ingresobtn.Name = "ingresobtn";
            ingresobtn.Size = new Size(94, 71);
            ingresobtn.TabIndex = 0;
            ingresobtn.Text = "Ingreso";
            ingresobtn.UseVisualStyleBackColor = true;
            ingresobtn.Click += ingresobtn_Click;
            // 
            // egresobtn
            // 
            egresobtn.Location = new Point(360, 158);
            egresobtn.Name = "egresobtn";
            egresobtn.Size = new Size(94, 71);
            egresobtn.TabIndex = 1;
            egresobtn.Text = "Egreso";
            egresobtn.UseVisualStyleBackColor = true;
            egresobtn.Click += egresobtn_Click;
            // 
            // consultaMovimientosbtn
            // 
            consultaMovimientosbtn.Location = new Point(260, 235);
            consultaMovimientosbtn.Name = "consultaMovimientosbtn";
            consultaMovimientosbtn.Size = new Size(194, 71);
            consultaMovimientosbtn.TabIndex = 2;
            consultaMovimientosbtn.Text = "Consultar Movimientos";
            consultaMovimientosbtn.UseVisualStyleBackColor = true;
            consultaMovimientosbtn.Click += consultaMovimientosbtn_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(consultaMovimientosbtn);
            Controls.Add(egresobtn);
            Controls.Add(ingresobtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ingresobtn;
        private Button egresobtn;
        private Button consultaMovimientosbtn;
    }
}