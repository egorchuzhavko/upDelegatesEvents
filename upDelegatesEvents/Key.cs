using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Key
    {
        public delegate void PushKey(string message);
        public event PushKey Notify;
        public void Push()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            if (keyInfo.Key == ConsoleKey.PageDown)
                Notify?.Invoke($"Была нажата нужная кнопка - {keyInfo.Key}");
            else
                Notify?.Invoke($"Ошибка, нужно нажать Page Down, была нажата - {keyInfo.Key}");
        }
    }
}
