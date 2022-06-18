namespace Openskill.Domain.Entities
{
    public class Module
    {
        public int Id { get; set; }

        /// <summary>
        /// Module title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Module content.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Module video path.
        /// </summary>
        public string VideoPath { get; set; }

        public ICollection<TrackModule> TrackModules { get; set; }
    }
}
