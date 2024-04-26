using PAT.Models.Repositories;
using PAT.ViewModels;

namespace PAT.Views;

public partial class AvailabilityView : ContentPage
{

	private readonly AvailabilityViewViewModel _viewModel;

	public AvailabilityView(IAvailabilityRepository availabilityRepository)
	{

        _viewModel = new AvailabilityViewViewModel(availabilityRepository);
		InitializeComponent();
	}
}
