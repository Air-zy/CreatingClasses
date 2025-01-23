using People;

Person person = new Person {
    personId = 1,
    firstName = "Ian",
    lastName = "Brooks",
    favoriteColour = "Red",
    age = 30,
    isWorking = true
};

person.DisplayPersonInfo();
person.ChangeFavoriteColour();

Console.WriteLine($"age in 10 years: {person.GetAgeInTenYears()}");

Console.WriteLine(person.ToString());

