using System;
using GenPayslip.Controllers;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http.Results;
using IBussinessLayer;
using BussinessEntites;
using BussinessLogic;

namespace TestPaySlipApi
{
    [TestClass]
    public class PaySlipTest
    {
        [TestMethod]
        public void TestTaxSlab0()
        {
            // Arrange
            IPaySlip ps = new PaySlip();
            // Act
            ClsPaySlip objClsPaySlip = new ClsPaySlip(ps);
            Employee emptest0 = new Employee
            {
                First_name = "rajeev",
                Last_name = "Sharma",
                Annual_salary = 200000
            };

            // Assert
            Assert.AreEqual(0, objClsPaySlip.CalculatePay(emptest0).Income_tax);

        }
        [TestMethod]
        public void TestTaxSlab10()
        {
            // Arrange
            IPaySlip ps = new PaySlip();
            // Act
            ClsPaySlip objClsPaySlip = new ClsPaySlip(ps);

            Employee emptest10 = new Employee
            {
                First_name = "rajeev",
                Last_name = "Sharma",
                Annual_salary = 500000
            };

            // Assert
            Assert.AreEqual(25000, objClsPaySlip.CalculatePay(emptest10).Income_tax);

        }
        [TestMethod]
        public void TestTaxSlab20()
        {
            // Arrange
            IPaySlip ps = new PaySlip();
            // Act
            ClsPaySlip objClsPaySlip = new ClsPaySlip(ps);

            Employee emptest20 = new Employee
            {
                First_name = "rajeev",
                Last_name = "Sharma",
                Annual_salary = 800000
            };

            // Assert
            Assert.AreEqual(85000, objClsPaySlip.CalculatePay(emptest20).Income_tax);
        }
        [TestMethod]
        public void TestTaxSlab30()
        {
            // Arrange
            IPaySlip ps = new PaySlip();

            // Act
            ClsPaySlip objClsPaySlip = new ClsPaySlip(ps);

            Employee emptest30 = new Employee
            {
                First_name = "rajeev",
                Last_name = "Sharma",
                Annual_salary =1500000
            };

            // Assert
            Assert.AreEqual(275000, objClsPaySlip.CalculatePay(emptest30).Income_tax);

        }
        [TestMethod]
        public void TestNetIncome()
        {
            // Arrange
            IPaySlip ps = new PaySlip();
            // Act
            ClsPaySlip objClsPaySlip = new ClsPaySlip(ps);
            Employee emptest0 = new Employee
            {
                First_name = "rajeev",
                Last_name = "Sharma",
                Annual_salary = 200000
            };
            
            // Assert
            Assert.AreEqual(200000, objClsPaySlip.CalculatePay(emptest0).Net_income);
        }
        [TestMethod]
        public void TestGrossIncome()
        {
            // Arrange
            IPaySlip ps = new PaySlip();
            // Act
            ClsPaySlip objClsPaySlip = new ClsPaySlip(ps);

            Employee emptest0 = new Employee
            {
                First_name = "rajeev",
                Last_name = "Sharma",
                Annual_salary = 200000
            };
            
            // Assert
            Assert.AreEqual(16666, objClsPaySlip.CalculatePay(emptest0).Gross_income);
        }
        [TestMethod]
        public void TestSuperAmount()
        {
            // Arrange
            IPaySlip ps = new PaySlip();
            // Act
            ClsPaySlip objClsPaySlip = new ClsPaySlip(ps);
            Employee emptest0 = new Employee
            {
                First_name = "rajeev",
                Last_name = "Sharma",
                Annual_salary = 200000,
                Super_rate = 4
                
            };
            
            // Assert
            Assert.AreEqual(66664, objClsPaySlip.CalculatePay(emptest0).Super_amount);
        }
        [TestMethod]
        public void TestName()
        {
            // Arrange
            IPaySlip ps = new PaySlip();
            // Act
            ClsPaySlip objClsPaySlip = new ClsPaySlip(ps);
            Employee emptest0 = new Employee
            {
                First_name = "rajeev",
                Last_name = "Sharma",
                Annual_salary = 200000
            };
            
            // Assert
            Assert.AreEqual("rajeev Sharma", objClsPaySlip.CalculatePay(emptest0).Name);
        }
        [TestMethod]
        public void TestPayPeriod()
        {
            // Arrange
            IPaySlip ps = new PaySlip();
            // Act
            ClsPaySlip objClsPaySlip = new ClsPaySlip(ps);
            Employee emptest0 = new Employee
            {
                First_name = "rajeev",
                Last_name = "Sharma",
                Annual_salary = 200000,
                Payment_start_date="01-March-2018 TO 31-March-2018"
            };

            // Assert
            Assert.AreEqual("01-March-2018 TO 31-March-2018", objClsPaySlip.CalculatePay(emptest0).Pay_period);
        }
    }
}
