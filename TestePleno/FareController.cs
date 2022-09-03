namespace TestePleno
{
    public class FareController
    {
        private OperatorService _operatorService;
        private FareService _FareService;

        public FareController()
        {
            _operatorService = new OperatorService();
            _FareService = new FareService();
        }

        public void CreateFare(Fare fare, Operator operatorCode)
        {
            _operatorService.Create(operatorCode);
            var selectedOperator = _operatorService.GetOperatorByCode(operatorCode.Code);
            fare.OperatorId = selectedOperator.Id;

            _FareService.Create(fare);
        }
    }
}
