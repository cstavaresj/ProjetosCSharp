using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Botão que adiciona as informações no banco de dados
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            //Cria conexão com o banco
            var connString = "Server=localhost;Database=agenda;Uid=root;Password=root"; 
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            
            try
            {
                connection.Open();

                //Se todos os campos forem preenchidos...
                if (textBoxNome.Text != "" && textBoxTelefone.Text != "" && textBoxEmail.Text != "" && textBoxEndereco.Text != "")
                {
                    //Insere no banco de dados
                    command.CommandText = "INSERT INTO contatos (nome, telefone, email, endereco) VALUES ('" + textBoxNome.Text + "','" + textBoxTelefone.Text + "','" + textBoxEmail.Text + "','" + textBoxEndereco.Text + "')";
                    command.ExecuteNonQuery();
                    
                    //Mostra mensagem na tela
                    labelMensagem.Text = "Contato adicionado com sucesso!";

                    //Limpa os campos
                    textBoxNome.Text = "";
                    textBoxEmail.Text = "";
                    textBoxTelefone.Text = "";
                    textBoxEndereco.Text = "";
                }
                //se algum campo não tiver preenchido, mostra mensagem de erro
                else
                {
                    labelMensagem.Text = "É necessário preencher todos os campos!";
                }
            }
            catch (Exception ex)
            {
                labelMensagem.Text = "Não foi possível estabelecer conexão! \n" + ex.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }
        
        //Botão para buscar um contato e mostrar na tela
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //Se algum desses campos não estiver vazio...
            if (textBoxNome.Text !="" || textBoxTelefone.Text != "" || textBoxEmail.Text != "")
            {
                var connString = "Server=localhost;Database=agenda;Uid=root;Password=root";
                var connection = new MySqlConnection(connString);
                var conexaoDataSet = new DataSet();
                
                try
                {
                    connection.Open();

                    if(textBoxNome.Text != "")
                    {
                        MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT nome, telefone, email, endereco FROM contatos WHERE nome LIKE '" + textBoxNome.Text + "%'", connection);
                        conexaoAdapter.Fill(conexaoDataSet, "contatos");
                    }
                    else if (textBoxTelefone.Text != "")
                        {
                        MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT nome, telefone, email, endereco FROM contatos WHERE telefone LIKE '" + textBoxTelefone.Text + "%'", connection);
                        conexaoAdapter.Fill(conexaoDataSet, "contatos");
                    }
                    else if (textBoxEmail.Text != "")
                    {
                        MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT nome, telefone, email, endereco FROM contatos WHERE email LIKE '" + textBoxEmail.Text + "%'", connection);
                        conexaoAdapter.Fill(conexaoDataSet, "contatos");
                    }

                    dataGridView1.DataSource = conexaoDataSet;
                    dataGridView1.DataMember = "contatos";
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                   
                }
                catch (Exception ex)
                {
                    labelMensagem.Text = "Não foi possível estabelecer conexão! \n" + ex.Message;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }

            }
            //se todos os campos de busca estiverem vazios, aparece mensagem de erro
            else
            {
                labelMensagem.Text = "Digite um nome, telefone ou e-mail para ser buscado!";
            }            
        }

        //Botão para limpar todos os campos
        private void buttonLimpaCampos_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            textBoxTelefone.Text = "";
            textBoxEndereco.Text = "";
            labelMensagem.Text = "Campos limpos!";
        }
    }
}