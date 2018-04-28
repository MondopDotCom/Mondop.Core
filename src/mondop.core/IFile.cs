using System.Text;

namespace Mondop.Core
{
    public interface IFile
    {
        bool Exists(string path);
        string[] ReadAllLines(string path);
        string ReadAllText(string path);
        byte[] ReadAllBytes(string path);

        void WriteAllLines(string path, string[] contents);
        void WriteAllLines(string path, string[] contents, Encoding encoding);
        void WriteAllBytes(string path, byte[] bytes);
        void WriteAllText(string path, string contents);
        void WriteAllText(string path, string contents, Encoding encoding);
    }
}
