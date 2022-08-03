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
         CarregarResponsabilidade();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Inserir(txtNome.Text));
            CarregarResponsabilidade();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Atualizar());
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
           // MessageBox.Show(nivel.Pesquisar());
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Deletar());
        }
        private void CarregarResponsabilidade()
        {
            NivelDAO nivelPesquisa = new NivelDAO();
            dgvNivel.DataSource = nivelPesquisa.Pesquisar();
        }

        private void btnCadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            txtNome.Focus();
            txtNome.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
