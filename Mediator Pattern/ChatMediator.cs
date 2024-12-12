using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public class ChatMediator
    {
        private List<User> _users; // список пользователей зарегистрированных в чате

        public ChatMediator()
        {
            _users = new List<User>();
        }

        public void AddUser(User user) //добавление нового пользователя
        {
            _users.Add(user);
        }

        public void RemoveUser(User user)// удаление пользователя 
        {
            _users.Remove(user);
        }

        public void SendMessage(Message message)
        {
            var recipient = _users.Find(u => u.Name == message.To); // С помощью метода Find мы ищем пользователя в списке _users имя которого совпадает с получателем сообщения 
            if (recipient != null) // если пользователь найден  вызываем метод ReceiveMessage у этого пользователя передавая ему сообщениеча
            {
                recipient.ReceiveMessage(message);
            }
            else//если не найден
            {
                Console.WriteLine($"Пользователь {message.To} не найден.");
            }
        }
    }
}
