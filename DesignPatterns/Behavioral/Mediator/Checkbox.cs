namespace DesignPatterns.Behavioral.Mediator;

public class Checkbox : Component
{
    public Checkbox(IMediator mediator) : base(mediator)
    {
    }

    private bool _value;
    public void Check()
    {
        _value = !_value;
    }

    public bool Value => _value;
    public override void OnClick()
    {
        _mediator.Notify(this, "click");
    }

    public override void KeyPress()
    {
        _mediator.Notify(this, "keypress");
    }
}