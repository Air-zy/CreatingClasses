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
            Console.WriteLine($"PersonId: {personId}, Name: {firstName} {lastName}'s favorite color is {favoriteColour}");
        }

        public void ChangeFavoriteColour() {
            favoriteColour = "White";
            Console.WriteLine($"{firstName} {lastName}'s favorite color has been changed to {favoriteColour}");
        }

        public int GetAgeInTenYears() {
            return age + 10;
        }

        public override string ToString() {
            return $"personId: {personId}\n" +
                   $"name: {firstName} {lastName}\n" +
                   $"favoriteColour: {favoriteColour}\n" +
                   $"age: {age}\n" +
                   $"isWorking: {isWorking}";
        }

    }
}
