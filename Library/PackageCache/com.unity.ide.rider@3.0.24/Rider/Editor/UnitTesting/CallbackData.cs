<<<<<<< HEAD
#if TEST_FRAMEWORK
using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;

namespace Packages.Rider.Editor.UnitTesting
{
  internal class CallbackData : ScriptableSingleton<CallbackData>
  {
    /// <summary>
    /// identifies that tests were started from Rider
    /// </summary>
    public bool isRider;

    [UsedImplicitly] // Is used by Rider Unity plugin by reflection
    public static event EventHandler Changed = (sender, args) => { }; 

    internal void RaiseChangedEvent()
    {
      Changed(null, EventArgs.Empty);
    }

    [UsedImplicitly] // Is used by Rider Unity plugin by reflection
    public List<TestEvent> events = new List<TestEvent>();
    
    [UsedImplicitly] // Is used by Rider Unity plugin by reflection
    public void Clear()
    {
      events.Clear();
    }
  }
}
=======
#if TEST_FRAMEWORK
using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;

namespace Packages.Rider.Editor.UnitTesting
{
  internal class CallbackData : ScriptableSingleton<CallbackData>
  {
    /// <summary>
    /// identifies that tests were started from Rider
    /// </summary>
    public bool isRider;

    [UsedImplicitly] // Is used by Rider Unity plugin by reflection
    public static event EventHandler Changed = (sender, args) => { }; 

    internal void RaiseChangedEvent()
    {
      Changed(null, EventArgs.Empty);
    }

    [UsedImplicitly] // Is used by Rider Unity plugin by reflection
    public List<TestEvent> events = new List<TestEvent>();
    
    [UsedImplicitly] // Is used by Rider Unity plugin by reflection
    public void Clear()
    {
      events.Clear();
    }
  }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
#endif