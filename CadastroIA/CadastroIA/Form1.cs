using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace CadastroIA
{
    public partial class Form1 : Form
    {
        int valor = 0;
        private OpenFileDialog ofd = new OpenFileDialog();
        public Image picture;
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Desktop\Desktop\2024 - 2º MDS\DS\4º BIM\ProjetoIA_Final_Lucas_MatheusPereira\CadastroIA\CadastroIA\bd_IAs.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
            FormSplashScreen frmSplashScreen = new FormSplashScreen();

            frmSplashScreen.ShowDialog();
            Thread.Sleep(1);
        }
        private void nmCategoriaFabricante_Click(object sender, EventArgs e)
        {
            Form2 formCategoriaFabricante = new Form2();
            formCategoriaFabricante.Show();
            Hide();
        }
        private byte[] converterparacristao(Image picture)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                picture.Save(ms, picture.RawFormat);
                return ms.ToArray();
            }
        }
        private void BtnSelecionarArquivoIA_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.picture = Image.FromFile(ofd.FileName);
                this.pictureBox1.Image = picture;
            }
        }

        private void BtnCadastrarIA_Click(object sender, EventArgs e)
        {
            txtCodigoIA.ReadOnly = true;
            txtCodigoIA.Enabled = false;
            txtNomeIA.Enabled = false;
            txtAnoLancamentoIA.Enabled = false;
            txtFabricanteIA.Enabled = false;
            txtAparelhoIA.Enabled = false;
            txtCategoriaIA.Enabled = false;
            btnCadastrarIA.Enabled = false;
            btnExcluirIA.Enabled = true;
            btnAlterarIA.Enabled = true;
            btnSairIA.Enabled = false;
            btnAnteriorIA.Enabled = true;
            btnPosteriorIA.Enabled = true;
            btnPrimeiroIA.Enabled = true;
            btnUltimoIA.Enabled = true;
            btnSairIA.Enabled = true;
            btnConfirmarAlteracoesIA.Enabled = false;
            btnSelecionarArquivoIA.Enabled = false;
            nmCategoriaFabricante.Enabled = true;

            string nome = txtNomeIA.Text;
            string ano = txtAnoLancamentoIA.Text;
            string fabricante = txtFabricanteIA.Text;
            string aparelho = txtAparelhoIA.Text;
            string categoria = txtCategoriaIA.Text;

            string sql = "INSERT INTO IA(nm_IA, AnoLanc_IA, Logo_IA, Fabricante_IA, Aparelho_IA, Categoria_IA) VALUES(@nome, @ano, @logo, @fabricante, @aparelho, @categoria)";
            byte[] imagem = converterparacristao(picture);

            using (SqlConnection conexao = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand(sql, conexao);
                string result = function.datalanc(ano);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@ano", ano);
                cmd.Parameters.AddWithValue("@logo", imagem);
                cmd.Parameters.AddWithValue("@fabricante", fabricante);
                cmd.Parameters.AddWithValue("@aparelho", aparelho);
                cmd.Parameters.AddWithValue("@categoria", categoria);

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();

                    string sqlCategoria = "INSERT INTO CategoriaFabricante(fk_CategoriaNome, fk_FabricanteNome) VALUES(@fkCategoriaNome, @fkFabricanteNome)";
                    SqlCommand cmdCategoria = new SqlCommand(sqlCategoria, conexao);
                    cmdCategoria.Parameters.AddWithValue("@fkCategoriaNome", categoria);
                    cmdCategoria.Parameters.AddWithValue("@fkFabricanteNome", fabricante);
                    cmdCategoria.ExecuteNonQuery();

                    txtNomeIA.Text = "";
                    txtAnoLancamentoIA.Text = "";
                    txtFabricanteIA.Text = "";
                    txtAparelhoIA.Text = "";
                    txtCategoriaIA.Text = "";
                    pictureBox1.Hide();

                    MessageBox.Show("Cadastro concluído com sucesso!");
                    MessageBox.Show("Vá para o próximo form clicando no botão 'CategoriaFabricante' no canto esquerdo superior do form. Os botões deste form já estão habilitados.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }
            }
        }

        private void BtnPosteriorIA_Click(object sender, EventArgs e)
        {
            valor++;

            txtCodigoIA.ReadOnly = true;
            txtCodigoIA.Enabled = false;
            txtNomeIA.Enabled = false;
            txtAnoLancamentoIA.Enabled = false;
            txtFabricanteIA.Enabled = false;
            txtAparelhoIA.Enabled = false;
            txtCategoriaIA.Enabled = false;
            btnSelecionarArquivoIA.Enabled = false;
            btnConfirmarAlteracoesIA.Enabled = false;

            using (SqlConnection conexao = new SqlConnection(conn))
            {
                string sql = "SELECT * FROM IA WHERE id_IA = @valor";
                SqlCommand pesq = new SqlCommand(sql, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);
                try
                {
                    conexao.Open();
                    SqlDataReader reader = pesq.ExecuteReader();
                    if (reader.Read())
                    {
                        
                        txtCodigoIA.Text = reader["id_IA"].ToString();
                        txtNomeIA.Text = reader["nm_IA"].ToString();
                        txtAnoLancamentoIA.Text = reader["AnoLanc_IA"].ToString();
                        txtFabricanteIA.Text = reader["Fabricante_IA"].ToString();
                        txtAparelhoIA.Text = reader["Aparelho_IA"].ToString();
                        txtCategoriaIA.Text = reader["Categoria_IA"].ToString();
                        byte[] imageBytes = (byte[])reader["Logo_IA"];
                        pictureBox1.Show();
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro: " + err.Message);
                }
            }
        }

        private void BtnAnteriorIA_Click(object sender, EventArgs e)
        {
            valor--;
            if(valor < 1) {
                valor = 1;
            };

            txtCodigoIA.ReadOnly = true;
            txtCodigoIA.Enabled = false;
            txtNomeIA.Enabled = false;
            txtAnoLancamentoIA.Enabled = false;
            txtFabricanteIA.Enabled = false;
            txtAparelhoIA.Enabled = false;
            txtCategoriaIA.Enabled = false;
            btnSelecionarArquivoIA.Enabled = false;

            using (SqlConnection conexao = new SqlConnection(conn))
            {
                string sql = "SELECT * FROM IA WHERE id_IA = @valor";
                SqlCommand pesq = new SqlCommand(sql, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);
                try
                {
                    conexao.Open();
                    SqlDataReader reader = pesq.ExecuteReader();
                    if (reader.Read())
                    {
                        txtCodigoIA.Text = reader["id_IA"].ToString();
                        txtNomeIA.Text = reader["nm_IA"].ToString();
                        txtAnoLancamentoIA.Text = reader["AnoLanc_IA"].ToString();
                        txtFabricanteIA.Text = reader["Fabricante_IA"].ToString();
                        txtAparelhoIA.Text = reader["Aparelho_IA"].ToString();
                        txtCategoriaIA.Text = reader["Categoria_IA"].ToString();
                        byte[] imageBytes = (byte[])reader["Logo_IA"];
                        pictureBox1.Show();
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                       
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro: " + err.Message);
                }
            }
        }

        private void BtnPrimeiroIA_Click(object sender, EventArgs e)
        {
            valor = 1;
            txtCodigoIA.ReadOnly = true;
            txtCodigoIA.Enabled = false;
            txtNomeIA.Enabled = false;
            txtAnoLancamentoIA.Enabled = false;
            txtFabricanteIA.Enabled = false;
            txtAparelhoIA.Enabled = false;
            txtCategoriaIA.Enabled = false;
            btnConfirmarAlteracoesIA.Enabled = false;
            btnSelecionarArquivoIA.Enabled = false;

            using (SqlConnection conexao = new SqlConnection(conn))
            {
                string sql = "SELECT * FROM IA WHERE id_IA = @valor";
                SqlCommand pesq = new SqlCommand(sql, conexao);
                pesq.Parameters.AddWithValue("@valor", valor);
                try
                {
                    conexao.Open();
                    SqlDataReader reader = pesq.ExecuteReader();
                    if (reader.Read())
                    {
                        txtCodigoIA.Text = reader["id_IA"].ToString();
                        txtNomeIA.Text = reader["nm_IA"].ToString();
                        txtAnoLancamentoIA.Text = reader["AnoLanc_IA"].ToString();
                        txtFabricanteIA.Text = reader["Fabricante_IA"].ToString();
                        txtAparelhoIA.Text = reader["Aparelho_IA"].ToString();
                        txtCategoriaIA.Text = reader["Categoria_IA"].ToString();
                        byte[] imageBytes = (byte[])reader["Logo_IA"];
                        pictureBox1.Show();
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }

                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro: " + err.Message);
                }
            }
        }

        private void BtnUltimoIA_Click(object sender, EventArgs e)
        {
            txtCodigoIA.ReadOnly = true;
            txtCodigoIA.Enabled = false;
            txtNomeIA.Enabled = false;
            txtAnoLancamentoIA.Enabled = false;
            txtFabricanteIA.Enabled = false;
            txtAparelhoIA.Enabled = false;
            txtCategoriaIA.Enabled = false;
            btnConfirmarAlteracoesIA.Enabled = false;
            btnSelecionarArquivoIA.Enabled = false;

            using (SqlConnection conexao = new SqlConnection(conn))
            {
                string sqlMaxId = "SELECT MAX(id_IA) FROM IA";
                SqlCommand cmdMaxId = new SqlCommand(sqlMaxId, conexao);

                try
                {
                    conexao.Open();
                    object result = cmdMaxId.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int maxId = Convert.ToInt32(result);
                        txtCodigoIA.Text = maxId.ToString();
                        valor = maxId;

                        string sqlDetalhes = "SELECT nm_IA, AnoLanc_IA, Fabricante_IA, Aparelho_IA, Logo_IA, Categoria_IA FROM IA WHERE id_IA = @id_IA";
                        SqlCommand cmdDetalhes = new SqlCommand(sqlDetalhes, conexao);
                        cmdDetalhes.Parameters.AddWithValue("@id_IA", maxId);

                        SqlDataReader reader = cmdDetalhes.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeIA.Text = reader["nm_IA"].ToString();
                            txtAnoLancamentoIA.Text = reader["AnoLanc_IA"].ToString();
                            txtFabricanteIA.Text = reader["Fabricante_IA"].ToString();
                            txtAparelhoIA.Text = reader["Aparelho_IA"].ToString();
                            txtCategoriaIA.Text = reader["Categoria_IA"].ToString();


                            byte[] imageBytes = (byte[])reader["Logo_IA"];
                            pictureBox1.Show();
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }

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

        private void BtnExcluirIA_Click(object sender, EventArgs e)
        {
            txtCodigoIA.ReadOnly = true;
            txtCodigoIA.Enabled = false;
            txtNomeIA.Enabled = false;
            txtAnoLancamentoIA.Enabled = false;
            txtFabricanteIA.Enabled = false;
            txtAparelhoIA.Enabled = false;
            txtCategoriaIA.Enabled = false;
            btnConfirmarAlteracoesIA.Enabled = false;
            btnSelecionarArquivoIA.Enabled = false;

            if (string.IsNullOrWhiteSpace(txtCodigoIA.Text))
            {
                MessageBox.Show("Nenhum registro selecionado para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmar = MessageBox.Show("Tem certeza de que deseja remover este registro?", "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                using (SqlConnection conexao = new SqlConnection(conn))
                {
                    string sql = "DELETE FROM IA WHERE id_IA = @codigo";
                    SqlCommand cmd = new SqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@codigo", txtCodigoIA.Text);

                    try
                    {
                        conexao.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro removido com sucesso!");
                            txtCodigoIA.Clear();
                            txtNomeIA.Clear();
                            txtAnoLancamentoIA.Clear();
                            txtFabricanteIA.Clear();
                            txtAparelhoIA.Clear();
                            txtCategoriaIA.Clear();
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

        private void btnSairIA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterarIA_Click(object sender, EventArgs e)
        {
            txtCodigoIA.ReadOnly = true;
            txtCodigoIA.Enabled = false;
            txtNomeIA.Enabled = true;
            txtAnoLancamentoIA.Enabled = true;
            txtFabricanteIA.Enabled = true;
            txtAparelhoIA.Enabled = true;
            txtCategoriaIA.Enabled = true;
            btnConfirmarAlteracoesIA.Enabled = true;
            btnSelecionarArquivoIA.Enabled = true;
            pictureBox1.Show();

            MessageBox.Show("Para confirmar a alteração, clique em 'Confirmar Alterações'.");
        }

        private void btnConfirmarAlteracoes_Click(object sender, EventArgs e)
        {
            txtCodigoIA.ReadOnly = true;
            txtCodigoIA.Enabled = false;
            txtNomeIA.Enabled = false;
            txtAnoLancamentoIA.Enabled = false;
            txtFabricanteIA.Enabled = false;
            txtAparelhoIA.Enabled = false;
            txtCategoriaIA.Enabled = false;
            btnConfirmarAlteracoesIA.Enabled = false;
            btnSelecionarArquivoIA.Enabled = false;
            pictureBox1.Show();

            string nome = txtNomeIA.Text;
            string ano = txtAnoLancamentoIA.Text;
            string fabricante = txtFabricanteIA.Text;
            string aparelho = txtAparelhoIA.Text;
            string categoria = txtCategoriaIA.Text;


            using (SqlConnection conexao = new SqlConnection(conn))
            {
                string idmin = "UPDATE IA SET nm_IA = @nome, AnoLanc_IA = @ano, Logo_IA = @imagem, Fabricante_IA = @fabricante, Aparelho_IA = @aparelho, Categoria_IA = @categoria WHERE id_IA = @valor";
                byte[] imagem = converterparacristao(picture);

                SqlCommand cmd = new SqlCommand(idmin, conexao);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@ano", ano);
                cmd.Parameters.AddWithValue("@imagem", imagem);
                cmd.Parameters.AddWithValue("@fabricante", fabricante);
                cmd.Parameters.AddWithValue("@aparelho", aparelho);
                cmd.Parameters.AddWithValue("@categoria", categoria);

                MessageBox.Show("A alteração foi registrada.");

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
    }

}



