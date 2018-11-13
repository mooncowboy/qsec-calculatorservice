using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace qsec_calculatorservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        public int Substract(int v1, int v2)
        {
            return v1 - v2;
        }

        public double Substract(double v1, double v2)
        {
            return v1 - v2;
        }
    }
}
