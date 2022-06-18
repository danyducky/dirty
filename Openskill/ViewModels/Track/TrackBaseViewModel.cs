using Openskill.ViewModels.Shared;

namespace Openskill.ViewModels.Track
{
    public class TrackBaseViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public IEnumerable<ModuleViewModel> Modules { get; set; }
    }
}
