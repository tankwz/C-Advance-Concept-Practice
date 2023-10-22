using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace C__Advance_Concept
{
    internal class LambdasAndCollections
    {
        record Hero(string Name, string HeroClass, int str);
     //   delegate bool Filtder<T>(T h);


        public static void Main(string[] args) {
            IEnumerable<T> Filter<T>(IEnumerable<T> items, Func<T, bool> f)
            {
                foreach (var item in items)
                {
                    if (f(item))
                    {
                        yield return item;
                    }
                }
            }


            var heroes = new List<Hero>
            {
                new("Ken", "Barbarian", 23),
                new("Kin", "Cleric", 15),
                new("Kin", "Cleric", 12),
                new("Sin", "Wreck", 1)
            };
            //alt f12 = quick peek


            //   var hero = FilterHeroesMoreThan15str(heroes);
            var hero = Filter(heroes, a => a.str > 15);
            var a = string.Join(",", hero);

            Console.WriteLine(a);
        }



    }
}
