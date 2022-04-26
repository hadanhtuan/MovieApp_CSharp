using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    internal class Movie
    {
        private int id;
        private string movie_name;
        private string avt;
        private string url;
        private string category;
        private string directors;
        private string description;
        private string actors;
        private string time;
        private int views;

        public int Id { get => id; set => id = value; }
        public string Movie_name { get => movie_name; set => movie_name = value; }
        public string Avt { get => avt; set => avt = value; }
        public string Url { get => url; set => url = value; }
        public string Category { get => category; set => category = value; }
        public string Directors { get => directors; set => directors = value; }
        public string Actors { get => actors; set => actors = value; }
        public string Time { get => time; set => time = value; }
        public int Views { get => views; set => views = value; }
        public string Description { get => description; set => description = value; }
    }
}
