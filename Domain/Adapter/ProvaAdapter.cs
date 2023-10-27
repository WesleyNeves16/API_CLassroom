using ClassroomRegistration.Domain.Data;
using ClassroomRegistration.Context;

namespace ClassroomRegistration.Domain.Adapter
{
    public class ProvaAdapter
    {
        public Prova ObjectToData(ProvaDomain prova)
        {
            return new Prova()
            {
                Codigo = prova.Codigo,
                CodAluno = prova.CodAluno,
                Data = prova.Data,
                Nota = prova.Nota,
                Peso = prova.Peso,
                Titulo = prova.Titulo,
            };
        }

        public ProvaDomain DataToObject(Prova prova)
        {
            return new ProvaDomain()
            {
                Codigo = prova.Codigo,
                CodAluno = prova.CodAluno,
                Data = prova.Data,
                Nota = prova.Nota,
                Peso = prova.Peso,
                Titulo = prova.Titulo,
            };
        }
    }
}
