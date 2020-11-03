using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO; // Отвечат за работу с файловой системой
using System.CodeDom;
using System.Net;

namespace ConsoleApp1
{
    class Program

    {

        static string file = @"C:\Пользователь\ADMIN\Рабочий ст";

        static void Main(string[] args)

        {
            /*double a, b, c, result = 0;
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);
            result = (b + Math.Sqrt(Math.Pow(b, 2) + 4 * a * c)) / -(2 * a) - Math.Pow(a, 3) * c + Math.Pow(b, -2);
            Console.WriteLine($"Результат Выражение:{result}");*/
            /*
                        double a, b, c, d, result = 0;
                        double.TryParse(Console.ReadLine(), out a);
                        double.TryParse(Console.ReadLine(), out b);
                        double.TryParse(Console.ReadLine(), out c);
                        double.TryParse(Console.ReadLine(), out d);
                        result = ((a * b) / (c * d)) - (((a * b) - c) / (c * d));
                        Console.WriteLine($"Результат Выражение:{result}");*/




            /* double sinx,cosx,tgxy,cosy,siny, result = 0;
             double.TryParse(Console.ReadLine(), out sinx);
             double.TryParse(Console.ReadLine(), out cosx);
             double.TryParse(Console.ReadLine(), out siny);
             double.TryParse(Console.ReadLine(), out cosy);
             double.TryParse(Console.ReadLine(), out tgxy);
             result = ((sinx + cosx) / (cosx - siny) * tgxy);
             Console.WriteLine($"Результат Выражение:{ result}");*/


            /*double x,y,result = 0;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            result = ((x + y) / (y + 1)) - ((x * y - 12) / (34 + x));
            Console.WriteLine($"Результат" + $"Выражение:{ result}");*/

            /*double x, y, e, tgx, result = 0;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out e);
            double.TryParse(Console.ReadLine(), out y);
            double.TryParse(Console.ReadLine(), out tgx);
            result = ((3 + Math.Pow(e, (y - 1))) / (1 + Math.Pow(x, 2) * Math.Abs(y - tgx)));
                Console.WriteLine($"Результат Выражение:{result}");*/

            /*double x,result= 0;
            double.TryParse(Console.ReadLine(), out x);
            result = (x - ((Math.Pow(x, 3) / 3) + (Math.Pow(x, 5) / 5)));
            Console.WriteLine($"Результат Выражение:{result}");*/
            /*
                       int number;
                        int.TryParse(Console.ReadLine(), out number);
                        int a = number / 1000;
                        int b = number / 100 % 10;
                        int c = number % 100 / 10;
                        int d = number % 10
                        Console.WriteLine(a*b*c*d);*/


            /*Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());
            double P = a + b + Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("P=" + P);
           
            Console.WriteLine("c=");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("d=");
            double d = double.Parse(Console.ReadLine());
            double e;
            double S = (c * d / 2);
            Console.WriteLine("Площадь = {0}", S);*/

            /*double x1, y1, x2, y2, x3, y3, a, b, c, p, s, p1;
            double.TryParse(Console.ReadLine(), out x1);
            double.TryParse(Console.ReadLine(), out y1);
            double.TryParse(Console.ReadLine(), out x2);
            double.TryParse(Console.ReadLine(), out y2);
            double.TryParse(Console.ReadLine(), out x3);
            double.TryParse(Console.ReadLine(), out y3);
            a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            c = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            p = a + b + c;
            p1 = p / 2;
            s = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - c));
            Console.WriteLine($"P:{p}");
            Console.WriteLine($"S:{s}");*/
            /*
            double result = 0;
            int x = 0;
            for (x = 0; x <= 15; x++)
            { циклы
                result = x * x + x + 17;
                Console.WriteLine($"{result}");*/

            /* double result =0;
               int x = 0;
               for (x = 0; x <= 40; x++)
               {
                   result = 2 * x * x + x + 41;
                   Console.WriteLine($"{result}");
               } */
            /* double result = 0;
             int x = 0;
             for (x = 0; x <= 28; x++)
             {
                 result = 2 * x * x + 41;
                 Console.WriteLine($"{result} ");
            } */

            // for (int i = 10; i >= 5; i-=2)
            //     Console.WriteLine(i + "\n");
            // for предзназначен для того,что бы делать операцию,
            //   или несколь копераций несколько раз 

            /*   int i= 0;
               while (i <= 6)
               {
                   Console.WriteLine(i);
                   i++;
               } */

            /*   double num;
               Console.WriteLine("How old are you");
               num = Convert.ToDouble(Console.ReadLine());

               if (num > 17 && num<50) 

               Console.WriteLine("You are older than 17");

               else if (num < 10) 
               Console.WriteLine("Under 10");
               else
                   Console.WriteLine("Else");

               string name = num == 15 ? "Firs" : "Second";
               Console.WriteLine(name); */

            //  switch ОПЕРАТОР
            /*   Random randNum = new Random();
               int num;

               num = randNum.Next(1,6);

               switch (num) условный оператор,который проверяет переменную на какое-либо значение

               { 
                   case 1:
                       Console.WriteLine("Num is-" + num);
                       break;
                   case 2:
                       Console.WriteLine("Num is equal to" + num);
                       break;
                   default:
                       Console.WriteLine("Nothing!" + num);
                   break; */

            /* int i;
             for (i = 0; i < 10; i++)
                 switch (i)
                 {
                     case 0:
                         Console.WriteLine("i=0");
                         break;
                     case 1:
                         Console.WriteLine("i=1");
                         break;

                     case 2:
                         Console.WriteLine("i=2");
                         break;
                     case 3:
                         Console.WriteLine("i=3");
                         break;
                     case 4:
                         Console.WriteLine("i=4");
                         break;
                     default:
                         Console.WriteLine("i>=5");
                         break; */
            // Массивы C#
            //синтаксис объявления массива
            //тип данных[] имя переменной;// непроинциализированный массив

            /*  int [] array = new int[10]; //размер массива(кол-во элементов )
              array = new int[] { 1, 2, 3, 4 }; // массив на 4 ячейки с зад.значениями
               array = new int[5] { 1, 2, 3, 4,5 };
               string[] arraystring = new string[] { "Привет", "Мир" };
               array[0] = 10; //назначить 10 в первую ячейку(Индекс 0)
               int i = array[10]; //прочитать ячейку с индексом 0 и сохранить ее назначение в переменную i
               Console.WriteLine(i);
               Console.WriteLine(array[1]);
               Console.WriteLine(array[9]);
               int.TryParse(Console.ReadLine(), out int leght);
               array = new int[leght]; 
               //двумерный массив 
               double[,] array2d =new double[10, 10];
               array2d[0, 0] = 1.0;
               for (int i = 0; i < 10; i++) ;
               {

                   for (int j = 0; j < 10; j++) ;
                   {

                       array2d[i, j] = i * j;
                       Console.WriteLine(array2d[i, j] + "\t");
                   }
                   Console.WriteLine();
               }
              
            
            
            
            
            //ступенчатые массивы (массив массивов)
               int[][] arrayArrays = new int[3][];
               arrayArrays = [10] =new int[10];
               arrayArrays = [3] = new int[5];
               arrayArrays =[5]= new int[3];
               arrayArrays[0][5] = 15; */
            /*int[] array = new int[10];
            for (int i = 0; i < array.Length; i++) ;
            {
                int.TryParse(Console.ReadLine()),
                 out array[i]);
            }
            int temp
            for (int i = 0, i< array.Length; i++) ;
            Console.WriteLine(array[i]);
            {
                temp = array[i - 1];
                array[i - 1] = array[i];
                array[i] = temp;
            }
            Console.WriteLine(new string("*")*/




            /*  Console.WriteLine("Введите длину массива");
               int.TryParse(Console.ReadLine(), out int n);
               int[] array = new int[n];
               Console.WriteLine($"Введи {n} целых чисел");
               int zeroCount = 0;
               for (int i = 0; i < n; i++) ;
               {
                   int.TryParse(Console.ReadLine(),
                       out array[i]);
                   if (array[i] == 0)
                       zeroCount++;


               }
               if (zeroCount == 0)
               {
                   Console.WriteLine("В последовательности нет" + "нулевых элементов!");
                   return;
               }
                   int[] arrayZero = new int[zeroCount];
               for (int i = 0; j = 0; i< n ;i ++)
                   if (array[i] == 0)
                   arrayZero[j++] = i;
               Console.WriteLine($"arrayZero[{i}]=" +
                   $"{arrayZero[i]}"); */
            /*
             * 
             *
             *
             *
             *________________________________________________________________
                  №4 Console.WriteLine ("n");
              int.TryParse (Console.ReadLine (), out int n);
              int [] array = new int[n];
              if (n <= 1)
  {
                  Console.WriteLine ("Слишком маленький массив");
              }
              for (int i = 0 ; i < n; i++)
  {
                  Console.WriteLine ($"array[{ i}] =");
                  int.TryParse (Console.ReadLine(), out array[i]);

              }
              bool result = true;
              for (int i = 1; i < n; i++)
  {
                  if (array[i - 1] >=i)
      {
                      result = false;
                      break;
                  }
              }
              Console.WriteLine (result ? "возрастает" : "не возрастает"); */
            /*     int n = 10 ;
                 int a = { 1, 2, 3, 4, 5 };
                 for (int i = 1; i < n; i++)
                 {
                     if (a[i] <= a[i - 1]) ;
                     {
                         Console.WriteLine("Последовательно не является возрастающей ");
                         return 0;
                     }
                 }
                 Console.WriteLine("Последовательно является возрастающей ");
                 return 0; */

            /*   {
                   int a = 11;
                   int sum = Sum(a + 1, 20 + 30);
                   Console.WriteLine(sum);
               }

                static int Sum(int x,int y) */


            //# 4.2 1
            /*      Console.WriteLine("Ввидите число N");
                  int.TryParse(Console.ReadLine(), out int n);
                for (int i = 1; i <= n; i++)
                {
                      s += Computer (i);
                      Console.WriteLine($"Результат:{s}");

                  }
                  static double Computer (int n)
                  {
                      return Math.Pow(-1, n) * 1 / Math.Pow(2, n);

                  } */


            //# 4.2 2
            /*   Console.WriteLine("Ввидите число N");
              int.TryParse(Console.ReadLine(), out int n);
              double s = 0;
              for (int i = 1; i <= n; i++)
              {
                  s += ComputerSin(i);
                  Console.WriteLine($"Результат: {s}");
              }
              static double ComputerSin(int i)
              {
                  double Знаменатель = 0;
                  for (int sin = 1; sin <= i; sin++)
                      Знаменатель += Math.Sin(sin);
                  return 1 / Знаменатель;

              } */
            //# 4.2 3

            /*    Console.WriteLine("Ввидети число N");
               int.TryParse(Console.ReadLine(), out int n);
               double P = 1;
               for (int i = 1; i <= n; i++)
               {
                   P *= (i * 2.0) / (i * 2.0 + 1.0);
               }
           }    */




            /*    //# 4.2 4

               Console.WriteLine("Ввидете число N");
               int.TryParse(Console.ReadLine(), out int n);
               for(int i=1; i<= n;i++)
               {

               } */


            //# МЕТОДЫ С МАССИВАМИ



            /* int.TryParse(Console.ReadLine(), out int n);
             int.TryParse(Console.ReadLine(), out int k);

             int[] array = new int[n];
             for (int i = 0; i < n; i++)
                 int.TryParse(Console.ReadLine(), out array[i]);

             int i = 0;
             var result = array.Select (s => 

             {
                 if (s == 0)
                     return i++;
                i++;
                     return -1;
             }).ToArray();
             Console.WriteLine(result);*/

            //# Коллекции
            //# Синтаксик
            //#  List<тип> название =  new List<тип> ();
            /*    List<int> array = new List<int>();
                array.Add(10);
                array.AddRange(new int[] { 1, 2, 3, 4, });
                Console.WriteLine(array[4]);
                array[0] = 11;
                Console.WriteLine(array.Count);
                array.Remove(5);// удаляет первый попавшийся элемент
                array.RemoveAll(s => s % 2 == 0);
                // array.RemoveAt(0);
                // array.RemoveRange(4, 2);

                array.InsertRange(2, new int[] { 1, 2, 3 });
                int index = array.IndexOf(5);//поиск индекса элемента
                  List <int>  elements= array.FindIndex (s => s>0);
                  Console.WriteLine(elements.Count) ; 
                array.ForEach(s => Console.WriteLine(s));
                Console.WriteLine("Сортировка!");
                array.Reverse();// изменение порядка элемента
                array.Sort((x, y) => y.CompareTo(x));
                array.ForEach(s => Console.WriteLine(s));
                array.Clear();// Очистка коллекции
                int [] array2 = array.ToArray(); 

            var first = array.Find (s => s % 11 == 0);
            List<int> resutl = array.FindAll (s => s % 11 == 0);
            var last = array.FindLast (s => s % 11 == 0);
            int lastindex = array.FindIndex(s => s % 11 == 0);

            array.FirstOrDefault(s => s % 11 == 0); */

            // №7
            /*  Console.WriteLine("N?");
               int.TryParse(Console.ReadLine(), out int n);
               Console.WriteLine("Z");
               int.TryParse(Console.ReadLine(), out int z);
               Console.WriteLine("Input elements...");
               List<double> array = new List<double>(n);
               Random random = new Random(); */
            /*   int count = 0;
               for (int i = 0; i < n; i++) ;
               {
                   array.Add(random.NextDouble() * random.Next(1, 101));
                  if (array[i]> z)
                   {
                       array[i] = z;
                       count++;
                   }
               }               */

            /*   for (int i = 0; i < n; i++) ;

               array.Add(random.NextDouble() * random.Next(1, 101));

               int count = 0;
               array = array.Select (s =>
               {
                   if (s > z)
                   {
                       count++;
                       return z;

                   }
               }) 


            for (int i = 0; i < n; i++) ;
            array.ForEach(s => Console.WriteLine(s));
            array.Add(random.NextDouble() * random.Next(-10, 10));
            int countPositive = array.Count(s => s > 0);
            int countNegaitive = array.Count(s => s < 0);
            int countZero = array.Count(s => s == 0);
            Console.WriteLine($"countPositive {countPositive} countNegaitive{countNegaitive}"); */

            // колекции
            //синтаксис
            // Dictionary <тип ключа, тип значения >  имя словаря = new Dictionary <тип ключа, тип значения>();
            /*  Dictionary<int, int> myDictionary = new Dictionary<string, string>();
             myDictionary.Add ("first", "Привет");
             myDictionary.Add ("second", "мир");
             if(!myDictionary.ContainsKey("second"))
             myDictionary.Add ("second", " ");

             myDictionary.Remove("second");
             Console.WriteLine(myDictionary["First"]);
             if (!myDictionary.ContainsKey("second")) // false
                 Console.WriteLine(myDictionary["second"]); */


            /*   // Queue <Тип> название = new Queue <тип>();
                Queue<string> qeue = new Queue<string>();
               Queue.Enqueue("новый элемент"); // добавить элемент
               var getElement = Queue.Dequeue();// получить первый элемент
               var getElement2 = Queue.Peek();
               var count = Queue.Count; // кол-во элементов в очереди

               //синтаксис
               // Stack<тип> название = new Stack<тип>();
               Stack<string> stack = new Stack<string>();
               stack.Push("добавленный элемент");
               var getElement3 = stack.Pop();// возвращает и удаляет первый элемент 
               var get4 = stack.Peek();// возвращает 1 элемент без удаления */


            //строкия- объявляются в C# как тип string и являются не изменяемыми объектами
            // со строкой можно работать,как с массивом типа char 
            /*  string s = Console.ReadLine();
              char[] array = new char[] { 'п', 'р', 'и', 'в', 'е', 'т' };
              string word = new string(array);
              char first = word[0];
              string newString = word.Replace('п', 'ы');
              Console.WriteLine(word);
              Console.WriteLine(newString);  */


            /* №2  string sentese1 = "br vvv fwq bgg qss";
              string[] sentese1Spl = sentese1.Split(' ', '.');
                  int count = 0;
              foreach (var s in sentese1Spl)
              {
                  if (s.Substring(0, 1) == "b")
                      count++;
              }
              Console.WriteLine(count);
              Console.ReadLine(); */

            // №3
            /* string s = "kgjfktjkrktjfkrtjrkrjtkrjtrkjhg";
             int r = 0, k = 0, t = 0;
             for (int i = 0; i < s.Length; i++)
             {
                 if (s[i] == 'r') { ++r; }
                 if (s[i] == 'k') { ++k; }
                 if (s[i] == 't') { ++t; }

             }
             Console.WriteLine(r);
             Console.WriteLine(k);
             Console.WriteLine(t); */

            // ФАЙЛОВАЯ СИСТЕМА В C#

            //   File.Create("aaaaaaa")

            /*   FileInfo info = new FileInfo(@"C:\Users\ADMIN\Desktop");
               Console.WriteLine(info.FullName); // ПОЛНЫЙ ПУТЬ ДО ФАЙЛА
               Console.WriteLine(info.Length);// размер файла в байтах
               Console.WriteLine(info.Name);// название файла
               Console.WriteLine(info.CreationTime);// время создания 
               Console.WriteLine(info.Extension);// расширение файла
               Console.WriteLine(info.DirectoryName); // путь к директории
               Console.WriteLine(info.IsReadOnly);// файл для чтения
               Console.WriteLine(info.Exists);// существует ли файл?
               Console.WriteLine(info.LastWriteTime); // дата измееия
               Console.WriteLine(info.LastAccessTime); // дата доступа

               // info.Delete(); удаляет файл
               FileInfo newFile = info.CopyTo(@"C:\"); 
                   /* info.Encrypt();
                      info.Decrypt(); 
                   info.Replace(@"C:\", @"C:/");
               Console.WriteLine("Копирование завершено"); */

            /*   bool result = File.Exists("путь к файлу");
               File.Delete("путь к файлу");
               File.Move("путь к файлу1", "путь к файлу 2");
               File.Copy("путь к файлу1", "путь к файлу 2", true);
               byte[] bytes = File.ReadAllBytes("путь к файлу1");
               String sFile = File.ReadAllText("путь к файлу 1");
               string[] rows = File.ReadAllLines("путь к файлу1");
               File.WriteAllBytes("путь к файлу", bytes);
               File.WriteAllText("путь к файлу", sFile);
               File.WriteAllLines("путь к файлу", rows);


               // Работа с файлами через stream
               FileStream fs = File.Open("путь к файлу",
                   FileMode.Create);
               Console.WriteLine(fs.Position);
               long i = fs.Length;// длина потока(файла)
               fs.Position = 100;
               //сдвиг на 100 байт с начала файла
              fs.Seek(-100, SeekOrigin.End);
               Console.WriteLine(fs.Position);
               int rl = fs.ReadByte();
               Console.WriteLine(fs.Position);
               byte[] array = new byte[10];
               fs.Read(array, 0, 10);
               //прочесть 10 байт и записать
               // в array ,начиная с 0 индекса
               Console.WriteLine(fs.Position); // 11
               fs.WriteByte(155);
               Console.WriteLine(fs.Position);// 12
               fs.Write(array, 0, 10);
               // прочеть 10 байт из array , начиная с 0 иднеса 
               // и записать их в файл с текущей позиции 

               // после работы с stream 
               // они должны быть закрыты!
               fs.Close();

               */
            /*  byte[]  array;
            using  FileStream fs = File.Open(@"C\: test.txt",
                  FileMode.Create, FileAccess.ReadWrite);
              {
                  array = new byte[fs.Length];
                  fs.Read(array, 0, array.Length);
              }

              /* fs.Seek(100, SeekOrigin.Begin);
              Console.WriteLine(fs.ReadByte());
              fs.Close();
              string s = Encoding.ASCII.GetString(array); 

            //  Encoding s = Encoding.UTF8.GetString(array);
              Console.WriteLine(s);  */
            /*  FileStream fs = File.OpenRead(@"C:\");
              fs = File.OpenWrite(@"c:\");
              StreamReader sr = File.OpenText(@"C:\");
              StreamWriter sw = new StreamWriter(@"C:\");
              sw.WriteLine("строка1");
              sw.WriteLine("строка1");
              File.AppendAllLines(@"C:\",
                  new string[] { "привет" });





              using (FileStream newFs = new FileStream("путь",
                      FileMode.Open, FileAccess.Read))
              {
                  using (BinaryReader br = new BinaryReader(newFs))
                  {
                      int intValue = br.ReadInt32();
                      long lVal = br.ReadInt64();
                      ulong ulVal = br.ReadUInt64();
                      string s = br.ReadString();

                  }
                  // newFS.Position = 0;
                  {
                      bw.Write(10);
                      bw.Write();
                      bw.Write(10);
                      bw.Write(10);
                      bw.Write(10);
                  }
                  var array = new byte[4];
                  newFs.Read(array, 0, 4);
                  int intValue1 = BitConverter.ToInt32(array , 0);

              } */

            // типизированные числовые файлы
            // №1

            /*   Console.WriteLine("Кол-во цифр?");
               int.TryParse(Console.ReadLine(),
                   out int numberCount);
               Random random = new Random();
               using (var fs = new FileStream("f",
                   FileMode.Create, FileAccess.Write))
               {
                   for (int i = 0; i < numberCount; i++)
                   {
                       var bytes = BitConverter.
                           GetBytes(random.Next());
                       fs.Write(bytes, 0, bytes.Length);
                   }

                           }
               using (var fsg = new FileStream("g",
                   FileMode.Create, FileAccess.Write))
               using (var fs = new FileStream("f",
                              FileMode.Open, FileAccess.Read))

               using (var br = new BinaryReader(fs))
               using (var bw = new BinaryWriter(fsg))
               {
                   for (int i = 0; i < numberCount; i ++)
                   {
                       int number = br.ReadInt32();
                       if ((number & 1) != 1)
                           bw.Write(number); */


            // File
            //DirectoryInfo

            /*  DirectoryInfo dirinfo=
              Directory.CreateDirectory("C:\test\test\test");
              //dirInfo.Fullname - полный путь к папке
              if (dirinfo.Exists) ;
              Console.WriteLine("Папка всё еще существует");
              Console.WriteLine(dirinfo.Name);
              //  dirinfo.Parent - предыдущая папка 
              // dirinfo.Root - корневая папка
              // dirinfo.GetDirectories() - массив вложенных директорий
              DirectoryInfo[] dirs = dirinfo.GetDirectories("Te*");
              FileInfo[] files = dirinfo.GetFiles("*"); // массив файлов 
              dirinfo.Create(); //создание папки
              dirinfo.Delete(); // удаление папки
              dirinfo.MoveTo("New destination"); // перемещение папки
              if (Directory.Exists(@"путь"))
                  Directory.Delete(@"путь");
              string [] files2 =   Directory.GetFiles("путь", "шаблон поиска");
              string[] dirs2 = Directory.GetDirectories("путь");
              DriveInfo[] drives = DriveInfo.GetDrives();
              var s = drives[0].Name; // имя диска
              long l = drives[0].TotalFreeSpace;// совободное пространство
              long size = drives[0].TotalSize; // общий размер
              long available = drives[0].AvailableFreeSpace;// доступное
              DirectoryInfo dir = drives[0].RootDirectory; // корневой каталог */
            //  var files = Directory.GetFiles(@"C:Documents and settings\");// защищается от ошибок 

            /*   try
               {
                   // Защащаемый код

               }
                catch(Exception e)
               {
                   //действие при ошибке
               }
               finally // необязательный 
               {
                   // блок, выполняемый после одного из блоков выше
               } */


            // Задача №1 



            /*      string command = null;
                  while (command != "exit")
                  {
                      command = Console.ReadLine();
                      switch (command)
                      {
                          case "init":
                              CreateFile();
                              break;
                          case "a":
                              MethodA();
                              break;
                          case "b":
                              MethodB();
                              break;
                          case "c":
                              MethodC();
                              break;
                      }
                  }
              }

              private static void MethodC()
              {
                  int count, itemsCount;
                  double itemsWeight;
                  Console.WriteLine("М кг?");
                  int.TryParse(Console.ReadLine(), out int m);
                  using (var fs = File.OpenRead(file))
                  using (var br = new BinaryReader(fs))
                  {
                      count = br.ReadInt32();
                      for (int i = 0; i < count; i++)
                      {
                          itemsCount = br.ReadInt32();
                          itemsWeight = br.ReadDouble();
                          if (itemsCount == 1 && itemsWeight < m)
                              Console.WriteLine($"{itemsCount} {itemsWeight}");
                      }
                  }
              }

              private static void MethodB()
              {
                  int count, averageCount, totalCount = 0, itemsCount = 0;
                  using (var fs = File.OpenRead(file))
                  using (var br = new BinaryReader(fs))
                  {
                      count = br.ReadInt32();
                      for (int i = 0; i < count; i++)
                      {
                          totalCount += br.ReadInt32();
                          fs.Seek(8, SeekOrigin.Current);
                      }
                      averageCount = totalCount / count;
                      fs.Seek(4, SeekOrigin.Begin);
                      int pCount2 = 0, pCountMoreAverage = 0;
                      for (int i = 0; i < count; i++)
                      {
                          itemsCount = br.ReadInt32();
                          fs.Seek(8, SeekOrigin.Current);
                          if (itemsCount > 2)
                              pCount2++;
                          if (itemsCount > averageCount)
                              pCountMoreAverage++;
                      }
                      Console.WriteLine($"Кол-во пассажиров с 3 и более вещами: {pCount2}");
                      Console.WriteLine($"Кол-во пассажиров с кол-вом вещей больше среднего: {pCountMoreAverage}");
                  }
              }

              private static void MethodA()
              {
                  Console.WriteLine("Число кг?");
                  int.TryParse(Console.ReadLine(), out int m);
                  double totalWeight = 0, averageWeight;
                  int totalCount = 0;
                  int count;
                  using (var fs = File.OpenRead(file))
                  using (var br = new BinaryReader(fs))
                  {
                      count = br.ReadInt32();
                      for (int i = 0; i < count; i++)
                      {
                          totalCount += br.ReadInt32();
                          totalWeight += br.ReadDouble();
                      }
                      averageWeight = totalWeight / totalCount;
                      fs.Seek(4, SeekOrigin.Begin);
                      int itemsCount;
                      double itemsWeight;
                      for (int i = 0; i < count; i++)
                      {
                          itemsCount = br.ReadInt32();
                          itemsWeight = br.ReadDouble();
                          if (Math.Abs(averageWeight - itemsWeight / itemsCount) <= m)
                          {
                              Console.WriteLine($"{itemsCount} {itemsWeight}");
                          }
                      }
                  }
              }

              private static void CreateFile()
              {
                  Console.WriteLine("кол-во пассажиров?");
                  int.TryParse(Console.ReadLine(), out int count);
                  using (var fs = File.Create(file))
                  using (var bw = new BinaryWriter(fs))
                  {
                      bw.Write(count);
                      for (int i = 0; i < count; i++)
                      {
                          Console.WriteLine("кол-во вещей?");
                          int.TryParse(Console.ReadLine(), out int itemsCount);
                          bw.Write(itemsCount);
                          Console.WriteLine("общий вес вещей?");
                          double.TryParse(Console.ReadLine(), out double itemsWeight);
                          bw.Write(itemsWeight);
                      }
                  }
              } */

            /*   {
                   ReadLibraryFile("Bibl.txt");

               }
               static List<LibraryEntry> ReadLibraryEnteries = new List<LibraryEntry>();
               using (FileStream fs = new FileStream (filepath, FileMode.OpenOrCreate, FileAccess.Read))
               {
                   using (StreamReader reader = new StreamReader (fs, Encoding.UTF8))
                   {
                       string currentString = reader.ReadLine();
                       string[] splittedString = currentString.Split(",");
                       LibraryEntry entry = new LibraryEntry
                       {
                           Author = splittedString[0],
                           BookName = splittedString [ 1]
                       }


                   }
               }   */










































































        }


    }
     
