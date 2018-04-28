namespace Mondop.Core
{
    public interface IDirectory
    {
        bool Exists(string path);
        void CreateDirectory(string path);
        string[] GetDirectories(string path);
        string[] GetFiles(string path);
        string[] GetFiles(string path, string searchPattern);
     }
}
