using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People {
    internal class Person {
        // attributes
        public int personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favoriteColour { get; set; }
        public int age { get; set; }
        public bool isWorking { get; set; }

        // methods
        public void DisplayPersonInfo() {
            Console.WriteLine($"{personId}: {firstName} {lastName}'s favorite color is {favoriteColour}");
        }

        public void ChangeFavoriteColour() {
            favoriteColour = "White";
        }

        public int GetAgeInTenYears() {
            return age + 10;
        }

        public override string ToString() {
            return $"PersonId: {personId}\n" + 
                   $"FirstName: {firstName}\n" +
                   $"LastName: {lastName}\n" +
                   $"FavoriteColour: {favoriteColour}\n" +
                   $"Age: {age}\n" +
                   $"IsWorking: {isWorking}";
        }

    }
}
