using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoole.Models
{
    public class Task
    {
        public Task(int index, int iD, int category_ID, string text, string answer, bool isDone)
        {
            Index = index;
            ID = iD;
            Category_ID = category_ID;
            Text = text;
            Answer = answer;
            IsDone = isDone;
        }

        public int Index { get; set; }

        public int ID { get; set; }
        public int Category_ID { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }
        public bool IsDone { get; set; }
    }
}
