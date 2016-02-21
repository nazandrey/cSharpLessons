using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterLib
{

    public abstract class Filter<T>
        where T : class
    {
        public abstract bool IsValid(T item);

        public IEnumerable<T> CheckList(IEnumerable<T> list)
        {
            foreach (T item in list)
            {
                if (IsValid(item))
                {
                    yield return item;
                }
            }
        }
    }

    public abstract class TextFilter<T> : Filter<T>
        where T : class
    {
        protected string _pattern;

        protected abstract bool IsValidProperty(string comparingValue, string pattern);

        public TextFilter(string pattern) {
            _pattern = pattern;
        }     
    }

    public abstract class OnePropertyTextFilter<T> : TextFilter<T>
        where T : class
    {
        protected string _property;

        public OnePropertyTextFilter(string pattern, string property) : base(pattern)
        {
            _property = property;
        }

        public override bool IsValid(T item)
        {
            bool isValid = true;
            string comparingValue = item.GetType().GetProperty(_property).GetValue(item, null).ToString();
            isValid = isValid && IsValidProperty(comparingValue, _pattern);
            return isValid;
        }
    }

    public abstract class PropertyListTextFilter<T> : TextFilter<T>
        where T : class
    {
        protected string[] _propertyList;

        public PropertyListTextFilter(string pattern, string[] propertyList) : base(pattern)
        {
            _propertyList = propertyList;
        }        

        public override bool IsValid(T item)
        {
            bool isValid = true;
            foreach (string property in _propertyList)
            {
                if (!isValid) { break; }
                string comparingValue = item.GetType().GetProperty(property).GetValue(item, null).ToString();
                isValid = isValid && IsValidProperty(comparingValue, _pattern);
            }
            return isValid;
        }        
    }

    public class PropertyFullFilter<T> : OnePropertyTextFilter<T>
        where T : class
    {
        public PropertyFullFilter(string pattern, string property) : base(pattern, property) {}

        protected override bool IsValidProperty(string comparingValue, string pattern) {
            return comparingValue == pattern;
        }
    }

    public class PropertyPartialFilter<T> : OnePropertyTextFilter<T>
        where T : class
    {
        public PropertyPartialFilter(string pattern, string property) : base(pattern, property) { }

        protected override bool IsValidProperty(string comparingValue, string pattern)
        {
            return comparingValue.Contains(pattern);
        }
    }

    public class PropertyListPartialFilter<T> : PropertyListTextFilter<T>
        where T : class
    {
        public PropertyListPartialFilter(string pattern, string[] propertyList) : base(pattern, propertyList) { }

        protected override bool IsValidProperty(string comparingValue, string pattern) {
            return comparingValue.Contains(pattern);
        }
    }

    public class PropertyListFullFilter<T> : PropertyListTextFilter<T>
        where T : class
    {
        public PropertyListFullFilter(string pattern, string[] propertyList) : base(pattern, propertyList) { }

        protected override bool IsValidProperty(string comparingValue, string pattern)
        {
            return comparingValue == pattern;
        }
    }
}
