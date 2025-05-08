using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneList
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        string[][] lista;
        readonly int max = 100;
        string identificador = "";

        public Form1()
        {
            InitializeComponent();
            lista = new string[max][];
        }

        int Tamanho(string[][] matriz)
        {
            int itens = 0;
            for (int i = 0; i < matriz.Length; i++)
            {
                if (matriz[i] != null)
                {
                    itens++;
                }
            }
            return itens;
        }

        int Tamanho(string[] vetor)
        {
            int itens = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != null)
                {
                    itens++;
                }
            }
            return itens;
=======
        string[,] lista;
        readonly int max = 100;
        int itens = 0;
        public Form1()
        {
            InitializeComponent();
            lista = new string[max, 2];
>>>>>>> 7c4d935baf96d3658d7b73c9159deb1b15655625
        }

        void Atualizar()
        {
            dgvList.Rows.Clear();
<<<<<<< HEAD
            for (int i = 0; i < Tamanho(lista); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvList);
                for (int j = 0; j < Tamanho(lista[i]); j++)
                {
                    row.Cells[j].Value = lista[i][j];
                }
                dgvList.Rows.Add(row);
            }
=======
            for (int i = 0;i<itens; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvList);
                for (int j = 0; j < 2; j++)
                {
                    row.Cells[j].Value = lista[i, j];
                }
                dgvList.Rows.Add(row);
            }

>>>>>>> 7c4d935baf96d3658d7b73c9159deb1b15655625
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || !txtPhone.MaskFull)
            {
                MessageBox.Show("Insira nome e telefone!");
                return;
            }
<<<<<<< HEAD

            if (identificador != "")
            {
                for (int i = 0; i < Tamanho(lista); i++)
                {
                    if (lista[i][0] == identificador)
                    {
                        lista[i][1] = txtName.Text;
                        lista[i][2] = txtPhone.Text;
                        break;
                    }
                }
                identificador = "";
            }
            else
            {
                int novoId = Tamanho(lista) + 1;
                lista[Tamanho(lista)] = new string[] { novoId.ToString(), txtName.Text, txtPhone.Text };
            }

            txtName.Clear();
            txtPhone.Clear();
=======
            lista[itens, 0] = txtName.Text;
            lista[itens, 1] = txtPhone.Text;
            itens++;

>>>>>>> 7c4d935baf96d3658d7b73c9159deb1b15655625
            Atualizar();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            DataGridViewCell celula = dgvList.SelectedCells[0];
            int linha = celula.RowIndex;
            string idRemover = dgvList.Rows[linha].Cells[0].Value.ToString();

            int indice = 0;
            for (indice = 0; indice < Tamanho(lista) && lista[indice][0] != idRemover; indice++) ;

            DialogResult resultado = MessageBox.Show("Deseja realmente remover?", "Remover", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                for (int i = indice; i < Tamanho(lista) - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                lista[Tamanho(lista) - 1] = null;

                for (int i = 0; i < Tamanho(lista); i++)
                {
                    lista[i][0] = (i + 1).ToString(); // Atualiza os IDs
                }

                Atualizar();
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvList.Rows.Count)
            {
                DataGridViewRow linha = dgvList.Rows[e.RowIndex];
                identificador = linha.Cells[0].Value.ToString();
                txtName.Text = linha.Cells[1].Value.ToString();
                txtPhone.Text = linha.Cells[2].Value.ToString();
            }
=======
            DialogResult result = MessageBox.Show("Deseja realmente remover?", "Remover", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewCell cell = dgvList.SelectedCells[0];
                int indice = cell.RowIndex;
                if (dgvList.SelectedCells.Count > 0)
                {
                    for (int i = indice; i < itens - 1; i++)
                    {
                        lista[i, 0] = lista[i + 1, 0];
                        lista[i, 1] = lista[i + 1, 1];
                    }
                    itens--;
                    Atualizar();
                }
            }
            else
            {
                return;
            }


>>>>>>> 7c4d935baf96d3658d7b73c9159deb1b15655625
        }
    }
}
