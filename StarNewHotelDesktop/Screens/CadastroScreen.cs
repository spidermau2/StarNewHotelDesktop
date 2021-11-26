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
    public partial class CadastroScreen : Form
    {
        readonly ClienteDAO clienteDAO = new ClienteDAO();
        readonly PagamentoDAO pagamentoDAO = new PagamentoDAO();
        readonly QuartoDAO quartoDAO = new QuartoDAO();
        readonly RefeicaoDAO refeicaoDAO = new RefeicaoDAO();
        readonly ReservaDAO reservaDAO = new ReservaDAO();
        TabSelected enumTab = TabSelected.Pessoa;

        public CadastroScreen()
        {
            InitializeComponent();
            UpdateGrid();
        }

        #region botões

        private void btCadastrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCpf.Text) || string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtRg.Text))
                return;

            string nome = txtNome.Text;
            int rg = int.Parse(txtRg.Text);
            long cpf = long.Parse(txtCpf.Text);

            ClienteModel cliente = new ClienteModel
            {
                Nome = nome,
                Rg = rg,
                Cpf = cpf
            };

            _ = clienteDAO.Post(cliente)
                ? MessageBox.Show("Cliente Cadastrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                : MessageBox.Show("Houve algum problema no cadastro do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Clear();
            UpdateGrid();
        }
        private void btnCadastrarPagamento_Click(object sender, EventArgs e)
        {
            string formaPagamento = txtPagamento.Text;
            if (string.IsNullOrEmpty(formaPagamento))
                return;
            FormaPagamentoModel pagamento = new FormaPagamentoModel()
            {
                Descricao = formaPagamento
            };
            pagamentoDAO.Post(pagamento);
            UpdateGrid();
            Clear();
        }
        private void btnCadastrarQuarto_Click(object sender, EventArgs e)
        {
            string quartoTipo = txtQuarto.Text;
            string valorQuarto = txtValorQuarto.Text;
            if (string.IsNullOrEmpty(quartoTipo) || !float.TryParse(valorQuarto, out float valorQuartoRes))
                return;
            QuartoModel quarto = new QuartoModel()
            {
                Descricao = quartoTipo,
                Valor = valorQuartoRes

            };
            quartoDAO.Post(quarto);
            UpdateGrid();
            Clear();
        }
        private void btnCadastrarRefeicao_Click(object sender, EventArgs e)
        {
            string nomeRefeicao = txtNomeRefeicao.Text;
            string valorRefeicao = txtValorRefeicao.Text;
            if (string.IsNullOrEmpty(nomeRefeicao) || string.IsNullOrEmpty(valorRefeicao) || !float.TryParse(valorRefeicao, out float valorRefeicaoRes))
                return;
            RefeicaoModel refeicao = new RefeicaoModel()
            {
                Descricao = nomeRefeicao,
                Valor = valorRefeicaoRes
            };
            refeicaoDAO.Post(refeicao);
            UpdateGrid();
            Clear();
        }

        #endregion

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    enumTab = TabSelected.Pessoa;
                    break;
                case 1:
                    enumTab = TabSelected.Pagamento;
                    break;
                case 2:
                    enumTab = TabSelected.Quarto;
                    break;
                case 3:
                    enumTab = TabSelected.Refeicao;
                    break;
                case 4:
                    enumTab = TabSelected.Reserva;
                    break;
            }
            UpdateGrid();
        }
        private void btnCadastrarReserva_Click(object sender, EventArgs e)
        {
            var cliente = int.Parse(cbxCliente.SelectedValue.ToString());
            var pagamento = int.Parse(cbxPagamento.SelectedValue.ToString());
            var quarto = int.Parse(cbxQuarto.SelectedValue.ToString());
            var refeicao = int.Parse(cbxRefeicao.SelectedValue.ToString());
            var horaEntrada = txtHoraEntradaReserva.Text;
            var horaSaida = txtHoraSaidaReserva.Text;
            var quantidade = txtQuantidadeReserva.Text;

            if (string.IsNullOrEmpty(horaEntrada) || string.IsNullOrEmpty(horaSaida) ||
                !int.TryParse(quantidade, out int quantidadeRes) || !TimeSpan.TryParse(horaEntrada, out TimeSpan horaEntradaTime) || !TimeSpan.TryParse(horaSaida, out TimeSpan horaSaidaTime))
                return;

            ReservaModel reserva = new ReservaModel()
            {
                HoraEntrada = horaEntradaTime.ToString(),
                HoraSaida = horaSaidaTime.ToString(),
                IdCliente = cliente,
                IdPagamento = pagamento,
                IdQuarto = quarto,
                IdRefeicao = refeicao,
                QuantidadeReserva = quantidadeRes,
                Pago = "N"
            };
            if (reservaDAO.Post(reserva))
            {
                UpdateGrid();
                Clear();
            }
        }

        #region utils
        private void Clear()
        {
            txtNome.Text = string.Empty;
            txtRg.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtPagamento.Text = string.Empty;
            txtNomeRefeicao.Text = string.Empty;
            txtValorRefeicao.Text = string.Empty;
            txtHoraSaidaReserva.Text = string.Empty;
            txtHoraEntradaReserva.Text = string.Empty;
            txtQuantidadeReserva.Text = string.Empty;
            txtQuarto.Text = string.Empty;
            txtValorQuarto.Text = string.Empty;
            try
            {
                cbxCliente.SelectedIndex = 0;
                cbxPagamento.SelectedIndex = 0;
                cbxQuarto.SelectedIndex = 0;
                cbxRefeicao.SelectedIndex = 0;
            }
            catch (Exception) { }

        }

        private void UpdateGrid()
        {
            switch (enumTab)
            {
                case TabSelected.Pessoa:
                    dgvPessoas.DataSource = clienteDAO.Get();
                    dgvPessoas.Refresh();
                    break;
                case TabSelected.Pagamento:
                    dgvPagamento.DataSource = pagamentoDAO.Get();
                    dgvPagamento.Refresh();
                    break;
                case TabSelected.Quarto:
                    dgvQuarto.DataSource = quartoDAO.Get();
                    dgvQuarto.Refresh();
                    break;
                case TabSelected.Refeicao:
                    dgvRefeicao.DataSource = refeicaoDAO.Get();
                    dgvRefeicao.Refresh();
                    break;
                case TabSelected.Reserva:

                    #region combobox
                    cbxCliente.DataSource = clienteDAO.Get();
                    cbxPagamento.DataSource = pagamentoDAO.Get();
                    cbxQuarto.DataSource = quartoDAO.Get();
                    cbxRefeicao.DataSource = refeicaoDAO.Get();

                    cbxCliente.ValueMember = "IdCliente";
                    cbxCliente.DisplayMember = "Nome";

                    cbxPagamento.ValueMember = "IdFormaPagamento";
                    cbxPagamento.DisplayMember = "Descricao";

                    cbxQuarto.ValueMember = "IdQuarto";
                    cbxQuarto.DisplayMember = "Descricao";

                    cbxRefeicao.ValueMember = "IdRefeicao";
                    cbxRefeicao.DisplayMember = "Descricao";

                    #endregion

                    dgvReserva.DataSource = reservaDAO.Get();
                    dgvReserva.Refresh();
                    break;
            }
        }

        enum TabSelected
        {
            Pessoa,
            Pagamento,
            Quarto,
            Refeicao,
            Reserva
        }
        #endregion
    }
}
