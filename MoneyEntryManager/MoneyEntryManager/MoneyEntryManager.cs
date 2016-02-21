using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Money;
using FilterLib;

namespace MoneyEntryManagerLib
{
    public class MoneyEntryManager
    {
        private List<MoneyEntry> _entries;
        private TextFilter<MoneyEntry> _textFilter;

        public MoneyEntryManager() {
            _entries = new List<MoneyEntry>();
            AddEntry(-100, new DateTime(2012, 11, 2), "Food", "Apple");
            AddEntry(-50, new DateTime(2013, 8, 21), "Food", "Banana");
            AddEntry(50, new DateTime(2013, 2, 18), "Gift", "Long stick");
            AddEntry(-1000, new DateTime(2014, 2, 27), "Car", "Fuel");
            AddEntry(5000, new DateTime(2013, 3, 1), "Salary", "From ");
            AddEntry(-3000, new DateTime(2011, 4, 12), "Cloth", "Pants and socks");
        }

        public void AddEntry(MoneyEntry me) {
            _entries.Add(me);
        }

        public void AddEntry(int amount, DateTime date, string category, string description)
        {
            MoneyEntry me = new MoneyEntry(amount, date, category, description);
            this.AddEntry(me);
        }

        public TextFilter<MoneyEntry> TextFilter{
            get
            {
                return _textFilter;
            }
            set
            {
                _textFilter = value;
            }
        }

        public List<MoneyEntry> Entries{
            get{ return _entries; }            
        }

        public List<MoneyEntry> FilteredEntries
        {
            get
            {
                if (_textFilter != null)
                {
                    return (List<MoneyEntry>)_textFilter.CheckList(_entries);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
