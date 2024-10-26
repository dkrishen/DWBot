namespace DWBot.Domain.Entities.States;

public sealed class DesignStateView : BaseView
{
    public DesignStateView(DesignState state) : base(state)
    {
    }

    public override string Message => "Вы выбрали \"Дизайн\" 🎨\r\n\r\nНаши дизайнеры создадут уникальный и привлекательный дизайн для вашего проекта, который подчеркнет его индивидуальность.";
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";
}