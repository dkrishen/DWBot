using DWBot.Domain.Entities.States;

namespace DWBot.Domain;

public abstract class BaseView : IView
{
    private readonly BaseState _state;
    
    protected BaseView(BaseState state)
    {
        _state = state;
    }
    
    public abstract string Message { get; }
    public abstract string MenuConfig { get; }
    
    public List<(string, string)> GetMenu()
    {
        var buttonConfigs = _state.Transitions
            .Select(stateType =>
                (CommandMapper.ButtonTextByStateType(stateType), CommandMapper.CommandTextByStateType(stateType))
            )
            .ToList();

        return buttonConfigs;
    }
}