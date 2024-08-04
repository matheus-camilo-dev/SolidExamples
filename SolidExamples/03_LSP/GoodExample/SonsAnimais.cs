namespace SolidExamples._03_LSP.GoodExample
{
    internal abstract class Animal 
    {
        public virtual void MakeSong() 
        {
            /* Default Song */
        }
    }
    internal class Dog : Animal
    {
        public override void MakeSong() 
        { 
            /* Some Code For Dog */ 
        }
    }

    internal class Cat : Animal
    {
        public override void MakeSong()
        {
            /* Some Code For Cat */
        }
    }

    internal class Pet
    {
        void DoAnimalSong(Animal animal)
        {
            animal.MakeSong();
        }
    }
}
