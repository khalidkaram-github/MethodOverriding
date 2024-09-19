namespace MethodOverriding
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dog = new ChildDog();
            dog.Speak();
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Dog makes a sound.");
        }
    }



    public class ChildDog : Dog
    {
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Child Dog makes a sound.");
        }
    }


}
