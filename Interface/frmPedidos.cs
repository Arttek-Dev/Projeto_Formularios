using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            mskDocumento.Mask = "000,000,000-00";
            rdoCPF.Checked = true;

            //Vetor - uma variável com vários dados
            //Organizado por posições
            string[] estados = new string[5] {"SP","MG","RJ","ES","BA"};

            //Atribuir o vetor ao Combobox
            cboEstado.DataSource = estados;
            cboEstado.Text = "Selecione um Estado";
        }

        private void rdoCPF_CheckedChanged(object sender, EventArgs e)
        {
            mskDocumento.Clear();
            mskDocumento.Mask = "000,000,000-00";
        }

        private void rdoCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            mskDocumento.Clear();
            mskDocumento.Mask = "00,000,000/0000-00";
        }

        private void chkImposto_CheckedChanged(object sender, EventArgs e)
        {
            // Estrutura de Deceisão
            // = é atribuição
            // == é de comporação
            if (chkImposto.Checked == true)
            {
                txtImposto.Enabled = true;
            } 
            else
            {
                txtImposto.Enabled = false;
                txtImposto.Clear();
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarar variáveis
            /*
             * Variáveis são espaços na memória
             */
            int qtde = 0;
            decimal unitario = 0;
            decimal total = 0;

            //Armazenar os dados do formulário

            qtde = Convert.ToInt32(txtQtde.Text);
            unitario = Convert.ToDecimal(txtUnitario.Text);


            //Cálculo de Total * / + - 
            total = qtde * unitario;

            //Retornat o valor para o formulário
            txtTotal.Text = total.ToString("F");

            //Verificar se há imposto

            if (chkImposto.Checked == true && txtImposto.Text != "")
            {
                decimal imposto = 0;
                imposto = Convert.ToDecimal(txtImposto.Text);
                decimal aliquota = 0;
                aliquota = imposto/ 100;

                //Total * aliquota + toal

                decimal totalGeral = 0;
                totalGeral = total * aliquota + total;
                txtTotalGeral.Text = totalGeral.ToString("F");
            }
            else
            {
                txtTotalGeral.Text = total.ToString("F");
            }


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        { 
            
            //Totalizar os valores do Produto
            decimal totalPagar = 0; //null

            //verificar se há linhas no DataGridView
            if (txtTotalGeral.Text != "")
            {
                // Adicionar valores ao componente DataGridView
                dgvTotais.Rows.Add(txtID.Text, txtDescricao.Text, txtQtde.Text, txtUnitario.Text,
                txtTotal.Text, txtImposto.Text, txtTotalGeral.Text);

                //Foreach -> Para cada - Estrutura de Repetição
                foreach (DataGridViewRow linha in dgvTotais.Rows)
                {
                    totalPagar += Convert.ToDecimal(linha.Cells["colTotalGeral"].Value);
                }

                //Mostrar o resultado ao usuário
                lblTotalPagar.Text = totalPagar.ToString("F");
            }
            LimparFormulario();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        //Procedimento - Bloco de código
        private void LimparFormulario()
        {
            txtID.Clear(); //1ª forma
            txtDescricao.Text = ""; //2ª forma
            txtQtde.Clear();
            txtUnitario.Clear();
            txtTotal.Clear();
            txtImposto.Clear();
            txtTotalGeral.Clear();
            chkImposto.Checked = false;
            txtImposto.Enabled = false;
        }

        private void cboParcelamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Estrutura de decisão com IF
            if (cboParcelamento.Text == "À Vista")
            {
                lblParcelamento.Text = lblTotalPagar.Text;
            }
            else if (cboParcelamento.Text == "2x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 2;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "3x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 3;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "4x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 4;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "5x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 5;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "6x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 6;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "7x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 7;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "8x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 8;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "9x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 9;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "10x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 10;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "11x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 11;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "12x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 12;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "13x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 13;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "14x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 14;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "15x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 15;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "16x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 16;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "17x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 17;
                lblParcelamento.Text = totalPagar.ToString("F");
            }
            else if (cboParcelamento.Text == "18x")
            {
                decimal totalPagar = Convert.ToDecimal(lblTotalPagar.Text);
                totalPagar = totalPagar / 18;
                lblParcelamento.Text = totalPagar.ToString("F");
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Analisar se há linhas para remover
            if (dgvTotais.Rows.Count > 0) // >= 1
            {
                DialogResult resposta = MessageBox.Show("Tem certeza que deseja REMOVER O PRODUTO?", "Aviso", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //Analisar a respota do usuário
                if (resposta == DialogResult.Yes)
                {
                    //Remover a linha selecionad do DataGridView
                    dgvTotais.Rows.RemoveAt(dgvTotais.CurrentRow.Index);

                    //Chamada do procedimento
                    CalcularTotalPagar();
                }
            }
            else
            {
                //Mensagem de texto para usuário
                MessageBox.Show("Não há produtos para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Procedimento para totalizar Produto
        public void CalcularTotalPagar()
        {
            decimal totalPagar = 0;
            //Foreach -> Para cada - Estrutura de Repetição
            foreach (DataGridViewRow linha in dgvTotais.Rows)
            {
                totalPagar += Convert.ToDecimal(linha.Cells["colTotalGeral"].Value);
            }

            //Mostrar o resultado ao usuário
            lblTotalPagar.Text = totalPagar.ToString("F");
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //Intânciar um formulário Clientes
            //Intância = carregar na memória
            frmClientes clientes = new frmClientes();
            //Mostrar o formulário na tela
            clientes.Show();

        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bloquear a digitação de texto
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                //Bloqueia a digitação
                e.Handled = true;
            }
        }
    }
}
