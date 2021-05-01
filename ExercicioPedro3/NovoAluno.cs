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
    public partial class NovoAluno : Form
    {
        public ListView ListViewAlunos; //atributo da classe curso

        public List<Alunos> AlunosList; //atributo da classe curso -- tipo de dados super dinâmico, pode receber qualquer tipo de dados. --List<Alunos>--

        public string sexo;

        public NovoAluno(ListView listView1, List<Alunos> AlunosList)
        {
            InitializeComponent();

            this.ListViewAlunos = listView1;
            this.AlunosList = AlunosList;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NovoAluno_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alunos aluno = new Alunos(textBox1.Text, dateTimePicker1.Value.ToString("d"), Convert.ToInt32(numericUpDown1.Value), sexo, comboBox1.SelectedItem.ToString());
            
            AlunosList.Add(aluno);

            ListViewAlunos.Items.Clear();

            foreach (Alunos Item in AlunosList)
            {
                ListViewItem row = new ListViewItem(Item.Nome);
                row.SubItems.Add(Item.DataNasc);

                row.SubItems.Add(Item.NumMatrciula.ToString());

                row.SubItems.Add(Item.Sexo.ToString());

                row.SubItems.Add(Item.Curso);

                ListViewAlunos.Items.Add(row);

            }

            this.Hide();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            if (radioButton1.Checked == true)
            {
                if (textBox1.Text != "" && comboBox1.SelectedIndex >= 0 && numericUpDown1.Value > 0)
                {
                    button2.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                }
                sexo = "F";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            if (radioButton2.Checked == true)
            {
                if (textBox1.Text != "" && comboBox1.SelectedIndex >= 0 && numericUpDown1.Value > 0)
                {
                    button2.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                }
                sexo = "M";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
