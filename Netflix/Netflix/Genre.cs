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
        public List<Title> Titles;
        public IEnumerator GetEnumerator()
        {
            yield return Titles;
        }
        public void AddToList()
        {

        }
    }
}
