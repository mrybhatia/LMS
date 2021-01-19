using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class MemberTransactions
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BookId { get; set; }

        public int MemberId { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}
