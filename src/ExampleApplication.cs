namespace Loupedeck.ExamplePlugin
{
    using System;

    // This class can be used to connect the Loupedeck plugin to an application.

    public class ExampleApplication : ClientApplication
    {
        public ExampleApplication()
        {
        }

        // This method can be used to link the plugin to a Windows application.
        protected override String GetProcessName() => "Example Plugin";

        // This method can be used to link the plugin to a macOS application.
        protected override String GetBundleName() => "test2";

        // This method can be used to check whether the application is installed or not.
        public override ClientApplicationStatus GetApplicationStatus() => ClientApplicationStatus.Unknown;
    }
}
