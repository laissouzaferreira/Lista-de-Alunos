using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ExercicioPedro3
{
   public class Alunos
    {
        public static string ConectString = ConfigurationManager.ConnectionStrings["ListadeAlunos"].ConnectionString;

        public string Nome; //atributos da classe Alunos. Poderiam add morada, telefone, sexo, etc...
        public string DataNasc;
        public int NumMatrciula;
        public string Sexo;
        public string Curso;
        public int Id;

        

        public Alunos(string Nome, string DataNasc, int NumMatrciula,string Sexo, string Curso)
        {
            this.Nome = Nome;
            this.DataNasc = DataNasc;
            this.NumMatrciula = NumMatrciula;
            this.Sexo = Sexo;
            this.Curso = Curso;
           
           
        }

        public Alunos() // construtor vazio, para não dar erro no While{Alunos aluno = new Alunos(Teria que ter parametros aqui);}. Pois senão, teríamos que passar parametros para o objeto. 
        { }

        public static void GetAlunos(List<Alunos> alunos)
        {
            SqlConnection connection = new SqlConnection(ConectString);
            connection.Open();

            SqlCommand command = new SqlCommand("select * From Alunos",connection); // objeto
            SqlDataReader dataReader = command.ExecuteReader(); //objeto
            while (dataReader.Read())
            {
                Alunos aluno = new Alunos();
                aluno.Id = Convert.ToInt32(dataReader["id"].ToString());
                aluno.Nome = dataReader["Nome"].ToString();
                aluno.DataNasc = dataReader["Data_Nascimento"].ToString();
                aluno.NumMatrciula = Convert.ToInt32(dataReader["Numero_Matricula"].ToString());
                aluno.Sexo = dataReader["Sexo"].ToString();
                aluno.Curso = dataReader["Curso"].ToString();
                alunos.Add(aluno);
            }

           
        }
    }
}
