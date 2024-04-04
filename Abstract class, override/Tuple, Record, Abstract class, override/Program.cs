namespace Tuple__Record__Abstract_class__override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            eagle e = new eagle() { Name = "asddf" };
            shark s = new shark() { Name = "zxcvb" };
            Parrot p = new Parrot() { Name = "asdfhjk" };

            s.Eat();
            s.Grow();

            animal[] animals = { e, s, p };

            Bird[] birds = { e, p, new Chicken() };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }

            foreach (Bird bird in birds)
            {
                bird.Fly();
            }

            Console.WriteLine(e);

            /* e.Eat();
             s.Eat();
             p.Eat();

             e.Fly();
             p.Fly();*/


        }
    }
}
