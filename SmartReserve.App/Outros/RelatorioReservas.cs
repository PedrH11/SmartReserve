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
    public partial class RelatorioReservas : MaterialForm
    {
        private readonly IBaseService<Reservas> _reservasService;
        public RelatorioReservas(IBaseService<Reservas> reservaService)
        {
            _reservasService = reservaService;
            InitializeComponent();
            CarregaReservas();
        }

        private void CarregaReservas()
        {
            
            var reservas = _reservasService.Get<Reservas>(new List<string>() { "Aulas", "Aulas.Instrutores", "Alunos" })
                                           .OrderByDescending(x => x.Id);

            foreach (var reserva in reservas)
            {
                ListaReservasEfet even = new ListaReservasEfet();
                even.labelNomeAula.Text = reserva.Aulas.Descricao;
                even.labelDataHorario.Text = reserva.Aulas.Horario.ToString("dd/MM/yyyy HH:mm:ss");
                even.labelAlunos.Text = reserva.Alunos.Nome;
                even.labelInstrutor.Text = reserva.Aulas.Instrutores.nome;
                even.labelId.Text = reserva.Id.ToString();
                if (reserva.StatusReserva)
                {
                    even.labelStatusReserva.Text = "Confirmado";
                }
                else
                {
                    even.labelStatusReserva.Text = "Cancelado";
                }

                flowLayoutReservas.Controls.Add(even);
            }
        }

    }
}
