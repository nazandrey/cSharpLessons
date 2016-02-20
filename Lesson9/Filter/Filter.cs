using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterLib
{
    public interface IFilter<T>
        where T : class
    {
        bool IsValid(T item);

        IEnumerable<T> CheckList(IEnumerable<T> list);
    }

    public class Filter<T> : IFilter<T>
        where T : class
    {
        bool IFilter<T>.IsValid(T item) {
            return true;
        }

        IEnumerable<T> IFilter<T>.CheckList(IEnumerable<T> list)
        {
            foreach (T item in list)
            {
                if (((IFilter<T>)this).IsValid(item))
                {
                    yield return item;
                }

            }
        }
    }
    


}
