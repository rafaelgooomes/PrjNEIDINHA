
namespace PrjNeidinha
{
    partial class Cadastrar_Funcionario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStatusFunc = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtLoginFunc = new System.Windows.Forms.TextBox();
            this.refInterna = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.nomeFunc = new System.Windows.Forms.Label();
            this.btnAdicionarFotoFunc = new System.Windows.Forms.Button();
            this.txtSenhaFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelFunc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtualizarFunc = new System.Windows.Forms.Button();
            this.btnEditarFunc = new System.Windows.Forms.Button();
            this.btnExcluirFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(941, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 313);
            this.panel1.TabIndex = 17;
            // 
            // txtStatusFunc
            // 
            this.txtStatusFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusFunc.Location = new System.Drawing.Point(1046, 117);
            this.txtStatusFunc.Name = "txtStatusFunc";
            this.txtStatusFunc.Size = new System.Drawing.Size(153, 38);
            this.txtStatusFunc.TabIndex = 16;
            this.txtStatusFunc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(946, 121);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 31);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // txtLoginFunc
            // 
            this.txtLoginFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginFunc.Location = new System.Drawing.Point(319, 224);
            this.txtLoginFunc.Name = "txtLoginFunc";
            this.txtLoginFunc.Size = new System.Drawing.Size(559, 38);
            this.txtLoginFunc.TabIndex = 12;
            // 
            // refInterna
            // 
            this.refInterna.AutoSize = true;
            this.refInterna.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refInterna.ForeColor = System.Drawing.Color.White;
            this.refInterna.Location = new System.Drawing.Point(40, 228);
            this.refInterna.Name = "refInterna";
            this.refInterna.Size = new System.Drawing.Size(87, 31);
            this.refInterna.TabIndex = 11;
            this.refInterna.Text = "Login:";
            this.refInterna.Click += new System.EventHandler(this.refInterna_Click);
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(319, 169);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(559, 38);
            this.txtNomeFunc.TabIndex = 10;
            // 
            // nomeFunc
            // 
            this.nomeFunc.AutoSize = true;
            this.nomeFunc.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFunc.ForeColor = System.Drawing.Color.White;
            this.nomeFunc.Location = new System.Drawing.Point(37, 173);
            this.nomeFunc.Name = "nomeFunc";
            this.nomeFunc.Size = new System.Drawing.Size(276, 31);
            this.nomeFunc.TabIndex = 9;
            this.nomeFunc.Text = "Nome do Funcionário:";
            // 
            // btnAdicionarFotoFunc
            // 
            this.btnAdicionarFotoFunc.BackColor = System.Drawing.Color.Gray;
            this.btnAdicionarFotoFunc.FlatAppearance.BorderSize = 0;
            this.btnAdicionarFotoFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarFotoFunc.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarFotoFunc.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarFotoFunc.Location = new System.Drawing.Point(977, 497);
            this.btnAdicionarFotoFunc.Name = "btnAdicionarFotoFunc";
            this.btnAdicionarFotoFunc.Size = new System.Drawing.Size(200, 41);
            this.btnAdicionarFotoFunc.TabIndex = 18;
            this.btnAdicionarFotoFunc.Text = "ADICIONAR FOTO";
            this.btnAdicionarFotoFunc.UseVisualStyleBackColor = false;
            // 
            // txtSenhaFunc
            // 
            this.txtSenhaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaFunc.Location = new System.Drawing.Point(319, 278);
            this.txtSenhaFunc.Name = "txtSenhaFunc";
            this.txtSenhaFunc.Size = new System.Drawing.Size(559, 38);
            this.txtSenhaFunc.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Senha:";
            // 
            // txtEmailFunc
            // 
            this.txtEmailFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFunc.Location = new System.Drawing.Point(319, 334);
            this.txtEmailFunc.Name = "txtEmailFunc";
            this.txtEmailFunc.Size = new System.Drawing.Size(559, 38);
            this.txtEmailFunc.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Email:";
            // 
            // txtTelFunc
            // 
            this.txtTelFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelFunc.Location = new System.Drawing.Point(319, 396);
            this.txtTelFunc.Name = "txtTelFunc";
            this.txtTelFunc.Size = new System.Drawing.Size(559, 38);
            this.txtTelFunc.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "Telefone:";
            // 
            // btnAtualizarFunc
            // 
            this.btnAtualizarFunc.BackColor = System.Drawing.Color.Gray;
            this.btnAtualizarFunc.FlatAppearance.BorderSize = 0;
            this.btnAtualizarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarFunc.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarFunc.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarFunc.Location = new System.Drawing.Point(251, 34);
            this.btnAtualizarFunc.Name = "btnAtualizarFunc";
            this.btnAtualizarFunc.Size = new System.Drawing.Size(169, 41);
            this.btnAtualizarFunc.TabIndex = 14;
            this.btnAtualizarFunc.Text = "ATUALIZAR";
            this.btnAtualizarFunc.UseVisualStyleBackColor = false;
            // 
            // btnEditarFunc
            // 
            this.btnEditarFunc.BackColor = System.Drawing.Color.Gray;
            this.btnEditarFunc.FlatAppearance.BorderSize = 0;
            this.btnEditarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFunc.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFunc.ForeColor = System.Drawing.Color.White;
            this.btnEditarFunc.Location = new System.Drawing.Point(53, 34);
            this.btnEditarFunc.Name = "btnEditarFunc";
            this.btnEditarFunc.Size = new System.Drawing.Size(169, 41);
            this.btnEditarFunc.TabIndex = 13;
            this.btnEditarFunc.Text = "EDITAR";
            this.btnEditarFunc.UseVisualStyleBackColor = false;
            // 
            // btnExcluirFunc
            // 
            this.btnExcluirFunc.BackColor = System.Drawing.Color.Gray;
            this.btnExcluirFunc.FlatAppearance.BorderSize = 0;
            this.btnExcluirFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFunc.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFunc.ForeColor = System.Drawing.Color.White;
            this.btnExcluirFunc.Location = new System.Drawing.Point(447, 34);
            this.btnExcluirFunc.Name = "btnExcluirFunc";
            this.btnExcluirFunc.Size = new System.Drawing.Size(169, 41);
            this.btnExcluirFunc.TabIndex = 19;
            this.btnExcluirFunc.Text = "EXCLUIR";
            this.btnExcluirFunc.UseVisualStyleBackColor = false;
            // 
            // Cadastrar_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1249, 591);
            this.Controls.Add(this.btnExcluirFunc);
            this.Controls.Add(this.btnEditarFunc);
            this.Controls.Add(this.txtTelFunc);
            this.Controls.Add(this.btnAtualizarFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailFunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenhaFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatusFunc);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAdicionarFotoFunc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLoginFunc);
            this.Controls.Add(this.refInterna);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.nomeFunc);
            this.Name = "Cadastrar_Funcionario";
            this.Text = "Cadastrar_Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStatusFunc;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtLoginFunc;
        private System.Windows.Forms.Label refInterna;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label nomeFunc;
        private System.Windows.Forms.Button btnAdicionarFotoFunc;
        private System.Windows.Forms.TextBox txtSenhaFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailFunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAtualizarFunc;
        private System.Windows.Forms.Button btnEditarFunc;
        private System.Windows.Forms.Button btnExcluirFunc;
    }
}