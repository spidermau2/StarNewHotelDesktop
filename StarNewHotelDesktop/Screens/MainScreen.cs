using StarNewHotelDesktop.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarNewHotelDesktop
{
    public partial class MainScreen : Form
    {
        private CadastroScreen cadastroForm;
        private ReservaScreen reservaForm;
        private QuartosOcupadosScreen quartosOcupadosForm;
        private MenuScreen menuForm;
        private CaixaScreen caixaScreen;
        public MainScreen()
        {
            InitializeComponent();
            btCadastros.BackColor = Color.FromArgb(0, 255, 255, 255);
            btCadastros.Parent = pictureBox1;
            btReservas.Parent = pictureBox1;
            btMenu.Parent = pictureBox1;
            btFinanceiro.Parent = pictureBox1;
            btQuartosOcupados.Parent = pictureBox1;

        }

        private void btCadastros_Click(object sender, EventArgs e)
        {
            cadastroForm = new CadastroScreen();
            cadastroForm.Show();
        }

        private void btReservas_Click(object sender, EventArgs e)
        {
            reservaForm = new ReservaScreen();
            reservaForm.Show();
        }

        private void btQuartosOcupados_Click(object sender, EventArgs e)
        {
            quartosOcupadosForm = new QuartosOcupadosScreen();
            quartosOcupadosForm.Show();
        }

        private void btInventario_Click(object sender, EventArgs e)
        {
            menuForm = new MenuScreen();
            menuForm.Show();
        }

        private void btFinanceiro_Click(object sender, EventArgs e)
        {
            caixaScreen = new CaixaScreen();
            caixaScreen.Show();
        }
    }
}
