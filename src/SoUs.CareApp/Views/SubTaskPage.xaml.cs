using SoUs.CareApp.ViewModels;
using SoUs.Entities;

namespace SoUs.CareApp.Views;

public partial class SubTaskPage : ContentPage
{
	public SubTaskPage(SubTaskPageViewmodel subTaskPageViewmodel)
	{
		InitializeComponent();
		BindingContext = subTaskPageViewmodel;
	}
}