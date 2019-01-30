namespace WpfApp1
{
    internal class Result
    {
        private string stringAnswer;
        private double doubleAnswer;

        public Result(double operatedResult)
        {
            this.stringAnswer = operatedResult.ToString();
        }

        public double getResult()
        {
            return this.doubleAnswer;
        }
    }
}