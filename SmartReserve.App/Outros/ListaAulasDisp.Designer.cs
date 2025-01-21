namespace SmartReserve.App.Outros
{
    partial class ListaAulasDisp
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            labelAula = new ReaLTaiizor.Controls.MaterialLabel();
            labelId = new ReaLTaiizor.Controls.MaterialLabel();
            labelCapacidade = new ReaLTaiizor.Controls.MaterialLabel();
            labelInstrutores = new ReaLTaiizor.Controls.MaterialLabel();
            labelHorario = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // labelAula
            // 
            labelAula.AutoSize = true;
            labelAula.Depth = 0;
            labelAula.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelAula.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            labelAula.Location = new Point(146, 14);
            labelAula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            labelAula.Name = "labelAula";
            labelAula.Size = new Size(49, 29);
            labelAula.TabIndex = 0;
            labelAula.Text = "Aula";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Depth = 0;
            labelId.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelId.Location = new Point(14, 14);
            labelId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            labelId.Name = "labelId";
            labelId.Size = new Size(14, 19);
            labelId.TabIndex = 1;
            labelId.Text = "Id";
            // 
            // labelCapacidade
            // 
            labelCapacidade.AutoSize = true;
            labelCapacidade.Depth = 0;
            labelCapacidade.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelCapacidade.Location = new Point(122, 117);
            labelCapacidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            labelCapacidade.Name = "labelCapacidade";
            labelCapacidade.Size = new Size(89, 19);
            labelCapacidade.TabIndex = 4;
            labelCapacidade.Text = "Capacidade:";
            // 
            // labelInstrutores
            // 
            labelInstrutores.AutoSize = true;
            labelInstrutores.Depth = 0;
            labelInstrutores.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelInstrutores.Location = new Point(115, 59);
            labelInstrutores.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            labelInstrutores.Name = "labelInstrutores";
            labelInstrutores.Size = new Size(80, 19);
            labelInstrutores.TabIndex = 5;
            labelInstrutores.Text = "Instrutores:";
            // 
            // labelHorario
            // 
            labelHorario.AutoSize = true;
            labelHorario.Depth = 0;
            labelHorario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelHorario.Location = new Point(90, 88);
            labelHorario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            labelHorario.Name = "labelHorario";
            labelHorario.Size = new Size(57, 19);
            labelHorario.TabIndex = 6;
            labelHorario.Text = "Horário:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(27, 59);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(64, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Instrutor:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(27, 88);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(57, 19);
            materialLabel2.TabIndex = 8;
            materialLabel2.Text = "Horário:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(27, 117);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(89, 19);
            materialLabel3.TabIndex = 9;
            materialLabel3.Text = "Capacidade:";
            // 
            // ListaAulasDisp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(labelHorario);
            Controls.Add(labelInstrutores);
            Controls.Add(labelCapacidade);
            Controls.Add(labelId);
            Controls.Add(labelAula);
            Name = "ListaAulasDisp";
            Size = new Size(357, 157);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ReaLTaiizor.Controls.MaterialLabel labelAula;
        public ReaLTaiizor.Controls.MaterialLabel labelId;
        public ReaLTaiizor.Controls.MaterialLabel labelCapacidade;
        public ReaLTaiizor.Controls.MaterialLabel labelInstrutores;
        public ReaLTaiizor.Controls.MaterialLabel labelHorario;
        public ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        public ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        public ReaLTaiizor.Controls.MaterialLabel materialLabel3;
    }
}
