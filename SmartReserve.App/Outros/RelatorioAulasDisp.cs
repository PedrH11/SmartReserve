        using ReaLTaiizor.Forms;
        using SmartReserve.Domain.Base;
        using SmartReserve.Domain.Entities;
        using System;
        using System.Collections.Generic;
        using System.ComponentModel;
        using System.Data;
        using System.Drawing;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;
        using System.Windows.Forms;

        namespace SmartReserve.App.Outros
        {
            public partial class RelatorioAulasDisp : MaterialForm
            {
                private readonly IBaseService<Aulas> _aulasService;
                public RelatorioAulasDisp(IBaseService<Aulas> aulasService)
                {
                    _aulasService = aulasService;        
                    InitializeComponent();
                    CarregaAulas();
                }

                private void CarregaAulas()
                {
                    var aulas = _aulasService.Get<Aulas>(new List<string>() { "Instrutores" })
                                                   .OrderByDescending(x => x.Id);

                    foreach (var aula in aulas)
                    {
                        ListaAulasDisp even = new ListaAulasDisp();
                        even.labelId.Text = aula.Id.ToString();
                        even.labelAula.Text = aula.Descricao;
                        even.labelCapacidade.Text = aula.Capacidade.ToString();
                        even.labelInstrutores.Text = aula.Instrutores.nome.ToString();
                        even.labelHorario.Text = aula.Horario.ToString("dd/MM/yyyy HH:mm:ss");

                       if (aula.StatusAula)
                       {
                           flowLayoutPanelAulasDisp.Controls.Add(even);
                       }
                    }               
                }
            }
        }
