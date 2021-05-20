
namespace Presentacion
{
    partial class RegistroFRM
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
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnGuardarRegistro = new System.Windows.Forms.Button();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.chkUser = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(131, 68);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 0;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(131, 42);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 1;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(131, 94);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 2;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.Location = new System.Drawing.Point(103, 157);
            this.btnGuardarRegistro.Name = "btnGuardarRegistro";
            this.btnGuardarRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarRegistro.TabIndex = 3;
            this.btnGuardarRegistro.Text = "Ingreso";
            this.btnGuardarRegistro.UseVisualStyleBackColor = true;
            this.btnGuardarRegistro.Click += new System.EventHandler(this.btnGuardarRegistro_Click_1);
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(131, 121);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(100, 20);
            this.txtEmp.TabIndex = 6;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(103, 33);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(89, 17);
            this.chkAdmin.TabIndex = 5;
            this.chkAdmin.Text = "Administrador";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // chkUser
            // 
            this.chkUser.AutoSize = true;
            this.chkUser.Location = new System.Drawing.Point(16, 33);
            this.chkUser.Name = "chkUser";
            this.chkUser.Size = new System.Drawing.Size(81, 17);
            this.chkUser.TabIndex = 4;
            this.chkUser.Text = "Observador";
            this.chkUser.UseVisualStyleBackColor = true;
            this.chkUser.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUser);
            this.groupBox1.Controls.Add(this.chkAdmin);
            this.groupBox1.Location = new System.Drawing.Point(42, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 63);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "seleccione tipo de usuario";
            // 
            // RegistroFRM
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.btnGuardarRegistro);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtContraseña);
            this.Name = "RegistroFRM";
            this.Load += new System.EventHandler(this.RegistroFRM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnGuardarRegistro;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.CheckBox chkUser;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}