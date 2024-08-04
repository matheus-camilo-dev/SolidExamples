namespace SolidExamples._04_ISP.BadExample
{
    internal interface IShoe
    {
        void PuttingOn();
        void TakeOff();
        void TyingShoeLaces();
    }

    internal class SneakersShoe : IShoe
    {
        public void PuttingOn() { /* Some Code */ }
        public void TakeOff() { /* Some Code */ }
        public void TyingShoeLaces() { /* Some Code */ }
    }
    internal class Sandals : IShoe
    {
        public void PuttingOn() { /* Some Code */ }
        public void TakeOff() { /* Some Code */ }
        // Sandals don't have laces
        public void TyingShoeLaces() {
            throw new NotImplementedException(); 
        }
    }
}
