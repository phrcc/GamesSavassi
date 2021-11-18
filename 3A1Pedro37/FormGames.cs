using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _3A1Pedro37.Code.BLL;




namespace _3A1Pedro37
{
    public partial class FormGames : Form


    {

        GameBLL gamebll = new GameBLL();
        GameDTO gamedto = new GameDTO();






        public FormGames()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGames_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            
            gamedto.Nome = txt_nome.Text;
            gamedto.Preco = txt_preco.Text;

            //Envio do dto preenchido para o método inserir
            gamebll.Inserir(gamedto);

            //Mensagem de sucesso
            MessageBox.Show("Cadastrado com sucesso!", "Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Limpeza dos componentes
            txt_id.Clear();
            txt_nome.Clear();
            txt_preco.Clear();
        }
    }
}
