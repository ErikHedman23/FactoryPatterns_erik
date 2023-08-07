using FactoryPatternExample_erik;

Console.WriteLine("What kind of phone do you have?");
var phoneType = Console.ReadLine();
var phone = PhoneFactory.GetPhone(phoneType);

phone.Call();
phone.Text();

var personsEmotions = new MyEmotions();

personsEmotions.MyCurrentEmotion();

