using StarNewHotelDesktop.DAO;
using StarNewHotelDesktop.Models;
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
    public partial class CaixaScreen : Form
    {
        readonly ResumoDAO resumoDAO = new ResumoDAO();
        readonly ReservaDAO reservaDAO = new ReservaDAO();
        List<ResumoModel> resumo = new List<ResumoModel>();
        List<ReservaModel> reservas = new List<ReservaModel>();
        string selectedId = "";
        public CaixaScreen()
        {
            InitializeComponent();
            UpdateData();
        }

        private void btnPagarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                ReservaModel reserva = reservas.FirstOrDefault(r => r.IdReserva == int.Parse(selectedId));
                reserva.Pago = "S";
                reservaDAO.Put(reserva);
                UpdateData();
            }
            catch (Exception) { }
        }

        private void UpdateData()
        {
            resumo = resumoDAO.Get();
            reservas = reservaDAO.Get();
            dgvCaixa.DataSource = resumo.Where(r => r.Pago == "N").ToList();
            txtValor.Text = "R$0";
            txtID.Text = "";
        }

        private void dgvCaixa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = dgvCaixa.Rows[e.RowIndex].Cells["Reserva"].Value.ToString();
            int quantidade = int.Parse(dgvCaixa.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString());
            float valorQuarto = int.Parse(dgvCaixa.Rows[e.RowIndex].Cells["ValorQuarto"].Value.ToString());
            float valorRefeicao = int.Parse(dgvCaixa.Rows[e.RowIndex].Cells["ValorRefeicao"].Value.ToString());

            float total = quantidade * valorQuarto + quantidade * valorRefeicao;

            txtValor.Text = $"R${total}";
            txtID.Text = selectedId;
        }
    }
}
