namespace DesignPatterns.Behavioral.Mediator;

public abstract class Component
{
    protected IMediator _mediator;
    
    public abstract void OnClick();
    public abstract void KeyPress();

    protected Component(IMediator mediator)
    {
        _mediator = mediator;
    }
}