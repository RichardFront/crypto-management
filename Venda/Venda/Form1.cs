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

namespace Venda
{
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            int i;
            int quant;
            double reais;
            double bitcoin = 480,
                ethereum = 300,
                monero = 280,
                stellar = 190,
                tether = 240;

            quant = Convert.ToInt32(txtQuant.Text.Trim());

            cmbMoeda.Items[0] = bitcoin;
            cmbMoeda.Items[1] = ethereum;
            cmbMoeda.Items[2] = monero;
            cmbMoeda.Items[3] = stellar;
            cmbMoeda.Items[4] = tether;

            for (i = 0; i < 5; i++)
            {
                reais = Convert.ToDouble(cmbMoeda.Items[i]) * quant * 3;
                txtReais.Text = reais.ToString("F2", CultureInfo.InvariantCulture);
   
            }

            ListViewItem venda = lvlRelatorio.Items.Add(txtIDcli.Text.Trim());
            if (cmbMoeda.Text != String.Empty)
            {
                cmbMoeda.Items[0] = "bitcoin";
                cmbMoeda.Items[1] = "ethereum";
                cmbMoeda.Items[2] = "monero";
                cmbMoeda.Items[3] = "stellar";
                cmbMoeda.Items[4] = "tether";
                venda.SubItems.Add(new ListViewItem.ListViewSubItem(null, cmbMoeda.Text.Trim()));

            }

            venda.SubItems.Add(new ListViewItem.ListViewSubItem(null, txtQuant.Text.Trim()));
            venda.SubItems.Add(new ListViewItem.ListViewSubItem(null, txtReais.Text.Trim()));
            venda.SubItems.Add(new ListViewItem.ListViewSubItem(null, dtpData.Text.Trim()));
            venda.SubItems.Add(new ListViewItem.ListViewSubItem(null, dtpHora.Text.Trim()));

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIDcli.Text = String.Empty;
            txtQuant.Text = String.Empty;
            txtReais.Text = String.Empty;

        }

        private void frmVenda_Load(object sender, EventArgs e)
        {

        }
    }
}