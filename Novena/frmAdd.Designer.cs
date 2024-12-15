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
            label5 = new Label();
            txtSegundoApellido = new TextBox();
            label4 = new Label();
            txtPrimerApellido = new TextBox();
            label2 = new Label();
            txtSegundoNombre = new TextBox();
            label3 = new Label();
            Sexo = new Label();
            cboSexo = new ComboBox();
            txtEdad = new TextBox();
            label1 = new Label();
            txtPrimerNombre = new TextBox();
            dgvKids = new DataGridView();
            btnDeleteKid = new Button();
            btnUpdateKid = new Button();
            btnAddKid = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKids).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSegundoApellido);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPrimerApellido);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSegundoNombre);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Sexo);
            groupBox2.Controls.Add(cboSexo);
            groupBox2.Controls.Add(txtEdad);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtPrimerNombre);
            groupBox2.Location = new Point(22, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(745, 258);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 214);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 19;
            label5.Text = "Segundo Apellido";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(181, 214);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(219, 27);
            txtSegundoApellido.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 165);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 17;
            label4.Text = "Primer Apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(181, 162);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(219, 27);
            txtPrimerApellido.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 113);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 15;
            label2.Text = "Segundo Nombre";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(181, 109);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(219, 27);
            txtSegundoNombre.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 66);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 14;
            label3.Text = "Edad";
            label3.Click += label3_Click;
            // 
            // Sexo
            // 
            Sexo.AutoSize = true;
            Sexo.Location = new Point(466, 116);
            Sexo.Name = "Sexo";
            Sexo.Size = new Size(41, 20);
            Sexo.TabIndex = 13;
            Sexo.Text = "Sexo";
            // 
            // cboSexo
            // 
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(527, 113);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(192, 28);
            cboSexo.TabIndex = 12;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(527, 63);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(192, 27);
            txtEdad.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 58);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Primer Nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(181, 58);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(219, 27);
            txtPrimerNombre.TabIndex = 10;
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
            // btnDeleteKid
            // 
            btnDeleteKid.BackColor = Color.DeepSkyBlue;
            btnDeleteKid.FlatStyle = FlatStyle.Flat;
            btnDeleteKid.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteKid.Location = new Point(793, 194);
            btnDeleteKid.Name = "btnDeleteKid";
            btnDeleteKid.Size = new Size(116, 36);
            btnDeleteKid.TabIndex = 26;
            btnDeleteKid.Text = "Borrar";
            btnDeleteKid.UseVisualStyleBackColor = false;
            btnDeleteKid.Click += btnDeleteKid_Click;
            // 
            // btnUpdateKid
            // 
            btnUpdateKid.BackColor = Color.DeepSkyBlue;
            btnUpdateKid.FlatStyle = FlatStyle.Flat;
            btnUpdateKid.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateKid.Location = new Point(793, 133);
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
            btnAddKid.ForeColor = SystemColors.ButtonHighlight;
            btnAddKid.Location = new Point(793, 78);
            btnAddKid.Name = "btnAddKid";
            btnAddKid.Size = new Size(116, 36);
            btnAddKid.TabIndex = 24;
            btnAddKid.Text = "Agregar";
            btnAddKid.UseVisualStyleBackColor = false;
            btnAddKid.Click += btnAddKid_Click;
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 637);
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
        }

        #endregion

        private GroupBox groupBox2;
        private Label label3;
        private Label Sexo;
        private ComboBox cboSexo;
        private TextBox txtEdad;
        private Label label1;
        private TextBox txtPrimerNombre;
        private DataGridView dgvKids;
        private Button btnDeleteKid;
        private Button btnUpdateKid;
        private Button btnAddKid;
        private Label label5;
        private TextBox txtSegundoApellido;
        private Label label4;
        private TextBox txtPrimerApellido;
        private Label label2;
        private TextBox txtSegundoNombre;
    }
}