namespace Openskill.Domain.Entities
{
    public class Track
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsAdditional { get; set; }

        public ICollection<TrackModule> TrackModules { get; set; }
    }
}
