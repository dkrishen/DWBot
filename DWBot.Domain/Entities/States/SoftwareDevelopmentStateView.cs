namespace DWBot.Domain.Entities.States;

public sealed class SoftwareDevelopmentStateView : BaseView
{
    public SoftwareDevelopmentStateView(SoftwareDevelopmentState state) : base(state)
    {
    }

    public override string Message => """
                                      Вы выбрали "Разработка ПО" 🖥
                                      
                                      Наша команда поможет вам создать надежное и современное программное обеспечение, которое идеально подойдет для вашего бизнеса.
                                      """;
    public override string MenuConfig => "Выберите, какое ПО вас интересует:";
}