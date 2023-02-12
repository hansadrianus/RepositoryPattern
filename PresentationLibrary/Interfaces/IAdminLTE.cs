namespace PresentationLibrary.Interfaces
{
    public interface IAdminLTE
    {
        AdminLTEOptions Options { get; }
        AdminLTEClasses Classes { get; }
        bool IsSideBarCollapsed { get; }
        string SiteCopyright { get; }
    }
}