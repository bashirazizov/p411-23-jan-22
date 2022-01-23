using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace faqApp.Models
{
    public class Faq
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public Faq(int Id, string Question, string Answer)
        {
            this.Id = Id;
            this.Question = Question;
            this.Answer = Answer;
        }
    }
}
