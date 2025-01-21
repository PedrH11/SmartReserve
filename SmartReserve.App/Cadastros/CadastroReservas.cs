using SmartReserve.App.Base;
using SmartReserve.App.Models;
using SmartReserve.Domain.Base;
using SmartReserve.Domain.Entities;
using SmartReserve.Services.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SmartReserve.App.Cadastros
{
    public partial class CadastroReservas : CadastroBase
    {
        private readonly IBaseService<Reservas> _reservasService;
        private readonly IBaseService<Alunos> _alunosService;
        private readonly IBaseService<Aulas> _aulasService;

        private List<ReservasModel>? _reservas;

        public CadastroReservas(IBaseService<Reservas> reservasService,
                                IBaseService<Alunos> alunosService,
                                IBaseService<Aulas> aulasService)
        {
            _reservasService = reservasService;
            _aulasService = aulasService;
            _alunosService = alunosService;
            InitializeComponent();
            CarregarCombo();
            RemoverReservasDeAulasInativas();
        }

        private void CarregarCombo()
        {
            cbxAulas.ValueMember = "Id";
            cbxAulas.DisplayMember = "Descricao";
            cbxAulas.DataSource = _aulasService.Get<Aulas>().ToList();

            cbxAlunos.ValueMember = "Id";
            cbxAlunos.DisplayMember = "Nome";
            cbxAlunos.DataSource = _alunosService.Get<Alunos>().ToList();
        }

        private void PreencheObjeto(Reservas reservas)
        {
            reservas.HoraReserva = DateTime.Now;

            if (int.TryParse(cbxAlunos.SelectedValue.ToString(), out var idAlunos))
            {
                var alunos = _alunosService.GetById<Alunos>(idAlunos);
                reservas.Alunos = alunos;
            }

            if (int.TryParse(cbxAulas.SelectedValue.ToString(), out var idAulas))
            {
                var aulas = _aulasService.GetById<Aulas>(idAulas);
                reservas.Aulas = aulas;
            }
            reservas.StatusReserva = btnAtivo.Checked;
        }

        private bool ValidarAula(Reservas reservas)
        {
            if (int.TryParse(cbxAulas.SelectedValue.ToString(), out var idAulas))
            {
                var aula = _aulasService.GetById<Aulas>(idAulas);
                if (aula == null)
                {
                    MessageBox.Show("A aula selecionada não foi encontrada.", @"SmartReserve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!aula.StatusAula)
                {
                    MessageBox.Show($"A aula \"{aula.Descricao}\" está desativada e não pode receber reservas.",
                                    @"SmartReserve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!isAlteracao)
                {
                    var reservasExistentes = _reservasService
                        .Get<Reservas>()
                        .Count(r => r.Aulas.Id == idAulas && r.StatusReserva);

                    if (reservasExistentes >= aula.Capacidade)
                    {
                        MessageBox.Show($"A capacidade da aula \"{aula.Descricao}\" foi atingida ({aula.Capacidade} alunos).",
                                        @"SmartReserve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    if (aula.Horario < DateTime.Now)
                    {
                        MessageBox.Show($"O horário da aula \"{aula.Descricao}\" já passou. Não é possível realizar mais reservas.",
                                        @"SmartReserve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        private bool ValidarAluno()
        {
            if (int.TryParse(cbxAlunos.SelectedValue.ToString(), out var idAlunos))
            {
                var aluno = _alunosService.GetById<Alunos>(idAlunos);
                if (aluno == null)
                {
                    MessageBox.Show("O aluno selecionado não foi encontrado.", @"SmartReserve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!aluno.StatusAluno)
                {
                    MessageBox.Show($"O aluno \"{aluno.Nome}\" está inativo e não pode ser associado à reserva.",
                                    @"SmartReserve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!isAlteracao)
                {
                    if (int.TryParse(cbxAulas.SelectedValue.ToString(), out var idAulas))
                    {
                        var reservaExistente = _reservasService.Get<Reservas>()
                            .Any(r => r.Aulas.Id == idAulas && r.Alunos.Id == idAlunos);

                        if (reservaExistente)
                        {
                            MessageBox.Show($"O aluno \"{aluno.Nome}\" já fez uma reserva para a aula \"{_aulasService.GetById<Aulas>(idAulas)?.Descricao}\".",
                                            @"SmartReserve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            return true;
        }


        protected override void Salvar()
        {
            try
            {
                if (!ValidarAula(new Reservas()) || !ValidarAluno()) return;

                if (isAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var reservas = _reservasService.GetById<Reservas>(id);
                        PreencheObjeto(reservas);
                        _reservasService.Update<Reservas, Reservas, ReservasValidator>(reservas);
                    }
                }
                else
                {
                    var reservas = new Reservas();
                    PreencheObjeto(reservas);
                    _reservasService.Add<Reservas, Reservas, ReservasValidator>(reservas);
                }

                TabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SmartReserve", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _reservasService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SmartReserve", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            var includes = new List<string>() { "Aulas", "Alunos" };
            _reservas = _reservasService.Get<ReservasModel>(includes).ToList();
            dgvConsulta.DataSource = _reservas;
            dgvConsulta.Columns["idAulas"]!.Visible = false;
            dgvConsulta.Columns["idAlunos"]!.Visible = false;
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtHoraReserva.Text = DateTime.TryParse(linha?.Cells["HoraReserva"].Value.ToString(), out var horaReserva)
               ? horaReserva.ToString("g")
               : DateTime.Now.ToString("g");
            btnAtivo.Checked = (bool)(linha?.Cells["StatusReserva"].Value ?? false);
            cbxAulas.SelectedValue = linha?.Cells["IdAulas"].Value;
            cbxAlunos.SelectedValue = linha?.Cells["IdAlunos"].Value;
        }

        private void RemoverReservasDeAulasInativas() //reservas com alunos inativos também
        {
            var reservas = _reservasService.Get<Reservas>(new List<string> { "Aulas", "Alunos" }).ToList();

            foreach (var reserva in reservas)
            {
                bool aulaInativa = reserva.Aulas != null && !reserva.Aulas.StatusAula;
                bool alunoInativo = reserva.Alunos != null && !reserva.Alunos.StatusAluno;

                if (aulaInativa || alunoInativo)
                {
                    _reservasService.Delete(reserva.Id);
                }
            }
        }
    }
}
