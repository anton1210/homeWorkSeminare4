/* Задача 25: Напишите метод, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B. Math.Pow использовать нельзя
(3, 5 -> 243 (3⁵)   2, 4 -> 16) */

void Degree(int A, int B)
{
    int rez = 1;
    for (int i = 0; i < B; i++)
    {
        rez = A * rez;
    }
    Console.WriteLine(rez);
}
Degree(3, 5);
