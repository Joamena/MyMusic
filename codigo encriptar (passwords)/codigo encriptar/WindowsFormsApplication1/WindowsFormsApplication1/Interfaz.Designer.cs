namespace WindowsFormsApplication1
{
    partial class Interfaz
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
            this._TextBoxUser = new System.Windows.Forms.TextBox();
            this._textBoxPassword = new System.Windows.Forms.TextBox();
            this._textBoxEncriptado = new System.Windows.Forms.TextBox();
            this._labelUser = new System.Windows.Forms.Label();
            this._labelPassword = new System.Windows.Forms.Label();
            this.encriptacion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _TextBoxUser
            // 
            this._TextBoxUser.Location = new System.Drawing.Point(150, 44);
            this._TextBoxUser.Name = "_TextBoxUser";
            this._TextBoxUser.Size = new System.Drawing.Size(258, 20);
            this._TextBoxUser.TabIndex = 1;
            // 
            // _textBoxPassword
            // 
            this._textBoxPassword.Location = new System.Drawing.Point(150, 87);
            this._textBoxPassword.Name = "_textBoxPassword";
            this._textBoxPassword.Size = new System.Drawing.Size(258, 20);
            this._textBoxPassword.TabIndex = 2;
            // 
            // _textBoxEncriptado
            // 
            this._textBoxEncriptado.Location = new System.Drawing.Point(150, 154);
            this._textBoxEncriptado.Multiline = true;
            this._textBoxEncriptado.Name = "_textBoxEncriptado";
            this._textBoxEncriptado.Size = new System.Drawing.Size(258, 81);
            this._textBoxEncriptado.TabIndex = 3;
            // 
            // _labelUser
            // 
            this._labelUser.AutoSize = true;
            this._labelUser.Location = new System.Drawing.Point(65, 44);
            this._labelUser.Name = "_labelUser";
            this._labelUser.Size = new System.Drawing.Size(30, 13);
            this._labelUser.TabIndex = 4;
            this._labelUser.Text = "user:";
            // 
            // _labelPassword
            // 
            this._labelPassword.AutoSize = true;
            this._labelPassword.Location = new System.Drawing.Point(65, 87);
            this._labelPassword.Name = "_labelPassword";
            this._labelPassword.Size = new System.Drawing.Size(52, 13);
            this._labelPassword.TabIndex = 5;
            this._labelPassword.Text = "password";
            // 
            // encriptacion
            // 
            this.encriptacion.AutoSize = true;
            this.encriptacion.Location = new System.Drawing.Point(65, 154);
            this.encriptacion.Name = "encriptacion";
            this.encriptacion.Size = new System.Drawing.Size(65, 13);
            this.encriptacion.TabIndex = 6;
            this.encriptacion.Text = "encriptacion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Encriptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.encriptacion);
            this.Controls.Add(this._labelPassword);
            this.Controls.Add(this._labelUser);
            this.Controls.Add(this._textBoxEncriptado);
            this.Controls.Add(this._textBoxPassword);
            this.Controls.Add(this._TextBoxUser);
            this.Name = "Interfaz";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _TextBoxUser;
        private System.Windows.Forms.TextBox _textBoxPassword;
        private System.Windows.Forms.TextBox _textBoxEncriptado;
        private System.Windows.Forms.Label _labelUser;
        private System.Windows.Forms.Label _labelPassword;
        private System.Windows.Forms.Label encriptacion;
        private System.Windows.Forms.Button button1;
    }
}