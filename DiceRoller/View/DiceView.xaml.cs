using DiceRoller.ViewModel;

namespace DiceRoller.View;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
        BindingContext = new DiceViewModel();
    }
}