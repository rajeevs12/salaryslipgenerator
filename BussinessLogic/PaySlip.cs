using BussinessEntites;
using IBussinessLayer;
using ObjectFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class ClsPaySlip : IPaySlipType
    {
        IPaySlip Psl;
        public ClsPaySlip(IPaySlip paySlip)
        {
            Psl = new PaySlip();
        }

        public IPaySlip CalculatePay(Employee Emp)
        {
            Psl.Name = Emp.First_name + " " + Emp.Last_name;
            Psl.Pay_period = Emp.Payment_start_date;
            Psl.Gross_income = Emp.Annual_salary / 12;

            GetDlObject objGetDlObject = new GetDlObject();
            List<Slabes> sl = objGetDlObject.Slabs().SetRange();


            var fullPayTax =
            sl.Where(t => t.range.max < Emp.Annual_salary)
                .Select(t => t)
                .ToArray()
                .Sum(taxBracket => ((taxBracket.range.max - (taxBracket.range.min - 1)) * taxBracket.tax) / 100);

            var partialTax =
                  sl.Where(t => t.range.min <= Emp.Annual_salary && t.range.max >= Emp.Annual_salary)
                      .Select(t => ((Emp.Annual_salary - (t.range.min - 1)) * t.tax) / 100)
                      .Single();

            var TotalTax = fullPayTax + partialTax;
            if (TotalTax > 0)
            {
                Psl.Income_tax = TotalTax;
            }
            else
            {
                Psl.Income_tax = 0;
            }

            Psl.Net_income = Emp.Annual_salary - Psl.Income_tax;
            Psl.Super_amount = Psl.Gross_income * Emp.Super_rate;

            return Psl;
        }
    }
}
