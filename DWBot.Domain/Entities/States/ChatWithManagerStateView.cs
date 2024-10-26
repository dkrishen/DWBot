namespace DWBot.Domain.Entities.States;

public sealed class ChatWithManagerStateView : BaseView
{
    public ChatWithManagerStateView(ChatWithManagerState state) : base(state)
    {
    }

    public override string Message =>
        "Свяжитесь с менеджером 💬\r\n\r\nНаш менеджер ответит на все ваши вопросы и поможет выбрать оптимальное решение для вашего бизнеса.\r\n\r\nhttps://t.me/miyarc";
    public override string MenuConfig => "Назад:";
}