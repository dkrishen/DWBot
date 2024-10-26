namespace DWBot.Domain.Entities.States;

public sealed class SupportStateView : BaseView
{
    public SupportStateView(SupportState state) : base(state)
    {
    }

    public override string Message => """
                                      Вы выбрали "Поддержка" 🛠
                                      
                                      Мы обеспечим надежную поддержку и обслуживание ваших систем, чтобы они работали без перебоев и сбоев.
                                      """;
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";
}