using SoUs.CareApp.ViewModels;

namespace SoUs.CareApp.Views;

public partial class MedicineTaskPage : ContentPage
{
	public MedicineTaskPage(MedicineTaskViewmodel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}