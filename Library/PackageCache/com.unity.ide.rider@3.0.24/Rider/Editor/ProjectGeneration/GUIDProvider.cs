<<<<<<< HEAD
namespace Packages.Rider.Editor.ProjectGeneration {
  class GUIDProvider : IGUIDGenerator
  {
    public string ProjectGuid(string name)
    {
      return SolutionGuidGenerator.GuidForProject(name);
    }
  }
}
=======
namespace Packages.Rider.Editor.ProjectGeneration {
  class GUIDProvider : IGUIDGenerator
  {
    public string ProjectGuid(string name)
    {
      return SolutionGuidGenerator.GuidForProject(name);
    }
  }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
