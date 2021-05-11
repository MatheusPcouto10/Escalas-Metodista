﻿using EscalasMetodista.Conexão;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalasMetodista.Views.Escalas
{
    public partial class FormEscala : Form
    {
        public int tipoEscala;
        SqlCommand cmd = new SqlCommand();
        private Label funcao, datas;
        public DateTime dataInicio, dataFim;
        public TimeSpan dias;
        public String intervaloEscala;

        public FormEscala()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair? Você pode perder todo o trabalho feito.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void FormEscalaLouvor_Load(object sender, EventArgs e)
        {
            carregarCabecalhoEscala();
            lbNomeEscala.Left = (this.Width - lbNomeEscala.Width) / 2;
            txtNomeEscala.Left = (this.Width - txtNomeEscala.Width) / 2;
        }

        private void carregarCabecalhoEscala()
        {
            cmd.CommandText = "SELECT descricao FROM SubFuncao WHERE idFuncao_fk = " + tipoEscala;
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;

                while (dr.Read())
                {
                    tbEscala.SuspendLayout();
                    funcao = new Label();
                    funcao.Name = "coluna" + dr[0].ToString();
                    funcao.Text = dr[0].ToString();
                    funcao.ForeColor = Color.White;
                    funcao.BackColor = Color.Transparent;
                    funcao.TextAlign = ContentAlignment.MiddleCenter;
                    funcao.Dock = DockStyle.Fill;
                    tbEscala.Controls.Add(funcao);
                    tbEscala.ResumeLayout();
                    i++;
                }

                carregarTbDatasEscala();
                tbEscala.Refresh();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void carregarTbDatasEscala()
        {
            int i = 1;
            while (dataInicio <= dataFim)
            {
                tbEscala.SuspendLayout();
                tbEscala.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
                tbEscala.RowStyles.Add(new RowStyle(SizeType.Absolute, 68));
                datas = new Label();
                datas.Name = "data";
                datas.Text = dataInicio.ToString("dd/MM");
                datas.TextAlign = ContentAlignment.MiddleCenter;
                datas.ForeColor = Color.Black;
                datas.BackColor = Color.Transparent;
                datas.TextAlign = ContentAlignment.MiddleCenter;
                datas.Anchor = Anchor = (AnchorStyles.Top | AnchorStyles.Bottom);
                tbEscala.Controls.Add(datas, 0, i);
                dataInicio = dataInicio.AddDays(1);
                //tbEscalas.RowCount++;
                i++;
                tbEscala.ResumeLayout();
            }
        }

        private void FormEscalaLouvor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.editarNomeEscala();
                    break;
                default:
                    break;
            }
        }

        private void tbEscala_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Graphics g = tbEscala.CreateGraphics();

            if (e.Column == 0 && e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            }

            else if (e.Column == 0 && e.Row > 0)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, e.CellBounds);
                g.DrawRectangle(new Pen(Brushes.Black, 2.0f), e.CellBounds);
            }

            else if (e.Row == 0 && e.Column > 0)
            {
                e.Graphics.FillRectangle(Brushes.Maroon, e.CellBounds);
                g.DrawRectangle(new Pen(Brushes.Black, 2.0f), e.CellBounds);
            }

            else if (e.Row > 0 && e.Column > 0)
            {
                g.DrawRectangle(new Pen(Brushes.DarkGray, 0.5f), e.CellBounds);
            }
        }

        private void lbNomeEscala_DoubleClick(object sender, EventArgs e)
        {
            txtNomeEscala.Visible = true;
            lbNomeEscala.Visible = false;
        }

        private void editarNomeEscala()
        {
            if (string.IsNullOrWhiteSpace(txtNomeEscala.Text))
            {
                MessageBox.Show("O nome da escala não pode ficar em branco.", "Campo em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbNomeEscala.Text = txtNomeEscala.Text;
                txtNomeEscala.Visible = false;
                lbNomeEscala.Visible = true;
                lbNomeEscala.Left = (this.Width - lbNomeEscala.Width) / 2;
                txtNomeEscala.Left = (this.Width - txtNomeEscala.Width) / 2;
            }
        }
    }
}

