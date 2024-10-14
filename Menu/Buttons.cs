using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Anti Report [UND]", method =() => Mods.AntiReport(), toolTip = "Makes you leave when someone tries to report you."},
                new ButtonInfo { buttonText = "A To Fake Oculus Menu [UND]", method =() => Mods.FakeOculusMenu(), toolTip = "Makes it look like you are in your oculus menu."},
                new ButtonInfo { buttonText = "Basic Mods", method =() => SettingsMods.BasicMods(), isTogglable = false, toolTip = "Opens the basic mods page for the menu."},
                new ButtonInfo { buttonText = "Fun Mods", method =() => SettingsMods.FunMods(), isTogglable = false, toolTip = "Opens the fun mods page for the menu."},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Basic Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Platforms [UND]", method =() => Mods.Platforms(), toolTip = "Makes platforms under your hands."},
                new ButtonInfo { buttonText = "Trigger Platforms [UND]", method =() => Mods.TriggerPlatforms(), toolTip = "Makes platforms under your hands."},
                new ButtonInfo { buttonText = "Trigger To NoClip [UND]", method =() => Mods.NoClip(), toolTip = "Makes you noclip."},
                new ButtonInfo { buttonText = "Long Arms [UND]", enableMethod =() => Mods.LongArms(), disableMethod =() => Mods.FixArms(), toolTip = "Makes you have longer arms."},
                new ButtonInfo { buttonText = "A To Fly [UND]", method =() => Mods.Fly(), toolTip = "Makes you fly in the direction of your head."},
                new ButtonInfo { buttonText = "A To Hand Fly [UND]", method =() => Mods.HandFly(), toolTip = "Makes you fly in the direction of your hand."},
                new ButtonInfo { buttonText = "Speedboost [LEGIT][UND]", method =() => Mods.MosaBoost(), toolTip = "A very small speedboost for comp."},
                new ButtonInfo { buttonText = "Grip To Wallwalk [LEGIT][UND]", method =() => Mods.WallWalk(), toolTip = "A very light wallwalk for comp."},
            },

            new ButtonInfo[] { // Fun Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Check If You Are [M] [UND]", method =() => Mods.CheckIfMaster(), isTogglable = false, toolTip = "Checks if you are master."},
                new ButtonInfo { buttonText = "Spawn Red Lucy [M][UND]", method =() => Mods.SpawnRedLucy(), isTogglable = false, toolTip = "Spawn red lucy."},
                new ButtonInfo { buttonText = "Grab Bat [M][UND]", method =() => Mods.GrabBat(), toolTip = "Makes the bat go to your hand."},
                new ButtonInfo { buttonText = "Grab Beach Ball [M][UND]", method =() => Mods.GrabBat(), toolTip = "Makes the beach ball go to your hand."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Disconnect", method =() => Mods.Disconnect(), isTogglable = false, toolTip = string.Empty},
            },
        };
    }
}
