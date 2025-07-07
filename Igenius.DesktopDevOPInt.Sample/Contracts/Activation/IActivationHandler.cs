namespace Igenius.DesktopDevOPInt.Sample.Contracts.Activation;

public interface IActivationHandler
{
    bool CanHandle();

    Task HandleAsync();
}
