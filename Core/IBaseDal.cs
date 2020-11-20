using System.Collections.Generic;
namespace Core
{
    public interface IBaseDal<T>
    {
        
        List<T> GetAll();
        int Add(T Entity);
        int Update(T Entity);
        int Delete(T Entity);
    }
}
