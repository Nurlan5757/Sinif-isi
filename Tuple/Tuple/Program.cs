namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {

            (int num, string text, double nums) result = A();
            Console.WriteLine(result.nums);

          /*  var result = B();
            Console.WriteLine(result);*/

            /*(int a, int b, int c ) result= C();
            result.a = 35;
            Console.WriteLine(result);*/


        }
        static (int, string, double) A()
        {
            return (5, "salam", 3.5);
        }
       /* static (int, string, byte) B()
        {
            return (12, "netersiz", 23);
        }*/

        /*static (int a,int b, int c) C()
        {
            return (1,2,3);
        }*/


    }
}
