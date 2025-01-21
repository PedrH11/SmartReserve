using SmartReserve.App.Base;
using SmartReserve.App.Models;
using SmartReserve.Domain.Base;
using SmartReserve.Domain.Entities;
using SmartReserve.Services.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartReserve.App.Cadastros
{
    public partial class CadastroAlunos : CadastroBase
    {
        private readonly IBaseService<Alunos> _alunosService;
        private List<Alunos>? alunos;
        public CadastroAlunos(IBaseService<Alunos> alunosService)
        {
            _alunosService = alunosService;
            InitializeComponent();
        }

        private void PreencheObjeto(Alunos alunos)
        {
            alunos.Nome = txtNome.Text;
            if (DateOnly.TryParse(txtDataNasc.Text, out var dataNasc))
            {
                alunos.Datanasc = dataNasc;
            }
            alunos.Telefone = txtTelefone.Text;
            alunos.CPF = txtCPF.Text;
            alunos.StatusAluno = btnAtivo.Checked;
        }

        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var alunos = _alunosService.GetById<Alunos>(id);
                        PreencheObjeto(alunos);
                        alunos = _alunosService.Update<Alunos, Alunos, AlunosValidator>(alunos);
                    }
                }
                else
                {
                    var alunos = new Alunos();
                    PreencheObjeto(alunos);
                    _alunosService.Add<Alunos, Alunos, AlunosValidator>(alunos);
                }
                TabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SmarReserve", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _alunosService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SmartReserve", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            alunos = _alunosService.Get<Alunos>().ToList();
            dgvConsulta.DataSource = alunos;
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtDataNasc.Text = DateTime.TryParse(linha?.Cells["Datanasc"].Value?.ToString(), out var dataNasc)
                ? dataNasc.ToString("g") // Use "dd/MM/yyyy HH:mm" para incluir horário
        :        "";
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtCPF.Text = linha?.Cells["CPF"].Value.ToString();
            btnAtivo.Checked = (bool)(linha?.Cells["StatusAluno"].Value ?? false);
        }
    }
}
