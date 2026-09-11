namespace Polimorfismo
{
    public class Animal
    {
        public virtual void EmitirSom()
            {
                Console.WriteLine("Som genérico de animal...");
            }
        }

        public class Leao : Animal
        {
            public override void EmitirSom()
            {
                Console.WriteLine("ROAR!");
            }
        }

        public class Macaco : Animal
        {
            public override void EmitirSom()
            {
                Console.WriteLine("UGH UGH AAH AAH!");
            }
        }

        public class Cobra : Animal
        {
            public override void EmitirSom()
            {
                Console.WriteLine("SSSSSSS...");
            }
        }
}
