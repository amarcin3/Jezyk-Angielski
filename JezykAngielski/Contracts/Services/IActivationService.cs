using System.Threading.Tasks;

namespace JezykAngielski.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
