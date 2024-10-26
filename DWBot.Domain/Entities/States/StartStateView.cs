namespace DWBot.Domain.Entities.States;

public sealed class StartStateView : BaseView
{
    public StartStateView(StartState state) : base(state)
    {
    }

    public override string Message => """
                                      Привет! 👋  
                                      Спасибо, что выбрали нас. Мы предлагаем широкий выбор IT-услуг и готовы помочь вам с любыми задачами.
                                      """;
    public override string MenuConfig => "Пожалуйста, выберите услугу, которая вас интересует:";
}