using PAT.Models.Repositories;

namespace PAT.ViewModels
{
    public class AvailabilityViewViewModel
    {
        private readonly IAvailabilityRepository _repository;

        public AvailabilityViewViewModel(IAvailabilityRepository availabilityRepository) { 

            _repository = availabilityRepository;
        }
    }
}
