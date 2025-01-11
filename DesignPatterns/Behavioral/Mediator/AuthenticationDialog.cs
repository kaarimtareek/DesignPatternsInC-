namespace DesignPatterns.Behavioral.Mediator;

public class AuthenticationDialog : IMediator
{
    public string Title{get;set;}
    public bool LoginOrRegister {get;set;}
    public TextBox UserName {get;set;}
    public TextBox Password {get;set;}
    public Button Ok {get;set;}
    public Button Cancel {get;set;}
    public Checkbox RememberMe {get;set;}

    public AuthenticationDialog()
    {
        UserName = new TextBox(this);
        Password = new TextBox(this);
        Ok = new Button(this, "OK");
        Cancel = new Button(this, "Cancel");
        RememberMe = new Checkbox(this);
        LoginOrRegister = true;
        Title = LoginOrRegister ? "Login" : "Register";
        
    }
    public void Notify(Component component, string eventName)
    {
        if (component is Button  && component == Ok && eventName == "click")
        {
            //try to login
            
        }

        if (component == RememberMe && eventName == "click")
        {
            //save credentials
        }
        //the rest of the code like this
        
    }
}