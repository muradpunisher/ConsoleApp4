using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Hello World!");
            //Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod.Misalçün metodu çağırıb array elementimi və 5 dəyəri göndərsəm,
            //arrayim dəyişilməli və arrayin  içində əvəlki elementləri,
            //əlavə olaraq son indexində isə 5 elementi olmalıdır və arrayin uzunluğu 1 vahid artmış olmalıdır.(metod geriye dəyər qaytarmır)
            int[] numbers = new int[] { 4, 8, 24, 87 };
            AddSomething(numbers, 5);
            //Verilmiş yazıda rəqəm olub olmadığını tapan metod.Göndərilən yazıda rəqəm varsa true yoxdursa false qaytarır
            Console.WriteLine(char.IsDigit('6'));
        }

        

        static void AddSomething(int[]nums,int digit)
        {
            int[] newAdd = new int[nums.Length+1];
            for (int i = 0; i < nums.Length; i++)
            {
                newAdd[i] = digit;
            }
            newAdd[newAdd.Length-1]= digit;
            
        }
        

        
        

    }


}
