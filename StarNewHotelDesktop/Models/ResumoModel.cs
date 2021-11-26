using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarNewHotelDesktop.Models
{
    public class ResumoModel
    {
        public int Reserva { get; set; }
        public string Entrada { get; set; }
        public string Saida { get; set; }
        public string Cliente { get; set; }
        public string Quarto { get; set; }
        public string Refeicao { get; set; }
        public float ValorQuarto { get; set; }
        public float ValorRefeicao { get; set; }
        public string Pago { get; set; }
        public int Quantidade { get; set; }

    }
}
