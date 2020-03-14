using System;
using System.Globalization;

namespace Program_02.Entities
{
    class Installment
    {
        public DateTime DueDate;
        public double Amount;

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + "-" + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
