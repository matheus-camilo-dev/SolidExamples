namespace SolidExamples._03_LSP.BadExample
{
    internal class Animal { }
    internal class Dog : Animal
    {
        public void Bark() { /* Some Code */ }
    }

    internal class  Cat : Animal
    {
        public void Meow() { /* Some Code*/ }
    }

    internal class Pet
    {
        void DoAnimalSong(Animal animal)
        {
            if (animal is Cat) 
            {
                ((Cat)animal).Meow();
            }
            else if (animal is Dog)
            {
                ((Dog)animal).Bark();
            }
        }
    }
}
