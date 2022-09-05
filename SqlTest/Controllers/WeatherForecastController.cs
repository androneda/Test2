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

        [Route("Heroes")]
        [HttpGet]
        public async Task<IActionResult> GetSqlAsync()
        {
            return Ok(await _sqlService.GetSql("SELECT * FROM public.\"Heroes\" " +
                                                "INNER JOIN public.\"Races\" " +
                                                "ON public.\"Heroes\".\"RaceId\" = public.\"Races\".\"Id\""));
        }

        [Route("HeroesCombinations")]
        [HttpGet]
        public async Task<IActionResult> GetSqlRaceSpecCombinationsAsync() //Все возможные комбинации расс и специализаций отсортированных по названию расс
        {
            return Ok(await _sqlService.GetSql("SELECT public.\"Specializations\".\"Name\", public.\"Races\".\"Name\" " +
                                                "FROM public.\"Specializations\", public.\"Races\" " +
                                                "ORDER BY public.\"Races\".\"Name\" ASC "));
        }

        [Route("Statistics")]
        [HttpGet]
        public async Task<IActionResult> GetMultiplySqlAsync() //Статистика Выбранных расс из всех героев (Выводит рассы которых больше чем 40% Всех героев)
        {
            return Ok(await _sqlService.GetSql("SELECT COUNT(hero), race.\"Name\" " +
                                                "FROM public.\"Heroes\" as hero " +
                                                "INNER JOIN public.\"Races\" as race " +
                                                "ON hero.\"RaceId\" = race.\"Id\"" +
                                                "GROUP BY race.\"Name\"" +
                                                "HAVING COUNT(hero.\"Name\")>=(SELECT COUNT(*) FROM public.\"Heroes\")*0.4"));
        }
    }
}
