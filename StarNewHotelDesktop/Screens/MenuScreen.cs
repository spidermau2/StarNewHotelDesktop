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
    public partial class MenuScreen : Form
    {
        readonly RefeicaoDAO refeicaoDAO = new RefeicaoDAO();
        public MenuScreen()
        {
            InitializeComponent();
            dgvMenu.DataSource = refeicaoDAO.Get();
        }
    }
}
