using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqlTest.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SQLController : ControllerBase
    {
        private readonly ISqlService _sqlService;
        public SQLController(ISqlService sqlService)
        {
            _sqlService = sqlService;
        }

        [Route("UsersPaggination")]
        [HttpGet]
        public IActionResult GetSql()
        {
            return Ok(_sqlService.GetDapperSql());
        }
    }
}
