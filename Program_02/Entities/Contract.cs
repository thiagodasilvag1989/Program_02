using System;
using System.Collections.Generic;

namespace Program_02.Entities
{
    class Contract
    {
        public int Number;
        public DateTime Date;
        public double Totalvalue;
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalvalue)
        {
            Number = number;
            Date = date;
            Totalvalue = totalvalue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
