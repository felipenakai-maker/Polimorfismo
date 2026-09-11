namespace Polimorfismo
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual double CalcularBonusAnual()
        {
            return Salario * 0.10;
        }
    }

    class Gerente : Funcionario
    {
        public override double CalcularBonusAnual()
        {
            return (Salario * 0.15) + 1000;
        }
    }

    class Desenvolvedor : Funcionario
    {
        public override double CalcularBonusAnual()
        {
            return Salario * 0.12;
        }
    }
}
