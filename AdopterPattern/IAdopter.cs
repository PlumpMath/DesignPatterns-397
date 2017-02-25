namespace AdopterPattern
{
    internal interface IAdopter
    {
        void ComplexOperation();
    }

    class Adopter : IAdopter
    {
        public void ComplexOperation()
        {
            FrameworkClass b = new FrameworkClass();
            b.PerformComplexOperation();
        }
    }

    class AdopterB : IAdopter
    {
        public void ComplexOperation()
        {
            LibraryClass l = new LibraryClass();
            l.PerformSimpleOperation();
        }
    }
}