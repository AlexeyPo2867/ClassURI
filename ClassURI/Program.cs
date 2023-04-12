using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ClassURI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Класс Uri

            Uri sample = new Uri("http://MySite.com/somfile.txt?SomeQuery");

            Console.WriteLine("Хост :  " + sample.Host);
            Console.WriteLine("Порт : " + sample.Port);
            Console.WriteLine("Protokol : " + sample.Scheme);
            Console.WriteLine("Локальный маршрут : " + sample.LocalPath);
            Console.WriteLine("Запрос :  " + sample.Query);
            Console.WriteLine("Маршрут и запрос : " + sample.PathAndQuery);


            // Доступ к заголовку HTTP - ответа

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            string[] names = resp.Headers.AllKeys;

            Console.WriteLine("{0,-20}{1}\n", "Имя", "Назначение");
            foreach (string n in names)
                Console.WriteLine("{0,-20}{1}", n, resp.Headers[n]);

            resp.Close();


        }
    }
}
