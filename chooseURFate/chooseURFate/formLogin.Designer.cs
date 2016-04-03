namespace chooseURFate
{
    partial class formLogin
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtB_Usuario = new System.Windows.Forms.TextBox();
            this.grB_Usuario = new System.Windows.Forms.GroupBox();
            this.grB_passwd = new System.Windows.Forms.GroupBox();
            this.txtB_passwd = new System.Windows.Forms.TextBox();
            this.btn_ResetDatos = new System.Windows.Forms.Button();
            this.btn_NuevoUsuario = new System.Windows.Forms.Button();
            this.grB_Usuario.SuspendLayout();
            this.grB_passwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Enabled = false;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(67, 198);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(87, 32);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.IntentoLogin);
            // 
            // txtB_Usuario
            // 
            this.txtB_Usuario.Location = new System.Drawing.Point(49, 23);
            this.txtB_Usuario.Name = "txtB_Usuario";
            this.txtB_Usuario.Size = new System.Drawing.Size(141, 24);
            this.txtB_Usuario.TabIndex = 1;
            this.txtB_Usuario.TextChanged += new System.EventHandler(this.IntroTexto);
            // 
            // grB_Usuario
            // 
            this.grB_Usuario.Controls.Add(this.txtB_Usuario);
            this.grB_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grB_Usuario.Location = new System.Drawing.Point(111, 49);
            this.grB_Usuario.Name = "grB_Usuario";
            this.grB_Usuario.Size = new System.Drawing.Size(220, 61);
            this.grB_Usuario.TabIndex = 3;
            this.grB_Usuario.TabStop = false;
            this.grB_Usuario.Text = "Usuario";
            // 
            // grB_passwd
            // 
            this.grB_passwd.Controls.Add(this.txtB_passwd);
            this.grB_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grB_passwd.Location = new System.Drawing.Point(111, 116);
            this.grB_passwd.Name = "grB_passwd";
            this.grB_passwd.Size = new System.Drawing.Size(220, 61);
            this.grB_passwd.TabIndex = 4;
            this.grB_passwd.TabStop = false;
            this.grB_passwd.Text = "Contraseña";
            // 
            // txtB_passwd
            // 
            this.txtB_passwd.Location = new System.Drawing.Point(49, 23);
            this.txtB_passwd.Name = "txtB_passwd";
            this.txtB_passwd.Size = new System.Drawing.Size(141, 24);
            this.txtB_passwd.TabIndex = 1;
            this.txtB_passwd.TextChanged += new System.EventHandler(this.IntroTexto);
            // 
            // btn_ResetDatos
            // 
            this.btn_ResetDatos.Enabled = false;
            this.btn_ResetDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetDatos.Location = new System.Drawing.Point(160, 198);
            this.btn_ResetDatos.Name = "btn_ResetDatos";
            this.btn_ResetDatos.Size = new System.Drawing.Size(87, 32);
            this.btn_ResetDatos.TabIndex = 5;
            this.btn_ResetDatos.Text = "Reiniciar";
            this.btn_ResetDatos.UseVisualStyleBackColor = true;
            // 
            // btn_NuevoUsuario
            // 
            this.btn_NuevoUsuario.Enabled = false;
            this.btn_NuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoUsuario.Location = new System.Drawing.Point(253, 198);
            this.btn_NuevoUsuario.Name = "btn_NuevoUsuario";
            this.btn_NuevoUsuario.Size = new System.Drawing.Size(87, 32);
            this.btn_NuevoUsuario.TabIndex = 6;
            this.btn_NuevoUsuario.Text = "Registro";
            this.btn_NuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 262);
            this.Controls.Add(this.btn_NuevoUsuario);
            this.Controls.Add(this.btn_ResetDatos);
            this.Controls.Add(this.grB_passwd);
            this.Controls.Add(this.grB_Usuario);
            this.Controls.Add(this.btn_Login);
            this.Name = "formLogin";
            this.Text = "formLogin";
            this.grB_Usuario.ResumeLayout(false);
            this.grB_Usuario.PerformLayout();
            this.grB_passwd.ResumeLayout(false);
            this.grB_passwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txtB_Usuario;
        private System.Windows.Forms.GroupBox grB_Usuario;
        private System.Windows.Forms.GroupBox grB_passwd;
        private System.Windows.Forms.TextBox txtB_passwd;
        private System.Windows.Forms.Button btn_ResetDatos;
        private System.Windows.Forms.Button btn_NuevoUsuario;
    }
}