namespace DesignPatterns.Observer.Solution
{
    public interface IActionAfterGenerateInvoice
    {
        void Execute(Invoice invoice);
    }
}
