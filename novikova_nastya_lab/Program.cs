using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace novikova_nastya 
{
    internal class Program
    {
        static void Main(string[] args)
        {


        //задание 1. Вывести на экран число е (основание натурального логарифма) с точностью до десятых
        //Console.WriteLine("задание 1");
        //Console.WriteLine(Math.Round(Math.Exp(1), 1));
        //Console.ReadLine();


        //задание 2 Вывести на экран числа 50 и 10 одно под другим
        //Console.WriteLine("задание 2");
        //Console.WriteLine(50);
        //Console.WriteLine(10);
        //Console.WriteLine("");
        //Console.ReadLine();


        //задание 3.Составить программу вывода на экран "столбиком" четырех любых чисел
        //Console.WriteLine("задание 3");
        //int a = 3;
        //int b = 5;
        //int c = 30;
        //int d = 48;
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);
        //Console.WriteLine(d);
        //Console.ReadLine();


        //задание 4. Пользователь вводит число.Выведите на экран число,которое больше введенного на 10
        //Console.WriteLine("задание 4");
        //int a = 14;
        //int b = a + 10;
        //Console.WriteLine(b);
        //Console.ReadLine();


        //задание 5.Дана сторона квадрата.Найти его периметр
        //Console.WriteLine("задание 5");
        //double a = 6;
        //double p = 4 * a;
        //Console.WriteLine(p);
        //Console.ReadLine();


        //задание 6. Дан радиус окружности.Найти длину окружности и площадь круга
        //Console.WriteLine("задание 6");
        //double r = 7;
        //double l = 2 * Math.PI * r;
        //double s = Math.PI * r * r;
        //Console.WriteLine(l);
        //Console.WriteLine(s);
        //Console.ReadLine();


        //задание 7.Найти значение y=cos(x)
        //Console.WriteLine("задание 7");
        //double x = 1.0;
        //double y = Math.Cos(x);
        //Console.WriteLine(y);
        //Console.ReadLine();


        //задание 8.Даны основание и высота равнобедренной трапеции.Найти ее периметр
        //Console.WriteLine("задание 8")  ;
        //double a = 4;//нижнее основание
        //double b = 2;//верхнее основание
        //double h = 6;
        //double d = Math.Sqrt(h * h + Math.Pow((a - b) /2, 2));
        //double p = a + b + d * 2;
        //Console.WriteLine(p) ;
        //Console.ReadLine();


        //задание 9.Известна стоимость 1 кг конфет, печенья и яблок.Найти стоимость всей покупки, если купили х кг конфет ,у кг печенья и z кг яблок  .
        //Console.WriteLine("задание 9")  ;
        //double x = 2;
        //double y = 1;
        //double z = 4;
        //double s = x + y + z;
        //Console.WriteLine(s) ;
        //Console.ReadLine();


        //задание 10.Напишите программу ,которая выводит на экран при троки Мир Труд и Май
        //Console.WriteLine("задание 10")   ;
        //Console.WriteLine("Мир Труд Май");
        //Console.WriteLine("Мир");
        //Console.WriteLine("    Труд");
        //Console.WriteLine("           Май");
        //Console.ReadLine();


        //задание 11.Программа просит пользователя ввести 2 числовые переменные.А после она меняет их местами и
        //выводит результат на экран.Но ,так как пользователь может ошибиться ,необходимо предусмотреть тот факт,
        //что пользователь может ввести букву или строку ,а также учесть,что число может быть дробным,и для выделения
        //ее дробной части одни используют точку, а другие-запятую
        //задание 12


        //задание 13.Составить программу вывода на экран числа,вводимого с клавиатуры.Вводимому числу должно 
        //предшествовать сообщение "Вы ввели число"
        //Console.WriteLine("задание 13");
        //Console.WriteLine("Введите число:");
        //string input = Console.ReadLine();
        //Console.WriteLine("Вы ввели число " + input);
        //Console.ReadLine();



        //задание 14.Составить программу вывода на экран:
        //2 кг
        //13 17
        //Console.WriteLine("задание 14");
        //Console.WriteLine("2 кг");
        //Console.WriteLine("13 17");
        //Console.ReadLine();


        //задание 15.Составить программу вывода на экран столбиком четырех случайных чисел
        //Console.WriteLine("задание 15");
        //Random random = new Random();
        //for (int i = 0; i < 4; i++) ;
        //int r = random.Next(1, 101);
        //Console.WriteLine(r);
        //Console.ReadLine();


        //задание 16.Найти корни квадратного уравнения ( коэффиценты задаются пользователем с клавиатуры)
        //Console.WriteLine("задание 16");
        //double a = Convert.ToDouble(Console.ReadLine());
        //double b = Convert.ToDouble(Console.ReadLine());
        //double c = Convert.ToDouble(Console.ReadLine());
        //double D = b * b - 4 * a * c;
        //    if (D > 0) ;
        //        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
        //       double x2 = (-b - Math.Sqrt(D)) / (2 * a) ;
        //    else if (D == 0) ;
        //        double x = -b / (2 * a);
        //    else
        //        Console.WriteLine("корней нет");

        //задание 17.Даны два целых числа .Найти их среднее арифметическое и средне геометрическое
        //Console.WriteLine("задание 17");
        //double a = 4;
        //double b = 6;
        //double ar = (a + b) / 2;    
        //double geo = Math.Sqrt(a * b);
        //Console.WriteLine(ar);
        //Console.WriteLine(geo);
        //Console.ReadLine();


        //задание 18.Известны координаты на плоскости двух точек.Составить программу вычисления расстояния между ними
        //Console.WriteLine("задание 18");
        //double x1 = 0;
        //double y1 = 1;

        //double x2 = 3;
        //double y2 = 6;

        //double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        //Console.WriteLine(d);
        //Console.ReadLine();


        //задание 19.Составить программу обмена значениями трех переменных величин a,b,c по схемам:
        //b присвоить значение а , с присвоить значение b,c присвоить значение а
        //b присвоить значение a,c присвоить значение b,a присвоить значение c
        //Console.WriteLine("задание 19.1");
        //int a = 1;
        //int b = 2;
        //int c = 3;
        //int g1 = b;
        //b = c;
        //a = g1;
        //c = a;
        
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);
        //Console.ReadLine();

        //Console.WriteLine("задание 19.2");
        //int a = 1;
        //int b = 2;
        //int c = 3;

        //int g2 = b;
        //b = a;
        //c = g2;
        //a = c;

        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);
        //Console.ReadLine();

        //задание 20.C начала суток прошло n секунд .Определить сколько прошло часов минут и секунд
        //Console.WriteLine("задание 20");
        //int n = 3600;
        //int h = n / 3600;
        //int m = n / 60;

        //Console.WriteLine(h);
        //Console.WriteLine(m);
        //Console.WriteLine(n);
        //Console.ReadLine();

        //задание 21.Дан прямоугольник с размерами 543 на 130.Сколько квадратов с размером 130 можно отрезать?
        //Console.WriteLine("задание 21");
        //int prw = 543;
        //int prh = 130;

        //int s = 130;
        //int ss = (prw /s) * (prh /s);
        //Console.WriteLine(ss);
        //Console.ReadLine();

        //задание 22.Дано трехзначное число.В нем зачеркнули последнюю цифру справа и приписали ее в начале.Найти число
        //Console.WriteLine("задание 22");


        //задание 23.Дано натуральное число n (n>999).Найти число сотен и число тысяч в нем
        //Console.WriteLine("задание 23");

        //задание 24.1 Дано четырехзначное число.Найти число полученное при прочтении его цифр справа налево
        //Console.WriteLine("задание 24");

        //задание 25
        //Console.WriteLine("задание 25")//;

        //задание 26
        //Console.WriteLine("задание 26");
        //double y = Convert.ToDouble(Console.ReadLine());
        //if (y < 0 || y > 2) ;
        //Console.WriteLine("ошибка");
        //return;
        //int h = 0;
        //double m = (y / 0.5);
        //int r = (int)m;//вычисление полных минут
        //double a = 6 * r;
        // Console.WriteLine(r);
        //Console.WriteLine(a);
        //Console.ReadLine();

        //задание 28
        //Console.WriteLine("задание 28");
        //double n1 = Convert.ToDouble(Console.ReadLine());
        //double n2 = Convert.ToDouble(Console.ReadLine());
        //double n3 = Convert.ToDouble(Console.ReadLine());
        //double minAbsV = Math.Abs(n1);
        //double minN = n1;

        //if (Math.Abs(n2) < minAbsV) 
               // minAbsV = Math.Abs(n2);
        //minN = n2;
        //if (Math.Abs(n3) < minAbsV)
                //minAbsV = Math.Abs(n3);
       // minN = n3;
        //Console.WriteLine(minN);
        //Console.ReadLine();
        
         
        










        }
    }
}
