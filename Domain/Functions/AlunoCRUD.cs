using ClassroomRegistration.Domain.Data;
using ClassroomRegistration.Domain.Adapter;
using ClassroomRegistration.Context;

namespace ClassroomRegistration.Domain.Functions
{
    public class AlunoCRUD
    {
        private readonly CRDbContext _CRDbContext;
        private readonly AlunoAdapter alunoAdapter;

        public AlunoCRUD(AlunoAdapter alunoAdapter)
        {
            this._CRDbContext = new CRDbContext();
            this.alunoAdapter = alunoAdapter;
        }

        public AlunoDomain Insert(Aluno value)
        {
            var aluno = this._CRDbContext.Aluno.Add(value);
            this._CRDbContext.SaveChanges();
            return this.alunoAdapter.DataToObject(aluno.Entity);
        }

        public AlunoDomain Update(Aluno value)
        {
            var aluno = this._CRDbContext.Aluno.Update(value);
            this._CRDbContext.SaveChanges();
            return this.alunoAdapter.DataToObject(aluno.Entity);
        }

        public AlunoDomain Read(int codigo)
        {
            var aluno = this._CRDbContext.Aluno.FirstOrDefault(a => a.Codigo == codigo);
            return this.alunoAdapter.DataToObject(aluno);
        }

        public List<AlunoDomain> ReadAll()
        {
            var alunos = this._CRDbContext.Aluno.ToList();
            var listaAlunos = new List<AlunoDomain>();

            foreach (var aluno in alunos)
            {
                listaAlunos.Add(this.alunoAdapter.DataToObject(aluno));
            }

            return listaAlunos;
        }

        public bool Delete(Aluno aluno)
        {
            this._CRDbContext.Aluno.Remove(aluno);
            this._CRDbContext.SaveChanges();

            return true;
        }
    }
}
