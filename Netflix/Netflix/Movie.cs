using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public class Movie : Title
    {
        public float Duration;

        public Movie(float duration, int rating, string name)
        {
            this.Duration = duration;
            this.rating = rating;
            this.name = name;
        }
        public void MovieToList()
        {

        }
    }
}
