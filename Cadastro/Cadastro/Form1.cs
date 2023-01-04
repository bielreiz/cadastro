using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Incluir sql
using System.Data.SqlClient;

namespace Cadastro
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        //Criação string de conexão
        SqlConnection conn = new SqlConnection(@"Data Source=PC-NOSSO;Initial Catalog=usuarios;User ID=sa;Password=12345");
        SqlCommand comandos = new SqlCommand();
        SqlDataReader dr;


        void carregarLista()
        {
            try
            {
                lstNome.Items.Clear();
                lstCodigo.Items.Clear();
                lstTelefone.Items.Clear();
                lstNum.Items.Clear();
                lstBairro.Items.Clear();
                lstRua.Items.Clear();

                conn.Open();

                comandos.CommandText = "SELECT * FROM tblPessoa";

                dr = comandos.ExecuteReader();
            

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lstCodigo.Items.Add(dr[0].ToString());
                        lstNome.Items.Add(dr[1].ToString());
                        lstTelefone.Items.Add(dr[2].ToString());
                        lstRua.Items.Add(dr[3].ToString());
                        lstBairro.Items.Add(dr[4].ToString());
                        lstNum.Items.Add(dr[5].ToString());
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void Limpar()
        {
            txtBairro.Clear();
            txtID.Clear();
            txtNome.Clear();
            txtNum.Clear();
            txtRua.Clear();
            txtTel.Clear();

            txtID.Focus();
        }
        

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            if (txtID.Text != "" && txtNome.Text != "" && txtTel.Text != "" && txtRua.Text != "" && txtBairro.Text != "" && txtTel.Text != "")
            {

                try
                {
                    //abrir conexão do BD
                    conn.Open();

                    //carregar o comando sql para o objeto "comando".
                    comandos.CommandText = "INSERT INTO tblpessoa (codPessoa, nome, telefone, rua, bairro, numCasa) VALUES ('" + txtID.Text + "', '" + txtNome.Text + "', '" + txtTel.Text + "', '" + txtRua.Text + "', '" + txtBairro.Text + "', '" + txtNum.Text + "')";

                    //essa é a execução do comando insert
                    comandos.ExecuteNonQuery();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Limpar();
                carregarLista();
            }
            else
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);                                   
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
           comandos.Connection = conn;

            carregarLista();
            Limpar();
        }

        private void lstCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;

            if (l.SelectedIndex != -1)
            {
                lstCodigo.SelectedIndex = l.SelectedIndex;
                lstNome.SelectedIndex = l.SelectedIndex;
                lstTelefone.SelectedIndex = l.SelectedIndex;
                lstRua.SelectedIndex = l.SelectedIndex;
                lstBairro.SelectedIndex = l.SelectedIndex;
                lstNum.SelectedIndex = l.SelectedIndex;

                txtID.Text = lstCodigo.SelectedItem.ToString();
                txtNome.Text = lstNome.SelectedItem.ToString();
                txtTel.Text = lstTelefone.SelectedItem.ToString();
                txtRua.Text = lstRua.SelectedItem.ToString();
                txtBairro.Text = lstBairro.SelectedItem.ToString();
                txtNum.Text = lstNum.SelectedItem.ToString();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtNome.Text != "" && txtTel.Text != "" && txtRua.Text != "" && txtBairro.Text != "" && txtTel.Text != "")
            {

                try
                {
                    //abrir conexão do BD
                    conn.Open();

                    //carregar o comando sql para o objeto "comando".
                    comandos.CommandText = "DELETE FROM tblpessoa WHERE codPessoa = '" + txtID.Text + "' AND nome = '" + txtNome.Text + "' AND telefone = '" + txtTel.Text + "' AND rua = '" + txtRua.Text + "' AND bairro = '" + txtBairro.Text + "' AND numCasa = '" + txtNum.Text + "'";

                    //essa é a execução do comando insert
                    comandos.ExecuteNonQuery();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Limpar();
                carregarLista();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtNome.Text != "" && txtTel.Text != "" && txtRua.Text != "" && txtBairro.Text != "" && txtTel.Text != "")
            {
                try
                {
                    //abrir conexão do BD
                    conn.Open();

                    //carregar o comando sql para o objeto "comando".
                    comandos.CommandText = "UPDATE tblPessoa SET codPessoa = '" + txtID.Text + "', nome = '" + txtNome.Text + "', telefone = '" + txtTel.Text + "', rua = '" + txtRua.Text + "', bairro = '" + txtBairro.Text + "', numCasa = '" + txtNum.Text + "' WHERE codPessoa = '" + lstCodigo.SelectedItem.ToString() + "' AND nome = '" + lstNome.SelectedItem.ToString() + "' AND telefone = '" + lstTelefone.SelectedItem.ToString() + "' AND rua = '" + lstRua.SelectedItem.ToString() + "' AND bairro = '" + lstBairro.SelectedItem.ToString() + "' AND numCasa = '" + lstNum.SelectedItem.ToString() + "'";

                    //essa é a execução do comando insert
                    comandos.ExecuteNonQuery();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Limpar();
                carregarLista();
            }
        }
    }
}
