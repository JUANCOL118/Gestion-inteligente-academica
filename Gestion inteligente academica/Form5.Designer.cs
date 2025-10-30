namespace Gestion_inteligente_academica
{
    partial class fm_Inicio_Sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_Inicio_Sesion));
            this.tx_correo = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.lb_correo = new System.Windows.Forms.Label();
            this.tx_contraseña = new System.Windows.Forms.TextBox();
            this.lk_cambiar_contraseña = new System.Windows.Forms.LinkLabel();
            this.lb_contra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_correo
            // 
            this.tx_correo.Location = new System.Drawing.Point(472, 209);
            this.tx_correo.Multiline = true;
            this.tx_correo.Name = "tx_correo";
            this.tx_correo.Size = new System.Drawing.Size(332, 30);
            this.tx_correo.TabIndex = 4;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.Location = new System.Drawing.Point(472, 372);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(155, 38);
            this.btn_ingresar.TabIndex = 5;
            this.btn_ingresar.Text = "Ingresar ";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_correo
            // 
            this.lb_correo.AutoSize = true;
            this.lb_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.lb_correo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_correo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_correo.ForeColor = System.Drawing.Color.White;
            this.lb_correo.Location = new System.Drawing.Point(241, 210);
            this.lb_correo.Name = "lb_correo";
            this.lb_correo.Size = new System.Drawing.Size(204, 29);
            this.lb_correo.TabIndex = 6;
            this.lb_correo.Text = "Correo electronico ";
            // 
            // tx_contraseña
            // 
            this.tx_contraseña.Location = new System.Drawing.Point(472, 259);
            this.tx_contraseña.Multiline = true;
            this.tx_contraseña.Name = "tx_contraseña";
            this.tx_contraseña.Size = new System.Drawing.Size(332, 30);
            this.tx_contraseña.TabIndex = 8;
            // 
            // lk_cambiar_contraseña
            // 
            this.lk_cambiar_contraseña.AutoSize = true;
            this.lk_cambiar_contraseña.Location = new System.Drawing.Point(469, 309);
            this.lk_cambiar_contraseña.Name = "lk_cambiar_contraseña";
            this.lk_cambiar_contraseña.Size = new System.Drawing.Size(140, 16);
            this.lk_cambiar_contraseña.TabIndex = 12;
            this.lk_cambiar_contraseña.TabStop = true;
            this.lk_cambiar_contraseña.Text = "Cambiar contraseña ...";
            // 
            // lb_contra
            // 
            this.lb_contra.AutoSize = true;
            this.lb_contra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.lb_contra.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contra.ForeColor = System.Drawing.Color.White;
            this.lb_contra.Location = new System.Drawing.Point(319, 259);
            this.lb_contra.Name = "lb_contra";
            this.lb_contra.Size = new System.Drawing.Size(126, 27);
            this.lb_contra.TabIndex = 7;
            this.lb_contra.Text = "Contraseña";
            this.lb_contra.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // fm_Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 592);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lk_cambiar_contraseña);
            this.Controls.Add(this.tx_contraseña);
            this.Controls.Add(this.lb_contra);
            this.Controls.Add(this.lb_correo);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.tx_correo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fm_Inicio_Sesion";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tx_correo;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Label lb_correo;
        private System.Windows.Forms.TextBox tx_contraseña;
        private System.Windows.Forms.LinkLabel lk_cambiar_contraseña;
        private System.Windows.Forms.Label lb_contra;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}