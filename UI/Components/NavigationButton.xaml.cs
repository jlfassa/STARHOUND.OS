using System.Windows.Controls;


namespace STARHOUND.OS.UI.Components;


public partial class NavigationButton : UserControl
{


    public NavigationButton()
    {
        InitializeComponent();
    }




    public string Text
    {

        get
        {
            return ButtonText.Text;
        }


        set
        {
            ButtonText.Text = value;
        }

    }


}