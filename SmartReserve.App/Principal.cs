using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using SmartReserve.App.Cadastros;
using SmartReserve.App.Infra;
using SmartReserve.App.Outros;

namespace SmartReserve.App
{
    public partial class Principal : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Principal()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new MaterialColorScheme(
                MaterialPrimary.Red500,   
                MaterialPrimary.Red700,   
                MaterialPrimary.Red200,   
                MaterialAccent.Red100,    
                MaterialTextShade.LIGHT   
            );
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroAlunos>();
        }

        private void instrutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroInstrutores>();
        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroAulas>();
        }

        private void categoriaDeAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCategoriaAula>();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroReservas>();
        }

        private void reservasEfetuadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<RelatorioReservas>();
        }

        private void aulasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExibeFormulario<RelatorioAulasDisp>();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServiceProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
