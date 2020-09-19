namespace Hypergeometric.API.Cards.Interfaces
{
    public interface IMultipleTapOptionCard
    {
        LandColor[] SecondaryColors { get; set; }
        string ConditionalManaUse { get; set; }
    }
}