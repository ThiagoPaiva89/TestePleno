using System;
namespace TestePleno
{
    class Program
    {
        static void Main(string[] args)
        {
            var fare = new Fare();
            var operators = new Operator();

            fare.Id = Guid.NewGuid();
            operators.Id = Guid.NewGuid();

            Console.WriteLine("Informe o valor da tarifa a ser cadastrada:");
            var fareValueInput = Console.ReadLine();
            fare.Value = decimal.Parse(fareValueInput);

            Console.WriteLine("Informe o código da operadora para a tarifa:");
            Console.WriteLine("Exemplos: OP01, OP02, OP03...");
            var operatorCodeInput = Console.ReadLine();
            operators.Code = operatorCodeInput;

            var fareController = new FareController();
            fareController.CreateFare(fare, operators);

            Console.WriteLine("Tarifa cadastrada com sucesso!");
            Console.Read();
        }
    }
}
