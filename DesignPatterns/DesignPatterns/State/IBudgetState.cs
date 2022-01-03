namespace DesignPatterns.State
{
    public interface IBudgetState
    {
        void ApplyExtraDiscount(Budget budget);
        void Approves(Budget budget);
        void Repproves(Budget budget);
        void Finish(Budget budget);
    }
}
