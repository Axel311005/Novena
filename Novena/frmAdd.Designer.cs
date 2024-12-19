namespace Novena
{
    partial class frmAdd
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
            groupBox2 = new GroupBox();
            txtEdad = new ComboBox();
            label5 = new Label();
            txtSegundoApellido = new TextBox();
            label4 = new Label();
            txtPrimerApellido = new TextBox();
            label2 = new Label();
            txtSegundoNombre = new TextBox();
            label3 = new Label();
            Sexo = new Label();
            cboSexo = new ComboBox();
            label1 = new Label();
            txtPrimerNombre = new TextBox();
            dgvKids = new DataGridView();
            btnUpdateKid = new Button();
            btnAddKid = new Button();
            btnBuscar = new Button();
            label6 = new Label();
            txtBuscador = new TextBox();
            btnDeleteKid = new Button();
            btnRefrescar = new Button();
            btnLimpiar = new Button();
            btnExportar = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKids).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEdad);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSegundoApellido);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPrimerApellido);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSegundoNombre);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Sexo);
            groupBox2.Controls.Add(cboSexo);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtPrimerNombre);
            groupBox2.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(8, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(833, 309);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtEdad
            // 
            txtEdad.FormattingEnabled = true;
            txtEdad.Location = new Point(633, 55);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(192, 35);
            txtEdad.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 214);
            label5.Name = "label5";
            label5.Size = new Size(176, 27);
            label5.TabIndex = 19;
            label5.Text = "Segundo Apellido";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(214, 214);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(321, 34);
            txtSegundoApellido.TabIndex = 20;
            txtSegundoApellido.KeyPress += txtSegundoApellido_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 165);
            label4.Name = "label4";
            label4.Size = new Size(157, 27);
            label4.TabIndex = 17;
            label4.Text = "Primer Apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(214, 162);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(321, 34);
            txtPrimerApellido.TabIndex = 18;
            txtPrimerApellido.KeyPress += txtPrimerApellido_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 113);
            label2.Name = "label2";
            label2.Size = new Size(176, 27);
            label2.TabIndex = 15;
            label2.Text = "Segundo Nombre";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(214, 110);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(321, 34);
            txtSegundoNombre.TabIndex = 16;
            txtSegundoNombre.KeyPress += txtSegundoNombre_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 58);
            label3.Name = "label3";
            label3.Size = new Size(58, 27);
            label3.TabIndex = 14;
            label3.Text = "Edad";
            label3.Click += label3_Click;
            // 
            // Sexo
            // 
            Sexo.AutoSize = true;
            Sexo.Location = new Point(572, 108);
            Sexo.Name = "Sexo";
            Sexo.Size = new Size(56, 27);
            Sexo.TabIndex = 13;
            Sexo.Text = "Sexo";
            // 
            // cboSexo
            // 
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(633, 105);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(192, 35);
            cboSexo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 58);
            label1.Name = "label1";
            label1.Size = new Size(157, 27);
            label1.TabIndex = 0;
            label1.Text = "Primer Nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(214, 58);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(321, 34);
            txtPrimerNombre.TabIndex = 10;
            txtPrimerNombre.KeyPress += txtPrimerNombre_KeyPress;
            // 
            // dgvKids
            // 
            dgvKids.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKids.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKids.Dock = DockStyle.Bottom;
            dgvKids.Location = new Point(0, 368);
            dgvKids.Name = "dgvKids";
            dgvKids.RowHeadersWidth = 51;
            dgvKids.Size = new Size(1023, 269);
            dgvKids.TabIndex = 23;
            dgvKids.CellClick += dgvKids_CellClick;
            // 
            // btnUpdateKid
            // 
            btnUpdateKid.BackColor = Color.DeepSkyBlue;
            btnUpdateKid.FlatStyle = FlatStyle.Flat;
            btnUpdateKid.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            btnUpdateKid.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateKid.Location = new Point(875, 80);
            btnUpdateKid.Name = "btnUpdateKid";
            btnUpdateKid.Size = new Size(116, 36);
            btnUpdateKid.TabIndex = 25;
            btnUpdateKid.Text = "Editar";
            btnUpdateKid.UseVisualStyleBackColor = false;
            btnUpdateKid.Click += btnUpdateKid_Click;
            // 
            // btnAddKid
            // 
            btnAddKid.BackColor = Color.DeepSkyBlue;
            btnAddKid.FlatStyle = FlatStyle.Flat;
            btnAddKid.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            btnAddKid.ForeColor = SystemColors.ButtonHighlight;
            btnAddKid.Location = new Point(875, 25);
            btnAddKid.Name = "btnAddKid";
            btnAddKid.Size = new Size(116, 36);
            btnAddKid.TabIndex = 24;
            btnAddKid.Text = "Agregar";
            btnAddKid.UseVisualStyleBackColor = false;
            btnAddKid.Click += btnAddKid_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DeepSkyBlue;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(613, 327);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 35);
            btnBuscar.TabIndex = 33;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            label6.Location = new Point(23, 330);
            label6.Name = "label6";
            label6.Size = new Size(98, 27);
            label6.TabIndex = 32;
            label6.Text = "Buscador";
            // 
            // txtBuscador
            // 
            txtBuscador.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            txtBuscador.Location = new Point(127, 328);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(456, 34);
            txtBuscador.TabIndex = 31;
            txtBuscador.KeyPress += txtBuscador_KeyPress;
            // 
            // btnDeleteKid
            // 
            btnDeleteKid.BackColor = Color.DeepSkyBlue;
            btnDeleteKid.FlatStyle = FlatStyle.Flat;
            btnDeleteKid.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            btnDeleteKid.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteKid.Location = new Point(875, 135);
            btnDeleteKid.Name = "btnDeleteKid";
            btnDeleteKid.Size = new Size(116, 36);
            btnDeleteKid.TabIndex = 26;
            btnDeleteKid.Text = "Borrar";
            btnDeleteKid.UseVisualStyleBackColor = false;
            btnDeleteKid.Click += btnDeleteKid_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.DeepSkyBlue;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold);
            btnRefrescar.ForeColor = SystemColors.ButtonHighlight;
            btnRefrescar.Location = new Point(875, 190);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(116, 36);
            btnRefrescar.TabIndex = 34;
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
            btnLimpiar.Location = new Point(875, 239);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 36);
            btnLimpiar.TabIndex = 35;
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
            btnExportar.Location = new Point(895, 330);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(116, 36);
            btnExportar.TabIndex = 36;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 637);
            Controls.Add(btnExportar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRefrescar);
            Controls.Add(btnBuscar);
            Controls.Add(label6);
            Controls.Add(txtBuscador);
            Controls.Add(btnDeleteKid);
            Controls.Add(btnUpdateKid);
            Controls.Add(btnAddKid);
            Controls.Add(dgvKids);
            Controls.Add(groupBox2);
            Name = "frmAdd";
            Text = "Gestión de Niños";
            Load += frmAdd_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKids).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label3;
        private Label Sexo;
        private ComboBox cboSexo;
        private Label label1;
        private TextBox txtPrimerNombre;
        private DataGridView dgvKids;
        private Button btnUpdateKid;
        private Button btnAddKid;
        private Label label5;
        private TextBox txtSegundoApellido;
        private Label label4;
        private TextBox txtPrimerApellido;
        private Label label2;
        private TextBox txtSegundoNombre;
        private Button btnBuscar;
        private Label label6;
        private TextBox txtBuscador;
        private Button btnDeleteKid;
        private Button btnRefrescar;
        private Button btnLimpiar;
        private ComboBox txtEdad;
        private Button btnExportar;
    }
}