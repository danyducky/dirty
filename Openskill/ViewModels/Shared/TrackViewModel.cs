namespace Openskill.ViewModels.Shared
{
    public class TrackViewModel
    {
        public TrackViewModel(string title, string description, int id)
        {
            Title = title;
            Description = description;
            Id = id;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
