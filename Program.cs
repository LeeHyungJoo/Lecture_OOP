


var btn = new Button(new Lamp());
btn.Click();
btn.Click();
btn.Click();


interface SwitchableDevice
{
    public void TurnOn();
    public void TurnOff();
}

public class Lamp : SwitchableDevice
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
    public Button(SwitchableDevice device) { this.device = device; }

    public void Click()
    {
        if (bPressed)
            device?.TurnOff();
        else
            device?.TurnOn();

        bPressed = !bPressed;
    }

    private bool bPressed;
    private SwitchableDevice device;
}
