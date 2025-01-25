using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People {
    internal class Relation {
        //can be sister brother mother or father
        public string RelationshipType { get; set; }
        public void ShowRelationShip(Person person1, Person person2) {
            Console.WriteLine($"Relationship between {person1.firstName} and {person2.firstName} is: {RelationshipType}");
        }
    }
}
