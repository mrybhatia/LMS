using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    [Route("api/member")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        [Route("{memberId}")]
        public Member GetMember(int memberId)
        {
            return new Member();
        }

        [Route("all")]
        public IEnumerable<Member> GetAllMembers()
        {
            return new List<Member>();
        }

        [Route("add")]
        public bool PostAddMember(Member member)
        {
            return true;
        }

        [Route("delete")]
        public bool DeleteMember(int memberId)
        {
            return true;
        }

        [Route("update")]
        public bool PutUpdateMember(Member member)
        {
            return true;
        }
    }
}
