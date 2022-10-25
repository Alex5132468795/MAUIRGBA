//using static Java.Util.Jar.Attributes;

namespace MauiApp8;

public partial class MainPage : ContentPage
{
    public double r=0;
    public double y=0;
    public double b=0;
    public double a=1;
    public bool flagA = false;
    public MainPage()
	{
		InitializeComponent();
    }
	public void ValueChangedR(object sender, ValueChangedEventArgs e)
	{
        r = e.NewValue;
        if (flagA)
        {
            Pic.Fill = Color.FromRgba(r/255, y / 255, b / 255, a);
        }
        else
        {

            Pic.Fill = Color.FromRgb(r / 255, y / 255, b / 255);
        }
    }
    public void ValueChangedY(object sender, ValueChangedEventArgs e)
    {
        y = e.NewValue;
        if (flagA)
        {
            Pic.Fill = Color.FromRgba(r, y, b, a);
        }
        else
        {

            Pic.Fill = Color.FromRgb(r, y, b);
        }
    }
    public void ValueChangedB(object sender, ValueChangedEventArgs e)
    {
        b = e.NewValue;
        if (flagA)
        {
            Pic.Fill = Color.FromRgba(r, y, b, a);
        }
        else
        {

            Pic.Fill = Color.FromRgb(r, y, b);
        }
    }
    public void ValueChangedA(object sender, ValueChangedEventArgs e)
    {
        a = e.NewValue;
        if (flagA)
        {
            Pic.Fill = Color.FromRgba(r, y, b, a);
        }
        else
        {

            Pic.Fill = Color.FromRgb(r, y, b);
        }
    }
    private void AStat(object sender, CheckedChangedEventArgs e)
    {
        flagA = e.Value;
    }
}

