using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using qsec_calculatorservice.Models;

namespace qsec_calculatorservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {

        public double Substract(double v1, double v2)
        {
            return v1 - v2;
        }

        [HttpPost]
        public decimal Add([FromBody] BinaryOperands input) {
            return input.Add();
        }

    }
}
