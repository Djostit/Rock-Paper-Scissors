using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mygame_two_player
{
    class Program
    {
        public static int c;
        public static int c1;
        public static bool z = true;
        public static string name1;
        public static string name2;
        static void math2(int select1,int select2)
        {
            switch (select1)
            {
                case 1:
                    if (select1 == 1 && select2 == 1)
                    {
                        Console.WriteLine("Камень против камня\nНичья!");
                    }
                    else if (select1 == 1 && select2 == 2)
                    {
                        Console.WriteLine("Камень против ножниц");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{name1} выиграл!");
                        Console.ForegroundColor = ConsoleColor.White;
                        c++;
                    }
                    else if (select1 == 1 && select2 == 3)
                    {
                        Console.WriteLine("Камень против бумаги");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{name2} выиграл!");
                        Console.ForegroundColor = ConsoleColor.White;
                        c1++;
                    }
                    break;
                case 2:
                    if (select1 == 2 && select2 == 1)
                    {
                        Console.WriteLine("Ножницы против камня");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{name2} выиграл!");
                        Console.ForegroundColor = ConsoleColor.White;
                        c1++;
                    }
                    else if (select1 == 2 && select2 == 2)
                    {
                        Console.WriteLine("Ножницы против ножниц\nНичья!");
                    }
                    else if (select1 == 2 && select2 == 3)
                    {
                        Console.WriteLine("Ножницы против бумаги");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{name1} выиграл!");
                        Console.ForegroundColor = ConsoleColor.White;
                        c++;
                    }
                    break;
                case 3:
                    if (select1 == 3 && select2 == 1)
                    {
                        Console.WriteLine("Бумага против камня");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{name1} выиграл!");
                        Console.ForegroundColor = ConsoleColor.White;
                        c++;
                    }
                    else if (select1 == 3 && select2 == 2)
                    {
                        Console.WriteLine("Бумага против ножниц");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{name2} выиграл!");
                        Console.ForegroundColor = ConsoleColor.White;
                        c1++;
                    }
                    else if (select1 == 3 && select2 == 3)
                    {
                        Console.WriteLine("Бумага против бумаги\nНичья!");
                    }
                    break;
                case 4:
                    z = false;
                    break;
                default:
                    Console.WriteLine("Не верный номер!");
                    break;
            }
        }
        static void Count(string name1, string name2)
        {
            string nam1 = $"{name1} счёт: {c}";
            int n1 = Console.WindowWidth - nam1.Length;
            string nam2 = $"{name2} счёт: {c1}";
            int n2 = Console.WindowWidth - nam2.Length;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(n1-1, 0);
            Console.WriteLine(nam1);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(n2-1, 1);
            Console.WriteLine(nam2);

            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
        S:
            int select1;
            int select2;
            try
            {
                Console.Write("Введите имя первого игрока: ");
                name1 = Console.ReadLine();
                Console.Write("Введите имя второго игрока: ");
                name2 = Console.ReadLine();
                Console.Clear();
                do
                {
                    Count(name1,name2);
                    Console.WriteLine($"{name1}");
                    Console.Write("Выберите:\n1. Камень\n2. Ножницы\n3. Бумага\n4. Выход\nНомер: ");
                    select1 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Count(name1, name2);
                    Console.WriteLine($"{name2}");
                    Console.Write("Выберите:\n1. Камень\n2. Ножницы\n3. Бумага\n4. Выход\nНомер: ");
                    select2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    math2(select1,select2);
                    if (select1 <= 3 && select2 <=3 && (c != 3 || c1 != 3))
                    {
                        System.Threading.Thread.Sleep(2000);
                    }
                    Console.Clear();
                    if (c == 3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"
 __      __   ______   __    __        __       __  ______  __    __ 
|  \    /  \ /      \ |  \  |  \      |  \  _  |  \|      \|  \  |  \
 \$$\  /  $$|  $$$$$$\| $$  | $$      | $$ / \ | $$ \$$$$$$| $$\ | $$
  \$$\/  $$ | $$  | $$| $$  | $$      | $$/  $\| $$  | $$  | $$$\| $$
   \$$  $$  | $$  | $$| $$  | $$      | $$  $$$\ $$  | $$  | $$$$\ $$
    \$$$$   | $$  | $$| $$  | $$      | $$ $$\$$\$$  | $$  | $$\$$ $$
    | $$    | $$__/ $$| $$__/ $$      | $$$$  \$$$$ _| $$_ | $$ \$$$$
    | $$     \$$    $$ \$$    $$      | $$$    \$$$|   $$ \| $$  \$$$
     \$$      \$$$$$$   \$$$$$$        \$$      \$$ \$$$$$$ \$$   \$$
");
                        System.Threading.Thread.Sleep(2000);
                        select1 = 4; select2 = 4;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (c1 == 3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(@"
 __      __   ______   __    __        __        ______    ______   ________ 
|  \    /  \ /      \ |  \  |  \      |  \      /      \  /      \ |        \
 \$$\  /  $$|  $$$$$$\| $$  | $$      | $$     |  $$$$$$\|  $$$$$$\| $$$$$$$$
  \$$\/  $$ | $$  | $$| $$  | $$      | $$     | $$  | $$| $$___\$$| $$__    
   \$$  $$  | $$  | $$| $$  | $$      | $$     | $$  | $$ \$$    \ | $$  \   
    \$$$$   | $$  | $$| $$  | $$      | $$     | $$  | $$ _\$$$$$$\| $$$$$   
    | $$    | $$__/ $$| $$__/ $$      | $$_____| $$__/ $$|  \__| $$| $$_____ 
    | $$     \$$    $$ \$$    $$      | $$     \\$$    $$ \$$    $$| $$     \
     \$$      \$$$$$$   \$$$$$$        \$$$$$$$$ \$$$$$$   \$$$$$$  \$$$$$$$$
");
                        System.Threading.Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.White;
                        select1 = 4; select2 = 4;
                    }
                    if (c == 3 || c1 == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Хотите начать заного?");
                        string st = Console.ReadLine().ToLower();
                        if (st == "да" || st == "д" || st == "y" || st == "yes")
                        {
                            z = true;
                            c = 0;
                            c1 = 0;
                        }
                        else if (st == "нет" || st == "н" || st == "n" || st == "no")
                        {
                            z = false;
                        }
                        Console.Clear();
                        if (st == "да" || st == "д" || st == "y" || st == "yes")
                        {
                            Console.WriteLine("Новые игроки?");
                            string st1 = Console.ReadLine();
                            if (st1 == "да" || st1 == "д" || st1 == "y" || st1 == "yes")
                            {
                                goto S;
                            }
                            else if (st1 == "нет" || st1 == "н" || st1 == "n" || st1 == "no")
                            {
                                z = true;
                            }
                            Console.Clear();
                        }
                    }
                }
                while (z);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                goto S;
            }
        }
    }
}
