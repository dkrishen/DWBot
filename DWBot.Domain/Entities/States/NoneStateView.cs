namespace DWBot.Domain.Entities.States;

public sealed class NoneStateView : BaseView
{
    public NoneStateView(NoneState state) : base(state)
    {
    }

    public override string Message => "Кажется, я не знаю такой команды 👀";
    public override string MenuConfig => "Назад:";
}