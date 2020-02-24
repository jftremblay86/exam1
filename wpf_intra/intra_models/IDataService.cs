using System.Collections.Generic;

namespace intra_models
{
    public interface IDataService<T>
    {
        public IEnumerable<T> GetAll();
    }
}