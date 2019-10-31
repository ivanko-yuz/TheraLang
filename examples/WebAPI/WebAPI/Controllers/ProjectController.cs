using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProjectController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Project>> Get()
        {
            Project project1 = new Project { Id = 1, Name = "Хатіко: Вірний друг",description = "Фільм поставлений за відомою правдивою історією, що сталася в Японії " +
                                                                                                "в 20 - х роках ХХ століття.Господар назвав нового чотириногого вихованця " +
                                                                                                "породи акіта - іну Хатіко(японською - Восьмий).Коли Хаті підріс, він став" +
                                                                                                "постійно супроводжувати господаря.Песик щодня проводжав і зустрічав свого" +
                                                                                                "власника Паркера(Річард Ґір) на вокзалі.Потім чоловік несподівано помер" +
                                                                                                "прямо на лекції в присутності студентів.Того дня вірний собака не дочекався" +
                                                                                                "його повернення.Не зважаючи на це Хатіко протягом 9 років, щовечора о 5" +
                                                                                                "годині приходив на вокзал зустрічати хазяїна і чекав його до останнього" +
                                                                                                "поїзда, допоки не помер від старості.Родичі Паркера шкодували пса і кілька" +
                                                                                                "разів намагалися дати йому прихисток у себе вдома, проте тварина втекла назад" +
                                                                                                "до своєї варти.Місцеві торговці підгодовували охлялого собаку, захоплюючись" +
                                                                                                "про себе його відданістю та терплячістю.А залізничники контролювали, щоб собаку," +
                                                                                                "який став неодмінним атрибутом пристанційної площі, ніхто не ображав.",
                                                                                                Type = "type 1" };
            Project project2 = new Project { Id = 2, Name = "project2", description = "proj2", Type = "type 2" };
            Project project3 = new Project { Id = 3, Name = "project3", description = "proj3", Type = "type 3" };
            Project[] projects = new Project[] { project1, project2, project3 };
            return projects;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Project> Get(int id)
        {
            Project project1 = new Project { Id = 1, Name = "Хатіко: Вірний друг", Type = "type 1" };
            Project project2 = new Project { Id = 2, Name = "project2", Type = "type 2" };
            Project project3 = new Project { Id = 3, Name = "project3", Type = "type 3" };
            Project[] projects = new Project[] { project1, project2, project3 };

            return projects.FirstOrDefault(x=>x.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


    }

}
