using Api.Models;

namespace Api.Repository
{
    public class Data
    {
        public static List<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Name ="John",
                    City="Chicago"
                },
                 new Person
                {
                    Id = 2,
                    Name ="Jay",
                    City="New York"
                },
                  new Person
                {
                    Id = 3,
                    Name ="Mary",
                    City="Washington"
                },
            };
        }
    }
}
