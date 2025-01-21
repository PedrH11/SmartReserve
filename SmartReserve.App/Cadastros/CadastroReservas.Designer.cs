namespace SmartReserve.App.Cadastros
{
    partial class CadastroReservas
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
            txtHoraReserva = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnAtivo = new ReaLTaiizor.Controls.MaterialRadioButton();
            cbxAulas = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxAlunos = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cbxAlunos);
            tabPageCadastro.Controls.Add(cbxAulas);
            tabPageCadastro.Controls.Add(btnAtivo);
            tabPageCadastro.Controls.Add(txtHoraReserva);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtHoraReserva, 0);
            tabPageCadastro.Controls.SetChildIndex(btnAtivo, 0);
            tabPageCadastro.Controls.SetChildIndex(cbxAulas, 0);
            tabPageCadastro.Controls.SetChildIndex(cbxAlunos, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // txtHoraReserva
            // 
            txtHoraReserva.AllowPromptAsInput = true;
            txtHoraReserva.AnimateReadOnly = false;
            txtHoraReserva.AsciiOnly = false;
            txtHoraReserva.BackgroundImageLayout = ImageLayout.None;
            txtHoraReserva.BeepOnError = false;
            txtHoraReserva.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtHoraReserva.Depth = 0;
            txtHoraReserva.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHoraReserva.HidePromptOnLeave = false;
            txtHoraReserva.HideSelection = true;
            txtHoraReserva.Hint = "Hora da Reserva";
            txtHoraReserva.InsertKeyMode = InsertKeyMode.Default;
            txtHoraReserva.LeadingIcon = null;
            txtHoraReserva.Location = new Point(119, 29);
            txtHoraReserva.Mask = "99/99/9999 99:99";
            txtHoraReserva.MaxLength = 32767;
            txtHoraReserva.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtHoraReserva.Name = "txtHoraReserva";
            txtHoraReserva.PasswordChar = '\0';
            txtHoraReserva.PrefixSuffixText = null;
            txtHoraReserva.PromptChar = '_';
            txtHoraReserva.ReadOnly = true;
            txtHoraReserva.RejectInputOnFirstFailure = false;
            txtHoraReserva.ResetOnPrompt = true;
            txtHoraReserva.ResetOnSpace = true;
            txtHoraReserva.RightToLeft = RightToLeft.No;
            txtHoraReserva.SelectedText = "";
            txtHoraReserva.SelectionLength = 0;
            txtHoraReserva.SelectionStart = 0;
            txtHoraReserva.ShortcutsEnabled = true;
            txtHoraReserva.Size = new Size(135, 48);
            txtHoraReserva.SkipLiterals = true;
            txtHoraReserva.TabIndex = 3;
            txtHoraReserva.TabStop = false;
            txtHoraReserva.Text = "  /  /       :";
            txtHoraReserva.TextAlign = HorizontalAlignment.Left;
            txtHoraReserva.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtHoraReserva.TrailingIcon = null;
            txtHoraReserva.UseSystemPasswordChar = false;
            txtHoraReserva.ValidatingType = null;
            // 
            // btnAtivo
            // 
            btnAtivo.AutoSize = true;
            btnAtivo.Depth = 0;
            btnAtivo.Location = new Point(616, 237);
            btnAtivo.Margin = new Padding(0);
            btnAtivo.MouseLocation = new Point(-1, -1);
            btnAtivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAtivo.Name = "btnAtivo";
            btnAtivo.Ripple = true;
            btnAtivo.Size = new Size(119, 37);
            btnAtivo.TabIndex = 4;
            btnAtivo.TabStop = true;
            btnAtivo.Text = "Confirmada";
            btnAtivo.UseAccentColor = false;
            btnAtivo.UseVisualStyleBackColor = true;
            // 
            // cbxAulas
            // 
            cbxAulas.AutoResize = false;
            cbxAulas.BackColor = Color.FromArgb(255, 255, 255);
            cbxAulas.Depth = 0;
            cbxAulas.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAulas.DropDownHeight = 174;
            cbxAulas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAulas.DropDownWidth = 121;
            cbxAulas.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAulas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAulas.FormattingEnabled = true;
            cbxAulas.Hint = "Aula";
            cbxAulas.IntegralHeight = false;
            cbxAulas.ItemHeight = 43;
            cbxAulas.Location = new Point(31, 102);
            cbxAulas.MaxDropDownItems = 4;
            cbxAulas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxAulas.Name = "cbxAulas";
            cbxAulas.Size = new Size(704, 49);
            cbxAulas.StartIndex = 0;
            cbxAulas.TabIndex = 5;
            // 
            // cbxAlunos
            // 
            cbxAlunos.AutoResize = false;
            cbxAlunos.BackColor = Color.FromArgb(255, 255, 255);
            cbxAlunos.Depth = 0;
            cbxAlunos.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAlunos.DropDownHeight = 174;
            cbxAlunos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAlunos.DropDownWidth = 121;
            cbxAlunos.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAlunos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAlunos.FormattingEnabled = true;
            cbxAlunos.Hint = "Aluno";
            cbxAlunos.IntegralHeight = false;
            cbxAlunos.ItemHeight = 43;
            cbxAlunos.Location = new Point(31, 173);
            cbxAlunos.MaxDropDownItems = 4;
            cbxAlunos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxAlunos.Name = "cbxAlunos";
            cbxAlunos.Size = new Size(704, 49);
            cbxAlunos.StartIndex = 0;
            cbxAlunos.TabIndex = 6;
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
            txtId.Location = new Point(31, 29);
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
            txtId.Size = new Size(67, 48);
            txtId.TabIndex = 7;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroReservas";
            Text = "CadastroReservas";
            TabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtHoraReserva;
        private ReaLTaiizor.Controls.MaterialComboBox cbxAlunos;
        private ReaLTaiizor.Controls.MaterialComboBox cbxAulas;
        private ReaLTaiizor.Controls.MaterialRadioButton btnAtivo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}