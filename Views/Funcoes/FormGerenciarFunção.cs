﻿using EscalasMetodista.Conexão;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalasMetodista.Views.Funcoes
{
    public partial class FormGerenciarFunção : Form
    {
        public int idFuncao;
        Conexao conexao = new Conexao();
        public FormGerenciarFunção()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                this.CarregarDataGrid();
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexao.Conectar();

                    cmd.CommandText = "SELECT * FROM funcao WHERE descricaoFuncao LIKE '%" + txtPesquisa.Text + "%'";

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgFuncoes.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhuma Função Encontrada"," ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                conexao.Desconectar();
            }
        }
        private void CarregarDataGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conectar();

                cmd.Connection = conexao.Conectar();
                cmd.CommandText = "SELECT * FROM funcao";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dgFuncoes.DataSource = dt; // Preenche o DataGridView
                }
                else
                {
                    MessageBox.Show("erro");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            conexao.Desconectar();
        }

        private void dgFuncoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificar qual a coluna clicada é a de editar
            if (dgFuncoes.Columns[e.ColumnIndex] == dgFuncoes.Columns["editar"])
            {
                // pegar o id para editar
                idFuncao = Convert.ToInt32(dgFuncoes.Rows[e.RowIndex].Cells["idFuncao"].Value.ToString());
            }
        }

        private void dgFuncoes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnPesquisa_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void dgFuncoes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgFuncoes.Columns)
            {
                switch (coluna.Name)
                {
                    case "idFuncao":
                        coluna.Width = 50;
                        coluna.HeaderText = "Código";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "descricaoFuncao":
                        coluna.Width = 420;
                        coluna.HeaderText = "Função";
                        break;
                    case "editar":
                        coluna.Width = 40;
                        coluna.DisplayIndex = 2;
                        break;
                    case "salvar":
                        coluna.Width = 40;
                        coluna.DisplayIndex = 3;
                        break;
                    default:
                        break;
                }
            }
        }

        private void FormGerenciarFunção_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
            salvar.Visible = false;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgFuncoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgFuncoes.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgFuncoes.Rows[e.RowIndex].Cells["salvar"].ToolTipText = "Clique aqui para salvar";
        }
    }
}
