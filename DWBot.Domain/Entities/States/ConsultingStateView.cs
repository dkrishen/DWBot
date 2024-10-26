namespace DWBot.Domain.Entities.States;

public sealed class ConsultingStateView : BaseView
{
    public ConsultingStateView(ConsultingState state) : base(state)
    {
    }

    public override string Message => """
                                      Вы выбрали "Консалтинг" 📊
                                      
                                      Наши эксперты помогут вам оптимизировать бизнес-процессы и внедрить передовые технологии для повышения эффективности вашей компании.
                                      """;
    public override string MenuConfig => "Что бы вы хотели сделать дальше?";
}