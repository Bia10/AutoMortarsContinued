using Verse;

namespace AutoMortarsContinued
{
    [StaticConstructorOnStartup]
    public class Startup
    {
        static Startup()
        {
            Log.Message("Loading AutoMortarsContinued ...");
            Log.Message("Loaded AutoMortarsContinued.");
        }
    }
}
