﻿
namespace EscalasMetodista.Views.Escalas
{
    partial class FormEscala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEscala));
            this.panel_botoes = new System.Windows.Forms.Panel();
            this.txtNomeEscala = new System.Windows.Forms.TextBox();
            this.lbNomeEscala = new System.Windows.Forms.Label();
            this.logo_metodista = new System.Windows.Forms.PictureBox();
            this.menuEscala = new System.Windows.Forms.ToolStrip();
            this.btnSalvarEscala = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvarEscalaComo = new System.Windows.Forms.ToolStripDropDownButton();
            this.planilhaxlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPreencherEscala = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnPreencherEscalaLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPreencherColuna = new System.Windows.Forms.ToolStripMenuItem();
            this.preencherTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.btnLimparEscala = new System.Windows.Forms.ToolStripDropDownButton();
            this.limparLinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparColunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdicionar = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbDatasEscala = new System.Windows.Forms.TableLayoutPanel();
            this.lbDataInicial = new System.Windows.Forms.Label();
            this.tbCabecalhoEscala = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPessoasEscala = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_metodista)).BeginInit();
            this.menuEscala.SuspendLayout();
            this.tbDatasEscala.SuspendLayout();
            this.tbCabecalhoEscala.SuspendLayout();
            this.tbPessoasEscala.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_botoes
            // 
            this.panel_botoes.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel_botoes.BackgroundImage = global::EscalasMetodista.Properties.Resources._2741104;
            this.panel_botoes.Controls.Add(this.txtNomeEscala);
            this.panel_botoes.Controls.Add(this.lbNomeEscala);
            this.panel_botoes.Controls.Add(this.logo_metodista);
            this.panel_botoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_botoes.Location = new System.Drawing.Point(0, 0);
            this.panel_botoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_botoes.Name = "panel_botoes";
            this.panel_botoes.Size = new System.Drawing.Size(1958, 109);
            this.panel_botoes.TabIndex = 3;
            // 
            // txtNomeEscala
            // 
            this.txtNomeEscala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeEscala.BackColor = System.Drawing.Color.Black;
            this.txtNomeEscala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeEscala.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtNomeEscala.ForeColor = System.Drawing.Color.White;
            this.txtNomeEscala.Location = new System.Drawing.Point(831, 35);
            this.txtNomeEscala.MaxLength = 40;
            this.txtNomeEscala.Name = "txtNomeEscala";
            this.txtNomeEscala.Size = new System.Drawing.Size(205, 28);
            this.txtNomeEscala.TabIndex = 5;
            this.txtNomeEscala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeEscala.Visible = false;
            // 
            // lbNomeEscala
            // 
            this.lbNomeEscala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNomeEscala.AutoSize = true;
            this.lbNomeEscala.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeEscala.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeEscala.ForeColor = System.Drawing.Color.White;
            this.lbNomeEscala.Location = new System.Drawing.Point(831, 35);
            this.lbNomeEscala.Name = "lbNomeEscala";
            this.lbNomeEscala.Size = new System.Drawing.Size(203, 29);
            this.lbNomeEscala.TabIndex = 7;
            this.lbNomeEscala.Text = "NOME ESCALA";
            this.lbNomeEscala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNomeEscala.DoubleClick += new System.EventHandler(this.lbNomeEscala_DoubleClick);
            // 
            // logo_metodista
            // 
            this.logo_metodista.BackColor = System.Drawing.Color.Transparent;
            this.logo_metodista.Image = global::EscalasMetodista.Properties.Resources._006;
            this.logo_metodista.Location = new System.Drawing.Point(12, 11);
            this.logo_metodista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo_metodista.Name = "logo_metodista";
            this.logo_metodista.Size = new System.Drawing.Size(168, 86);
            this.logo_metodista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_metodista.TabIndex = 4;
            this.logo_metodista.TabStop = false;
            // 
            // menuEscala
            // 
            this.menuEscala.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuEscala.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuEscala.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuEscala.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvarEscala,
            this.toolStripSeparator3,
            this.btnSalvarEscalaComo,
            this.toolStripSeparator2,
            this.btnImprimir,
            this.toolStripSeparator1,
            this.btnPreencherEscala,
            this.toolStripSeparator6,
            this.btnVoltar,
            this.btnLimparEscala,
            this.toolStripSeparator4,
            this.btnAdicionar});
            this.menuEscala.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuEscala.Location = new System.Drawing.Point(0, 109);
            this.menuEscala.Name = "menuEscala";
            this.menuEscala.Size = new System.Drawing.Size(1958, 25);
            this.menuEscala.Stretch = true;
            this.menuEscala.TabIndex = 7;
            // 
            // btnSalvarEscala
            // 
            this.btnSalvarEscala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalvarEscala.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvarEscala.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarEscala.Image")));
            this.btnSalvarEscala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarEscala.Name = "btnSalvarEscala";
            this.btnSalvarEscala.Size = new System.Drawing.Size(65, 22);
            this.btnSalvarEscala.Text = "Salvar ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // btnSalvarEscalaComo
            // 
            this.btnSalvarEscalaComo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planilhaxlsToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.btnSalvarEscalaComo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvarEscalaComo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarEscalaComo.Name = "btnSalvarEscalaComo";
            this.btnSalvarEscalaComo.Size = new System.Drawing.Size(120, 28);
            this.btnSalvarEscalaComo.Text = "Salvar Como";
            // 
            // planilhaxlsToolStripMenuItem
            // 
            this.planilhaxlsToolStripMenuItem.Name = "planilhaxlsToolStripMenuItem";
            this.planilhaxlsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.planilhaxlsToolStripMenuItem.Text = "Planilha (.xls)";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.pDFToolStripMenuItem.Text = "PDF";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnImprimir
            // 
            this.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnImprimir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 28);
            this.btnImprimir.Text = "Imprimir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnPreencherEscala
            // 
            this.btnPreencherEscala.BackColor = System.Drawing.Color.Transparent;
            this.btnPreencherEscala.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPreencherEscalaLinha,
            this.btnPreencherColuna,
            this.preencherTudoToolStripMenuItem});
            this.btnPreencherEscala.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPreencherEscala.Name = "btnPreencherEscala";
            this.btnPreencherEscala.Size = new System.Drawing.Size(154, 28);
            this.btnPreencherEscala.Text = "Preencher Escala";
            // 
            // btnPreencherEscalaLinha
            // 
            this.btnPreencherEscalaLinha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPreencherEscalaLinha.Name = "btnPreencherEscalaLinha";
            this.btnPreencherEscalaLinha.Size = new System.Drawing.Size(228, 26);
            this.btnPreencherEscalaLinha.Text = "Preencher Linha";
            // 
            // btnPreencherColuna
            // 
            this.btnPreencherColuna.Name = "btnPreencherColuna";
            this.btnPreencherColuna.Size = new System.Drawing.Size(228, 26);
            this.btnPreencherColuna.Text = "Preencher Coluna";
            // 
            // preencherTudoToolStripMenuItem
            // 
            this.preencherTudoToolStripMenuItem.Name = "preencherTudoToolStripMenuItem";
            this.preencherTudoToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.preencherTudoToolStripMenuItem.Text = "Preencher Tudo";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::EscalasMetodista.Properties.Resources.sair;
            this.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(79, 31);
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimparEscala
            // 
            this.btnLimparEscala.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparLinhaToolStripMenuItem,
            this.limparColunaToolStripMenuItem,
            this.limparTudoToolStripMenuItem});
            this.btnLimparEscala.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLimparEscala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimparEscala.Name = "btnLimparEscala";
            this.btnLimparEscala.Size = new System.Drawing.Size(128, 28);
            this.btnLimparEscala.Text = "Limpar Escala";
            // 
            // limparLinhaToolStripMenuItem
            // 
            this.limparLinhaToolStripMenuItem.Name = "limparLinhaToolStripMenuItem";
            this.limparLinhaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.limparLinhaToolStripMenuItem.Text = "Limpar Linha";
            // 
            // limparColunaToolStripMenuItem
            // 
            this.limparColunaToolStripMenuItem.Name = "limparColunaToolStripMenuItem";
            this.limparColunaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.limparColunaToolStripMenuItem.Text = "Limpar Coluna";
            // 
            // limparTudoToolStripMenuItem
            // 
            this.limparTudoToolStripMenuItem.Name = "limparTudoToolStripMenuItem";
            this.limparTudoToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.limparTudoToolStripMenuItem.Text = "Limpar Tudo";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.btnAdicionar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(95, 28);
            this.btnAdicionar.Text = "Adicionar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 26);
            this.toolStripMenuItem1.Text = "Adicionar Linha";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(222, 26);
            this.toolStripMenuItem2.Text = "Adicionar Coluna";
            // 
            // tbDatasEscala
            // 
            this.tbDatasEscala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDatasEscala.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbDatasEscala.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tbDatasEscala.ColumnCount = 1;
            this.tbDatasEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbDatasEscala.Controls.Add(this.lbDataInicial, 0, 0);
            this.tbDatasEscala.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.tbDatasEscala.Location = new System.Drawing.Point(0, 191);
            this.tbDatasEscala.Name = "tbDatasEscala";
            this.tbDatasEscala.RowCount = 11;
            this.tbDatasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbDatasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbDatasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbDatasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbDatasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbDatasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbDatasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbDatasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbDatasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbDatasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbDatasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbDatasEscala.Size = new System.Drawing.Size(150, 497);
            this.tbDatasEscala.TabIndex = 5;
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDataInicial.AutoSize = true;
            this.lbDataInicial.BackColor = System.Drawing.Color.Transparent;
            this.lbDataInicial.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lbDataInicial.ForeColor = System.Drawing.Color.Black;
            this.lbDataInicial.Location = new System.Drawing.Point(5, 2);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(140, 42);
            this.lbDataInicial.TabIndex = 6;
            this.lbDataInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCabecalhoEscala
            // 
            this.tbCabecalhoEscala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCabecalhoEscala.AutoScroll = true;
            this.tbCabecalhoEscala.AutoSize = true;
            this.tbCabecalhoEscala.BackColor = System.Drawing.Color.Maroon;
            this.tbCabecalhoEscala.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbCabecalhoEscala.ColumnCount = 10;
            this.tbCabecalhoEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tbCabecalhoEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbCabecalhoEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbCabecalhoEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbCabecalhoEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbCabecalhoEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbCabecalhoEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbCabecalhoEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbCabecalhoEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbCabecalhoEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbCabecalhoEscala.Controls.Add(this.label10, 0, 0);
            this.tbCabecalhoEscala.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCabecalhoEscala.ForeColor = System.Drawing.Color.White;
            this.tbCabecalhoEscala.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tbCabecalhoEscala.Location = new System.Drawing.Point(147, 131);
            this.tbCabecalhoEscala.Name = "tbCabecalhoEscala";
            this.tbCabecalhoEscala.RowCount = 1;
            this.tbCabecalhoEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbCabecalhoEscala.Size = new System.Drawing.Size(1811, 61);
            this.tbCabecalhoEscala.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(70, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 59);
            this.label10.TabIndex = 14;
            this.label10.Text = "Obs.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "DATA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPessoasEscala
            // 
            this.tbPessoasEscala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPessoasEscala.BackColor = System.Drawing.SystemColors.Control;
            this.tbPessoasEscala.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tbPessoasEscala.ColumnCount = 10;
            this.tbPessoasEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tbPessoasEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbPessoasEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbPessoasEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbPessoasEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbPessoasEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbPessoasEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbPessoasEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbPessoasEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbPessoasEscala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tbPessoasEscala.Controls.Add(this.label2, 0, 0);
            this.tbPessoasEscala.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.tbPessoasEscala.Location = new System.Drawing.Point(147, 191);
            this.tbPessoasEscala.Name = "tbPessoasEscala";
            this.tbPessoasEscala.RowCount = 11;
            this.tbPessoasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbPessoasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbPessoasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbPessoasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbPessoasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbPessoasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbPessoasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbPessoasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbPessoasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbPessoasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbPessoasEscala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tbPessoasEscala.Size = new System.Drawing.Size(1811, 497);
            this.tbPessoasEscala.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 42);
            this.label2.TabIndex = 6;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEscala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(50, 0);
            this.AutoScrollMinSize = new System.Drawing.Size(5, 0);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1958, 688);
            this.Controls.Add(this.tbPessoasEscala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuEscala);
            this.Controls.Add(this.tbCabecalhoEscala);
            this.Controls.Add(this.tbDatasEscala);
            this.Controls.Add(this.panel_botoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormEscala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEscalaLouvor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEscalaLouvor_KeyDown);
            this.panel_botoes.ResumeLayout(false);
            this.panel_botoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_metodista)).EndInit();
            this.menuEscala.ResumeLayout(false);
            this.menuEscala.PerformLayout();
            this.tbDatasEscala.ResumeLayout(false);
            this.tbDatasEscala.PerformLayout();
            this.tbCabecalhoEscala.ResumeLayout(false);
            this.tbCabecalhoEscala.PerformLayout();
            this.tbPessoasEscala.ResumeLayout(false);
            this.tbPessoasEscala.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_botoes;
        private System.Windows.Forms.PictureBox logo_metodista;
        private System.Windows.Forms.ToolStrip menuEscala;
        private System.Windows.Forms.ToolStripDropDownButton btnPreencherEscala;
        private System.Windows.Forms.ToolStripMenuItem btnPreencherEscalaLinha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton btnSalvarEscalaComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.ToolStripMenuItem btnPreencherColuna;
        private System.Windows.Forms.ToolStripButton btnSalvarEscala;
        private System.Windows.Forms.ToolStripDropDownButton btnLimparEscala;
        private System.Windows.Forms.ToolStripMenuItem limparLinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planilhaxlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txtNomeEscala;
        private System.Windows.Forms.ToolStripMenuItem preencherTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparColunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparTudoToolStripMenuItem;
        public System.Windows.Forms.Label lbNomeEscala;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton btnAdicionar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tbCabecalhoEscala;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TableLayoutPanel tbDatasEscala;
        private System.Windows.Forms.Label lbDataInicial;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TableLayoutPanel tbPessoasEscala;
        private System.Windows.Forms.Label label2;
    }
}