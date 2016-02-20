using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class MoneyEntry {

        private double _amount;
        private DateTime _entryDate;

        public MoneyEntry()
        {
            _amount = 0;
            _entryDate = new DateTime();
        }

        public MoneyEntry(double amount, DateTime entryDate, string category, string description)
        {
            _amount = amount;
            _entryDate = entryDate;
            Category = category;
            Description = description;
        }

        public override string ToString()
        {
            return string.Format("{0} от {1}", _amount, _entryDate.Date);
        }

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public bool IsDebt
        {
            get { return (_amount <= 0); }
            set { if (value == true && _amount >= 0 || value == false && _amount <= 0) { _amount = -_amount; } }
        }

        public DateTime EntryDate {
            get { return _entryDate; }
            set { _entryDate = value; }
        }

        public string Category { get; set; }

        public string Description { get; set; }


    }
}
