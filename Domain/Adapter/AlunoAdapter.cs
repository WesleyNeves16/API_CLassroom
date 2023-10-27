using ClassroomRegistration.Domain.Data;
using ClassroomRegistration.Context;

namespace ClassroomRegistration.Domain.Adapter
{
    public class AlunoAdapter
    {
        public Aluno ObjectToData(AlunoDomain aluno)
        {
            return new Aluno()
            {
                Codigo = aluno.Codigo,
                Nome = aluno.Nome,
                CPF = aluno.CPF,
                Nascimento = aluno.Nascimento,                
            };
        }

        public AlunoDomain DataToObject(Aluno aluno)
        {
            return new AlunoDomain()
            {
                Codigo = aluno.Codigo,
                Nome = aluno.Nome,
                CPF = aluno.CPF,
                Nascimento = aluno.Nascimento,
            };
        }
    }
}
