namespace Loupedeck.ExamplePlugin
{
    using System;
    public class HapticDynamicCommand : PluginDynamicCommand
    {
        private const String EventName = "buttonPress";

        public HapticDynamicCommand()
            : base("Button Press", "Invokes the haptic event on button press", "Haptics")
        {
        }

        protected override Boolean OnLoad()
        {
            // Define event
            this.Plugin.PluginEvents.AddEvent(EventName, "Button Press", "This haptic event is sent when the user presses the button");

            return true;
        }
        // ...
    }
}