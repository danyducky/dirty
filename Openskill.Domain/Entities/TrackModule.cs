namespace Openskill.Domain.Entities
{
    public class TrackModule
    {
        public int TrackId { get; set; }

        public int ModuleId { get; set; }

        public Track Track { get; set; }

        public Module Module { get; set; }
    }
}
