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
    public partial class CadastroInstrutores : CadastroBase
    {
        private IBaseService<Instrutores> _instrutoresService;
        private List<Instrutores>? Instrutores;
        public CadastroInstrutores(IBaseService<Instrutores> instrutoresService)
        {
            _instrutoresService = instrutoresService;
            InitializeComponent();
        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void PreencheObjeto(Instrutores instrutores)
        {
            instrutores.nome = txtNome.Text;
            instrutores.especialidade = txtEspecialidade.Text;
            instrutores.CPF = txtCPF.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var instrutores = _instrutoresService.GetById<Instrutores>(id);
                        PreencheObjeto(instrutores);
                        instrutores = _instrutoresService.Update<Instrutores, Instrutores, InstrutoresValidator>(instrutores);
                    }
                }
                else
                {
                    var instrutores = new Instrutores();
                    PreencheObjeto(instrutores);
                    _instrutoresService.Add<Instrutores, Instrutores, InstrutoresValidator>(instrutores);
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
                _instrutoresService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SmartReserve", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            Instrutores = _instrutoresService.Get<Instrutores>().ToList();
            dgvConsulta.DataSource = Instrutores;
            dgvConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEspecialidade.Text = linha?.Cells["Especialidade"].Value.ToString();
            txtCPF.Text = linha?.Cells["CPF"].Value.ToString();
        }
    }
}
