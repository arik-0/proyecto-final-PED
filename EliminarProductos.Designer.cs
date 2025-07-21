namespace proyecto_final_PED
{
    partial class EliminarProductos
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
            dataGridView1 = new DataGridView();
            eliminarProductobtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(720, 352);
            dataGridView1.TabIndex = 0;
            // 
            // eliminarProductobtn
            // 
            eliminarProductobtn.Location = new Point(666, 409);
            eliminarProductobtn.Name = "eliminarProductobtn";
            eliminarProductobtn.Size = new Size(94, 29);
            eliminarProductobtn.TabIndex = 1;
            eliminarProductobtn.Text = "Eliminar Producto";
            eliminarProductobtn.UseVisualStyleBackColor = true;
            eliminarProductobtn.Click += eliminarProductobtn_Click;
            // 
            // EliminarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(eliminarProductobtn);
            Controls.Add(dataGridView1);
            Name = "EliminarProductos";
            Text = "EliminarProductos";
            Load += EliminarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button eliminarProductobtn;
    }
}