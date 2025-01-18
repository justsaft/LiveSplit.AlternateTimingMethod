using LiveSplit.Model;

using System;
using System.Reflection;

namespace LiveSplit.UI.Components;

public class AlternateTimingMethodFactory : IComponentFactory
{
    public string ComponentName => "Alternate Timing Method";

    public string Description => "Displays Real Time if the comparison is set to Game Time and vice versa.";

    public ComponentCategory Category => ComponentCategory.Information;

    public IComponent Create(LiveSplitState state)
    {
        return new AlternateTimingMethod(state);
    }

    public string UpdateName => ComponentName;

    public string UpdateURL => "https://raw.githubusercontent.com/dalet/LiveSplit.AlternateTimingMethod/master/";

    public string XMLURL => UpdateURL + "Components/update.LiveSplit.AlternateTimingMethod.xml";

    public Version Version => Assembly.GetExecutingAssembly().GetName().Version;
}
