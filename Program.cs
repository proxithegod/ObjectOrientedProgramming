namespace ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

           //Object oriented programming
           //Inheritance
           //Abstraction

            Dog dog = new Dog("blue", 23, "Bright", 3);
            Bird bird = new Bird("white", 2, "eagle");

            dog.CanFly(dog);
            bird.CanFly(bird);


            //Collection

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            numbers.Remove(3);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("blue", 23, "Bright", 3));
            animals.Add(bird);

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
                animal.CanFly
            }



            Console.ReadLine();
        }
    }
}