namespace Chain_of_Responsibility
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    internal abstract class Approver
    {
        protected Approver Successor;

        public void SetSuccessor(Approver successor)
        {
            Successor = successor;
        }
        public abstract void ProcessRequest(Purchase purchase);
    }
}
