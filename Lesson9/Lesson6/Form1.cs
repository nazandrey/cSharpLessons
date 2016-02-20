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
using System.Diagnostics;


namespace Lesson9
{
    public partial class Form1 : Form
    {
        public enum Colors { red, blue, green, yellow }

        private readonly List<string> FILTER_OPTION_ARR = new List<string>()
        {
            "полное совпадение (категория)",
            "частичное совпадение (категория)",
            "по всем полям"

        };        
        private const int AMOUNT_ROW_IDX = 1;
        private int _balance;

        public Form1()
        {
            InitializeComponent();

            filterOptionArr.DataSource = FILTER_OPTION_ARR;

            Filter<string> filter = new Filter<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _balance = 0;
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
    }
}
