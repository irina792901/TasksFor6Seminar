/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите массив через пробел, запятую, знаки ; : или / ");
int count = ReadLine().Split(new char[]{' ', ',', ':', ';', '/'},
StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray().
Where(a=>a>0).Count();
WriteLine(count);


