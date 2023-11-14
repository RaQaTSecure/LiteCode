using System.Diagnostics;

namespace LiteCode.Threading
{
    public class Processing
    {
        public static void Cmd(string line, Additionals.Enums.WindowFormStyle style)
        {
            if(style == Additionals.Enums.WindowFormStyle.Normal)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c {line}",
                    WindowStyle = ProcessWindowStyle.Normal
                });
            }
            else if(style == Additionals.Enums.WindowFormStyle.Hide)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c {line}",
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            }
            else if(style == Additionals.Enums.WindowFormStyle.Minimized)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c {line}",
                    WindowStyle = ProcessWindowStyle.Minimized
                });
            }
            else if(style == Additionals.Enums.WindowFormStyle.Maximized)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c {line}",
                    WindowStyle = ProcessWindowStyle.Maximized
                });
            }
        }

        public static void JavaCmd(string line, Additionals.Enums.WindowFormStyle style)
        {
            if (style == Additionals.Enums.WindowFormStyle.Normal)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"java -jar {line}",
                    WindowStyle = ProcessWindowStyle.Normal
                });
            }
            else if (style == Additionals.Enums.WindowFormStyle.Hide)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"java -jar {line}",
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            }
            else if (style == Additionals.Enums.WindowFormStyle.Minimized)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"java -jar {line}",
                    WindowStyle = ProcessWindowStyle.Minimized
                });
            }
            else if (style == Additionals.Enums.WindowFormStyle.Maximized)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"java -jar {line}",
                    WindowStyle = ProcessWindowStyle.Maximized
                });
            }
        }

        public static void ProcessFile(string file)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = file
            });
        }

        public static void ProcessFile(string file, Additionals.Enums.WindowFormStyle style)
        {
            if (style == Additionals.Enums.WindowFormStyle.Normal)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = file,
                    WindowStyle = ProcessWindowStyle.Normal
                });
            }
            else if (style == Additionals.Enums.WindowFormStyle.Hide)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = file,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            }
            else if (style == Additionals.Enums.WindowFormStyle.Minimized)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = file,
                    WindowStyle = ProcessWindowStyle.Minimized
                });
            }
            else if (style == Additionals.Enums.WindowFormStyle.Maximized)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = file,
                    WindowStyle = ProcessWindowStyle.Maximized
                });
            }
        }

        public static void ProcessFile(string file, string argument, Additionals.Enums.WindowFormStyle style)
        {
            if (style == Additionals.Enums.WindowFormStyle.Normal)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = file,
                    Arguments = argument,
                    WindowStyle = ProcessWindowStyle.Normal
                });
            }
            else if (style == Additionals.Enums.WindowFormStyle.Hide)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = file,
                    Arguments = argument,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            }
            else if (style == Additionals.Enums.WindowFormStyle.Minimized)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = file,
                    Arguments = argument,
                    WindowStyle = ProcessWindowStyle.Minimized
                });
            }
            else if (style == Additionals.Enums.WindowFormStyle.Maximized)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = file,
                    Arguments = argument,
                    WindowStyle = ProcessWindowStyle.Maximized
                });
            }
        }
    }
}
