using CommunityToolkit.Mvvm.ComponentModel;

namespace Escape.ViewModels;

public partial class JuegoModel : ViewModelBase
{
    [ObservableProperty]
    private string _prueba = "Diálogo lorem ipsum dolor sit amet";
}
