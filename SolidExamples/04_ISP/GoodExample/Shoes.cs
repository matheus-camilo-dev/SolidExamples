namespace SolidExamples._04_ISP.GoodExample
{
    internal interface IShoe
    {
        void PuttingOn();
        void TakeOff();
    }
    internal interface IShoeWithLaces
    {
        void TyingShoeLaces();
    }

    internal class SneakersShoe : IShoe, IShoeWithLaces
    {
        public void PuttingOn() { /* Some Code */ }
        public void TakeOff() { /* Some Code */ }
        public void TyingShoeLaces() { /* Some Code */ }
    }
    internal class Sandals : IShoe
    {
        public void PuttingOn() { /* Some Code */ }
        public void TakeOff() { /* Some Code */ }
    }
}
