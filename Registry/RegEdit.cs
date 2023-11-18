using Microsoft.Win32;
using LiteCodeLibrary.Additionals;

namespace LiteCodeLibrary.Regedit
{
    public static class RegEdit
    {
        public static void CreateRegister(string subFolderName, Enums.RegistryFolderType mainFolder)
        {
            if(mainFolder == Enums.RegistryFolderType.LocalMachine)
            {
                RegistryKey main = Registry.LocalMachine.CreateSubKey(subFolderName);

                main.Close();
            }
            else if(mainFolder == Enums.RegistryFolderType.CurrentUser)
            {
                RegistryKey main = Registry.CurrentUser.CreateSubKey(subFolderName);

                main.Close();
            }
        }

        public static void SetValueRegister(string subFolderName, string valueName, object value, Enums.RegistryFolderType mainFolder)
        {
            if (mainFolder == Enums.RegistryFolderType.LocalMachine)
            {
                RegistryKey main = Registry.LocalMachine.OpenSubKey(subFolderName);

                main.SetValue(valueName, value);

                main.Close();
            }
            else if (mainFolder == Enums.RegistryFolderType.CurrentUser)
            {
                RegistryKey main = Registry.CurrentUser.OpenSubKey(subFolderName);

                main.SetValue(valueName, value);

                main.Close();
            }
        }
    }
}
