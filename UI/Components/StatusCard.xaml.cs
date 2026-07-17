using System.Windows.Controls;


namespace STARHOUND.OS.UI.Components;


public partial class StatusCard : UserControl
{

    public StatusCard()
    {
        InitializeComponent();
    }



    public void SetData(string title, string value, double percentage)
    {

        TitleText.Text = title;

        ValueText.Text = value;

        StatusBar.Value = percentage;

    }

}