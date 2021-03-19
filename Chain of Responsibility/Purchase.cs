namespace Chain_of_Responsibility
{
    /// <summary>
    /// Class holding request details
    /// </summary>
    internal class Purchase
    {
        public Purchase(int number, double amount, string purpose)
        {
            Number = number;
            Amount = amount;
            Purpose = purpose;
        }
        public int Number { get; set; }

        public double Amount { get; set; }

        public string Purpose { get; set; }
    }
}