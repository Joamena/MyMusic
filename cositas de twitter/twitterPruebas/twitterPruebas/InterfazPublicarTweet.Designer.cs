namespace twitterPruebas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Comentario = new System.Windows.Forms.Label();
            this._textBoxComentario = new System.Windows.Forms.TextBox();
            this._BotonPublicar = new System.Windows.Forms.Button();
            this._buttonContar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Comentario
            // 
            this.Comentario.AutoSize = true;
            this.Comentario.Location = new System.Drawing.Point(25, 52);
            this.Comentario.Name = "Comentario";
            this.Comentario.Size = new System.Drawing.Size(63, 13);
            this.Comentario.TabIndex = 1;
            this.Comentario.Text = "Comentario:";
            this.Comentario.Click += new System.EventHandler(this.label1_Click);
            // 
            // _textBoxComentario
            // 
            this._textBoxComentario.Location = new System.Drawing.Point(28, 86);
            this._textBoxComentario.Name = "_textBoxComentario";
            this._textBoxComentario.Size = new System.Drawing.Size(228, 20);
            this._textBoxComentario.TabIndex = 2;
            // 
            // _BotonPublicar
            // 
            this._BotonPublicar.Location = new System.Drawing.Point(97, 125);
            this._BotonPublicar.Name = "_BotonPublicar";
            this._BotonPublicar.Size = new System.Drawing.Size(75, 23);
            this._BotonPublicar.TabIndex = 3;
            this._BotonPublicar.Text = "Publicar";
            this._BotonPublicar.UseVisualStyleBackColor = true;
            this._BotonPublicar.Click += new System.EventHandler(this.button1_Click);
            // 
            // _buttonContar
            // 
            this._buttonContar.Location = new System.Drawing.Point(97, 163);
            this._buttonContar.Name = "_buttonContar";
            this._buttonContar.Size = new System.Drawing.Size(75, 23);
            this._buttonContar.TabIndex = 4;
            this._buttonContar.Text = "contar #\'s";
            this._buttonContar.UseVisualStyleBackColor = true;
            this._buttonContar.Click += new System.EventHandler(this._buttonContar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 265);
            this.Controls.Add(this._buttonContar);
            this.Controls.Add(this._BotonPublicar);
            this.Controls.Add(this._textBoxComentario);
            this.Controls.Add(this.Comentario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Comentario;
        private System.Windows.Forms.TextBox _textBoxComentario;
        private System.Windows.Forms.Button _BotonPublicar;
        private System.Windows.Forms.Button _buttonContar;
    }
}

