using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbOOP.ls3
{
    public class StringProcessor
    {

        public static string Reverse(string data) => new string(data.ToCharArray().Reverse().ToArray());

        public static void ReadContact()
        {
            var data = File.ReadAllLines(@"D:\Development\DotNet\source\repos\gbOOP\gbOOP\ls3\contacts.txt");

            for (int i = 0; i < data.Length; i++)
            {
                var email = SearchMail(ref data[i]);
                WriteContact(email);
                Console.WriteLine(email);
            }
        }

        public static string SearchMail(ref string contact) => contact.Split('&')[1].Trim();

        public static void WriteContact(string email)
        {
            File.AppendAllText(@"D:\Development\DotNet\source\repos\gbOOP\gbOOP\ls3\email.txt", $"{email}\n");
        }


    }
}
