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
    public partial class Curso : Form
    {
        public ListView ListViewAlunos; //atributo da classe curso

        public List<Alunos> AlunosList; //atributo da classe curso -- tipo de dados super dinâmico, pode receber qualquer tipo de dados. --List<Alunos>--

        public Curso(ListView listView1, List<Alunos> AlunosList)
        {
            InitializeComponent();

            this.ListViewAlunos = listView1;
            this.AlunosList = AlunosList;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "ADM":
                    {
                        ListViewAlunos.Items.Clear();
                        
                        foreach(Alunos Item in AlunosList)
                        {
                            if (Item.Curso == "ADM")
                            {
                                ListViewItem row = new ListViewItem(Item.Nome);
                                row.SubItems.Add(Item.DataNasc);

                                row.SubItems.Add(Item.NumMatrciula.ToString());

                                row.SubItems.Add(Item.Sexo.ToString());

                                row.SubItems.Add(Item.Curso);

                                ListViewAlunos.Items.Add(row);
                                
                            }

                        }
                        break;
                    }

                case "Ed Fisica":
                    {
                        ListViewAlunos.Items.Clear();

                        foreach (Alunos Item in AlunosList)
                        {
                            if (Item.Curso == "Ed Fisica")
                            {
                                ListViewItem row = new ListViewItem(Item.Nome);
                                row.SubItems.Add(Item.DataNasc);

                                row.SubItems.Add(Item.NumMatrciula.ToString());

                                row.SubItems.Add(Item.Sexo.ToString());

                                row.SubItems.Add(Item.Curso);

                                ListViewAlunos.Items.Add(row);

                            }

                        }
                        break;
                    }


                case "Fisica":
                    {
                        ListViewAlunos.Items.Clear();

                        foreach (Alunos Item in AlunosList)
                        {
                            if (Item.Curso == "Fisica")
                            {
                                ListViewItem row = new ListViewItem(Item.Nome);
                                row.SubItems.Add(Item.DataNasc);

                                row.SubItems.Add(Item.NumMatrciula.ToString());

                                row.SubItems.Add(Item.Sexo.ToString());

                                row.SubItems.Add(Item.Curso);

                                ListViewAlunos.Items.Add(row);

                            }

                        }
                        break;
                    }

                case "Música":
                    {
                        ListViewAlunos.Items.Clear();

                        foreach (Alunos Item in AlunosList)
                        {
                            if (Item.Curso == "Música")
                            {
                                ListViewItem row = new ListViewItem(Item.Nome);
                                row.SubItems.Add(Item.DataNasc);

                                row.SubItems.Add(Item.NumMatrciula.ToString());

                                row.SubItems.Add(Item.Sexo.ToString());

                                row.SubItems.Add(Item.Curso);

                                ListViewAlunos.Items.Add(row);

                            }

                        }
                        break;
                    }



            }
        }

        private void Curso_Load(object sender, EventArgs e)
        {

        }
    }
}
