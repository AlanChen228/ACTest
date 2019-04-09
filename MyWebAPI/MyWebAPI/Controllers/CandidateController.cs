using MyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebAPI.Controllers
{
    public class CandidateController : ApiController
    {
        Models.Candidate[] Candidates = new Models.Candidate[] {
            new Models.Candidate { Name="peter", Id="a000000000", Age=30, Email="peter@gmail.com" },
            new Models.Candidate { Name="justin", Id="a11111111", Age=28, Email="justin@gmail.com" },
            new Models.Candidate { Name="terry", Id="a222222222", Age=32, Email="terry@gmail.com" }
        };

        /// <summary>
        /// 這是GetAllCandidates
        /// </summary>
        /// <returns>All</returns>
        [JwtAuthActionFilter]
        public IEnumerable<Models.Candidate> GetAllCandidates()
        {
            return Candidates;
        }

        //public IHttpActionResult GetCandidate(string Name)
        //{
        //    var myCandidate = Candidates.FirstOrDefault((c)=>c.Name== Name);
        //    if (myCandidate == null)
        //        return StatusCode(HttpStatusCode.NoContent);
        //    else
        //        return Ok(myCandidate);
        //}

        //以姓名搜尋應徵者資料
        /// <summary>
        /// 這是以姓名搜尋應徵者資料
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <returns>應徵者資料</returns>
        public IHttpActionResult GetCandidateByNamea(string Name)
        {
            var myCandidate = Candidates.FirstOrDefault((c) => c.Name == Name);
            if (myCandidate == null)
                return NotFound();
            else
                return Ok(myCandidate);
        }

        //以ID搜尋應徵者資料
        /// <summary>
        /// 這是以ID搜尋應徵者資料
        /// </summary>
        /// <param name="Id">ID</param>
        /// <returns>應徵者資料</returns>
        public IHttpActionResult GetCandidateById(string Id)
        {
            var myCandidate = Candidates.FirstOrDefault((c) => c.Id == Id);
            if (myCandidate == null)
                return NotFound();
            else
                return Ok(myCandidate);
        }

        //以姓名及ID搜尋應徵者資料
        /// <summary>
        /// 這是以姓名及ID搜尋應徵者資料
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Id">ID</param>
        /// <returns>應徵者資料</returns>
        public IHttpActionResult GetCandidateByNameaAndId(string Name, string Id)
        {
            var myCandidate = Candidates.FirstOrDefault((c) => c.Name == Name && c.Id == Id);
            if (myCandidate == null)
                return NotFound();
            else
                return Ok(myCandidate);
        }
    }


}
