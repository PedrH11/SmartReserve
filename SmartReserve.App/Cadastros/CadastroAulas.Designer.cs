namespace SmartReserve.App.Cadastros
{
    partial class CadastroAulas
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
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCapacidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtHorario = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnAtivo = new ReaLTaiizor.Controls.MaterialRadioButton();
            cbxInstrutores = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxCategoriaAula = new ReaLTaiizor.Controls.MaterialComboBox();
            TabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cbxCategoriaAula);
            tabPageCadastro.Controls.Add(cbxInstrutores);
            tabPageCadastro.Controls.Add(btnAtivo);
            tabPageCadastro.Controls.Add(txtHorario);
            tabPageCadastro.Controls.Add(txtCapacidade);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCapacidade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtHorario, 0);
            tabPageCadastro.Controls.SetChildIndex(btnAtivo, 0);
            tabPageCadastro.Controls.SetChildIndex(cbxInstrutores, 0);
            tabPageCadastro.Controls.SetChildIndex(cbxCategoriaAula, 0);
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.AutoCompleteMode = AutoCompleteMode.None;
            txtDescricao.AutoCompleteSource = AutoCompleteSource.None;
            txtDescricao.BackgroundImageLayout = ImageLayout.None;
            txtDescricao.CharacterCasing = CharacterCasing.Normal;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.HideSelection = true;
            txtDescricao.Hint = "Descrição";
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(40, 24);
            txtDescricao.MaxLength = 32767;
            txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.PrefixSuffixText = null;
            txtDescricao.ReadOnly = false;
            txtDescricao.RightToLeft = RightToLeft.No;
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.ShortcutsEnabled = true;
            txtDescricao.Size = new Size(630, 48);
            txtDescricao.TabIndex = 2;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(676, 24);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(85, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtCapacidade
            // 
            txtCapacidade.AnimateReadOnly = false;
            txtCapacidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCapacidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCapacidade.BackgroundImageLayout = ImageLayout.None;
            txtCapacidade.CharacterCasing = CharacterCasing.Normal;
            txtCapacidade.Depth = 0;
            txtCapacidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCapacidade.HideSelection = true;
            txtCapacidade.Hint = "Capacidade (max)";
            txtCapacidade.LeadingIcon = null;
            txtCapacidade.Location = new Point(40, 98);
            txtCapacidade.MaxLength = 32767;
            txtCapacidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCapacidade.Name = "txtCapacidade";
            txtCapacidade.PasswordChar = '\0';
            txtCapacidade.PrefixSuffixText = null;
            txtCapacidade.ReadOnly = false;
            txtCapacidade.RightToLeft = RightToLeft.No;
            txtCapacidade.SelectedText = "";
            txtCapacidade.SelectionLength = 0;
            txtCapacidade.SelectionStart = 0;
            txtCapacidade.ShortcutsEnabled = true;
            txtCapacidade.Size = new Size(312, 48);
            txtCapacidade.TabIndex = 4;
            txtCapacidade.TabStop = false;
            txtCapacidade.TextAlign = HorizontalAlignment.Left;
            txtCapacidade.TrailingIcon = null;
            txtCapacidade.UseSystemPasswordChar = false;
            // 
            // txtHorario
            // 
            txtHorario.AllowPromptAsInput = true;
            txtHorario.AnimateReadOnly = false;
            txtHorario.AsciiOnly = false;
            txtHorario.BackgroundImageLayout = ImageLayout.None;
            txtHorario.BeepOnError = false;
            txtHorario.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtHorario.Depth = 0;
            txtHorario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHorario.HidePromptOnLeave = false;
            txtHorario.HideSelection = true;
            txtHorario.Hint = "Data/Horario";
            txtHorario.InsertKeyMode = InsertKeyMode.Default;
            txtHorario.LeadingIcon = null;
            txtHorario.Location = new Point(406, 98);
            txtHorario.Mask = "99/99/9999 99:99";
            txtHorario.MaxLength = 32767;
            txtHorario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtHorario.Name = "txtHorario";
            txtHorario.PasswordChar = '\0';
            txtHorario.PrefixSuffixText = null;
            txtHorario.PromptChar = '_';
            txtHorario.ReadOnly = false;
            txtHorario.RejectInputOnFirstFailure = false;
            txtHorario.ResetOnPrompt = true;
            txtHorario.ResetOnSpace = true;
            txtHorario.RightToLeft = RightToLeft.No;
            txtHorario.SelectedText = "";
            txtHorario.SelectionLength = 0;
            txtHorario.SelectionStart = 0;
            txtHorario.ShortcutsEnabled = true;
            txtHorario.Size = new Size(194, 48);
            txtHorario.SkipLiterals = true;
            txtHorario.TabIndex = 5;
            txtHorario.TabStop = false;
            txtHorario.Text = "  /  /       :";
            txtHorario.TextAlign = HorizontalAlignment.Left;
            txtHorario.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtHorario.TrailingIcon = null;
            txtHorario.UseSystemPasswordChar = false;
            txtHorario.ValidatingType = null;
            // 
            // btnAtivo
            // 
            btnAtivo.AutoSize = true;
            btnAtivo.Depth = 0;
            btnAtivo.Location = new Point(622, 109);
            btnAtivo.Margin = new Padding(0);
            btnAtivo.MouseLocation = new Point(-1, -1);
            btnAtivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAtivo.Name = "btnAtivo";
            btnAtivo.Ripple = true;
            btnAtivo.Size = new Size(109, 37);
            btnAtivo.TabIndex = 6;
            btnAtivo.TabStop = true;
            btnAtivo.Text = "Disponivel";
            btnAtivo.UseAccentColor = false;
            btnAtivo.UseVisualStyleBackColor = true;
            // 
            // cbxInstrutores
            // 
            cbxInstrutores.AutoResize = false;
            cbxInstrutores.BackColor = Color.FromArgb(255, 255, 255);
            cbxInstrutores.Depth = 0;
            cbxInstrutores.DrawMode = DrawMode.OwnerDrawVariable;
            cbxInstrutores.DropDownHeight = 174;
            cbxInstrutores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInstrutores.DropDownWidth = 121;
            cbxInstrutores.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxInstrutores.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxInstrutores.FormattingEnabled = true;
            cbxInstrutores.Hint = "Instrutores";
            cbxInstrutores.IntegralHeight = false;
            cbxInstrutores.ItemHeight = 43;
            cbxInstrutores.Location = new Point(40, 171);
            cbxInstrutores.MaxDropDownItems = 4;
            cbxInstrutores.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxInstrutores.Name = "cbxInstrutores";
            cbxInstrutores.Size = new Size(721, 49);
            cbxInstrutores.StartIndex = 0;
            cbxInstrutores.TabIndex = 7;
            // 
            // cbxCategoriaAula
            // 
            cbxCategoriaAula.AutoResize = false;
            cbxCategoriaAula.BackColor = Color.FromArgb(255, 255, 255);
            cbxCategoriaAula.Depth = 0;
            cbxCategoriaAula.DrawMode = DrawMode.OwnerDrawVariable;
            cbxCategoriaAula.DropDownHeight = 174;
            cbxCategoriaAula.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoriaAula.DropDownWidth = 121;
            cbxCategoriaAula.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxCategoriaAula.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxCategoriaAula.FormattingEnabled = true;
            cbxCategoriaAula.Hint = "Categoria da aula";
            cbxCategoriaAula.IntegralHeight = false;
            cbxCategoriaAula.ItemHeight = 43;
            cbxCategoriaAula.Location = new Point(40, 226);
            cbxCategoriaAula.MaxDropDownItems = 4;
            cbxCategoriaAula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxCategoriaAula.Name = "cbxCategoriaAula";
            cbxCategoriaAula.Size = new Size(721, 49);
            cbxCategoriaAula.StartIndex = 0;
            cbxCategoriaAula.TabIndex = 8;
            // 
            // CadastroAulas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroAulas";
            Text = "CadastroAulas";
            TabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCapacidade;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtHorario;
        private ReaLTaiizor.Controls.MaterialRadioButton btnAtivo;
        private ReaLTaiizor.Controls.MaterialComboBox cbxCategoriaAula;
        private ReaLTaiizor.Controls.MaterialComboBox cbxInstrutores;
    }
}