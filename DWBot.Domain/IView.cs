namespace DWBot.Domain;

public interface IView
{
    string Message { get; }
    string MenuConfig { get; }
    List<(string, string)> GetMenu();
}