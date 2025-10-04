namespace Loupedeck.ExamplePlugin
{
    using System;

    using SharpHook;

    // This class contains the plugin-level logic of the Loupedeck plugin.
    public class HapticPlugin : Plugin
    {
        private const String EventName = "periodic10seconds";

        // Gets a value indicating whether this is an API-only plugin.
        public override Boolean UsesApplicationApiOnly => true;

        // Gets a value indicating whether this is a Universal plugin or an Application plugin.
        public override Boolean HasNoApplication => true;

        // private readonly System.Timers.Timer _periodicEventTimer = new();

        private readonly EventLoopGlobalHook _hook = new();

        public override void Load()
        {
            // Define event
            this.PluginEvents.AddEvent(EventName, "Every 10 seconds", "This haptic event is sent every 10 seconds");

            this._hook.MouseMoved += this.OnMouseMoved;

            this._hook.RunAsync();

            // this._periodicEventTimer.AutoReset = true;
            // this._periodicEventTimer.Interval = 5000;
            // this._periodicEventTimer.Elapsed += this.OnPeriodicEventTimerElapsed;
            // this._periodicEventTimer.Start();
        }
        public override void Unload()
        {
            // this._periodicEventTimer.Stop();
            // this._periodicEventTimer.Elapsed -= this.OnPeriodicEventTimerElapsed;
        }

        private void OnMouseMoved(Object sender, MouseHookEventArgs e)
        {
            // Trigger event
            if (e.Data.X == 0 || e.Data.Y == 0)
            {
                this.PluginEvents.RaiseEvent(EventName);
            }
        }

        // private void OnPeriodicEventTimerElapsed(Object sender, System.Timers.ElapsedEventArgs e)
        // {
        //     // Trigger event
        //     this.PluginEvents.RaiseEvent(EventName);
        // }
    }
}