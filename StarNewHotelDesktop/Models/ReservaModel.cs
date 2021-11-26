using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarNewHotelDesktop.Models
{
    class ReservaModel
    {
        public int IdReserva { get; set; }
        public int QuantidadeReserva { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSaida { get; set; }
        public int IdCliente { get; set; }
        public int IdPagamento { get; set; }
        public int IdQuarto { get; set; }
        public int IdRefeicao { get; set; }
        public string Pago { get; set; }
    }
}
