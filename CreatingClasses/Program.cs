using People;

Person ianBrooks = new Person {
    personId = 1,
    firstName = "Ian",
    lastName = "Brooks",
    favoriteColour = "Red",
    age = 30,
    isWorking = true
};
Person ginaJames = new Person {
    personId = 2,
    firstName = "Gina",
    lastName = "James",
    favoriteColour = "Green",
    age = 18,
    isWorking = false
};
Person mikeBriscoe = new Person {
    personId = 3,
    firstName = "Mike",
    lastName = "Briscoe",
    favoriteColour = "Blue",
    age = 45,
    isWorking = true
};
Person maryBeals = new Person {
    personId = 4,
    firstName = "Mary",
    lastName = "Beals",
    favoriteColour = "Yellow",
    age = 28,
    isWorking = true
};

ginaJames.DisplayPersonInfo();
Console.WriteLine(mikeBriscoe.ToString());
ianBrooks.ChangeFavoriteColour();
ianBrooks.DisplayPersonInfo();

Relation sisters = new Relation {
    RelationshipType = "Sisterhood"
};
sisters.ShowRelationShip(ginaJames, maryBeals);

Relation brothers = new Relation {
    RelationshipType = "Brotherhood"
};
brothers.ShowRelationShip(ianBrooks, mikeBriscoe);

//

List<Person> people = new List<Person> { ianBrooks, ginaJames, mikeBriscoe, maryBeals };

// init.....
double totalAge = 0;
Person youngestPerson = people[0]; // no constructor so i just do this?
Person oldestPerson = people[0];

foreach (var person in people) {
    totalAge += person.age;
    if (person.age < youngestPerson.age) { // get youngest
        youngestPerson = person;
    }
    if (person.age > oldestPerson.age) { // get oldest
        oldestPerson = person;
    }
}

double averageAge = totalAge / people.Count;
Console.WriteLine($"Average age is: {averageAge}");

Console.WriteLine($"The youngest person is: {youngestPerson.firstName}");
Console.WriteLine($"The oldest person: {oldestPerson.firstName}");

foreach (var person in people) {
    if (person.firstName[0] == 'M') {
        Console.WriteLine(person.ToString());
    }
}
foreach (var person in people) {
    if (person.favoriteColour == "Blue") {
        Console.WriteLine(person.ToString());
    }
}