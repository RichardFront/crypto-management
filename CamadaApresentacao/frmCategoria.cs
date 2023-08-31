using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class frmCategoria : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        private bool eNovo2 = false;
        private bool eEditar2 = false;
        private bool eNovo3 = false;
        private bool eEditar3 = false;

        public frmCategoria()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.txtNome, "Insira o nome do cliente");
        }

        //Mostrar mensagem de confirmação
        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema Comércio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Mostrar mensagem de erro
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema Comércio", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       

        //Limpar Campos
        private void Limpar()
        {
            this.txtNome.Text = string.Empty;
            this.txtIdCliente.Text = string.Empty;
            this.txtRazao_Social.Text = string.Empty;
            this.txtCPF.Text = string.Empty;
            this.txtCNPJ.Text = string.Empty;
            this.txtEndereco.Text = string.Empty;
            this.txtCidade.Text = string.Empty;
            this.txtUF.Text = string.Empty;
            this.txtTelefone.Text = string.Empty;




        }


        //Habilitar os text box
        private void Habilitar(bool valor)
        {
            this.txtNome.ReadOnly = !valor;
            this.txtRazao_Social.ReadOnly = !valor;
            this.txtIdCliente.ReadOnly = !valor;
            this.txtCPF.ReadOnly = !valor;
            this.txtCNPJ.ReadOnly = !valor;
            this.txtEndereco.ReadOnly = !valor;
            this.txtCidade.ReadOnly = !valor;
            this.txtUF.ReadOnly = !valor;
            this.txtTelefone.ReadOnly = !valor;



        }


        //Habilitar os botoes
        private void botoes()
        {
            if(this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovo.Enabled = false;
                this.btnSalvar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;

            }else
            {
                this.Habilitar(false);
                this.btnNovo.Enabled = true;
                this.btnSalvar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
            
        }



        //Ocultar as Colunas do Grid
        private void ocultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
           // this.dataLista.Columns[1].Visible = false;
        }


        //Mostrar no Data Grid
        private void Mostrar()
        {
            this.dataLista.DataSource = NCategoria.Mostrar();
            this.ocultarColunas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }



        //Buscar pelo Nome
        private void BuscarNome()
        {
            this.dataLista.DataSource = NCategoria.BuscarNome(this.txtBuscar.Text);
           
            this.ocultarColunas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }



        private void frmCategoria_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Mostrar2();
            this.Mostrar3();
            this.Habilitar(false);
            this.Habilitar2(false);
            this.Habilitar3(false);
            this.botoes();
            this.botoes2();
            this.botoes3();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNome();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtNome.Focus();
            this.txtIdCliente.Enabled = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if(this.txtNome.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos");
                    errorIcone.SetError(txtNome, "Insira o nome");

                }else
                {
                    if (this.eNovo)
                    {
                        resp = NCategoria.Inserir(this.txtNome.Text.Trim().ToUpper(), this.txtRazao_Social.Text.Trim(), this.txtCPF.Text.Trim(), this.txtCNPJ.Text.Trim(), this.txtEndereco.Text.Trim(),this.txtCidade.Text.Trim(), this.txtUF.Text.Trim(), this.txtTelefone.Text.Trim());
                    }else
                    {
                        resp = NCategoria.Editar(Convert.ToInt32(this.txtIdCliente.Text), this.txtNome.Text.Trim().ToUpper(), this.txtRazao_Social.Text.Trim(), this.txtCPF.Text.Trim(), this.txtCNPJ.Text.Trim(), this.txtEndereco.Text.Trim(), this.txtCidade.Text.Trim(), this.txtUF.Text.Trim(), this.txtTelefone.Text.Trim());
                            
                    }

                    if (resp.Equals("OK"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOk("Registro salvo com sucesso");
                        }else
                        {
                            this.MensagemOk("Registro editado com sucesso");
                        }
                    }else
                    {
                        this.MensagemErro(resp);
                    }

                    this.eNovo = false;
                    this.eEditar = false;
                    this.botoes();
                    this.Limpar();
                    this.Mostrar();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdCliente.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idcliente"].Value);
            this.txtNome.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Nome"].Value);
            this.txtRazao_Social.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Razao_Social"].Value);
            this.txtCPF.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["CPF"].Value);
            this.txtCNPJ.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["CNPJ"].Value);
            this.txtEndereco.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Endereco"].Value);
            this.txtCidade.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Cidade"].Value);
            this.txtUF.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["UF"].Value);
            this.txtTelefone.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Telefone"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtIdCliente.Text.Equals(""))
            {
                this.MensagemErro("Selecione um registro para inserir");
            }else
            {
                this.eEditar = true;
                this.botoes();
                this.Habilitar(true);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eEditar = false;
            this.botoes();
            this.Habilitar(false);
            this.Limpar();

        }

        private void chkDeletar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletar.Checked)
            {
                this.dataLista.Columns[0].Visible = true;
            }else
            {
                this.dataLista.Columns[0].Visible = false;
            }
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente Deseja apagar os Registros", "Sistema Comércio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach(DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = NCategoria.Excluir(Convert.ToInt32(Codigo));

                            if (Resp.Equals("OK"))
                            {
                                this.MensagemOk("Registro excluido com sucesso");

                            }else
                            {
                                this.MensagemErro(Resp);
                            }
                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }

        private void txtIdCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }


        // Criptomoedas
        private void Limpar2()
        {
            this.txtDescricao.Text = string.Empty;
            this.txtIdcriptomoeda.Text = string.Empty;
            this.txtValor.Text = string.Empty;
           

        }

        private void Habilitar2(bool valor)
        {
            this.txtIdcriptomoeda.ReadOnly = !valor;
            this.txtDescricao.ReadOnly = !valor;
            this.txtValor.ReadOnly = !valor;
            



        }

        private void botoes2()
        {
            if (this.eNovo2 || this.eEditar2)
            {
                this.Habilitar2(true);
                this.btnNovo2.Enabled = false;
                this.btnSalvar2.Enabled = true;
                this.btnEditar2.Enabled = false;
                this.btnCancelar2.Enabled = true;

            }
            else
            {
                this.Habilitar2(false);
                this.btnNovo2.Enabled = true;
                this.btnSalvar2.Enabled = false;
                this.btnEditar2.Enabled = true;
                this.btnCancelar2.Enabled = false;
            }

        }
        private void ocultarColunas2()
        {
            this.dataLista2.Columns[0].Visible = false;
            // this.dataLista.Columns[1].Visible = false;
        }

        private void Mostrar2()
        {
            this.dataLista2.DataSource = NCriptomoeda.Mostrar2();
            this.ocultarColunas2();
            lblTotal2.Text = "Total de Registros: " + Convert.ToString(dataLista2.Rows.Count);
        }



        private void BuscarNome2()
        {
            this.dataLista2.DataSource = NCriptomoeda.BuscarNome2(this.txtBuscar2.Text);

            this.ocultarColunas2();
            lblTotal2.Text = "Total de Registros: " + Convert.ToString(dataLista2.Rows.Count);
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            this.BuscarNome2();

        }

        private void txtBuscar2_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome2();

        }

        private void btnNovo2_Click(object sender, EventArgs e)
        {

            this.eNovo2 = true;
            this.eEditar2 = false;
            this.botoes2();
            this.Limpar2();
            this.Habilitar2(true);
            this.txtDescricao.Focus();
            this.txtIdcriptomoeda.Enabled = false;

        }

        private void btnSalvar2_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.txtDescricao.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos");
                    errorIcone.SetError(txtDescricao, "Insira o nome");

                }
                else
                {
                    if (this.eNovo2)
                    {
                        resp = NCriptomoeda.Inserir2(this.txtDescricao.Text.Trim().ToUpper(), this.txtValor.Text.Trim());
                    }
                    else
                    {
                        resp = NCriptomoeda.Editar2(Convert.ToInt32(this.txtIdcriptomoeda.Text), this.txtDescricao.Text.Trim().ToUpper(), this.txtValor.Text.Trim());

                    }

                    if (resp.Equals("OK"))
                    {
                        if (this.eNovo2)
                        {
                            this.MensagemOk("Registro salvo com sucesso");
                        }
                        else
                        {
                            this.MensagemOk("Registro editado com sucesso");
                        }
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }

                    this.eNovo2 = false;
                    this.eEditar2 = false;
                    this.botoes2();
                    this.Limpar2();
                    this.Mostrar2();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        private void dataLista2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista2.Columns["Deletar2"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar2 = (DataGridViewCheckBoxCell)dataLista2.Rows[e.RowIndex].Cells["Deletar2"];
                ChkDeletar2.Value = !Convert.ToBoolean(ChkDeletar2.Value);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataLista2_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdcriptomoeda.Text = Convert.ToString(this.dataLista2.CurrentRow.Cells["idcriptomoeda"].Value);
            this.txtDescricao.Text = Convert.ToString(this.dataLista2.CurrentRow.Cells["descricao"].Value);
            this.txtValor.Text = Convert.ToString(this.dataLista2.CurrentRow.Cells["valor"].Value);
            

            this.tabControl1.SelectedIndex = 3;


        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            if (this.txtIdcriptomoeda.Text.Equals(""))
            {
                this.MensagemErro("Selecione um registro para inserir");
            }
            else
            {
                this.eEditar2 = true;
                this.botoes2();
                this.Habilitar2(true);
            }
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            this.eNovo2 = false;
            this.eEditar2 = false;
            this.botoes2();
            this.Habilitar2(false);
            this.Limpar2();

        }

        private void chkDeletar2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletar2.Checked)
            {
                this.dataLista2.Columns[0].Visible = true;
            }
            else
            {
                this.dataLista2.Columns[0].Visible = false;
            }
        }

        private void btnDeletar2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente Deseja apagar os Registros", "Sistema Comércio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista2.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = NCriptomoeda.Excluir2(Convert.ToInt32(Codigo));

                            if (Resp.Equals("OK"))
                            {
                                this.MensagemOk("Registro excluido com sucesso");

                            }
                            else
                            {
                                this.MensagemErro(Resp);
                            }
                        }
                    }
                    this.Mostrar2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void ocultarColunas3()
        {
            this.dataLista3.Columns[0].Visible = false;
            // this.dataLista.Columns[1].Visible = false;
        }

        private void BuscarNome3()
        {
            this.dataLista3.DataSource = NVendas.BuscarNome3(this.txtBuscar3.Text);

            this.ocultarColunas3();
            lblTotal3.Text = "Total de Registros: " + Convert.ToString(dataLista3.Rows.Count);
        }

        private void dataLista3_MouseClick(object sender, MouseEventArgs e)
        {

        }
       
       
        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtIDcli_TextChanged(object sender, EventArgs e)
        {

        }
        private void Habilitar3(bool valor)
        {
            this.txtVenda.ReadOnly = !valor;
            this.txtIDcli.ReadOnly = !valor;
           
            this.txtQuant.ReadOnly = !valor;




        }


        private void Mostrar3()
        {
            this.dataLista3.DataSource = NVendas.Mostrar3();
        
            lblTotal3.Text = "Total de Registros: " + Convert.ToString(dataLista3.Rows.Count);
        }


        
        private void botoes3()
        {
            if (this.eNovo3 || this.eEditar3)
            {
                this.Habilitar3(true);
                this.btnNovo3.Enabled = false;
                this.btnSalvar3.Enabled = true;
               
                this.btnCancelar3.Enabled = true;

            }
            else
            {
                this.Habilitar3(false);
                this.btnNovo3.Enabled = true;
                this.btnSalvar3.Enabled = false;
               
                this.btnCancelar3.Enabled = false;
            }

        }
        public void Limpar3()
        {
            txtVenda.Text = string.Empty;
            cmbMoeda.Text = string.Empty;
            txtIDcli.Text = string.Empty;
            txtQuant.Text = string.Empty;
            txtReais.Text = string.Empty;

        }
        
      
        private void txtReais_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnSalvar3_Click(object sender, EventArgs e)
        {
            if (cmbMoeda.SelectedItem == "bitcoin")
            {
                int quant = Convert.ToInt32(txtQuant.Text.Trim());
                double reais = 480;
                reais = reais * quant;

                txtReais.Text = reais.ToString("F2", CultureInfo.InvariantCulture);

            }
            else if (cmbMoeda.SelectedItem == "ethereum")
            {
                int quant = Convert.ToInt32(txtQuant.Text.Trim());

                double reais = 300;
                reais = reais * quant;

                txtReais.Text = reais.ToString("F2", CultureInfo.InvariantCulture);
            }

            else if (cmbMoeda.SelectedItem == "monero")
            {
                int quant = Convert.ToInt32(txtQuant.Text.Trim());

                double reais = 280;
                reais = reais * quant;

                txtReais.Text = reais.ToString("F2", CultureInfo.InvariantCulture);
            }

            else if (cmbMoeda.SelectedItem == "stellar")
            {
                int quant = Convert.ToInt32(txtQuant.Text.Trim());

                double reais = 190;
                reais = reais * quant;

                txtReais.Text = reais.ToString("F2", CultureInfo.InvariantCulture);
            }

            else if (cmbMoeda.SelectedItem == "tether")
            {

                int quant = Convert.ToInt32(txtQuant.Text.Trim());
                double reais = 240;
                reais = reais * quant;
                txtReais.Text = reais.ToString("F2", CultureInfo.InvariantCulture);
            }


            if (cmbMoeda.Text != String.Empty)
            {
                cmbMoeda.Items[0] = "bitcoin";
                cmbMoeda.Items[1] = "ethereum";
                cmbMoeda.Items[2] = "monero";
                cmbMoeda.Items[3] = "stellar";
                cmbMoeda.Items[4] = "tether";


            }
            try
            {
                string resp = "";
                if (this.txtIDcli.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos");
                    errorIcone.SetError(txtIDcli, "Insira o codigo");

                }
                else
                {
                    if (this.eNovo3)
                    {
                        resp = NVendas.Inserir3(Convert.ToInt32(this.txtIDcli.Text),this.cmbMoeda.Text.Trim(), Convert.ToInt32(this.txtQuant.Text.Trim()), this.txtReais.Text.Trim());

                    }
                    else
                    {
                        resp = NVendas.Editar3(Convert.ToInt32(this.txtVenda.Text), Convert.ToInt32(this.txtIDcli.Text), this.cmbMoeda.Text.Trim(), Convert.ToInt32(this.txtQuant.Text.Trim()), this.txtReais.Text.Trim());

                    }

                    if (resp.Equals("OK"))
                    {
                        if (this.eNovo3)
                        {
                            this.MensagemOk("Registro salvo com sucesso");
                        }
                        else
                        {
                            this.MensagemOk("Registro editado com sucesso");
                        }
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }


                    this.botoes3();
                    this.Limpar3();
                    this.Mostrar3();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }





        }
        private void cmbMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            


    }

        private void btnCancelar3_Click(object sender, EventArgs e)
        {
            this.eNovo3 = false;
            this.eEditar3 = false;
            this.botoes3();
            this.Habilitar3(false);
            this.Limpar3();
        }

        private void btnEditar3_Click(object sender, EventArgs e)
        {
            if (this.txtVenda.Text.Equals(""))
            {
                this.MensagemErro("Selecione um registro para inserir");
            }
            else
            {
                this.eEditar3 = true;
                this.botoes3();
                this.Habilitar3(true);
            }
        }

        private void dataLista3_DoubleClick(object sender, EventArgs e)
        {
            this.txtVenda.Text = Convert.ToString(this.dataLista3.CurrentRow.Cells["idvenda"].Value);
            this.txtIDcli.Text = Convert.ToString(this.dataLista3.CurrentRow.Cells["idcliente"].Value);
            this.cmbMoeda.Text = Convert.ToString(this.dataLista3.CurrentRow.Cells["moedas"].Value);
            this.txtQuant.Text = Convert.ToString(this.dataLista3.CurrentRow.Cells["quantidade"].Value);
            this.txtReais.Text = Convert.ToString(this.dataLista3.CurrentRow.Cells["reais"].Value);

            this.tabControl1.SelectedIndex = 5;


        }

        private void btnNovo3_Click(object sender, EventArgs e)
        {
            this.eNovo3 = true;
            this.eEditar3 = false;
            this.botoes3();
            this.Limpar3();
            this.Habilitar3(true);
            this.txtIDcli.Focus();
            this.txtVenda.Enabled = false;

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvlRelatorio2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar3_Click(object sender, EventArgs e)
        {
            this.BuscarNome3();
        }

        private void chkDeletar3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletar3.Checked)
            {
                this.dataLista3.Columns[0].Visible = true;
            }
            else
            {
                this.dataLista3.Columns[0].Visible = false;
            }
        }

        private void btnDeletar3_Click(object sender, EventArgs e)
        {
           
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Realmente Deseja apagar os Registros", "Sistema Comércio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcao == DialogResult.OK)
                    {
                        string Codigo;
                        string Resp = "";

                        foreach (DataGridViewRow row in dataLista3.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToString(row.Cells[1].Value);
                                Resp = NVendas.Excluir3(Convert.ToInt32(Codigo));

                                if (Resp.Equals("OK"))
                                {
                                    this.MensagemOk("Registro excluido com sucesso");

                                }
                                else
                                {
                                    this.MensagemErro(Resp);
                                }
                            }
                        }
                        this.Mostrar3();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }


            

        }

        private void dataLista3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista3.Columns["Deletar3"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar3 = (DataGridViewCheckBoxCell)dataLista3.Rows[e.RowIndex].Cells["Deletar3"];
                ChkDeletar3.Value = !Convert.ToBoolean(ChkDeletar3.Value);
            }
        }
    }
    }

        
       

        
   
    
    

