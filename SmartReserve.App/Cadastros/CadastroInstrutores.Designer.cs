namespace SmartReserve.App.Cadastros
{
    partial class CadastroInstrutores
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEspecialidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCPF = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            TabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtCPF);
            tabPageCadastro.Controls.Add(txtEspecialidade);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEspecialidade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCPF, 0);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(27, 31);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(591, 48);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(646, 31);
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
            txtId.Size = new Size(115, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.AnimateReadOnly = false;
            txtEspecialidade.AutoCompleteMode = AutoCompleteMode.None;
            txtEspecialidade.AutoCompleteSource = AutoCompleteSource.None;
            txtEspecialidade.BackgroundImageLayout = ImageLayout.None;
            txtEspecialidade.CharacterCasing = CharacterCasing.Normal;
            txtEspecialidade.Depth = 0;
            txtEspecialidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEspecialidade.HideSelection = true;
            txtEspecialidade.Hint = "Especialidade";
            txtEspecialidade.LeadingIcon = null;
            txtEspecialidade.Location = new Point(27, 116);
            txtEspecialidade.MaxLength = 32767;
            txtEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.PasswordChar = '\0';
            txtEspecialidade.PrefixSuffixText = null;
            txtEspecialidade.ReadOnly = false;
            txtEspecialidade.RightToLeft = RightToLeft.No;
            txtEspecialidade.SelectedText = "";
            txtEspecialidade.SelectionLength = 0;
            txtEspecialidade.SelectionStart = 0;
            txtEspecialidade.ShortcutsEnabled = true;
            txtEspecialidade.Size = new Size(416, 48);
            txtEspecialidade.TabIndex = 4;
            txtEspecialidade.TabStop = false;
            txtEspecialidade.TextAlign = HorizontalAlignment.Left;
            txtEspecialidade.TrailingIcon = null;
            txtEspecialidade.UseSystemPasswordChar = false;
            // 
            // txtCPF
            // 
            txtCPF.AllowPromptAsInput = true;
            txtCPF.AnimateReadOnly = false;
            txtCPF.AsciiOnly = false;
            txtCPF.BackgroundImageLayout = ImageLayout.None;
            txtCPF.BeepOnError = false;
            txtCPF.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCPF.Depth = 0;
            txtCPF.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCPF.HidePromptOnLeave = false;
            txtCPF.HideSelection = true;
            txtCPF.Hint = "CPF";
            txtCPF.InsertKeyMode = InsertKeyMode.Default;
            txtCPF.LeadingIcon = null;
            txtCPF.Location = new Point(449, 116);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.MaxLength = 32767;
            txtCPF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCPF.Name = "txtCPF";
            txtCPF.PasswordChar = '\0';
            txtCPF.PrefixSuffixText = null;
            txtCPF.PromptChar = '_';
            txtCPF.ReadOnly = false;
            txtCPF.RejectInputOnFirstFailure = false;
            txtCPF.ResetOnPrompt = true;
            txtCPF.ResetOnSpace = true;
            txtCPF.RightToLeft = RightToLeft.No;
            txtCPF.SelectedText = "";
            txtCPF.SelectionLength = 0;
            txtCPF.SelectionStart = 0;
            txtCPF.ShortcutsEnabled = true;
            txtCPF.Size = new Size(312, 48);
            txtCPF.SkipLiterals = true;
            txtCPF.TabIndex = 5;
            txtCPF.TabStop = false;
            txtCPF.Text = "   ,   ,   -";
            txtCPF.TextAlign = HorizontalAlignment.Left;
            txtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCPF.TrailingIcon = null;
            txtCPF.UseSystemPasswordChar = false;
            txtCPF.ValidatingType = null;
            txtCPF.Click += materialMaskedTextBox1_Click;
            // 
            // CadastroInstrutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroInstrutores";
            Text = "CadastroInstrutores";
            TabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCPF;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEspecialidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
    }
}