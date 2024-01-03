
using ChallengeApp;

User user1 = new User("Wiktor", "789wasd789");
User user2 = new User("Kinga", "789wasd789");
User user3 = new User("Mia", "789wasd789");
User user4 = new User("Jacek", "789wasd789");


user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);







