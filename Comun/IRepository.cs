namespace Comun
{
    public interface IRepository<T> where T: Agregado
    {
        void Save(T entity);
        T Find(string id);
       void Delete(T enity);

    }
}
