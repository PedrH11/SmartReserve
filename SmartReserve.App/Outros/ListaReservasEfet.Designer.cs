namespace SmartReserve.App.Outros
{
    partial class ListaReservasEfet
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
            labelNomeAula = new Label();
            labelAlunos = new Label();
            labelDataHorario = new Label();
            labelInstrutor = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelStatusReserva = new Label();
            labelId = new Label();
            SuspendLayout();
            // 
            // labelNomeAula
            // 
            labelNomeAula.AutoSize = true;
            labelNomeAula.Font = new Font("Segoe UI", 20F);
            labelNomeAula.Location = new Point(181, 17);
            labelNomeAula.Name = "labelNomeAula";
            labelNomeAula.Size = new Size(109, 46);
            labelNomeAula.TabIndex = 0;
            labelNomeAula.Text = "label1";
            // 
            // labelAlunos
            // 
            labelAlunos.AutoSize = true;
            labelAlunos.Font = new Font("Segoe UI", 12F);
            labelAlunos.Location = new Point(178, 92);
            labelAlunos.Name = "labelAlunos";
            labelAlunos.Size = new Size(65, 28);
            labelAlunos.TabIndex = 1;
            labelAlunos.Text = "label2";
            // 
            // labelDataHorario
            // 
            labelDataHorario.AutoSize = true;
            labelDataHorario.Location = new Point(208, 63);
            labelDataHorario.Name = "labelDataHorario";
            labelDataHorario.Size = new Size(50, 20);
            labelDataHorario.TabIndex = 2;
            labelDataHorario.Text = "label1";
            // 
            // labelInstrutor
            // 
            labelInstrutor.AutoSize = true;
            labelInstrutor.BackColor = SystemColors.GrayText;
            labelInstrutor.Font = new Font("Segoe UI", 12F);
            labelInstrutor.Location = new Point(204, 120);
            labelInstrutor.Name = "labelInstrutor";
            labelInstrutor.Size = new Size(65, 28);
            labelInstrutor.TabIndex = 3;
            labelInstrutor.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(19, 92);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 4;
            label1.Text = "Nome do aluno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(19, 120);
            label2.Name = "label2";
            label2.Size = new Size(179, 28);
            label2.TabIndex = 5;
            label2.Text = "Nome do instrutor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(19, 148);
            label3.Name = "label3";
            label3.Size = new Size(163, 28);
            label3.TabIndex = 6;
            label3.Text = "Status da reserva:";
            // 
            // labelStatusReserva
            // 
            labelStatusReserva.AutoSize = true;
            labelStatusReserva.BackColor = SystemColors.GrayText;
            labelStatusReserva.Font = new Font("Segoe UI", 12F);
            labelStatusReserva.Location = new Point(188, 148);
            labelStatusReserva.Name = "labelStatusReserva";
            labelStatusReserva.Size = new Size(65, 28);
            labelStatusReserva.TabIndex = 7;
            labelStatusReserva.Text = "label1";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(19, 17);
            labelId.Name = "labelId";
            labelId.Size = new Size(50, 20);
            labelId.TabIndex = 8;
            labelId.Text = "label4";
            // 
            // ListaReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            Controls.Add(labelId);
            Controls.Add(labelStatusReserva);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelInstrutor);
            Controls.Add(labelDataHorario);
            Controls.Add(labelAlunos);
            Controls.Add(labelNomeAula);
            Name = "ListaReservas";
            Size = new Size(579, 186);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelNomeAula;
        public Label labelDataHorario;
        public Label labelInstrutor;
        public Label labelAlunos;
        private Label label1;
        private Label label2;
        private Label label3;
        public Label labelStatusReserva;
        public Label labelId;
    }
}
