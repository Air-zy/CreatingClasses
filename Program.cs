using System;
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
    age = 30,
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
