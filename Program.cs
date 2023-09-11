
var btn = new Button(new Lamp());
btn.Click();
btn.Click();
btn.Click();


class Lamp
{
    public Lamp() { }
    public void TurnOn() { Console.WriteLine("turn on"); }
    public void TurnOff() { Console.WriteLine("turn off"); }
}

class Button
{
    public Button(Lamp lamp) { this.lamp = lamp; }

    public void Click()
    {
        if (bPressed)
            lamp?.TurnOff();
        else
            lamp?.TurnOn();

        bPressed = !bPressed;
    }

    private bool bPressed;
    private Lamp lamp;
}
