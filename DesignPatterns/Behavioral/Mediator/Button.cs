namespace DesignPatterns.Behavioral.Mediator;

public class Button : Component
{
    public String Text { get; }
    public Button(IMediator mediator, string text) : base(mediator)
    {
        Text = text;
    }

    public override void OnClick()
    {
        
        this._mediator.Notify(this, "click");
    }

    public override void KeyPress()
    {
        this._mediator.Notify(this, "keypress");
    }
}