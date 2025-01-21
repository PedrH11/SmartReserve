namespace SmartReserve.App
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            categoriaDeAulaToolStripMenuItem = new ToolStripMenuItem();
            aulasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            instrutoresToolStripMenuItem = new ToolStripMenuItem();
            alunosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            reservasToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            reservasEfetuadasToolStripMenuItem = new ToolStripMenuItem();
            RelatorioaulasToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, relatóriosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriaDeAulaToolStripMenuItem, aulasToolStripMenuItem, toolStripSeparator1, instrutoresToolStripMenuItem, alunosToolStripMenuItem, toolStripSeparator2, reservasToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(88, 24);
            cadastroToolStripMenuItem.Text = "Cadastros";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // categoriaDeAulaToolStripMenuItem
            // 
            categoriaDeAulaToolStripMenuItem.Name = "categoriaDeAulaToolStripMenuItem";
            categoriaDeAulaToolStripMenuItem.Size = new Size(210, 26);
            categoriaDeAulaToolStripMenuItem.Text = "Categoria de aula";
            categoriaDeAulaToolStripMenuItem.Click += categoriaDeAulaToolStripMenuItem_Click;
            // 
            // aulasToolStripMenuItem
            // 
            aulasToolStripMenuItem.Name = "aulasToolStripMenuItem";
            aulasToolStripMenuItem.Size = new Size(210, 26);
            aulasToolStripMenuItem.Text = "Aulas";
            aulasToolStripMenuItem.Click += aulasToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(207, 6);
            // 
            // instrutoresToolStripMenuItem
            // 
            instrutoresToolStripMenuItem.Name = "instrutoresToolStripMenuItem";
            instrutoresToolStripMenuItem.Size = new Size(210, 26);
            instrutoresToolStripMenuItem.Text = "Instrutores";
            instrutoresToolStripMenuItem.Click += instrutoresToolStripMenuItem_Click;
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            alunosToolStripMenuItem.Size = new Size(210, 26);
            alunosToolStripMenuItem.Text = "Alunos";
            alunosToolStripMenuItem.Click += alunosToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(207, 6);
            // 
            // reservasToolStripMenuItem
            // 
            reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            reservasToolStripMenuItem.Size = new Size(210, 26);
            reservasToolStripMenuItem.Text = "Reservas";
            reservasToolStripMenuItem.Click += reservasToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reservasEfetuadasToolStripMenuItem, RelatorioaulasToolStripMenuItem1 });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(90, 24);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // reservasEfetuadasToolStripMenuItem
            // 
            reservasEfetuadasToolStripMenuItem.Name = "reservasEfetuadasToolStripMenuItem";
            reservasEfetuadasToolStripMenuItem.Size = new Size(149, 26);
            reservasEfetuadasToolStripMenuItem.Text = "Reservas";
            reservasEfetuadasToolStripMenuItem.Click += reservasEfetuadasToolStripMenuItem_Click;
            // 
            // RelatorioaulasToolStripMenuItem1
            // 
            RelatorioaulasToolStripMenuItem1.Name = "RelatorioaulasToolStripMenuItem1";
            RelatorioaulasToolStripMenuItem1.Size = new Size(149, 26);
            RelatorioaulasToolStripMenuItem1.Text = "Aulas";
            RelatorioaulasToolStripMenuItem1.Click += aulasToolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources._166116f7_f552_41a8_a878_770c033315f8__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sistema SmartReserve";
            TransparencyKey = Color.Black;
            WindowState = FormWindowState.Maximized;
            FormClosing += Principal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem instrutoresToolStripMenuItem;
        private ToolStripMenuItem aulasToolStripMenuItem;
        private ToolStripMenuItem categoriaDeAulaToolStripMenuItem;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem reservasEfetuadasToolStripMenuItem;
        private ToolStripMenuItem RelatorioaulasToolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
