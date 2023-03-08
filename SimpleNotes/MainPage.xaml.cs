using SimpleNotes.ViewModel;

namespace SimpleNotes;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainWindowViewModel viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;
	}

	
}

