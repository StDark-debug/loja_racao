
namespace loja_racao
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cad_entrega = new System.Windows.Forms.Button();
            this.btn_list_entrega = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_cad_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seja Bem-Vindo!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_cad_entrega
            // 
            this.btn_cad_entrega.Location = new System.Drawing.Point(161, 104);
            this.btn_cad_entrega.Name = "btn_cad_entrega";
            this.btn_cad_entrega.Size = new System.Drawing.Size(176, 23);
            this.btn_cad_entrega.TabIndex = 1;
            this.btn_cad_entrega.Text = "Cadastrar Entrega";
            this.btn_cad_entrega.UseVisualStyleBackColor = true;
            this.btn_cad_entrega.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_list_entrega
            // 
            this.btn_list_entrega.Location = new System.Drawing.Point(161, 143);
            this.btn_list_entrega.Name = "btn_list_entrega";
            this.btn_list_entrega.Size = new System.Drawing.Size(176, 23);
            this.btn_list_entrega.TabIndex = 2;
            this.btn_list_entrega.Text = "Listar Entregas";
            this.btn_list_entrega.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_cad_user
            // 
            this.btn_cad_user.Location = new System.Drawing.Point(161, 182);
            this.btn_cad_user.Name = "btn_cad_user";
            this.btn_cad_user.Size = new System.Drawing.Size(176, 23);
            this.btn_cad_user.TabIndex = 5;
            this.btn_cad_user.Text = "Cadastrar Usuário";
            this.btn_cad_user.UseVisualStyleBackColor = true;
            this.btn_cad_user.Click += new System.EventHandler(this.btn_cad_user_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 312);
            this.Controls.Add(this.btn_cad_user);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_list_entrega);
            this.Controls.Add(this.btn_cad_entrega);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Sistema de Entregas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cad_entrega;
        private System.Windows.Forms.Button btn_list_entrega;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_cad_user;
    }
}