using System.Threading.Tasks;

namespace WinUI3_Application.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle(object args);

        Task HandleAsync(object args);
    }
}
