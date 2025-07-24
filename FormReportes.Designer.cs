namespace proyecto_final_PED
{
    partial class FormReportes
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
            stockActualPorProdbtn = new Button();
            stockPorRubrobtn = new Button();
            MovimientosPorProvbtn = new Button();
            objetosConBajoStockbtn = new Button();
            historialDeMovimientosPorProdbtn = new Button();
            SuspendLayout();
            // 
            // stockActualPorProdbtn
            // 
            stockActualPorProdbtn.Location = new Point(238, 168);
            stockActualPorProdbtn.Name = "stockActualPorProdbtn";
            stockActualPorProdbtn.Size = new Size(94, 78);
            stockActualPorProdbtn.TabIndex = 0;
            stockActualPorProdbtn.Text = "Stock Actual por Producto";
            stockActualPorProdbtn.UseVisualStyleBackColor = true;
            stockActualPorProdbtn.Click += stockActualPorProdbtn_Click;
            // 
            // stockPorRubrobtn
            // 
            stockPorRubrobtn.Location = new Point(353, 168);
            stockPorRubrobtn.Name = "stockPorRubrobtn";
            stockPorRubrobtn.Size = new Size(94, 78);
            stockPorRubrobtn.TabIndex = 1;
            stockPorRubrobtn.Text = "Stock por Rubro";
            stockPorRubrobtn.UseVisualStyleBackColor = true;
            stockPorRubrobtn.Click += stockPorRubrobtn_Click;
            // 
            // MovimientosPorProvbtn
            // 
            MovimientosPorProvbtn.Location = new Point(238, 252);
            MovimientosPorProvbtn.Name = "MovimientosPorProvbtn";
            MovimientosPorProvbtn.Size = new Size(94, 78);
            MovimientosPorProvbtn.TabIndex = 2;
            MovimientosPorProvbtn.Text = "Movimientos por Proveedor";
            MovimientosPorProvbtn.UseVisualStyleBackColor = true;
            MovimientosPorProvbtn.Click += MovimientosPorProvbtn_Click;
            // 
            // objetosConBajoStockbtn
            // 
            objetosConBajoStockbtn.Location = new Point(353, 252);
            objetosConBajoStockbtn.Name = "objetosConBajoStockbtn";
            objetosConBajoStockbtn.Size = new Size(94, 78);
            objetosConBajoStockbtn.TabIndex = 3;
            objetosConBajoStockbtn.Text = "Objetos con bajo stock";
            objetosConBajoStockbtn.UseVisualStyleBackColor = true;
            objetosConBajoStockbtn.Click += objetosConBajoStockbtn_Click;
            // 
            // historialDeMovimientosPorProdbtn
            // 
            historialDeMovimientosPorProdbtn.Location = new Point(293, 336);
            historialDeMovimientosPorProdbtn.Name = "historialDeMovimientosPorProdbtn";
            historialDeMovimientosPorProdbtn.Size = new Size(118, 102);
            historialDeMovimientosPorProdbtn.TabIndex = 4;
            historialDeMovimientosPorProdbtn.Text = "Historial de movimiento por producto";
            historialDeMovimientosPorProdbtn.UseVisualStyleBackColor = true;
            historialDeMovimientosPorProdbtn.Click += historialDeMovimientosPorProdbtn_Click;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(historialDeMovimientosPorProdbtn);
            Controls.Add(objetosConBajoStockbtn);
            Controls.Add(MovimientosPorProvbtn);
            Controls.Add(stockPorRubrobtn);
            Controls.Add(stockActualPorProdbtn);
            Name = "FormReportes";
            Text = "FormReportes";
            ResumeLayout(false);
        }

        #endregion

        private Button stockActualPorProdbtn;
        private Button stockPorRubrobtn;
        private Button MovimientosPorProvbtn;
        private Button objetosConBajoStockbtn;
        private Button historialDeMovimientosPorProdbtn;
    }
}