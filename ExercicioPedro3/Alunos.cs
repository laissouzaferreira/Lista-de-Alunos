using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedro3
{
   public class Alunos
    {
        public string Nome; //atributos da classe Alunos. Poderiam add morada, telefone, sexo, etc...
        public string DataNasc;
        public int NumMatrciula;
        public char Sexo;
        public string Curso;

        

        public Alunos(string Nome, string DataNasc, int NumMatrciula, char Sexo, string Curso)
        {
            this.Nome = Nome;
            this.DataNasc = DataNasc;
            this.NumMatrciula = NumMatrciula;
            this.Sexo = Sexo;
            this.Curso = Curso;
           
        }
    }
}
