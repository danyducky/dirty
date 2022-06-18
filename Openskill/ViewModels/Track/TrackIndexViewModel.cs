using Openskill.ViewModels.Shared;

namespace Openskill.ViewModels.Track
{
    public class TrackIndexViewModel
    {
        public IEnumerable<TrackViewModel> Tracks { get; set; }

        public IEnumerable<TrackViewModel> AdditionalTracks { get; set; }
    }
}
