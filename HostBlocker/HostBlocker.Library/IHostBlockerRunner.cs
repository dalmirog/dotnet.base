namespace HostBlocker.Library
{
    public interface IHostBlockerRunner
    {
        IEnumerable<Site> Run(SiteAction action);
    }
}