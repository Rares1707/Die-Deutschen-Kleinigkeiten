using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerDeutschenNichtigkeiten
{
    public class Question
    {
        public string Prep { get; set; }
        public string GoodAnswer { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }

        public Question(string prep, string goodanswer, string answer2, string answer3, string answer4)
        {
            Prep = prep;
            GoodAnswer = goodanswer;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
        }

    }
}
