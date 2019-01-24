using System.Threading.Tasks;

namespace AdvancedFizzBuzz.Interfaces
{
    public interface IFizzBuzzService
    {
        Task DoFizzBuzzAsync(int lowVal, int highVal);
    }
}
