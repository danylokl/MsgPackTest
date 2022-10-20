using MessagePack;
namespace MsgPackTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User
            {
                Id = 0,
                Age = 18,
                Name = "Jhon",
                PhoneNumbers = new List<string> { "13849739","13295744" }
            };

            byte[] userMsgPack = MessagePackSerializer.Serialize(user);

            var desirialazied = MessagePackSerializer.Deserialize<User>(userMsgPack);
            var value = desirialazied.PhoneNumbers.FirstOrDefault();

            Console.WriteLine(value);
        }
    }
}