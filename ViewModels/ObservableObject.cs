using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace STARHOUND.OS.ViewModels;


public abstract class ObservableObject : INotifyPropertyChanged
{

    public event PropertyChangedEventHandler? PropertyChanged;



    protected void OnPropertyChanged(
        [CallerMemberName] string? propertyName = null)
    {

        PropertyChanged?.Invoke(
            this,
            new PropertyChangedEventArgs(propertyName)
        );

    }

}