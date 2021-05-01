using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioPedro3
{
    public partial class Form1 : Form
    {
        public List<Alunos> AlunosList = new List<Alunos>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Alunos alunos1 = new Alunos("Felipe Augusto", "1991, 06, 04", 2021, 'M', "ADM");
            Alunos alunos2 = new Alunos("Fabiano Lopes", "1981, 09, 06", 2022, 'M', "Ed Fisica");
            Alunos alunos3 = new Alunos("Lais Barbosa", "1988, 09, 06", 2023, 'F', "Fisica");
            Alunos alunos4 = new Alunos("Laura Santos ", "1993, 09, 97", 2024, 'F', "Música");

            AlunosList.Add(alunos1);
            AlunosList.Add(alunos2);
            AlunosList.Add(alunos3);
            AlunosList.Add(alunos4);

            foreach(Alunos Item in AlunosList)
            {
                ListViewItem row = new ListViewItem(Item.Nome);
                row.SubItems.Add(Item.DataNasc);

                row.SubItems.Add(Item.NumMatrciula.ToString());

                row.SubItems.Add(Item.Sexo.ToString());

                row.SubItems.Add(Item.Curso);

                listView1.Items.Add(row);

            }

        }

        private void mostrarAlunosPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Curso formcurse = new Curso(listView1, AlunosList);
            formcurse.Show();
        }

        private void mostrarTodosOsAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (Alunos Item in AlunosList)
            {
                ListViewItem row = new ListViewItem(Item.Nome);
                row.SubItems.Add(Item.DataNasc);

                row.SubItems.Add(Item.NumMatrciula.ToString());

                row.SubItems.Add(Item.Sexo.ToString());

                row.SubItems.Add(Item.Curso);

                listView1.Items.Add(row);

            }

        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoAluno NewAluno = new NovoAluno(listView1, AlunosList);
            NewAluno.Show();
        }
    }
}
