namespace Venda
{
    partial class frmVenda
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtIDcli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVenda = new System.Windows.Forms.Button();
            this.txtReais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMoeda = new System.Windows.Forms.ComboBox();
            this.gpbMoedas = new System.Windows.Forms.GroupBox();
            this.lblValorThether = new System.Windows.Forms.Label();
            this.lblValorStellar = new System.Windows.Forms.Label();
            this.lblValorMonero = new System.Windows.Forms.Label();
            this.lblValorEthereum = new System.Windows.Forms.Label();
            this.lblValorBitcoin = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbSelecione = new System.Windows.Forms.GroupBox();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvlRelatorio = new System.Windows.Forms.ListView();
            this.clhIDcli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhQuant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbMoedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbSelecione.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 705);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gpbMoedas);
            this.tabPage1.Controls.Add(this.gpbSelecione);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1176, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Realizar venda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.dtpHora);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.txtIDcli);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnVenda);
            this.groupBox1.Controls.Add(this.txtReais);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQuant);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMoeda);
            this.groupBox1.Location = new System.Drawing.Point(535, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 324);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Venda";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(358, 278);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 31);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // dtpHora
            // 
            this.dtpHora.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpHora.Enabled = false;
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(484, 75);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(65, 20);
            this.dtpHora.TabIndex = 10;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(378, 33);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(171, 20);
            this.dtpData.TabIndex = 9;
            // 
            // txtIDcli
            // 
            this.txtIDcli.Location = new System.Drawing.Point(142, 34);
            this.txtIDcli.Name = "txtIDcli";
            this.txtIDcli.Size = new System.Drawing.Size(121, 20);
            this.txtIDcli.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID cliente";
            // 
            // btnVenda
            // 
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.Location = new System.Drawing.Point(190, 278);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(144, 31);
            this.btnVenda.TabIndex = 6;
            this.btnVenda.Text = "Realizar venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // txtReais
            // 
            this.txtReais.Enabled = false;
            this.txtReais.Location = new System.Drawing.Point(142, 177);
            this.txtReais.Name = "txtReais";
            this.txtReais.ReadOnly = true;
            this.txtReais.Size = new System.Drawing.Size(121, 20);
            this.txtReais.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor em Reais";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(142, 129);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(121, 20);
            this.txtQuant.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criptomoeda";
            // 
            // cmbMoeda
            // 
            this.cmbMoeda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoeda.FormattingEnabled = true;
            this.cmbMoeda.Items.AddRange(new object[] {
            "Bitcoin",
            "Ethereum",
            "Monero",
            "Stellar",
            "Tether"});
            this.cmbMoeda.Location = new System.Drawing.Point(142, 78);
            this.cmbMoeda.Name = "cmbMoeda";
            this.cmbMoeda.Size = new System.Drawing.Size(121, 21);
            this.cmbMoeda.TabIndex = 0;
            // 
            // gpbMoedas
            // 
            this.gpbMoedas.Controls.Add(this.lblValorThether);
            this.gpbMoedas.Controls.Add(this.lblValorStellar);
            this.gpbMoedas.Controls.Add(this.lblValorMonero);
            this.gpbMoedas.Controls.Add(this.lblValorEthereum);
            this.gpbMoedas.Controls.Add(this.lblValorBitcoin);
            this.gpbMoedas.Controls.Add(this.pictureBox5);
            this.gpbMoedas.Controls.Add(this.pictureBox4);
            this.gpbMoedas.Controls.Add(this.pictureBox3);
            this.gpbMoedas.Controls.Add(this.pictureBox2);
            this.gpbMoedas.Controls.Add(this.pictureBox1);
            this.gpbMoedas.Location = new System.Drawing.Point(8, 74);
            this.gpbMoedas.Name = "gpbMoedas";
            this.gpbMoedas.Size = new System.Drawing.Size(506, 324);
            this.gpbMoedas.TabIndex = 1;
            this.gpbMoedas.TabStop = false;
            // 
            // lblValorThether
            // 
            this.lblValorThether.AutoSize = true;
            this.lblValorThether.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorThether.Location = new System.Drawing.Point(433, 269);
            this.lblValorThether.Name = "lblValorThether";
            this.lblValorThether.Size = new System.Drawing.Size(48, 25);
            this.lblValorThether.TabIndex = 9;
            this.lblValorThether.Text = "240";
            // 
            // lblValorStellar
            // 
            this.lblValorStellar.AutoSize = true;
            this.lblValorStellar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorStellar.Location = new System.Drawing.Point(433, 211);
            this.lblValorStellar.Name = "lblValorStellar";
            this.lblValorStellar.Size = new System.Drawing.Size(48, 25);
            this.lblValorStellar.TabIndex = 8;
            this.lblValorStellar.Text = "190";
            // 
            // lblValorMonero
            // 
            this.lblValorMonero.AutoSize = true;
            this.lblValorMonero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMonero.Location = new System.Drawing.Point(433, 161);
            this.lblValorMonero.Name = "lblValorMonero";
            this.lblValorMonero.Size = new System.Drawing.Size(48, 25);
            this.lblValorMonero.TabIndex = 7;
            this.lblValorMonero.Text = "280";
            // 
            // lblValorEthereum
            // 
            this.lblValorEthereum.AutoSize = true;
            this.lblValorEthereum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorEthereum.Location = new System.Drawing.Point(433, 111);
            this.lblValorEthereum.Name = "lblValorEthereum";
            this.lblValorEthereum.Size = new System.Drawing.Size(48, 25);
            this.lblValorEthereum.TabIndex = 6;
            this.lblValorEthereum.Text = "300";
            // 
            // lblValorBitcoin
            // 
            this.lblValorBitcoin.AutoSize = true;
            this.lblValorBitcoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBitcoin.Location = new System.Drawing.Point(433, 57);
            this.lblValorBitcoin.Name = "lblValorBitcoin";
            this.lblValorBitcoin.Size = new System.Drawing.Size(48, 25);
            this.lblValorBitcoin.TabIndex = 5;
            this.lblValorBitcoin.Text = "480";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Venda.Properties.Resources.Tether;
            this.pictureBox5.Location = new System.Drawing.Point(12, 242);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Venda.Properties.Resources.Stellar;
            this.pictureBox4.Location = new System.Drawing.Point(12, 192);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Venda.Properties.Resources.Monero;
            this.pictureBox3.Location = new System.Drawing.Point(17, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Venda.Properties.Resources.Ethereum;
            this.pictureBox2.Location = new System.Drawing.Point(29, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Venda.Properties.Resources.Bitcoin;
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gpbSelecione
            // 
            this.gpbSelecione.Controls.Add(this.lblSelecione);
            this.gpbSelecione.Location = new System.Drawing.Point(8, 6);
            this.gpbSelecione.Name = "gpbSelecione";
            this.gpbSelecione.Size = new System.Drawing.Size(1160, 62);
            this.gpbSelecione.TabIndex = 0;
            this.gpbSelecione.TabStop = false;
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.Location = new System.Drawing.Point(6, 16);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(293, 29);
            this.lblSelecione.TabIndex = 0;
            this.lblSelecione.Text = "Criptomoedas disponiveis";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvlRelatorio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1176, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Relatório";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvlRelatorio
            // 
            this.lvlRelatorio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvlRelatorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhIDcli,
            this.clhNome,
            this.clhQuant,
            this.clhValor,
            this.clhData,
            this.clhHora});
            this.lvlRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlRelatorio.FullRowSelect = true;
            this.lvlRelatorio.GridLines = true;
            this.lvlRelatorio.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvlRelatorio.HideSelection = false;
            this.lvlRelatorio.Location = new System.Drawing.Point(245, 84);
            this.lvlRelatorio.Name = "lvlRelatorio";
            this.lvlRelatorio.Size = new System.Drawing.Size(659, 488);
            this.lvlRelatorio.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvlRelatorio.TabIndex = 0;
            this.lvlRelatorio.UseCompatibleStateImageBehavior = false;
            this.lvlRelatorio.View = System.Windows.Forms.View.Details;
            // 
            // clhIDcli
            // 
            this.clhIDcli.Text = "ID cliente";
            this.clhIDcli.Width = 126;
            // 
            // clhNome
            // 
            this.clhNome.Text = "Moeda";
            this.clhNome.Width = 101;
            // 
            // clhQuant
            // 
            this.clhQuant.Text = "Quantidade";
            this.clhQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhQuant.Width = 82;
            // 
            // clhValor
            // 
            this.clhValor.Text = "Valor";
            this.clhValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhValor.Width = 125;
            // 
            // clhData
            // 
            this.clhData.Text = "Data";
            this.clhData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhData.Width = 102;
            // 
            // clhHora
            // 
            this.clhHora.Text = "Horário";
            this.clhHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhHora.Width = 119;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 705);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVenda";
            this.Text = "Tescore";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbMoedas.ResumeLayout(false);
            this.gpbMoedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbSelecione.ResumeLayout(false);
            this.gpbSelecione.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gpbMoedas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbSelecione;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMoeda;
        private System.Windows.Forms.TextBox txtIDcli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.TextBox txtReais;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ListView lvlRelatorio;
        private System.Windows.Forms.ColumnHeader clhIDcli;
        private System.Windows.Forms.ColumnHeader clhNome;
        private System.Windows.Forms.ColumnHeader clhValor;
        private System.Windows.Forms.ColumnHeader clhData;
        private System.Windows.Forms.ColumnHeader clhHora;
        private System.Windows.Forms.Label lblValorBitcoin;
        private System.Windows.Forms.Label lblValorMonero;
        private System.Windows.Forms.Label lblValorEthereum;
        private System.Windows.Forms.Label lblValorThether;
        private System.Windows.Forms.Label lblValorStellar;
        private System.Windows.Forms.ColumnHeader clhQuant;
        private System.Windows.Forms.Button btnLimpar;
    }
}

