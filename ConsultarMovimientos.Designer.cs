namespace proyecto_final_PED
{
    partial class ConsultarMovimientos
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
            volverAlMenubtn = new Button();
            buscarPorNombrebtn = new Button();
            groupBox3 = new GroupBox();
            tipoMovimientolst = new ListBox();
            groupBox2 = new GroupBox();
            nombreProdtxt = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            iniciodebusquedadtp = new DateTimePicker();
            findebusquedadtp = new DateTimePicker();
            buscarPorTipobtn = new Button();
            buscarporfechabtn = new Button();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // volverAlMenubtn
            // 
            volverAlMenubtn.Location = new Point(793, 362);
            volverAlMenubtn.Name = "volverAlMenubtn";
            volverAlMenubtn.Size = new Size(97, 76);
            volverAlMenubtn.TabIndex = 12;
            volverAlMenubtn.Text = "Volver al menu";
            volverAlMenubtn.UseVisualStyleBackColor = true;
            // 
            // buscarPorNombrebtn
            // 
            buscarPorNombrebtn.Location = new Point(793, 27);
            buscarPorNombrebtn.Name = "buscarPorNombrebtn";
            buscarPorNombrebtn.Size = new Size(97, 76);
            buscarPorNombrebtn.TabIndex = 11;
            buscarPorNombrebtn.Text = "Buscar por nombre";
            buscarPorNombrebtn.UseVisualStyleBackColor = true;
            buscarPorNombrebtn.Click += buscarbtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tipoMovimientolst);
            groupBox3.Location = new Point(528, 221);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(259, 217);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // tipoMovimientolst
            // 
            tipoMovimientolst.FormattingEnabled = true;
            tipoMovimientolst.Items.AddRange(new object[] { "Ingreso", "Egreso", "Ambos" });
            tipoMovimientolst.Location = new Point(12, 30);
            tipoMovimientolst.Name = "tipoMovimientolst";
            tipoMovimientolst.Size = new Size(150, 104);
            tipoMovimientolst.TabIndex = 0;
            tipoMovimientolst.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nombreProdtxt);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(528, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(259, 197);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // nombreProdtxt
            // 
            nombreProdtxt.Location = new Point(54, 111);
            nombreProdtxt.Name = "nombreProdtxt";
            nombreProdtxt.Size = new Size(142, 27);
            nombreProdtxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 54);
            label1.Name = "label1";
            label1.Size = new Size(142, 40);
            label1.TabIndex = 0;
            label1.Text = "Ingrese nombre del \r\nproducto a buscar\r\n";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(479, 373);
            dataGridView1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(11, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 415);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // iniciodebusquedadtp
            // 
            iniciodebusquedadtp.Location = new Point(528, 370);
            iniciodebusquedadtp.Name = "iniciodebusquedadtp";
            iniciodebusquedadtp.Size = new Size(250, 27);
            iniciodebusquedadtp.TabIndex = 14;
            // 
            // findebusquedadtp
            // 
            findebusquedadtp.Location = new Point(528, 406);
            findebusquedadtp.Name = "findebusquedadtp";
            findebusquedadtp.Size = new Size(250, 27);
            findebusquedadtp.TabIndex = 15;
            // 
            // buscarPorTipobtn
            // 
            buscarPorTipobtn.Location = new Point(793, 129);
            buscarPorTipobtn.Name = "buscarPorTipobtn";
            buscarPorTipobtn.Size = new Size(97, 76);
            buscarPorTipobtn.TabIndex = 16;
            buscarPorTipobtn.Text = "Buscar por tipo";
            buscarPorTipobtn.UseVisualStyleBackColor = true;
            buscarPorTipobtn.Click += buscarPorTipobtn_Click;
            // 
            // buscarporfechabtn
            // 
            buscarporfechabtn.Location = new Point(793, 263);
            buscarporfechabtn.Name = "buscarporfechabtn";
            buscarporfechabtn.Size = new Size(97, 76);
            buscarporfechabtn.TabIndex = 17;
            buscarporfechabtn.Text = "Buscar por fecha";
            buscarporfechabtn.UseVisualStyleBackColor = true;
            buscarporfechabtn.Click += buscarporfechabtn_Click;
            // 
            // ConsultarMovimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 450);
            Controls.Add(buscarporfechabtn);
            Controls.Add(buscarPorTipobtn);
            Controls.Add(findebusquedadtp);
            Controls.Add(iniciodebusquedadtp);
            Controls.Add(volverAlMenubtn);
            Controls.Add(buscarPorNombrebtn);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "ConsultarMovimientos";
            Text = "ConsultarMovimientos";
            Load += ConsultarMovimientos_Load;
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button volverAlMenubtn;
        private Button buscarPorNombrebtn;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox nombreProdtxt;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private ListBox tipoMovimientolst;
        private DateTimePicker iniciodebusquedadtp;
        private DateTimePicker findebusquedadtp;
        private Button buscarPorTipobtn;
        private Button buscarporfechabtn;
    }
}