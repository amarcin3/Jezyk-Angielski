using System.Threading.Tasks;

namespace JezykAngielski.Activation;

public interface IActivationHandler
{
    bool CanHandle(object args);

    Task HandleAsync(object args);
}
