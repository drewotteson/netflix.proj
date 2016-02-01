using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public class Genre : IEnumerable
    {
        public string moviegenre;
        public string showgenre;
        public List<string> Titles;
        public IEnumerator GetEnumerator()
        {
            //for 
            yield return Titles;
        }
        public void AddToList(string moviegenre)
        {
            Titles.Add(moviegenre);
        }
        public void AddToList2(string showgenre)
        {
            Titles.Add(showgenre);

        }
    }
}
