namespace UniversityLibrary.UI
{
    partial class MainForm
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlnfoEstudiante = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMultas = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlnfoEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(41, 186);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(525, 51);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Estudiante";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlnfoEstudiante
            // 
            this.pnlnfoEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlnfoEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(14)))));
            this.pnlnfoEstudiante.Controls.Add(this.pictureBox1);
            this.pnlnfoEstudiante.Controls.Add(this.lblMultas);
            this.pnlnfoEstudiante.Controls.Add(this.lblTipo);
            this.pnlnfoEstudiante.Controls.Add(this.lblPrestamos);
            this.pnlnfoEstudiante.Controls.Add(this.lblNombre);
            this.pnlnfoEstudiante.Location = new System.Drawing.Point(0, 0);
            this.pnlnfoEstudiante.Name = "pnlnfoEstudiante";
            this.pnlnfoEstudiante.Size = new System.Drawing.Size(607, 544);
            this.pnlnfoEstudiante.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniversityLibrary.UI.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(231, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblMultas
            // 
            this.lblMultas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMultas.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultas.ForeColor = System.Drawing.Color.White;
            this.lblMultas.Location = new System.Drawing.Point(42, 405);
            this.lblMultas.Name = "lblMultas";
            this.lblMultas.Size = new System.Drawing.Size(520, 44);
            this.lblMultas.TabIndex = 4;
            this.lblMultas.Text = "Multas";
            this.lblMultas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.Color.Gray;
            this.lblTipo.Location = new System.Drawing.Point(41, 235);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(525, 33);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo de usuario";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrestamos.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamos.ForeColor = System.Drawing.Color.White;
            this.lblPrestamos.Location = new System.Drawing.Point(46, 343);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(520, 44);
            this.lblPrestamos.TabIndex = 2;
            this.lblPrestamos.Text = "Libros prestados";
            this.lblPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogin.Animated = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btnLogin.FillColor2 = System.Drawing.Color.Teal;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(3, 5);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(258, 174);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Prestar Libro";
            this.btnLogin.UseTransparentBackground = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnLogin);
            this.flowLayoutPanel1.Controls.Add(this.guna2GradientButton1);
            this.flowLayoutPanel1.Controls.Add(this.guna2GradientButton2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(613, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(265, 544);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Goldenrod;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Sienna;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(3, 185);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(258, 174);
            this.guna2GradientButton1.TabIndex = 5;
            this.guna2GradientButton1.Text = "Devolver Libro";
            this.guna2GradientButton1.UseTransparentBackground = true;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.LightCoral;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Brown;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(3, 365);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(258, 174);
            this.guna2GradientButton2.TabIndex = 6;
            this.guna2GradientButton2.Text = "Pagar Multas";
            this.guna2GradientButton2.UseTransparentBackground = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlnfoEstudiante);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlnfoEstudiante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlnfoEstudiante;
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.Label lblMultas;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
    }
}