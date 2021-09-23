﻿using EscalasMetodista.Session;
using EscalasMetodista.Views;
using EscalasMetodista.Views.Escalas;
using EscalasMetodista.Views.Funcoes;
using EscalasMetodista.Views.Outros;
using EscalasMetodista.Views.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalasMetodista
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void controleAcesso()
        {
            if (UsuarioSession.tipoUsuario.Equals(2))
            {
                btnFuncoesMenu.Visible = false;
                btnUsuariosMenu.Visible = false;
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            DateTime dataHoje = DateTime.Today;
            btnPerfil.Text = UsuarioSession.nomeUsuario + " " + UsuarioSession.sobrenomeUsuario;
            labelIdUsuarioLogado.Text = "Código: " + UsuarioSession.idUsuario;
            labelData.Text = "Data: " + dataHoje.ToString("D");
            controleAcesso();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgEscalas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgEscalas.Columns)
            {
                switch (coluna.Name)
                {
                    case "descricao":
                        coluna.Width = 100;
                        coluna.HeaderText = "Arquivo";
                        break;
                    case "dataAlteracao":
                        coluna.Width = 50;
                        coluna.HeaderText = "Última Alteração";
                        break;
                    default:
                        break;
                }
            }
        }

        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    //this.btnPesquisa(null, null);
                    break;
                case Keys.Escape:
                    this.btnSair_Click(null, null);
                    break;
                default:
                    break;
            }
        }


        private void btnEscalaMenu_Click(object sender, EventArgs e)
        {
            FormPersonalizarEscala form = new FormPersonalizarEscala();
            form.Show();
        }

        private void btnUsuariosMenu_Click(object sender, EventArgs e)
        {
            FormCadastrarUsuario form = new FormCadastrarUsuario();
            form.Show();
        }

        private void btnFuncoesMenu_Click(object sender, EventArgs e)
        {
            dropBtnFuncoes.Show(btnFuncoesMenu, new Point(0, btnFuncoesMenu.Height));
        }

        private void btnAjudaMenu_Click(object sender, EventArgs e)
        {
            FormAjuda form = new FormAjuda();
            form.ShowDialog();
        }

        private void btnSobreMenu_Click(object sender, EventArgs e)
        {
            FormSobre form = new FormSobre();
            form.ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            dropBtnPerfil.Show(btnPerfil, new Point(0, btnPerfil.Height));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormLogin form = new FormLogin();
                form.Show();
                this.Hide();
            }
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            FormCadastrarUsuario form = new FormCadastrarUsuario(UsuarioSession.idUsuario);
            form.cbFuncaoPrincipal.Enabled = false;
            form.cbFuncaoSecundaria.Enabled = false;
            form.cbSubFuncaoPrincipal.Enabled = false;
            form.cbSubFuncaoSecundaria.Enabled = false;
            form.cbTipoUsuario.Enabled = false;
            form.btnDeletar.Visible = false;
            form.btnLimparForm.Visible = false;
            form.btnConsultarUsuario.Visible = false;
            form.btnSalvar.Left = (form.Width - form.btnSalvar.Width) / 2;
            form.lbTitulo.Text = "EDITAR PERFIL";
            form.Text = "Editar Perfil";
            form.lbTitulo.Left = (form.Width - form.lbTitulo.Width) / 2;
            form.btnLimparFuncaoPrincipal.Visible = false;
            form.btnLimparFuncaoSecundaria.Visible = false;
            form.ShowDialog();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            FormAlterarSenha form = new FormAlterarSenha();
            form.ShowDialog();
        }

        private void btnFuncoes_Click(object sender, EventArgs e)
        {
            FormGerenciarFuncao form = new FormGerenciarFuncao();
            form.Show();
        }

        private void btnSubFuncoes_Click(object sender, EventArgs e)
        {
            FormGerenciarSubfuncoes form = new FormGerenciarSubfuncoes();
            form.Show();
        }

    }
}
