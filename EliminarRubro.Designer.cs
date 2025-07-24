namespace proyecto_final_PED
{
    partial class EliminarRubro
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
            eliminarProductobtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // eliminarProductobtn
            // 
            eliminarProductobtn.Location = new Point(666, 398);
            eliminarProductobtn.Name = "eliminarProductobtn";
            eliminarProductobtn.Size = new Size(94, 29);
            eliminarProductobtn.TabIndex = 3;
            eliminarProductobtn.Text = "Eliminar Producto";
            eliminarProductobtn.UseVisualStyleBackColor = true;
            eliminarProductobtn.Click += eliminarProductobtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(720, 352);
            dataGridView1.TabIndex = 2;
            // 
            // EliminarRubro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(eliminarProductobtn);
            Controls.Add(dataGridView1);
            Name = "EliminarRubro";
            Text = "EliminarRubro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button eliminarProductobtn;
        private DataGridView dataGridView1;
    }
}