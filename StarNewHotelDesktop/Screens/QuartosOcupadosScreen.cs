using StarNewHotelDesktop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarNewHotelDesktop.Screens
{
    public partial class QuartosOcupadosScreen : Form
    {
        readonly QuartoDAO quartoDAO = new QuartoDAO();
        readonly ReservaDAO reservaDAO = new ReservaDAO();
        public QuartosOcupadosScreen()
        {
            InitializeComponent();
            var reservas = reservaDAO.Get();
            var quartos = quartoDAO.GetOcupados();
            dgvQuarto.DataSource = quartoDAO.GetOcupados();
        }
    }
}
