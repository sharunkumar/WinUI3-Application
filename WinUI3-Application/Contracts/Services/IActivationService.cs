using System.Threading.Tasks;

namespace WinUI3_Application.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
