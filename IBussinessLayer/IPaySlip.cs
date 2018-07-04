using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessEntites;
namespace IBussinessLayer
{
    public interface IPaySlipType
    {
        IPaySlip CalculatePay(Employee emp);
    }
    public class PaySlip : IPaySlip
    {
        public string Name { get; set; }
        public string Pay_period { get; set; }
        public int Gross_income { get; set; }
        public int Net_income { get; set; }
        public int Income_tax { get; set; }
        public int Super_amount { get; set; }
    }
    public interface IPaySlip
    {
        string Name { get; set; }
        string Pay_period { get; set; }
        int Gross_income { get; set; }
        int Net_income { get; set; }
        int Income_tax { get; set; }
        int Super_amount { get; set; }
    }
}
