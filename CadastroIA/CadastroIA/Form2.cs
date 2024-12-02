using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroIA
{
    public partial class Form2 : Form
    {
        int valor = 0;
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Desktop\Desktop\2024 - 2º MDS\DS\4º BIM\ProjetoIA_Final_Lucas_MatheusPereira\CadastroIA\CadastroIA\bd_IAs.mdf;Integrated Security=True;Connect Timeout=30";
        public Form2()
        {
            InitializeComponent();
            FormSplashScreen frmSplashScreen = new FormSplashScreen();

            frmSplashScreen.ShowDialog();
            Thread.Sleep(1);
        }

        private void nmVoltarCadastrarIAs_Click(object sender, EventArgs e)
        {
            Form1 OutroForm = new Form1();
            OutroForm.Show();
            Hide();
        }

        private void btnSairCategoriaFabricante_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarCategoriaFabricante_Click(object sender, EventArgs e)
        {
            txtCodigoCategoria.ReadOnly = true;
            txtCodigoCategoria.Enabled = false;
            txtCodigoFabricante.ReadOnly = true;
            txtCodigoFabricante.Enabled = false;
            txtNomeCategoria.Enabled = false;
            txtNomeFabricante.Enabled = false;
            txtDescricaoCategoria.Enabled = false;
            txtProprietarioFabricante.Enabled = false;
            txtPaisOrigemFabricante.Enabled = false;
            btnCadastrarCategoriaFabricante.Enabled = false;
            btnExcluirCategoriaFabricante.Enabled = true;
            btnAlterarCategoriaFabricante.Enabled = true;
            btnSairCategoriaFabricante.Enabled = true;
            btnAnteriorCategoriaFabricante.Enabled = true;
            btnPosteriorCategoriaFabricante.Enabled = true;
            btnPrimeiroCategoriaFabricante.Enabled = true;
            btnUltimoCategoriaFabricante.Enabled = true;
            btnConfirmarAlteracoes.Enabled = false;
            nmVoltarCadastrarIAs.Enabled = true;

            string categoria = txtNomeCategoria.Text;
            string descricao = txtDescricaoCategoria.Text;
            string fabricante = txtNomeFabricante.Text;
            string proprietario = txtProprietarioFabricante.Text;
            string origem = txtPaisOrigemFabricante.Text;

            string sql = "INSERT INTO CategoriaFabricante(fk_CategoriaNome, ds_Categoria, fk_FabricanteNome, Proprietario_Fabricante, Pais_Origem_Fabricante) VALUES(@categoria, @descricao, @fabricante, @proprietario, @origem)";

            using (SqlConnection conexao = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@fabricante", fabricante);
                cmd.Parameters.AddWithValue("@proprietario", proprietario);
                cmd.Parameters.AddWithValue("@origem", origem);
                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    txtNomeCategoria.Text = "";
                    txtNomeFabricante.Text = "";
                    txtDescricaoCategoria.Text = "";
                    txtProprietarioFabricante.Text = "";
                    txtPaisOrigemFabricante.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }
                MessageBox.Show("Cadastro concluído!");
            }
        }

        private void btnPosteriorCategoriaFabricante_Click(object sender, EventArgs e)
        {
            valor++;

            txtCodigoCategoria.ReadOnly = true;
            txtCodigoCategoria.Enabled = false;
            txtCodigoFabricante.ReadOnly = true;
            txtCodigoFabricante.Enabled = false;
            txtNomeCategoria.Enabled = false;
            txtNomeFabricante.Enabled = false;
            txtDescricaoCategoria.Enabled = false;
            txtProprietarioFabricante.Enabled = false;
            txtPaisOrigemFabricante.Enabled = false;

            using (SqlConnection conexao = new SqlConnection(conn))
            {
                string sql = "SELECT * FROM CategoriaFabricante WHERE id_CategoriaFabricante = @valor";
                SqlCommand pesq = new SqlCommand(sql, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);
                try
                {
                    conexao.Open();
                    SqlDataReader reader = pesq.ExecuteReader();
                    if (reader.Read())
                    {
                        txtCodigoCategoria.Text = reader["id_CategoriaFabricante"].ToString();
                        txtCodigoFabricante.Text = reader["id_CategoriaFabricante"].ToString();
                        txtNomeCategoria.Text = reader["fk_CategoriaNome"].ToString();
                        txtDescricaoCategoria.Text = reader["ds_Categoria"].ToString();
                        txtNomeFabricante.Text = reader["fk_FabricanteNome"].ToString();
                        txtProprietarioFabricante.Text = reader["Proprietario_Fabricante"].ToString();
                        txtPaisOrigemFabricante.Text = reader["Pais_Origem_Fabricante"].ToString();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro: " + err.Message);
                }
            }
        }

        private void BtnAnteriorCategoriaFabricante_Click(object sender, EventArgs e)
        {
            valor--;
            if (valor < 1)
            {
                valor = 1;
            };

            txtCodigoCategoria.ReadOnly = true;
            txtCodigoCategoria.Enabled = false;
            txtCodigoFabricante.ReadOnly = true;
            txtCodigoFabricante.Enabled = false;
            txtNomeCategoria.Enabled = false;
            txtNomeFabricante.Enabled = false;
            txtDescricaoCategoria.Enabled = false;
            txtProprietarioFabricante.Enabled = false;
            txtPaisOrigemFabricante.Enabled = false;

            using (SqlConnection conexao = new SqlConnection(conn))
            {
                string sql = "SELECT * FROM CategoriaFabricante WHERE id_CategoriaFabricante = @valor";
                SqlCommand pesq = new SqlCommand(sql, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);
                try
                {
                    conexao.Open();
                    SqlDataReader reader = pesq.ExecuteReader();
                    if (reader.Read())
                    {
                        txtCodigoCategoria.Text = reader["id_CategoriaFabricante"].ToString();
                        txtCodigoFabricante.Text = reader["id_CategoriaFabricante"].ToString();
                        txtNomeCategoria.Text = reader["fk_CategoriaNome"].ToString();
                        txtDescricaoCategoria.Text = reader["ds_Categoria"].ToString();
                        txtNomeFabricante.Text = reader["fk_FabricanteNome"].ToString();
                        txtProprietarioFabricante.Text = reader["Proprietario_Fabricante"].ToString();
                        txtPaisOrigemFabricante.Text = reader["Pais_Origem_Fabricante"].ToString();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro: " + err.Message);
                }
            }

        }

        private void BtnPrimeiroCategoriaFabricante_Click(object sender, EventArgs e)
        {
            valor = 1;
            txtCodigoCategoria.ReadOnly = true;
            txtCodigoCategoria.Enabled = false;
            txtCodigoFabricante.ReadOnly = true;
            txtCodigoFabricante.Enabled = false;
            txtNomeCategoria.Enabled = false;
            txtNomeFabricante.Enabled = false;
            txtDescricaoCategoria.Enabled = false;
            txtProprietarioFabricante.Enabled = false;
            txtPaisOrigemFabricante.Enabled = false;

            using (SqlConnection conexao = new SqlConnection(conn))
            {
                string sql = "SELECT * FROM CategoriaFabricante WHERE id_CategoriaFabricante = @valor";
                SqlCommand pesq = new SqlCommand(sql, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);
                try
                {
                    conexao.Open();
                    SqlDataReader reader = pesq.ExecuteReader();
                    if (reader.Read())
                    {
                        txtCodigoCategoria.Text = reader["id_CategoriaFabricante"].ToString();
                        txtCodigoFabricante.Text = reader["id_CategoriaFabricante"].ToString();
                        txtNomeCategoria.Text = reader["fk_CategoriaNome"].ToString();
                        txtDescricaoCategoria.Text = reader["ds_Categoria"].ToString();
                        txtNomeFabricante.Text = reader["fk_FabricanteNome"].ToString();
                        txtProprietarioFabricante.Text = reader["Proprietario_Fabricante"].ToString();
                        txtPaisOrigemFabricante.Text = reader["Pais_Origem_Fabricante"].ToString();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro: " + err.Message);
                }
            }

        }

        private void BtnUltimoCategoriaFabricante_Click(object sender, EventArgs e)
        {
            txtCodigoCategoria.ReadOnly = true;
            txtCodigoCategoria.Enabled = false;
            txtCodigoFabricante.ReadOnly = true;
            txtCodigoFabricante.Enabled = false;
            txtNomeCategoria.Enabled = false;
            txtNomeFabricante.Enabled = false;
            txtDescricaoCategoria.Enabled = false;
            txtProprietarioFabricante.Enabled = false;
            txtPaisOrigemFabricante.Enabled = false;

            using (SqlConnection conexao = new SqlConnection(conn))
            {
                string sqlMaxId = "SELECT MAX(id_CategoriaFabricante) FROM CategoriaFabricante";
                SqlCommand cmdMaxId = new SqlCommand(sqlMaxId, conexao);

                try
                {
                    conexao.Open();
                    object result = cmdMaxId.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int maxId = Convert.ToInt32(result);
                        txtCodigoCategoria.Text = maxId.ToString();
                        txtCodigoFabricante.Text = maxId.ToString();
                        valor = maxId;

                        string sqlDetalhes = "SELECT fk_CategoriaNome, ds_Categoria, fk_FabricanteNome, Proprietario_Fabricante, Pais_Origem_Fabricante FROM CategoriaFabricante WHERE id_CategoriaFabricante = @id_CategoriaFabricante";
                        SqlCommand cmdDetalhes = new SqlCommand(sqlDetalhes, conexao);
                        cmdDetalhes.Parameters.AddWithValue("@id_CategoriaFabricante", maxId);

                        SqlDataReader reader = cmdDetalhes.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeCategoria.Text = reader["fk_CategoriaNome"].ToString();
                            txtDescricaoCategoria.Text = reader["ds_Categoria"].ToString();
                            txtNomeFabricante.Text = reader["fk_FabricanteNome"].ToString();
                            txtProprietarioFabricante.Text = reader["Proprietario_Fabricante"].ToString();
                            txtPaisOrigemFabricante.Text = reader["Pais_Origem_Fabricante"].ToString();

                            MessageBox.Show("IA encontrada com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("IA não encontrada.");
                        }

                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro ao buscar o registro: " + err.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }

        }

        private void BtnExcluirCategoriaFabricante_Click(object sender, EventArgs e)
        {
            txtCodigoCategoria.ReadOnly = true;
            txtCodigoCategoria.Enabled = false;
            txtCodigoFabricante.ReadOnly = true;
            txtCodigoFabricante.Enabled = false;
            txtNomeCategoria.Enabled = false;
            txtNomeFabricante.Enabled = false;
            txtDescricaoCategoria.Enabled = false;
            txtProprietarioFabricante.Enabled = false;
            txtPaisOrigemFabricante.Enabled = false;

            if (string.IsNullOrWhiteSpace(txtCodigoCategoria.Text))
            {
                MessageBox.Show("Nenhum registro selecionado para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmar = MessageBox.Show("Tem certeza de que deseja remover este registro?", "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                using (SqlConnection conexao = new SqlConnection(conn))
                {
                    string sql = "DELETE FROM CategoriaFabricante WHERE id_CategoriaFabricante = @codigo1";
                    SqlCommand cmd = new SqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@codigo1", txtCodigoCategoria.Text);

                    string sql2 = "DELETE FROM CategoriaFabricante WHERE id_CategoriaFabricante = @codigo2";
                    SqlCommand cmd2 = new SqlCommand(sql2, conexao);
                    cmd.Parameters.AddWithValue("@codigo2", txtCodigoFabricante.Text);

                    try
                    {
                        conexao.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro removido com sucesso!");
                            txtCodigoCategoria.Clear();
                            txtCodigoFabricante.Clear();
                            txtNomeCategoria.Clear();
                            txtNomeFabricante.Clear();
                            txtDescricaoCategoria.Clear();
                            txtProprietarioFabricante.Clear();
                            txtPaisOrigemFabricante.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Registro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao remover registro: " + ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
        }

        private void BtnAlterarCategoriaFabricante_Click(object sender, EventArgs e)
        {
            txtCodigoCategoria.ReadOnly = true;
            txtCodigoCategoria.Enabled = false;
            txtCodigoFabricante.ReadOnly = true;
            txtCodigoFabricante.Enabled = false;
            txtNomeCategoria.Enabled = false;
            txtNomeFabricante.Enabled = false;
            txtDescricaoCategoria.Enabled = true;
            txtProprietarioFabricante.Enabled = true;
            txtPaisOrigemFabricante.Enabled = true;
            btnCadastrarCategoriaFabricante.Enabled = false;
            btnExcluirCategoriaFabricante.Enabled = false;
            btnAlterarCategoriaFabricante.Enabled = false;
            btnSairCategoriaFabricante.Enabled = true;
            btnAnteriorCategoriaFabricante.Enabled = false;
            btnPosteriorCategoriaFabricante.Enabled = false;
            btnPrimeiroCategoriaFabricante.Enabled = false;
            btnUltimoCategoriaFabricante.Enabled = false;
            btnConfirmarAlteracoes.Enabled = false;
            btnConfirmarAlteracoes.Enabled = true;

            MessageBox.Show("Para confirmar a alteração, clique em 'Confirmar Alterações'.");
        }

        private void BtnConfirmarAlteracoesCategoria_Click(object sender, EventArgs e)
        {
            txtCodigoCategoria.ReadOnly = true;
            txtCodigoCategoria.Enabled = false;
            txtCodigoFabricante.ReadOnly = true;
            txtCodigoFabricante.Enabled = false;
            txtNomeCategoria.Enabled = false;
            txtNomeFabricante.Enabled = false;
            txtDescricaoCategoria.Enabled = false;
            txtProprietarioFabricante.Enabled = false;
            txtPaisOrigemFabricante.Enabled = false;
            btnConfirmarAlteracoes.Enabled = false;
            btnCadastrarCategoriaFabricante.Enabled = false;
            btnExcluirCategoriaFabricante.Enabled = true;
            btnAlterarCategoriaFabricante.Enabled = true;
            btnSairCategoriaFabricante.Enabled = true;
            btnAnteriorCategoriaFabricante.Enabled = true;
            btnPosteriorCategoriaFabricante.Enabled = true;
            btnPrimeiroCategoriaFabricante.Enabled = true;
            btnUltimoCategoriaFabricante.Enabled = true;

            string categoria = txtNomeCategoria.Text;
            string descricao = txtDescricaoCategoria.Text;
            string fabricante = txtNomeFabricante.Text;
            string proprietario = txtProprietarioFabricante.Text;
            string origem = txtPaisOrigemFabricante.Text;

            using (SqlConnection conexao = new SqlConnection(conn))
            {
                string idmin = "UPDATE CategoriaFabricante SET fk_CategoriaNome = @categoria, ds_Categoria = @descricao, fk_FabricanteNome = @fabricante, Proprietario_Fabricante = @proprietario, Pais_Origem_Fabricante = @origem WHERE id_CategoriaFabricante = @valor";
                SqlCommand cmd = new SqlCommand(idmin, conexao);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@fabricante", fabricante);
                cmd.Parameters.AddWithValue("@proprietario", proprietario);
                cmd.Parameters.AddWithValue("@origem", origem);

                MessageBox.Show("A alteração foi registrada.");

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void TxtCodigoCategoria_TextChanged(object sender, EventArgs e)
        {
            txtCodigoCategoria.Text = Convert.ToString(valor);
        }
    }
}
