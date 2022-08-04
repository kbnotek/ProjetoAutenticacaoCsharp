using System;
using System.Windows.Forms;
using ModuloAuteticacao.Classes;

namespace ModuloAuteticacao.Desktop
{
    public partial class TelaNivel : Form
    {
        public TelaNivel()
        {
            InitializeComponent();
        }

        private void TelaNivel_Load(object sender, EventArgs e)
        {
         CarregarDgvNivel();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Inserir(txtNomeNivel.Text));
            CarregarDgvNivel();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Atualizar(txtId.Text, txtNomeNivel.Text));
            CarregarDgvNivel();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            NivelDAO pesqNome = new NivelDAO();
            dgvNivel.DataSource = pesqNome.Pesquisar(txtNomeNivel.Text);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            NivelDAO deletNivel = new NivelDAO();
            MessageBox.Show(deletNivel.Deletar(txtId.Text));
            CarregarDgvNivel();
        }
        private void CarregarDgvNivel()
        {
            NivelDAO nivelPesquisa = new NivelDAO();
            dgvNivel.DataSource = nivelPesquisa.Pesquisar();
        }

        private void btnCadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            txtNomeNivel.Focus();
            txtNomeNivel.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvNivel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {           
           txtId.Text = dgvNivel.Rows[e.RowIndex].Cells[0].Value.ToString();
           txtNomeNivel.Text = dgvNivel.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }
    }
}
