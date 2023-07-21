using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    internal class Program
    {
        static Dictionary<int, string> phoneBook = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            Console.WriteLine("вводите номера сначала номер, потом имя, через запятую");
            string t;
            while ((t = Console.ReadLine()) != "")
            {
                EnterPhoneNumber(t);
            }
            Console.WriteLine("Введите номер телефона");
            while (true)
            {
                try
                {
                    Console.WriteLine(GetPhoneNumber(int.Parse(Console.ReadLine())));
                }
                catch
                {
                    Console.WriteLine("Неверный ввод");
                }
            }
        }

        private static void EnterPhoneNumber(string enteredValue)
        {
            try
            {
                string[] t = enteredValue.Split(',');
                if(t.Length != 2)
                {
                    Console.WriteLine("Неправильный ввод");
                    return;
                }
                else
                {
                    PushPhoneNumber(int.Parse(t[0]), t[1]);
                }
            }
            catch
            {
                Console.WriteLine("Неправильный ввод");
            }
        }

        private static void PushPhoneNumber(int phoneNumber, string ownerName)
        {
            phoneBook.Add(phoneNumber, ownerName);
        }

        private static string GetPhoneNumber(int phoneNumber)
        {
            string result;
            if(phoneBook.TryGetValue(phoneNumber, out result))
            {
                return result;
            }
            else
            {
                return "Такого номера не существует";
            }
        }
    }
}
