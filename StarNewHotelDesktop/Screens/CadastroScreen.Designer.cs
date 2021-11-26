
namespace StarNewHotelDesktop.Screens
{
    partial class CadastroScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPessoa = new System.Windows.Forms.TabPage();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.tabFormaPagamento = new System.Windows.Forms.TabPage();
            this.dgvPagamento = new System.Windows.Forms.DataGridView();
            this.btnCadastrarPagamento = new System.Windows.Forms.Button();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabQuarto = new System.Windows.Forms.TabPage();
            this.txtValorQuarto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvQuarto = new System.Windows.Forms.DataGridView();
            this.btnCadastrarQuarto = new System.Windows.Forms.Button();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabRefeicao = new System.Windows.Forms.TabPage();
            this.btnCadastrarRefeicao = new System.Windows.Forms.Button();
            this.txtValorRefeicao = new System.Windows.Forms.TextBox();
            this.txtNomeRefeicao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvRefeicao = new System.Windows.Forms.DataGridView();
            this.tabReserva = new System.Windows.Forms.TabPage();
            this.cbxRefeicao = new System.Windows.Forms.ComboBox();
            this.cbxQuarto = new System.Windows.Forms.ComboBox();
            this.cbxPagamento = new System.Windows.Forms.ComboBox();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.btnCadastrarReserva = new System.Windows.Forms.Button();
            this.txtQuantidadeReserva = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHoraSaidaReserva = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHoraEntradaReserva = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPessoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            this.tabFormaPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).BeginInit();
            this.tabQuarto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).BeginInit();
            this.tabRefeicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefeicao)).BeginInit();
            this.tabReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPessoa);
            this.tabControl.Controls.Add(this.tabFormaPagamento);
            this.tabControl.Controls.Add(this.tabQuarto);
            this.tabControl.Controls.Add(this.tabRefeicao);
            this.tabControl.Controls.Add(this.tabReserva);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(680, 594);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPessoa
            // 
            this.tabPessoa.Controls.Add(this.btCadastrar);
            this.tabPessoa.Controls.Add(this.txtCpf);
            this.tabPessoa.Controls.Add(this.txtRg);
            this.tabPessoa.Controls.Add(this.txtNome);
            this.tabPessoa.Controls.Add(this.label3);
            this.tabPessoa.Controls.Add(this.label2);
            this.tabPessoa.Controls.Add(this.label1);
            this.tabPessoa.Controls.Add(this.dgvPessoas);
            this.tabPessoa.Location = new System.Drawing.Point(4, 25);
            this.tabPessoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPessoa.Name = "tabPessoa";
            this.tabPessoa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPessoa.Size = new System.Drawing.Size(672, 565);
            this.tabPessoa.TabIndex = 0;
            this.tabPessoa.Text = "Pessoa";
            this.tabPessoa.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.LightGreen;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastrar.Location = new System.Drawing.Point(365, 126);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(101, 32);
            this.btCadastrar.TabIndex = 15;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click_1);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(87, 98);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(380, 22);
            this.txtCpf.TabIndex = 14;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(87, 62);
            this.txtRg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(380, 22);
            this.txtRg.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 20);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(380, 22);
            this.txtNome.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "RG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.AllowUserToAddRows = false;
            this.dgvPessoas.AllowUserToDeleteRows = false;
            this.dgvPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPessoas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Location = new System.Drawing.Point(25, 164);
            this.dgvPessoas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.ReadOnly = true;
            this.dgvPessoas.RowHeadersVisible = false;
            this.dgvPessoas.RowHeadersWidth = 51;
            this.dgvPessoas.RowTemplate.Height = 24;
            this.dgvPessoas.Size = new System.Drawing.Size(629, 396);
            this.dgvPessoas.TabIndex = 8;
            // 
            // tabFormaPagamento
            // 
            this.tabFormaPagamento.Controls.Add(this.dgvPagamento);
            this.tabFormaPagamento.Controls.Add(this.btnCadastrarPagamento);
            this.tabFormaPagamento.Controls.Add(this.txtPagamento);
            this.tabFormaPagamento.Controls.Add(this.label4);
            this.tabFormaPagamento.Location = new System.Drawing.Point(4, 25);
            this.tabFormaPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFormaPagamento.Name = "tabFormaPagamento";
            this.tabFormaPagamento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFormaPagamento.Size = new System.Drawing.Size(672, 565);
            this.tabFormaPagamento.TabIndex = 1;
            this.tabFormaPagamento.Text = "Pagamento";
            this.tabFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // dgvPagamento
            // 
            this.dgvPagamento.AllowUserToAddRows = false;
            this.dgvPagamento.AllowUserToDeleteRows = false;
            this.dgvPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagamento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamento.Location = new System.Drawing.Point(23, 86);
            this.dgvPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPagamento.Name = "dgvPagamento";
            this.dgvPagamento.ReadOnly = true;
            this.dgvPagamento.RowHeadersVisible = false;
            this.dgvPagamento.RowHeadersWidth = 51;
            this.dgvPagamento.RowTemplate.Height = 24;
            this.dgvPagamento.Size = new System.Drawing.Size(632, 474);
            this.dgvPagamento.TabIndex = 17;
            // 
            // btnCadastrarPagamento
            // 
            this.btnCadastrarPagamento.BackColor = System.Drawing.Color.LightGreen;
            this.btnCadastrarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarPagamento.Location = new System.Drawing.Point(368, 48);
            this.btnCadastrarPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrarPagamento.Name = "btnCadastrarPagamento";
            this.btnCadastrarPagamento.Size = new System.Drawing.Size(101, 32);
            this.btnCadastrarPagamento.TabIndex = 16;
            this.btnCadastrarPagamento.Text = "Cadastrar";
            this.btnCadastrarPagamento.UseVisualStyleBackColor = false;
            this.btnCadastrarPagamento.Click += new System.EventHandler(this.btnCadastrarPagamento_Click);
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(171, 20);
            this.txtPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(299, 22);
            this.txtPagamento.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Forma de Pagamento";
            // 
            // tabQuarto
            // 
            this.tabQuarto.Controls.Add(this.txtValorQuarto);
            this.tabQuarto.Controls.Add(this.label15);
            this.tabQuarto.Controls.Add(this.dgvQuarto);
            this.tabQuarto.Controls.Add(this.btnCadastrarQuarto);
            this.tabQuarto.Controls.Add(this.txtQuarto);
            this.tabQuarto.Controls.Add(this.label5);
            this.tabQuarto.Location = new System.Drawing.Point(4, 25);
            this.tabQuarto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabQuarto.Name = "tabQuarto";
            this.tabQuarto.Size = new System.Drawing.Size(672, 565);
            this.tabQuarto.TabIndex = 2;
            this.tabQuarto.Text = "Quarto";
            this.tabQuarto.UseVisualStyleBackColor = true;
            // 
            // txtValorQuarto
            // 
            this.txtValorQuarto.Location = new System.Drawing.Point(128, 43);
            this.txtValorQuarto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorQuarto.Name = "txtValorQuarto";
            this.txtValorQuarto.Size = new System.Drawing.Size(325, 22);
            this.txtValorQuarto.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Valor  ";
            // 
            // dgvQuarto
            // 
            this.dgvQuarto.AllowUserToAddRows = false;
            this.dgvQuarto.AllowUserToDeleteRows = false;
            this.dgvQuarto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuarto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuarto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuarto.Location = new System.Drawing.Point(21, 118);
            this.dgvQuarto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQuarto.Name = "dgvQuarto";
            this.dgvQuarto.ReadOnly = true;
            this.dgvQuarto.RowHeadersVisible = false;
            this.dgvQuarto.RowHeadersWidth = 51;
            this.dgvQuarto.RowTemplate.Height = 24;
            this.dgvQuarto.Size = new System.Drawing.Size(631, 436);
            this.dgvQuarto.TabIndex = 21;
            // 
            // btnCadastrarQuarto
            // 
            this.btnCadastrarQuarto.BackColor = System.Drawing.Color.LightGreen;
            this.btnCadastrarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarQuarto.Location = new System.Drawing.Point(353, 81);
            this.btnCadastrarQuarto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrarQuarto.Name = "btnCadastrarQuarto";
            this.btnCadastrarQuarto.Size = new System.Drawing.Size(101, 32);
            this.btnCadastrarQuarto.TabIndex = 20;
            this.btnCadastrarQuarto.Text = "Cadastrar";
            this.btnCadastrarQuarto.UseVisualStyleBackColor = false;
            this.btnCadastrarQuarto.Click += new System.EventHandler(this.btnCadastrarQuarto_Click);
            // 
            // txtQuarto
            // 
            this.txtQuarto.Location = new System.Drawing.Point(128, 14);
            this.txtQuarto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(325, 22);
            this.txtQuarto.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tipo de Quarto";
            // 
            // tabRefeicao
            // 
            this.tabRefeicao.Controls.Add(this.btnCadastrarRefeicao);
            this.tabRefeicao.Controls.Add(this.txtValorRefeicao);
            this.tabRefeicao.Controls.Add(this.txtNomeRefeicao);
            this.tabRefeicao.Controls.Add(this.label6);
            this.tabRefeicao.Controls.Add(this.label7);
            this.tabRefeicao.Controls.Add(this.dgvRefeicao);
            this.tabRefeicao.Location = new System.Drawing.Point(4, 25);
            this.tabRefeicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRefeicao.Name = "tabRefeicao";
            this.tabRefeicao.Size = new System.Drawing.Size(672, 565);
            this.tabRefeicao.TabIndex = 3;
            this.tabRefeicao.Text = "Refeicao";
            this.tabRefeicao.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarRefeicao
            // 
            this.btnCadastrarRefeicao.BackColor = System.Drawing.Color.LightGreen;
            this.btnCadastrarRefeicao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarRefeicao.Location = new System.Drawing.Point(363, 82);
            this.btnCadastrarRefeicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrarRefeicao.Name = "btnCadastrarRefeicao";
            this.btnCadastrarRefeicao.Size = new System.Drawing.Size(101, 32);
            this.btnCadastrarRefeicao.TabIndex = 21;
            this.btnCadastrarRefeicao.Text = "Cadastrar";
            this.btnCadastrarRefeicao.UseVisualStyleBackColor = false;
            this.btnCadastrarRefeicao.Click += new System.EventHandler(this.btnCadastrarRefeicao_Click);
            // 
            // txtValorRefeicao
            // 
            this.txtValorRefeicao.Location = new System.Drawing.Point(83, 54);
            this.txtValorRefeicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorRefeicao.Name = "txtValorRefeicao";
            this.txtValorRefeicao.Size = new System.Drawing.Size(380, 22);
            this.txtValorRefeicao.TabIndex = 20;
            // 
            // txtNomeRefeicao
            // 
            this.txtNomeRefeicao.Location = new System.Drawing.Point(83, 14);
            this.txtNomeRefeicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeRefeicao.Name = "txtNomeRefeicao";
            this.txtNomeRefeicao.Size = new System.Drawing.Size(380, 22);
            this.txtNomeRefeicao.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nome";
            // 
            // dgvRefeicao
            // 
            this.dgvRefeicao.AllowUserToAddRows = false;
            this.dgvRefeicao.AllowUserToDeleteRows = false;
            this.dgvRefeicao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRefeicao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRefeicao.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRefeicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefeicao.Location = new System.Drawing.Point(21, 121);
            this.dgvRefeicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRefeicao.Name = "dgvRefeicao";
            this.dgvRefeicao.ReadOnly = true;
            this.dgvRefeicao.RowHeadersVisible = false;
            this.dgvRefeicao.RowHeadersWidth = 51;
            this.dgvRefeicao.RowTemplate.Height = 24;
            this.dgvRefeicao.Size = new System.Drawing.Size(635, 433);
            this.dgvRefeicao.TabIndex = 16;
            // 
            // tabReserva
            // 
            this.tabReserva.Controls.Add(this.cbxRefeicao);
            this.tabReserva.Controls.Add(this.cbxQuarto);
            this.tabReserva.Controls.Add(this.cbxPagamento);
            this.tabReserva.Controls.Add(this.cbxCliente);
            this.tabReserva.Controls.Add(this.dgvReserva);
            this.tabReserva.Controls.Add(this.btnCadastrarReserva);
            this.tabReserva.Controls.Add(this.txtQuantidadeReserva);
            this.tabReserva.Controls.Add(this.label14);
            this.tabReserva.Controls.Add(this.label13);
            this.tabReserva.Controls.Add(this.txtHoraSaidaReserva);
            this.tabReserva.Controls.Add(this.label12);
            this.tabReserva.Controls.Add(this.txtHoraEntradaReserva);
            this.tabReserva.Controls.Add(this.label11);
            this.tabReserva.Controls.Add(this.label8);
            this.tabReserva.Controls.Add(this.label9);
            this.tabReserva.Controls.Add(this.label10);
            this.tabReserva.Location = new System.Drawing.Point(4, 25);
            this.tabReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabReserva.Name = "tabReserva";
            this.tabReserva.Size = new System.Drawing.Size(672, 565);
            this.tabReserva.TabIndex = 4;
            this.tabReserva.Text = "Reserva";
            this.tabReserva.UseVisualStyleBackColor = true;
            // 
            // cbxRefeicao
            // 
            this.cbxRefeicao.FormattingEnabled = true;
            this.cbxRefeicao.Location = new System.Drawing.Point(97, 112);
            this.cbxRefeicao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxRefeicao.Name = "cbxRefeicao";
            this.cbxRefeicao.Size = new System.Drawing.Size(373, 24);
            this.cbxRefeicao.TabIndex = 35;
            // 
            // cbxQuarto
            // 
            this.cbxQuarto.FormattingEnabled = true;
            this.cbxQuarto.Location = new System.Drawing.Point(97, 79);
            this.cbxQuarto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxQuarto.Name = "cbxQuarto";
            this.cbxQuarto.Size = new System.Drawing.Size(373, 24);
            this.cbxQuarto.TabIndex = 34;
            // 
            // cbxPagamento
            // 
            this.cbxPagamento.FormattingEnabled = true;
            this.cbxPagamento.Location = new System.Drawing.Point(97, 46);
            this.cbxPagamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxPagamento.Name = "cbxPagamento";
            this.cbxPagamento.Size = new System.Drawing.Size(373, 24);
            this.cbxPagamento.TabIndex = 33;
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(97, 9);
            this.cbxCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(373, 24);
            this.cbxCliente.TabIndex = 32;
            // 
            // dgvReserva
            // 
            this.dgvReserva.AllowUserToAddRows = false;
            this.dgvReserva.AllowUserToDeleteRows = false;
            this.dgvReserva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReserva.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Location = new System.Drawing.Point(5, 244);
            this.dgvReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.ReadOnly = true;
            this.dgvReserva.RowHeadersVisible = false;
            this.dgvReserva.RowHeadersWidth = 51;
            this.dgvReserva.RowTemplate.Height = 24;
            this.dgvReserva.Size = new System.Drawing.Size(652, 306);
            this.dgvReserva.TabIndex = 31;
            // 
            // btnCadastrarReserva
            // 
            this.btnCadastrarReserva.BackColor = System.Drawing.Color.LightGreen;
            this.btnCadastrarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarReserva.Location = new System.Drawing.Point(371, 206);
            this.btnCadastrarReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrarReserva.Name = "btnCadastrarReserva";
            this.btnCadastrarReserva.Size = new System.Drawing.Size(101, 32);
            this.btnCadastrarReserva.TabIndex = 30;
            this.btnCadastrarReserva.Text = "Cadastrar";
            this.btnCadastrarReserva.UseVisualStyleBackColor = false;
            this.btnCadastrarReserva.Click += new System.EventHandler(this.btnCadastrarReserva_Click);
            // 
            // txtQuantidadeReserva
            // 
            this.txtQuantidadeReserva.Location = new System.Drawing.Point(97, 178);
            this.txtQuantidadeReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidadeReserva.Name = "txtQuantidadeReserva";
            this.txtQuantidadeReserva.Size = new System.Drawing.Size(113, 22);
            this.txtQuantidadeReserva.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Quantidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Refeição";
            // 
            // txtHoraSaidaReserva
            // 
            this.txtHoraSaidaReserva.Location = new System.Drawing.Point(341, 145);
            this.txtHoraSaidaReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoraSaidaReserva.Name = "txtHoraSaidaReserva";
            this.txtHoraSaidaReserva.Size = new System.Drawing.Size(129, 22);
            this.txtHoraSaidaReserva.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(259, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Hora Saída";
            // 
            // txtHoraEntradaReserva
            // 
            this.txtHoraEntradaReserva.Location = new System.Drawing.Point(97, 145);
            this.txtHoraEntradaReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoraEntradaReserva.Name = "txtHoraEntradaReserva";
            this.txtHoraEntradaReserva.Size = new System.Drawing.Size(113, 22);
            this.txtHoraEntradaReserva.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Hora Entrada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quarto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pagamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cliente";
            // 
            // CadastroScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 619);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CadastroScreen";
            this.Text = "Cadastro";
            this.tabControl.ResumeLayout(false);
            this.tabPessoa.ResumeLayout(false);
            this.tabPessoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.tabFormaPagamento.ResumeLayout(false);
            this.tabFormaPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).EndInit();
            this.tabQuarto.ResumeLayout(false);
            this.tabQuarto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).EndInit();
            this.tabRefeicao.ResumeLayout(false);
            this.tabRefeicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefeicao)).EndInit();
            this.tabReserva.ResumeLayout(false);
            this.tabReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPessoa;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.TabPage tabFormaPagamento;
        private System.Windows.Forms.TabPage tabQuarto;
        private System.Windows.Forms.TabPage tabRefeicao;
        private System.Windows.Forms.TabPage tabReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.Button btnCadastrarPagamento;
        private System.Windows.Forms.DataGridView dgvPagamento;
        private System.Windows.Forms.DataGridView dgvQuarto;
        private System.Windows.Forms.Button btnCadastrarQuarto;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrarRefeicao;
        private System.Windows.Forms.TextBox txtValorRefeicao;
        private System.Windows.Forms.TextBox txtNomeRefeicao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvRefeicao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuantidadeReserva;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHoraSaidaReserva;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHoraEntradaReserva;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCadastrarReserva;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.ComboBox cbxRefeicao;
        private System.Windows.Forms.ComboBox cbxQuarto;
        private System.Windows.Forms.ComboBox cbxPagamento;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.TextBox txtValorQuarto;
        private System.Windows.Forms.Label label15;
    }
}