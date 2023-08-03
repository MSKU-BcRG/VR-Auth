<<<<<<< HEAD
namespace Packages.Rider.Editor.ProjectGeneration
{
  internal interface IFileIO
  {
    bool Exists(string fileName);

    string ReadAllText(string fileName);
    void WriteAllText(string path, string content);

    string EscapedRelativePathFor(string file, string projectDirectory);
  }
=======
namespace Packages.Rider.Editor.ProjectGeneration
{
  internal interface IFileIO
  {
    bool Exists(string fileName);

    string ReadAllText(string fileName);
    void WriteAllText(string path, string content);

    string EscapedRelativePathFor(string file, string projectDirectory);
  }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}