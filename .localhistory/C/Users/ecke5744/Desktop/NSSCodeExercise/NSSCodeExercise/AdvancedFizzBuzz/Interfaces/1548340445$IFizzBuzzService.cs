using System.Threading.Tasks;

namespace AdvancedFizzBuzz.Interfaces
{
    public interface IFizzBuzzService
    {
        Task DoFizzBuzz(int lowVal, int highVal);
    }
}
