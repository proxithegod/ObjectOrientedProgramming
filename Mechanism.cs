using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public abstract class Mechanism
    {
        public virtual void CanFly(Animal animal)
        {
            if (animal is Dog dog)
            {
                Console.WriteLine($"{dog.Name} cannot fly");
            } else if (animal is Bird bird)
            {
                Console.WriteLine($"{bird.Name} can fly");
            }

        }
    }
}
