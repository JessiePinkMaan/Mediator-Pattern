namespace Mediator_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // создаем медиатор
            ChatMediator chatMediator = new ChatMediator();

            // создаем юзеров
            User user1 = new User("Labrador", chatMediator);
            User user2 = new User("Bob", chatMediator);
            User user3 = new User("Barmalei", chatMediator);

            
            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);

            // отправка сообщений
            user1.SendMessage("Barmalei", "НУ КАК ТАМ У БАРМАЛЕЕВ СЕЙЧАС ДЕЛИШКИ ???");
            user3.SendMessage("Labrador", "КАК НИКОГДА ХОРОШО!");
            user2.SendMessage("Barmalei", "вот это да");

            // удаление из чата 
            chatMediator.RemoveUser(user2);

        

            //история чата для определнного юзера

            foreach (var message in user1.MessageHistory)
            {
                Console.WriteLine($"история сообщений от: {message.From}, Сообщение: {message.Content}");
            }

          
        }
    }
}