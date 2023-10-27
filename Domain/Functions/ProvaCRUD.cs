using ClassroomRegistration.Domain.Data;
using ClassroomRegistration.Domain.Adapter;
using ClassroomRegistration.Context;

namespace ClassroomRegistration.Domain.Functions
{
    public class ProvaCRUD
    {
        private readonly CRDbContext _CRDbContext;
        private readonly ProvaAdapter provaAdapter;

        public ProvaCRUD(ProvaAdapter provaAdapter)
        {
            this._CRDbContext = new CRDbContext();
            this.provaAdapter = provaAdapter;
        }

        public ProvaDomain Insert(Prova value)
        {
            var prova = this._CRDbContext.Prova.Add(value);
            this._CRDbContext.SaveChanges();
            return this.provaAdapter.DataToObject(prova.Entity);
        }

        public ProvaDomain Update(Prova value)
        {
            var prova = this._CRDbContext.Prova.Update(value);
            this._CRDbContext.SaveChanges();
            return this.provaAdapter.DataToObject(prova.Entity);
        }

        public ProvaDomain Read(int codigo)
        {
            var prova = this._CRDbContext.Prova.FirstOrDefault(a => a.Codigo == codigo);
            return this.provaAdapter.DataToObject(prova);
        }

        public List<ProvaDomain> ReadAll()
        {
            var provas = this._CRDbContext.Prova.ToList();
            var listaProvas = new List<ProvaDomain>();

            foreach (var prova in provas)
            {
                listaProvas.Add(this.provaAdapter.DataToObject(prova));
            }

            return listaProvas;
        }

        public bool Delete(Prova prova)
        {
            this._CRDbContext.Prova.Remove(prova);
            this._CRDbContext.SaveChanges();

            return true;
        }
    }
}
