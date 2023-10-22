using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advance_Concept
{
    internal class LambdasAndCollections
    {
        record Hero(string Name, string HeroClass, int str);

        public static void Main(string[] args) {
            List<Hero> FilterHeroesMoreThan15str(List<Hero> heroes)
            {

                return heroes.Where(a => a.str > 15).ToList();
            }
            var heroes = new List<Hero>
            {
                new("Ken", "Barbarian", 23),
                new("Kin", "Cleric", 15),
                new("Sin", "Wreck", 1)
            };
            //alt f12 = quick peek
            var hero = FilterHeroesMoreThan15str(heroes);

            var a = string.Join(",", heroes);

            Console.WriteLine(a);
        }



    }
}
