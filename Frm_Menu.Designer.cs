namespace LivrariaTeste
{
    partial class Frm_Menu
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
            this.pne_menu = new System.Windows.Forms.Panel();
            this.pne_logo = new System.Windows.Forms.Panel();
            this.btn_func = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_fone = new System.Windows.Forms.Button();
            this.btn_livros = new System.Windows.Forms.Button();
            this.btn_editora = new System.Windows.Forms.Button();
            this.btn_cat = new System.Windows.Forms.Button();
            this.Btn_Autor = new System.Windows.Forms.Button();
            this.btn_pedido = new System.Windows.Forms.Button();
            this.btn_caixa = new System.Windows.Forms.Button();
            this.pne_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pne_menu
            // 
            this.pne_menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pne_menu.Controls.Add(this.btn_caixa);
            this.pne_menu.Controls.Add(this.btn_pedido);
            this.pne_menu.Controls.Add(this.Btn_Autor);
            this.pne_menu.Controls.Add(this.btn_cat);
            this.pne_menu.Controls.Add(this.btn_editora);
            this.pne_menu.Controls.Add(this.btn_livros);
            this.pne_menu.Controls.Add(this.btn_fone);
            this.pne_menu.Controls.Add(this.btn_cliente);
            this.pne_menu.Controls.Add(this.btn_func);
            this.pne_menu.Controls.Add(this.pne_logo);
            this.pne_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pne_menu.Location = new System.Drawing.Point(0, 0);
            this.pne_menu.Name = "pne_menu";
            this.pne_menu.Size = new System.Drawing.Size(585, 808);
            this.pne_menu.TabIndex = 0;
            // 
            // pne_logo
            // 
            this.pne_logo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pne_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pne_logo.Location = new System.Drawing.Point(0, 0);
            this.pne_logo.Name = "pne_logo";
            this.pne_logo.Size = new System.Drawing.Size(585, 203);
            this.pne_logo.TabIndex = 0;
            // 
            // btn_func
            // 
            this.btn_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_func.Location = new System.Drawing.Point(51, 209);
            this.btn_func.Name = "btn_func";
            this.btn_func.Size = new System.Drawing.Size(360, 66);
            this.btn_func.TabIndex = 1;
            this.btn_func.Text = "Funcionario";
            this.btn_func.UseVisualStyleBackColor = true;
            // 
            // btn_cliente
            // 
            this.btn_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.Location = new System.Drawing.Point(51, 281);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(360, 65);
            this.btn_cliente.TabIndex = 2;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_fone
            // 
            this.btn_fone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fone.Location = new System.Drawing.Point(51, 352);
            this.btn_fone.Name = "btn_fone";
            this.btn_fone.Size = new System.Drawing.Size(360, 57);
            this.btn_fone.TabIndex = 3;
            this.btn_fone.Text = "Telefones";
            this.btn_fone.UseVisualStyleBackColor = true;
            // 
            // btn_livros
            // 
            this.btn_livros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_livros.Location = new System.Drawing.Point(51, 415);
            this.btn_livros.Name = "btn_livros";
            this.btn_livros.Size = new System.Drawing.Size(360, 65);
            this.btn_livros.TabIndex = 4;
            this.btn_livros.Text = "Livros";
            this.btn_livros.UseVisualStyleBackColor = true;
            this.btn_livros.Click += new System.EventHandler(this.btn_livros_Click);
            // 
            // btn_editora
            // 
            this.btn_editora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editora.Location = new System.Drawing.Point(51, 538);
            this.btn_editora.Name = "btn_editora";
            this.btn_editora.Size = new System.Drawing.Size(360, 54);
            this.btn_editora.TabIndex = 5;
            this.btn_editora.Text = "Editora";
            this.btn_editora.UseVisualStyleBackColor = true;
            // 
            // btn_cat
            // 
            this.btn_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat.Location = new System.Drawing.Point(51, 486);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.Size = new System.Drawing.Size(360, 46);
            this.btn_cat.TabIndex = 6;
            this.btn_cat.Text = "Categoria";
            this.btn_cat.UseVisualStyleBackColor = true;
            // 
            // Btn_Autor
            // 
            this.Btn_Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Autor.Location = new System.Drawing.Point(51, 598);
            this.Btn_Autor.Name = "Btn_Autor";
            this.Btn_Autor.Size = new System.Drawing.Size(360, 54);
            this.Btn_Autor.TabIndex = 7;
            this.Btn_Autor.Text = "Autores";
            this.Btn_Autor.UseVisualStyleBackColor = true;
            // 
            // btn_pedido
            // 
            this.btn_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pedido.Location = new System.Drawing.Point(51, 658);
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.Size = new System.Drawing.Size(360, 51);
            this.btn_pedido.TabIndex = 8;
            this.btn_pedido.Text = "Pedido";
            this.btn_pedido.UseVisualStyleBackColor = true;
            // 
            // btn_caixa
            // 
            this.btn_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_caixa.Location = new System.Drawing.Point(51, 729);
            this.btn_caixa.Name = "btn_caixa";
            this.btn_caixa.Size = new System.Drawing.Size(360, 52);
            this.btn_caixa.TabIndex = 9;
            this.btn_caixa.Text = "Caixa";
            this.btn_caixa.UseVisualStyleBackColor = true;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 808);
            this.Controls.Add(this.pne_menu);
            this.Name = "Frm_Menu";
            this.Text = "Frm_Menu";
            this.pne_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pne_menu;
        private System.Windows.Forms.Button btn_caixa;
        private System.Windows.Forms.Button btn_pedido;
        private System.Windows.Forms.Button Btn_Autor;
        private System.Windows.Forms.Button btn_cat;
        private System.Windows.Forms.Button btn_editora;
        private System.Windows.Forms.Button btn_livros;
        private System.Windows.Forms.Button btn_fone;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_func;
        private System.Windows.Forms.Panel pne_logo;
    }
}