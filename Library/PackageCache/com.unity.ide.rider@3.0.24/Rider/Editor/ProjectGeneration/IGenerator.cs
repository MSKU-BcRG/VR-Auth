<<<<<<< HEAD
using System.Collections.Generic;

namespace Packages.Rider.Editor.ProjectGeneration
{
  internal interface IGenerator
  {
    bool SyncIfNeeded(IEnumerable<string> affectedFiles, IEnumerable<string> reimportedFiles, bool checkProjectFiles = false);
    void Sync();
    bool HasSolutionBeenGenerated();
    string SolutionFile();
    IAssemblyNameProvider AssemblyNameProvider { get; }
  }
=======
using System.Collections.Generic;

namespace Packages.Rider.Editor.ProjectGeneration
{
  internal interface IGenerator
  {
    bool SyncIfNeeded(IEnumerable<string> affectedFiles, IEnumerable<string> reimportedFiles, bool checkProjectFiles = false);
    void Sync();
    bool HasSolutionBeenGenerated();
    string SolutionFile();
    IAssemblyNameProvider AssemblyNameProvider { get; }
  }
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
}