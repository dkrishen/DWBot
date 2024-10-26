namespace DWBot.Domain.Entities.States;

public sealed class ChatWithManagerStateView : BaseView
{
    public ChatWithManagerStateView(ChatWithManagerState state) : base(state)
    {
    }

    public override string Message => """
                                      Свяжитесь с менеджером 💬
                                      
                                      Наш менеджер ответит на все ваши вопросы и поможет выбрать оптимальное решение для вашего бизнеса.
                                      
                                      https://t.me/miyarc
                                      """;
    public override string MenuConfig => "Назад:";
}