using BussinessEntites;
using IBussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GenPayslip.Controllers
{
    public class GenPaySlipController : ApiController
    {
        IPaySlipType _paySlip;
        
        public GenPaySlipController(IPaySlipType paySlip)
        {
            _paySlip = paySlip;
        }
        public IHttpActionResult GenPaySlip(Employee emp)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("All parameters are required");
            }
            IPaySlip p = _paySlip.CalculatePay(emp);
            return Ok(p);
        }
    }
}
