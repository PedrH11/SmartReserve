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
    public partial class CadastroAulas : CadastroBase
    {
        private readonly IBaseService<Aulas> _aulasService;
        private readonly IBaseService<Instrutores> _instrutoresService;
        private readonly IBaseService<CategoriaAula> _categoriaAulaService;

        private List<AulasModel>? _aulas;
        public CadastroAulas(IBaseService<Aulas> aulasService,
                             IBaseService<Instrutores> instrutoresService,
                             IBaseService<CategoriaAula> categoriaAulaService)
        {
            _aulasService = aulasService;
            _instrutoresService = instrutoresService;
            _categoriaAulaService = categoriaAulaService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cbxCategoriaAula.ValueMember = "Id";
            cbxCategoriaAula.DisplayMember = "nome";
            cbxCategoriaAula.DataSource = _categoriaAulaService.Get<CategoriaAula>().ToList();

            cbxInstrutores.ValueMember = "Id";
            cbxInstrutores.DisplayMember = "nome";
            cbxInstrutores.DataSource= _instrutoresService.Get<Instrutores>().ToList();
        }

        private void PreencheObjeto(Aulas aulas)
        {
            aulas.Descricao = txtDescricao.Text;
            if (int.TryParse(txtCapacidade.Text, out var capacidade)) 
            {
                aulas.Capacidade = capacidade;
            };

            if(DateTime.TryParse(txtHorario.Text, out var horario))
            {
                aulas.Horario = horario;
            }

            aulas.StatusAula = btnAtivo.Checked;

            if(int.TryParse(cbxInstrutores.SelectedValue.ToString(), out var idinstrutores))
            {
                var instrutores = _instrutoresService.GetById<Instrutores>(idinstrutores);
                aulas.Instrutores = instrutores;
            }

            if (int.TryParse(cbxCategoriaAula.SelectedValue.ToString(), out var idCategoriaAula))
            {
                var categoriaAula = _categoriaAulaService.GetById<CategoriaAula>(idCategoriaAula);
                aulas.CategoriaAula = categoriaAula;
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var aulas = _aulasService.GetById<Aulas>(id);
                        PreencheObjeto(aulas);
                        aulas = _aulasService.Update<Aulas, Aulas, AulasValidator>(aulas);
                    }
                }
                else
                {
                    var aulas = new Aulas();
                    PreencheObjeto(aulas);
                    _aulasService.Add<Aulas, Aulas, AulasValidator>(aulas);
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
                _aulasService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SmartReserve", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            var includes = new List<string>() { "Instrutores", "CategoriaAula" };
            _aulas = _aulasService.Get<AulasModel>(includes).ToList();

            foreach (var aula in _aulas)
            {
                if (aula.horario < DateTime.Now)
                { 
                    _aulasService.Delete(aula.Id);
                }
            }

            _aulas = _aulasService.Get<AulasModel>(includes).ToList();
            dgvConsulta.DataSource = _aulas;
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text= linha?.Cells["Id"].Value.ToString();
            txtDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
            txtCapacidade.Text = linha?.Cells["Capacidade"].Value.ToString();
            txtHorario.Text = DateTime.TryParse(linha?.Cells["Horario"].Value.ToString(), out var horario)
               ? horario.ToString("g")
               : "";
            btnAtivo.Checked = (bool)(linha?.Cells["StatusAula"].Value ?? false);
            cbxCategoriaAula.SelectedValue = linha?.Cells["IdCategoriaAula"].Value;
            cbxInstrutores.SelectedValue = linha?.Cells["IdInstrutores"].Value;

        }
    }
}
