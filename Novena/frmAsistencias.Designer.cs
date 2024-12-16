namespace Novena
{
    partial class frmAsistencias
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
            chbDay1 = new CheckBox();
            chbDay7 = new CheckBox();
            chbDay8 = new CheckBox();
            chbDay6 = new CheckBox();
            chbDay5 = new CheckBox();
            chbDay4 = new CheckBox();
            chbDay3 = new CheckBox();
            chbDay2 = new CheckBox();
            chbDay9 = new CheckBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtNombreCompleto = new TextBox();
            dgvAsistencia = new DataGridView();
            txtBuscador = new TextBox();
            label2 = new Label();
            btnDeleteAsist = new Button();
            btnUpdateAsist = new Button();
            btnAddAsist = new Button();
            btnBuscar = new Button();
            btnRefrescar = new Button();
            btnLimpiar = new Button();
            btnExportar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            SuspendLayout();
            // 
            // chbDay1
            // 
            chbDay1.AutoSize = true;
            chbDay1.Location = new Point(18, 94);
            chbDay1.Name = "chbDay1";
            chbDay1.Size = new Size(78, 31);
            chbDay1.TabIndex = 11;
            chbDay1.Text = "Día 1";
            chbDay1.UseVisualStyleBackColor = true;
            // 
            // chbDay7
            // 
            chbDay7.AutoSize = true;
            chbDay7.Location = new Point(15, 232);
            chbDay7.Name = "chbDay7";
            chbDay7.Size = new Size(81, 31);
            chbDay7.TabIndex = 12;
            chbDay7.Text = "Día 7";
            chbDay7.UseVisualStyleBackColor = true;
            // 
            // chbDay8
            // 
            chbDay8.AutoSize = true;
            chbDay8.Location = new Point(308, 232);
            chbDay8.Name = "chbDay8";
            chbDay8.Size = new Size(81, 31);
            chbDay8.TabIndex = 13;
            chbDay8.Text = "Día 8";
            chbDay8.UseVisualStyleBackColor = true;
            // 
            // chbDay6
            // 
            chbDay6.AutoSize = true;
            chbDay6.Location = new Point(575, 165);
            chbDay6.Name = "chbDay6";
            chbDay6.Size = new Size(81, 31);
            chbDay6.TabIndex = 14;
            chbDay6.Text = "Día 6";
            chbDay6.UseVisualStyleBackColor = true;
            // 
            // chbDay5
            // 
            chbDay5.AutoSize = true;
            chbDay5.Location = new Point(308, 165);
            chbDay5.Name = "chbDay5";
            chbDay5.Size = new Size(81, 31);
            chbDay5.TabIndex = 15;
            chbDay5.Text = "Día 5";
            chbDay5.UseVisualStyleBackColor = true;
            // 
            // chbDay4
            // 
            chbDay4.AutoSize = true;
            chbDay4.Location = new Point(15, 165);
            chbDay4.Name = "chbDay4";
            chbDay4.Size = new Size(82, 31);
            chbDay4.TabIndex = 16;
            chbDay4.Text = "Día 4";
            chbDay4.UseVisualStyleBackColor = true;
            // 
            // chbDay3
            // 
            chbDay3.AutoSize = true;
            chbDay3.Location = new Point(575, 94);
            chbDay3.Name = "chbDay3";
            chbDay3.Size = new Size(81, 31);
            chbDay3.TabIndex = 17;
            chbDay3.Text = "Día 3";
            chbDay3.UseVisualStyleBackColor = true;
            // 
            // chbDay2
            // 
            chbDay2.AutoSize = true;
            chbDay2.Location = new Point(308, 94);
            chbDay2.Name = "chbDay2";
            chbDay2.Size = new Size(81, 31);
            chbDay2.TabIndex = 18;
            chbDay2.Text = "Día 2";
            chbDay2.UseVisualStyleBackColor = true;
            // 
            // chbDay9
            // 
            chbDay9.AutoSize = true;
            chbDay9.Location = new Point(575, 232);
            chbDay9.Name = "chbDay9";
            chbDay9.Size = new Size(81, 31);
            chbDay9.TabIndex = 19;
            chbDay9.Text = "Día 9";
            chbDay9.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombreCompleto);
            groupBox1.Controls.Add(chbDay1);
            groupBox1.Controls.Add(chbDay9);
            groupBox1.Controls.Add(chbDay2);
            groupBox1.Controls.Add(chbDay8);
            groupBox1.Controls.Add(chbDay6);
            groupBox1.Controls.Add(chbDay7);
            groupBox1.Controls.Add(chbDay5);
            groupBox1.Controls.Add(chbDay4);
            groupBox1.Controls.Add(chbDay3);
            groupBox1.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 289);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Asistencias";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 49);
            label1.Name = "label1";
            label1.Size = new Size(185, 27);
            label1.TabIndex = 21;
            label1.Text = "Nombre Completo";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(209, 46);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.ReadOnly = true;
            txtNombreCompleto.Size = new Size(470, 34);
            txtNombreCompleto.TabIndex = 20;
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Dock = DockStyle.Bottom;
            dgvAsistencia.Location = new Point(0, 394);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.RowHeadersWidth = 51;
            dgvAsistencia.Size = new Size(1085, 230);
            dgvAsistencia.TabIndex = 22;
            dgvAsistencia.CellClick += dgvAsistencia_CellClick;
            // 
            // txtBuscador
            // 
            txtBuscador.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            txtBuscador.Location = new Point(118, 327);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(474, 34);
            txtBuscador.TabIndex = 25;
            txtBuscador.KeyPress += txtBuscador_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            label2.Location = new Point(14, 330);
            label2.Name = "label2";
            label2.Size = new Size(98, 27);
            label2.TabIndex = 26;
            label2.Text = "Buscador";
            // 
            // btnDeleteAsist
            // 
            btnDeleteAsist.BackColor = Color.DeepSkyBlue;
            btnDeleteAsist.FlatStyle = FlatStyle.Flat;
            btnDeleteAsist.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            btnDeleteAsist.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteAsist.Location = new Point(791, 147);
            btnDeleteAsist.Name = "btnDeleteAsist";
            btnDeleteAsist.Size = new Size(116, 36);
            btnDeleteAsist.TabIndex = 29;
            btnDeleteAsist.Text = "Borrar";
            btnDeleteAsist.UseVisualStyleBackColor = false;
            btnDeleteAsist.Click += btnDeleteAsist_Click;
            // 
            // btnUpdateAsist
            // 
            btnUpdateAsist.BackColor = Color.DeepSkyBlue;
            btnUpdateAsist.FlatStyle = FlatStyle.Flat;
            btnUpdateAsist.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            btnUpdateAsist.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateAsist.Location = new Point(791, 86);
            btnUpdateAsist.Name = "btnUpdateAsist";
            btnUpdateAsist.Size = new Size(116, 36);
            btnUpdateAsist.TabIndex = 28;
            btnUpdateAsist.Text = "Editar";
            btnUpdateAsist.UseVisualStyleBackColor = false;
            btnUpdateAsist.Click += btnUpdateAsist_Click;
            // 
            // btnAddAsist
            // 
            btnAddAsist.BackColor = Color.DeepSkyBlue;
            btnAddAsist.FlatStyle = FlatStyle.Flat;
            btnAddAsist.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            btnAddAsist.ForeColor = SystemColors.ButtonHighlight;
            btnAddAsist.Location = new Point(791, 31);
            btnAddAsist.Name = "btnAddAsist";
            btnAddAsist.Size = new Size(116, 36);
            btnAddAsist.TabIndex = 27;
            btnAddAsist.Text = "Agregar";
            btnAddAsist.UseVisualStyleBackColor = false;
            btnAddAsist.Click += btnAddAsist_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DeepSkyBlue;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(598, 327);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 36);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.DeepSkyBlue;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            btnRefrescar.ForeColor = SystemColors.ButtonHighlight;
            btnRefrescar.Location = new Point(791, 203);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(116, 36);
            btnRefrescar.TabIndex = 31;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DeepSkyBlue;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(791, 265);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 36);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.DeepSkyBlue;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            btnExportar.ForeColor = SystemColors.ButtonHighlight;
            btnExportar.Location = new Point(957, 352);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(116, 36);
            btnExportar.TabIndex = 33;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // frmAsistencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 624);
            Controls.Add(btnExportar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRefrescar);
            Controls.Add(btnBuscar);
            Controls.Add(btnDeleteAsist);
            Controls.Add(btnUpdateAsist);
            Controls.Add(btnAddAsist);
            Controls.Add(label2);
            Controls.Add(txtBuscador);
            Controls.Add(dgvAsistencia);
            Controls.Add(groupBox1);
            Name = "frmAsistencias";
            Text = "Asistencias";
            Load += frmAsistencias_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox chbDay1;
        private CheckBox chbDay7;
        private CheckBox chbDay8;
        private CheckBox chbDay6;
        private CheckBox chbDay5;
        private CheckBox chbDay4;
        private CheckBox chbDay3;
        private CheckBox chbDay2;
        private CheckBox chbDay9;
        private GroupBox groupBox1;
        private DataGridView dgvAsistencia;
        private TextBox txtBuscador;
        private Label label2;
        private Button btnDeleteAsist;
        private Button btnUpdateAsist;
        private Button btnAddAsist;
        private Label label1;
        private TextBox txtNombreCompleto;
        private Button btnBuscar;
        private Button btnRefrescar;
        private Button btnLimpiar;
        private Button btnExportar;
    }
}