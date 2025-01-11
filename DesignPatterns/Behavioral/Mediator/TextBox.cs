namespace DesignPatterns.Behavioral.Mediator;

public class TextBox : Component
{
    public string Text { get; set; }
    public TextBox(IMediator mediator) : base(mediator)
    {
    }

    public override void OnClick()
    {
        _mediator.Notify(this, "click");
    }

    public override void KeyPress()
    {
        this._mediator.Notify(this, "keypress");
    }
}