namespace Openskill.ViewModels.Track
{
    public class TrackModuleViewModel : TrackBaseViewModel
    {
        public int ModuleId { get; set; }

        public string Caption { get; set; }

        public string Content { get; set; }

        public string VideoPath { get; set; }

        public bool IsLast { get; set; }
    }
}
