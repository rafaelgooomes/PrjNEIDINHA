
namespace PrjNeidinha
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAcessarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAcessarLogin
            // 
            this.btnAcessarLogin.BackColor = System.Drawing.Color.Gray;
            this.btnAcessarLogin.FlatAppearance.BorderSize = 0;
            this.btnAcessarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessarLogin.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessarLogin.ForeColor = System.Drawing.Color.White;
            this.btnAcessarLogin.Location = new System.Drawing.Point(310, 181);
            this.btnAcessarLogin.Name = "btnAcessarLogin";
            this.btnAcessarLogin.Size = new System.Drawing.Size(169, 41);
            this.btnAcessarLogin.TabIndex = 14;
            this.btnAcessarLogin.Text = "ACESSAR";
            this.btnAcessarLogin.UseVisualStyleBackColor = false;
            this.btnAcessarLogin.Click += new System.EventHandler(this.btnAcessarLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAcessarLogin);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAcessarLogin;
    }
}

