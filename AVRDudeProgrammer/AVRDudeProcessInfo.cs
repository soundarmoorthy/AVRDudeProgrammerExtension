namespace AtmelStudio.AVRDude.Wrapper
{
    public sealed class AVRDudeProcessInfo
    {
        public readonly string FullPath;
        public readonly string Args;
        public readonly ArgumentMode Mode;
        public readonly string ConfFile;

        public AVRDudeProcessInfo(string fullPath, string args, ArgumentMode mode, string confFile)
        {
            FullPath = fullPath;
            Args = args;
            Mode = mode;
            ConfFile = confFile;
        }
    }
}