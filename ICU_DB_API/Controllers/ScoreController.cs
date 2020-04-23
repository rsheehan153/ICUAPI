using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ICU_DB_API.Controllers
{
    public class ScoreController : ApiController
    {
        public IEnumerable<Score> Get()
        {
            using (NHSScoreDataEntities entities = new NHSScoreDataEntities())
            {
                return entities.Scores.ToList();
            }
        }




    }
}
