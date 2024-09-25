

using DependencyInjection._03.Interface;
using DependencyInjection._03.Service;
using System;

namespace DependencyInjection._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ISendMessage sendMessage = new SendNotif();

            RegisterUserService register = new RegisterUserService(sendMessage);
            //register.message = sendMessage;

            register.Execute("info@bugeto.net","bugeto.net");


            Console.ReadLine();
        }
    }



    public class RegisterUserService
    {

        ISendMessage message;
        public RegisterUserService(ISendMessage sendMessage)
        {
            message = sendMessage;
        }

        //public ISendMessage message;
        public void Execute(string email,string name)
        {

            //----------------
            //-----------
            Console.WriteLine("Sabtnam anjam shod......!");
            message.Send(email, name);
        }
    }


}
