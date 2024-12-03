namespace cadastroEmpresas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCnpj = new TextBox();
            txtData = new TextBox();
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            cadEmpresasToolStripMenuItem = new ToolStripMenuItem();
            pesquisarEmpresaToolStripMenuItem = new ToolStripMenuItem();
            btcadastrar = new Button();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(294, 171);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(270, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 42);
            label1.Name = "label1";
            label1.Size = new Size(357, 30);
            label1.TabIndex = 1;
            label1.Text = "Cadastros e Pesquisas de Empresas ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(207, 169);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(210, 216);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 3;
            label3.Text = "CNPJ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(211, 254);
            label4.Name = "label4";
            label4.Size = new Size(144, 21);
            label4.TabIndex = 4;
            label4.Text = "Data de Cadastro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(214, 299);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 5;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(294, 214);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(268, 23);
            txtCnpj.TabIndex = 2;
            // 
            // txtData
            // 
            txtData.Location = new Point(386, 254);
            txtData.Name = "txtData";
            txtData.Size = new Size(178, 23);
            txtData.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(351, 119);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 8;
            label6.Text = "EMPRESA";
            label6.Click += label6_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 25);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { cadEmpresasToolStripMenuItem, pesquisarEmpresaToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 25);
            menuStrip2.TabIndex = 10;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // cadEmpresasToolStripMenuItem
            // 
            cadEmpresasToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadEmpresasToolStripMenuItem.Name = "cadEmpresasToolStripMenuItem";
            cadEmpresasToolStripMenuItem.Size = new Size(104, 21);
            cadEmpresasToolStripMenuItem.Text = "Cad Empresas";
            // 
            // pesquisarEmpresaToolStripMenuItem
            // 
            pesquisarEmpresaToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pesquisarEmpresaToolStripMenuItem.Name = "pesquisarEmpresaToolStripMenuItem";
            pesquisarEmpresaToolStripMenuItem.Size = new Size(131, 21);
            pesquisarEmpresaToolStripMenuItem.Text = "Pesquisar Empresa";
            // 
            // btcadastrar
            // 
            btcadastrar.Location = new Point(351, 300);
            btcadastrar.Name = "btcadastrar";
            btcadastrar.Size = new Size(75, 23);
            btcadastrar.TabIndex = 4;
            btcadastrar.Text = "Cadastrar";
            btcadastrar.UseVisualStyleBackColor = true;
            btcadastrar.Click += btcadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btcadastrar);
            Controls.Add(label6);
            Controls.Add(txtData);
            Controls.Add(txtCnpj);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCnpj;
        private TextBox txtData;
        private Label label6;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem cadEmpresasToolStripMenuItem;
        private Button btcadastrar;
        private ToolStripMenuItem pesquisarEmpresaToolStripMenuItem;
    }
}
