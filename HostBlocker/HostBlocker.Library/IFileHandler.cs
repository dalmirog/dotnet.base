namespace HostBlocker.Library
{
    public interface IFileHandler
    {
        IEnumerable<Site> GetSites();
        IEnumerable<Site> ReadHostFile();
        void WriteHostFile();
    }
}