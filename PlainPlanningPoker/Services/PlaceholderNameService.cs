namespace PlainPlanningPoker.Services;

public class PlaceholderNameService
{
    private readonly string[] _adjectives = new[] {
        "Agile", "Brave", "Clever", "Daring", "Eager", "Fearless", "Gentle", "Happy", "Inventive", "Joyful",
        "Kind", "Lively", "Merry", "Nimble", "Optimistic", "Proud", "Quick", "Resourceful", "Strong", "Thoughtful",
        "Unique", "Vibrant", "Wise", "Xenial", "Youthful", "Zealous"
    };
    private readonly string[] _animals = new[] {
        "Antelope", "Bear", "Cougar", "Dolphin", "Eagle", "Fox", "Gorilla", "Hawk", "Iguana", "Jaguar",
        "Koala", "Lion", "Moose", "Newt", "Owl", "Panda", "Quail", "Rabbit", "Snake", "Tiger",
        "Urchin", "Vulture", "Wolf", "Xerus", "Yak", "Zebra"
    };
    private readonly Random _random = new();

    public string GeneratePlaceholderName()
    {
        return $"{_adjectives[_random.Next(_adjectives.Length)]} {_animals[_random.Next(_animals.Length)]}";
    }
}
