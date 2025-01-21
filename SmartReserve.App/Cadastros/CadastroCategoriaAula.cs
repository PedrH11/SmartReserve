using ReaLTaiizor.Forms;
using SmartReserve.App.Base;
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
    public partial class CadastroCategoriaAula : SmartReserve.App.Base.CadastroBase
    {
        private IBaseService<CategoriaAula> _categoriaAulaService;
        private List<CategoriaAula>? categoriaAulas;
        public CadastroCategoriaAula(IBaseService<CategoriaAula> categoriaAulaService)
        {
            _categoriaAulaService = categoriaAulaService;
            InitializeComponent();
        }

        private void PreencherObjeto(CategoriaAula categoriaula)
        {
            categoriaula.nome = txtNome.Text;
        }

        private void materialTextBoxEdit2_Click(object sender, EventArgs e)
        {

        }

        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var categoriaAula = _categoriaAulaService.GetById<CategoriaAula>(id);
                        PreencherObjeto(categoriaAula);
                        categoriaAula = _categoriaAulaService.Update<CategoriaAula, CategoriaAula, CategoriaAulaValidator>(categoriaAula);
                    }
                }
                else
                {
                    var categoriaAula = new CategoriaAula();
                    PreencherObjeto(categoriaAula);
                    _categoriaAulaService.Add<CategoriaAula, CategoriaAula, CategoriaAulaValidator>(categoriaAula);
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
                _categoriaAulaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SmartReserve", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            categoriaAulas = _categoriaAulaService.Get<CategoriaAula>().ToList();
            dgvConsulta.DataSource = categoriaAulas;
            dgvConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
        }
    }
}
