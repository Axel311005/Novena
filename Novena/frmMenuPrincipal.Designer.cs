namespace Novena
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            panelMenu = new Panel();
            btnAsistencia = new Button();
            btnKids = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            btnMinimizar = new PictureBox();
            btnResize = new PictureBox();
            btnCerrar = new PictureBox();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnResize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.CornflowerBlue;
            panelMenu.Controls.Add(btnAsistencia);
            panelMenu.Controls.Add(btnKids);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(213, 736);
            panelMenu.TabIndex = 0;
            // 
            // btnAsistencia
            // 
            btnAsistencia.BackColor = Color.Transparent;
            btnAsistencia.Dock = DockStyle.Top;
            btnAsistencia.FlatAppearance.BorderSize = 0;
            btnAsistencia.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnAsistencia.FlatStyle = FlatStyle.Flat;
            btnAsistencia.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsistencia.ForeColor = Color.White;
            btnAsistencia.Image = (Image)resources.GetObject("btnAsistencia.Image");
            btnAsistencia.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsistencia.Location = new Point(0, 123);
            btnAsistencia.Name = "btnAsistencia";
            btnAsistencia.Size = new Size(213, 60);
            btnAsistencia.TabIndex = 10;
            btnAsistencia.Text = "Asistencia";
            btnAsistencia.UseVisualStyleBackColor = false;
            btnAsistencia.Click += btnAsistencia_Click;
            // 
            // btnKids
            // 
            btnKids.BackColor = Color.Transparent;
            btnKids.Dock = DockStyle.Top;
            btnKids.FlatAppearance.BorderSize = 0;
            btnKids.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 0);
            btnKids.FlatStyle = FlatStyle.Flat;
            btnKids.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKids.ForeColor = Color.White;
            btnKids.Image = (Image)resources.GetObject("btnKids.Image");
            btnKids.ImageAlign = ContentAlignment.MiddleLeft;
            btnKids.Location = new Point(0, 63);
            btnKids.Name = "btnKids";
            btnKids.Size = new Size(213, 60);
            btnKids.TabIndex = 9;
            btnKids.Text = "Niños";
            btnKids.UseVisualStyleBackColor = false;
            btnKids.Click += btnKids_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Font = new Font("Microsoft Sans Serif", 12F);
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(213, 63);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Parroquia SMA";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.LightSkyBlue;
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(btnMinimizar);
            panelTitleBar.Controls.Add(btnResize);
            panelTitleBar.Controls.Add(btnCerrar);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(213, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1088, 66);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(94, 66);
            btnCloseChildForm.TabIndex = 11;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(458, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(67, 22);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "HOME";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(990, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(35, 35);
            btnMinimizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMinimizar.TabIndex = 9;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnResize
            // 
            btnResize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResize.Cursor = Cursors.Hand;
            btnResize.Image = (Image)resources.GetObject("btnResize.Image");
            btnResize.Location = new Point(946, 11);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(38, 37);
            btnResize.SizeMode = PictureBoxSizeMode.CenterImage;
            btnResize.TabIndex = 8;
            btnResize.TabStop = false;
            btnResize.Click += btnResize_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1031, 11);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 43);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 7;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(213, 66);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1088, 670);
            panelDesktop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo_parroquia;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1088, 670);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 736);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenuPrincipal";
            Text = "frmMenuPrincipal";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnResize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Label label1;
        private Panel panelTitleBar;
        private Label lblTitle;
        private PictureBox btnMinimizar;
        private PictureBox btnResize;
        private PictureBox btnCerrar;
        private Button btnAsistencia;
        private Button btnKids;
        private Button btnCloseChildForm;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
    }
}