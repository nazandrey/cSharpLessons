using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Money;
using FilterLib;
using MoneyEntryManagerLib;
using System.Diagnostics;


namespace Lesson9
{
    public partial class Form1 : Form
    {
        private readonly string[] FILTER_PROPERTY_ARR = {
            "Amount"
            ,"EntryDate"
            ,"Category"
            ,"Description"
        };
        private const string DEFAULT_FILTER_PROPERTY = "Category";

        private readonly List<string> FILTER_OPTION_ARR = new List<string>()
        {
            "полное совпадение (категория)"
            ,"частичное совпадение (категория)"
            ,"полное совпадение (все поля)"
            ,"частичное совпадение (все поля)"

        };        
        private const int AMOUNT_ROW_IDX = 1;
        private int _balance;
        private MoneyEntryManager meManager;

        public Form1()
        {
            InitializeComponent();

            filterOptionArr.DataSource = FILTER_OPTION_ARR;
            meManager = new MoneyEntryManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _balance = 0;
            foreach (MoneyEntry me in meManager.Entries)
            {
                AddMoneyEntry(me);
            }
        }        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int amount;      
            Int32.TryParse(textBoxAmount.Text, out amount);
            _balance += amount;
            DateTime date = datePickerEntryDate.Value.Date;
            MoneyEntry me = new MoneyEntry(amount, date, textBoxCategory.Text, textBoxDescription.Text);
            _UpdateBalanceView();

            AddMoneyEntry(me);
        }

        private void AddMoneyEntry(MoneyEntry me)
        {
            tableEntry.Rows.Add(me.IsDebt ? "Расход" : "Доход", me.Amount, me.EntryDate, me.Category, me.Description);
            tableFilteredEntryArr.Rows.Add(me.IsDebt ? "Расход" : "Доход", me.Amount, me.EntryDate, me.Category, me.Description);

            _ClearFieldArr();
        }

        private void _ClearFieldArr() {
            textBoxAmount.Text = "";
            datePickerEntryDate.Value = DateTime.Now;
            textBoxCategory.Text = "";
            textBoxDescription.Text = "";
        }

        private void tableEntry_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == AMOUNT_ROW_IDX && e.RowIndex > -1) {
                int newAmount;
                DataGridViewCell changedCell = tableEntry.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewCell debtCell = tableEntry.Rows[e.RowIndex].Cells[0];
                Int32.TryParse(changedCell.Value.ToString(), out newAmount);
                MoneyEntry me = new MoneyEntry();
                me.Amount = newAmount;
                debtCell.Value = me.IsDebt ? "Расход" : "Доход";

                _UpdateBalance();
                
            }            
        }

        private void _UpdateBalance() {
            _balance = 0;
            foreach (DataGridViewRow entry in tableEntry.Rows)
            {
                int amount;                
                Int32.TryParse((entry.Cells[AMOUNT_ROW_IDX].Value ?? "0").ToString(), out amount);
                _balance += amount;
            }
            _UpdateBalanceView();
        }

        private void _UpdateBalanceView()
        {            
            labelBalanceValue.Text = _balance.ToString();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            tableFilteredEntryArr.Rows.Clear();
            meManager.TextFilter = getTextFilter(textBoxPattern.Text, comboBoxFilterType.SelectedIndex);
            List<MoneyEntry> filteredEntries = meManager.FilteredEntries;
            foreach (MoneyEntry me in filteredEntries)
            {
                AddMoneyEntry(me);
            };
        }

        private TextFilter<MoneyEntry> getTextFilter(string pattern, int filterOptionIdx) {
            switch (filterOptionIdx)
            {
                case 0: //"полное совпадение (категория)"
                    return new PropertyFullFilter<MoneyEntry>(pattern, DEFAULT_FILTER_PROPERTY);
                case 1: // "частичное совпадение (категория)",
                    return new PropertyPartialFilter<MoneyEntry>(pattern, DEFAULT_FILTER_PROPERTY);
                case 2: // "полное совпадение (все поля)"            
                    return new PropertyListFullFilter<MoneyEntry>(pattern, FILTER_PROPERTY_ARR);
                case 3: // "частичное совпадение (все поля)"
                    return new PropertyListPartialFilter<MoneyEntry> (pattern, FILTER_PROPERTY_ARR);
                default:
                    return null;
            }
        }

        private void buttonFilterClear_Click(object sender, EventArgs e)
        {
            tableFilteredEntryArr.Rows.Clear();
            textBoxPattern.Text = "";
            foreach (MoneyEntry me in meManager.Entries)
            {
                AddMoneyEntry(me);
            };
        }
    }
}
