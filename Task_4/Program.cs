using System.Linq.Expressions;

namespace Task_4;

class Program
{
    static void Main(string[] args)
    {


        // 1.Ədədlərdən ibarət arrayın ən kiçik elementini tapın

        //int[] arry = { 54, 67, 99, 5, 67, 12, 43, 3, 99 };

        //int i = 1, temp = arry[0];
        //for (; i < arry.Length; i++)
        //{
        //    if (arry[i] < temp)
        //        temp = arry[i];

        //}
        //Console.WriteLine($"Array de en kicik element :{temp}");



        //2.Sozlerden ibaret arrayde uzunlugu 4 - den boyuk olan sozleri ekrana çap edin

        //string[] arry = { "dag", "das", "su", "bulaq", "agaclar" };

        //for (int i = 0; i < arry.Length; i++)
        //{
        //    if (arry[i].Length > 4)
        //    Console.WriteLine(arry[i]);

        //}






        //3.Ədədlərdən ibarət arrayda neçə rəqəm olduğunu ekrana çap edin(Məs: { 1,77,6,14}
        //arrayında 2 rəqəm var )

        //int[] arry = { 11, 2, 35, 46, 5, 67, 7, 89, 99, 10, };

        //for (int i = 0; i < arry.Length; i++)
        //{
        //    if (arry[i] < 10)
        //        Console.WriteLine(arry[i]);
        //}




        // 4.Verilmish sozde 'a' herfi olub olmadigini tapan alqoritm

        //string data = "Baku";
        //int i = 0, count = 0;
        //for (; i < data.Length; i++)
        //{
        //    if (data[i] == 'a')
        //    {
        //        count++;
        //        Console.WriteLine($"{data}  sozunde a herfi vardir");
        //    }
        //}
        //if (count == 0)
        //    Console.WriteLine($"{data}  sozunde a herfi yoxdur");




        //5.(optional) Yalniz 1 for dongusu ile siralanmamish arrayi siralamaga calishin(qiymete tesir etmir)
        //int[] arry = { 17, 6, 33, 4, 55, 3, 77, 88, };

        //int n = arry.Length;
        //for (int i = 0; i < n * (n + 1) / 2; i++)
        //{
        //    int pass = i / n; 
        //    int j = i % n; 

        //    if (j + 1 < n && arry[j] > arry[j + 1])
        //    {
        //        int temp = arry[j];
        //        arry[j] = arry[j + 1];
        //        arry[j + 1] = temp;
        //    }
        //}

        //foreach (var item in arry)
        //{
        //    Console.WriteLine(item);
        //}


    }
}
