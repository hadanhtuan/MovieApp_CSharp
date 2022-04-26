using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    internal class ListMovie
    {
        List<Movie> list;
        private static ListMovie instance;

        internal List<Movie> List { get => list; set => list = value; }
        internal static ListMovie Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListMovie();
                }
                return instance;
            }

            set => instance = value;
        }

        public ListMovie()
        {
            list = new List<Movie>();
        }
    }
}
