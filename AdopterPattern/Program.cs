using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientClass client = new ClientClass(new Adopter());
            client.ConsumingMethod();

            client = new ClientClass(new AdopterB());
            client.ConsumingMethod();

            Console.ReadLine();
        }
    }

    class ClientClass
    {
        IAdopter adpt;
        public ClientClass (IAdopter adpt)
        {
            this.adpt = adpt;
        }

        public void ConsumingMethod()
        {
            adpt.ComplexOperation();
        }
    }
}
