namespace proyecto_final_PED
{
    partial class AgregarProductos
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
            agregarProductosbtn = new Button();
            nombretxt = new TextBox();
            descripciontxt = new TextBox();
            stockud = new NumericUpDown();
            precioCompraud = new NumericUpDown();
            rubroslstbx = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)stockud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)precioCompraud).BeginInit();
            SuspendLayout();
            // 
            // agregarProductosbtn
            // 
            agregarProductosbtn.Location = new Point(266, 138);
            agregarProductosbtn.Name = "agregarProductosbtn";
            agregarProductosbtn.Size = new Size(91, 87);
            agregarProductosbtn.TabIndex = 0;
            agregarProductosbtn.Text = "Agregar Producto";
            agregarProductosbtn.UseVisualStyleBackColor = true;
            agregarProductosbtn.Click += agregarProductosbtn_Click;
            // 
            // nombretxt
            // 
            nombretxt.Location = new Point(52, 51);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(125, 27);
            nombretxt.TabIndex = 1;
            // 
            // descripciontxt
            // 
            descripciontxt.Location = new Point(229, 53);
            descripciontxt.Multiline = true;
            descripciontxt.Name = "descripciontxt";
            descripciontxt.Size = new Size(159, 66);
            descripciontxt.TabIndex = 2;
            // 
            // stockud
            // 
            stockud.Location = new Point(54, 113);
            stockud.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            stockud.Name = "stockud";
            stockud.Size = new Size(150, 27);
            stockud.TabIndex = 4;
            // 
            // precioCompraud
            // 
            precioCompraud.Location = new Point(54, 169);
            precioCompraud.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            precioCompraud.Name = "precioCompraud";
            precioCompraud.Size = new Size(150, 27);
            precioCompraud.TabIndex = 5;
            // 
            // rubroslstbx
            // 
            rubroslstbx.FormattingEnabled = true;
            rubroslstbx.Location = new Point(54, 234);
            rubroslstbx.Name = "rubroslstbx";
            rubroslstbx.Size = new Size(150, 114);
            rubroslstbx.TabIndex = 8;
            rubroslstbx.ItemCheck += rubroslstbx_ItemCheck;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 31);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 90);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 10;
            label2.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 146);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 11;
            label3.Text = "Precio de Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 211);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 12;
            label4.Text = "Rubros";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(229, 30);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 13;
            label5.Text = "Descripcion";
            // 
            // AgregarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 391);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rubroslstbx);
            Controls.Add(precioCompraud);
            Controls.Add(stockud);
            Controls.Add(descripciontxt);
            Controls.Add(nombretxt);
            Controls.Add(agregarProductosbtn);
            Name = "AgregarProductos";
            Text = "Menu Agregar Productos";
            Load += AgregarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)stockud).EndInit();
            ((System.ComponentModel.ISupportInitialize)precioCompraud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button agregarProductosbtn;
        private TextBox nombretxt;
        private TextBox descripciontxt;
        private NumericUpDown stockud;
        private NumericUpDown precioCompraud;
        private CheckedListBox rubroslstbx;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}