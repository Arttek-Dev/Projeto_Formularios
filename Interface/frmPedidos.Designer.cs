
namespace Interface
{
    partial class frmPedidos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.grpDocumento = new System.Windows.Forms.GroupBox();
            this.mskDocumento = new System.Windows.Forms.MaskedTextBox();
            this.rdoCNPJ = new System.Windows.Forms.RadioButton();
            this.rdoCPF = new System.Windows.Forms.RadioButton();
            this.mskFone = new System.Windows.Forms.MaskedTextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dptHora = new System.Windows.Forms.DateTimePicker();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grpProduto = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.lblTotalGeral = new System.Windows.Forms.Label();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkImposto = new System.Windows.Forms.CheckBox();
            this.lblImposto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblUnitario = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.grpTotais = new System.Windows.Forms.GroupBox();
            this.dgvTotais = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImposto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalGeral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTotalPagar = new System.Windows.Forms.GroupBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.grpParcelamento = new System.Windows.Forms.GroupBox();
            this.cboParcelamento = new System.Windows.Forms.ComboBox();
            this.lblParcelamento = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.grpCliente.SuspendLayout();
            this.grpDocumento.SuspendLayout();
            this.grpProduto.SuspendLayout();
            this.grpTotais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotais)).BeginInit();
            this.grpTotalPagar.SuspendLayout();
            this.grpParcelamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.btnClientes);
            this.grpCliente.Controls.Add(this.grpDocumento);
            this.grpCliente.Controls.Add(this.mskFone);
            this.grpCliente.Controls.Add(this.cboEstado);
            this.grpCliente.Controls.Add(this.dptHora);
            this.grpCliente.Controls.Add(this.dtpData);
            this.grpCliente.Controls.Add(this.lblHora);
            this.grpCliente.Controls.Add(this.lblData);
            this.grpCliente.Controls.Add(this.txtCliente);
            this.grpCliente.Controls.Add(this.txtCodigo);
            this.grpCliente.Controls.Add(this.lblEstado);
            this.grpCliente.Controls.Add(this.lblFone);
            this.grpCliente.Controls.Add(this.lblCliente);
            this.grpCliente.Controls.Add(this.lblCodigo);
            this.grpCliente.Location = new System.Drawing.Point(12, 12);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(579, 162);
            this.grpCliente.TabIndex = 0;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente";
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(495, 107);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(64, 23);
            this.btnClientes.TabIndex = 15;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // grpDocumento
            // 
            this.grpDocumento.Controls.Add(this.mskDocumento);
            this.grpDocumento.Controls.Add(this.rdoCNPJ);
            this.grpDocumento.Controls.Add(this.rdoCPF);
            this.grpDocumento.Location = new System.Drawing.Point(255, 56);
            this.grpDocumento.Name = "grpDocumento";
            this.grpDocumento.Size = new System.Drawing.Size(219, 91);
            this.grpDocumento.TabIndex = 14;
            this.grpDocumento.TabStop = false;
            // 
            // mskDocumento
            // 
            this.mskDocumento.Location = new System.Drawing.Point(36, 53);
            this.mskDocumento.Mask = "000,000,000-00";
            this.mskDocumento.Name = "mskDocumento";
            this.mskDocumento.Size = new System.Drawing.Size(132, 20);
            this.mskDocumento.TabIndex = 2;
            // 
            // rdoCNPJ
            // 
            this.rdoCNPJ.AutoSize = true;
            this.rdoCNPJ.Location = new System.Drawing.Point(116, 19);
            this.rdoCNPJ.Name = "rdoCNPJ";
            this.rdoCNPJ.Size = new System.Drawing.Size(52, 17);
            this.rdoCNPJ.TabIndex = 1;
            this.rdoCNPJ.TabStop = true;
            this.rdoCNPJ.Text = "CNPJ";
            this.rdoCNPJ.UseVisualStyleBackColor = true;
            this.rdoCNPJ.CheckedChanged += new System.EventHandler(this.rdoCNPJ_CheckedChanged);
            // 
            // rdoCPF
            // 
            this.rdoCPF.AutoSize = true;
            this.rdoCPF.Location = new System.Drawing.Point(36, 19);
            this.rdoCPF.Name = "rdoCPF";
            this.rdoCPF.Size = new System.Drawing.Size(45, 17);
            this.rdoCPF.TabIndex = 0;
            this.rdoCPF.TabStop = true;
            this.rdoCPF.Text = "CPF";
            this.rdoCPF.UseVisualStyleBackColor = true;
            this.rdoCPF.CheckedChanged += new System.EventHandler(this.rdoCPF_CheckedChanged);
            // 
            // mskFone
            // 
            this.mskFone.Location = new System.Drawing.Point(62, 87);
            this.mskFone.Mask = "(00)00000-0000";
            this.mskFone.Name = "mskFone";
            this.mskFone.Size = new System.Drawing.Size(176, 20);
            this.mskFone.TabIndex = 13;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(62, 121);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(176, 21);
            this.cboEstado.TabIndex = 12;
            // 
            // dptHora
            // 
            this.dptHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dptHora.Location = new System.Drawing.Point(495, 26);
            this.dptHora.Name = "dptHora";
            this.dptHora.ShowUpDown = true;
            this.dptHora.Size = new System.Drawing.Size(64, 20);
            this.dptHora.TabIndex = 11;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(211, 26);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(212, 20);
            this.dtpData.TabIndex = 10;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(459, 29);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "Hora";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(173, 29);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(62, 56);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(176, 20);
            this.txtCliente.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(61, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(97, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(15, 124);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado";
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(16, 90);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(31, 13);
            this.lblFone.TabIndex = 2;
            this.lblFone.Text = "Fone";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(15, 59);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // grpProduto
            // 
            this.grpProduto.Controls.Add(this.btnAdicionar);
            this.grpProduto.Controls.Add(this.btnLimpar);
            this.grpProduto.Controls.Add(this.txtTotalGeral);
            this.grpProduto.Controls.Add(this.lblTotalGeral);
            this.grpProduto.Controls.Add(this.txtImposto);
            this.grpProduto.Controls.Add(this.btnCalcular);
            this.grpProduto.Controls.Add(this.txtTotal);
            this.grpProduto.Controls.Add(this.txtUnitario);
            this.grpProduto.Controls.Add(this.txtQtde);
            this.grpProduto.Controls.Add(this.txtDescricao);
            this.grpProduto.Controls.Add(this.txtID);
            this.grpProduto.Controls.Add(this.chkImposto);
            this.grpProduto.Controls.Add(this.lblImposto);
            this.grpProduto.Controls.Add(this.lblTotal);
            this.grpProduto.Controls.Add(this.lblUnitario);
            this.grpProduto.Controls.Add(this.lblQtde);
            this.grpProduto.Controls.Add(this.lblDescricao);
            this.grpProduto.Controls.Add(this.lblID);
            this.grpProduto.Location = new System.Drawing.Point(12, 180);
            this.grpProduto.Name = "grpProduto";
            this.grpProduto.Size = new System.Drawing.Size(579, 105);
            this.grpProduto.TabIndex = 1;
            this.grpProduto.TabStop = false;
            this.grpProduto.Text = "Produto";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(476, 66);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 18;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(476, 37);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.Enabled = false;
            this.txtTotalGeral.Location = new System.Drawing.Point(342, 68);
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.Size = new System.Drawing.Size(128, 20);
            this.txtTotalGeral.TabIndex = 16;
            // 
            // lblTotalGeral
            // 
            this.lblTotalGeral.AutoSize = true;
            this.lblTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeral.Location = new System.Drawing.Point(227, 70);
            this.lblTotalGeral.Name = "lblTotalGeral";
            this.lblTotalGeral.Size = new System.Drawing.Size(109, 16);
            this.lblTotalGeral.TabIndex = 15;
            this.lblTotalGeral.Text = "Total Geral R$";
            // 
            // txtImposto
            // 
            this.txtImposto.Enabled = false;
            this.txtImposto.Location = new System.Drawing.Point(82, 69);
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(75, 20);
            this.txtImposto.TabIndex = 13;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(163, 67);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(54, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(374, 39);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(96, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // txtUnitario
            // 
            this.txtUnitario.Location = new System.Drawing.Point(303, 39);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.Size = new System.Drawing.Size(65, 20);
            this.txtUnitario.TabIndex = 10;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(255, 39);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(34, 20);
            this.txtQtde.TabIndex = 9;
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(62, 39);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(176, 20);
            this.txtDescricao.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(18, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(36, 20);
            this.txtID.TabIndex = 7;
            // 
            // chkImposto
            // 
            this.chkImposto.AutoSize = true;
            this.chkImposto.Location = new System.Drawing.Point(61, 72);
            this.chkImposto.Name = "chkImposto";
            this.chkImposto.Size = new System.Drawing.Size(15, 14);
            this.chkImposto.TabIndex = 6;
            this.chkImposto.UseVisualStyleBackColor = true;
            this.chkImposto.CheckedChanged += new System.EventHandler(this.chkImposto_CheckedChanged);
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Location = new System.Drawing.Point(16, 72);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(44, 13);
            this.lblImposto.TabIndex = 5;
            this.lblImposto.Text = "Imposto";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(375, 25);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total R$";
            // 
            // lblUnitario
            // 
            this.lblUnitario.AutoSize = true;
            this.lblUnitario.Location = new System.Drawing.Point(300, 25);
            this.lblUnitario.Name = "lblUnitario";
            this.lblUnitario.Size = new System.Drawing.Size(60, 13);
            this.lblUnitario.TabIndex = 3;
            this.lblUnitario.Text = "Unitário R$";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(252, 23);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(30, 13);
            this.lblQtde.TabIndex = 2;
            this.lblQtde.Text = "Qtde";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(59, 26);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(16, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID*";
            // 
            // grpTotais
            // 
            this.grpTotais.Controls.Add(this.dgvTotais);
            this.grpTotais.Location = new System.Drawing.Point(12, 291);
            this.grpTotais.Name = "grpTotais";
            this.grpTotais.Size = new System.Drawing.Size(579, 173);
            this.grpTotais.TabIndex = 2;
            this.grpTotais.TabStop = false;
            this.grpTotais.Text = "Totais";
            // 
            // dgvTotais
            // 
            this.dgvTotais.AllowUserToAddRows = false;
            this.dgvTotais.AllowUserToDeleteRows = false;
            this.dgvTotais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDescricao,
            this.colQtde,
            this.colUnitario,
            this.colTotal,
            this.colImposto,
            this.colTotalGeral});
            this.dgvTotais.Location = new System.Drawing.Point(6, 19);
            this.dgvTotais.Name = "dgvTotais";
            this.dgvTotais.ReadOnly = true;
            this.dgvTotais.Size = new System.Drawing.Size(567, 149);
            this.dgvTotais.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 35;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 120;
            // 
            // colQtde
            // 
            this.colQtde.HeaderText = "Qtde";
            this.colQtde.Name = "colQtde";
            this.colQtde.ReadOnly = true;
            this.colQtde.Width = 40;
            // 
            // colUnitario
            // 
            this.colUnitario.HeaderText = "Unitário";
            this.colUnitario.Name = "colUnitario";
            this.colUnitario.ReadOnly = true;
            this.colUnitario.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total R$";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colImposto
            // 
            this.colImposto.HeaderText = "Imposto";
            this.colImposto.Name = "colImposto";
            this.colImposto.ReadOnly = true;
            this.colImposto.Width = 50;
            // 
            // colTotalGeral
            // 
            this.colTotalGeral.HeaderText = "Total Geral R$";
            this.colTotalGeral.Name = "colTotalGeral";
            this.colTotalGeral.ReadOnly = true;
            this.colTotalGeral.Width = 99;
            // 
            // grpTotalPagar
            // 
            this.grpTotalPagar.Controls.Add(this.lblTotalPagar);
            this.grpTotalPagar.Location = new System.Drawing.Point(18, 470);
            this.grpTotalPagar.Name = "grpTotalPagar";
            this.grpTotalPagar.Size = new System.Drawing.Size(211, 100);
            this.grpTotalPagar.TabIndex = 3;
            this.grpTotalPagar.TabStop = false;
            this.grpTotalPagar.Text = "Total à pagar";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalPagar.Location = new System.Drawing.Point(64, 34);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(87, 39);
            this.lblTotalPagar.TabIndex = 0;
            this.lblTotalPagar.Text = "0,00";
            // 
            // grpParcelamento
            // 
            this.grpParcelamento.Controls.Add(this.cboParcelamento);
            this.grpParcelamento.Controls.Add(this.lblParcelamento);
            this.grpParcelamento.Location = new System.Drawing.Point(242, 470);
            this.grpParcelamento.Name = "grpParcelamento";
            this.grpParcelamento.Size = new System.Drawing.Size(211, 100);
            this.grpParcelamento.TabIndex = 4;
            this.grpParcelamento.TabStop = false;
            this.grpParcelamento.Text = "Parcelamento";
            // 
            // cboParcelamento
            // 
            this.cboParcelamento.FormattingEnabled = true;
            this.cboParcelamento.Items.AddRange(new object[] {
            "À Vista",
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x",
            "8x",
            "9x",
            "10x",
            "11x",
            "12x",
            "13x",
            "14x",
            "15x",
            "15x",
            "16x",
            "17x",
            "18x"});
            this.cboParcelamento.Location = new System.Drawing.Point(15, 34);
            this.cboParcelamento.Name = "cboParcelamento";
            this.cboParcelamento.Size = new System.Drawing.Size(61, 21);
            this.cboParcelamento.TabIndex = 1;
            this.cboParcelamento.SelectedIndexChanged += new System.EventHandler(this.cboParcelamento_SelectedIndexChanged);
            // 
            // lblParcelamento
            // 
            this.lblParcelamento.AutoSize = true;
            this.lblParcelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblParcelamento.Location = new System.Drawing.Point(91, 34);
            this.lblParcelamento.Name = "lblParcelamento";
            this.lblParcelamento.Size = new System.Drawing.Size(87, 39);
            this.lblParcelamento.TabIndex = 0;
            this.lblParcelamento.Text = "0,00";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(488, 504);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(605, 587);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.grpParcelamento);
            this.Controls.Add(this.grpTotalPagar);
            this.Controls.Add(this.grpTotais);
            this.Controls.Add(this.grpProduto);
            this.Controls.Add(this.grpCliente);
            this.Name = "frmPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpDocumento.ResumeLayout(false);
            this.grpDocumento.PerformLayout();
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            this.grpTotais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotais)).EndInit();
            this.grpTotalPagar.ResumeLayout(false);
            this.grpTotalPagar.PerformLayout();
            this.grpParcelamento.ResumeLayout(false);
            this.grpParcelamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DateTimePicker dptHora;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.MaskedTextBox mskFone;
        private System.Windows.Forms.GroupBox grpDocumento;
        private System.Windows.Forms.RadioButton rdoCNPJ;
        private System.Windows.Forms.RadioButton rdoCPF;
        private System.Windows.Forms.MaskedTextBox mskDocumento;
        private System.Windows.Forms.GroupBox grpProduto;
        private System.Windows.Forms.CheckBox chkImposto;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblUnitario;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.Label lblTotalGeral;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtUnitario;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.GroupBox grpTotais;
        private System.Windows.Forms.DataGridView dgvTotais;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImposto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalGeral;
        private System.Windows.Forms.GroupBox grpTotalPagar;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.GroupBox grpParcelamento;
        private System.Windows.Forms.Label lblParcelamento;
        private System.Windows.Forms.ComboBox cboParcelamento;
        private System.Windows.Forms.Button btnRemover;
    }
}

