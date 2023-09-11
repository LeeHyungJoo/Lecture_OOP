


var btn = new Button(new Lamp());
btn.Click();
btn.Click();
btn.Click();


interface ILight
{
    public void TurnOn();
    public void TurnOff();
}

public class Lamp : ILight
{
    public void TurnOff()
    {
        Console.WriteLine("Turn Off");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turn On");
    }
}


class Button
{
    public Button(ILight lamp) { this.lamp = lamp; }

    public void Click()
    {
        if (bPressed)
            lamp?.TurnOff();
        else
            lamp?.TurnOn();

        bPressed = !bPressed;
    }

    private bool bPressed;
    private ILight lamp;
}
