#region License Information (GPL v3)

/*
    Copyright (c) Jaex

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using ShareX.HelpersLib;
using System;
using System.IO;
using System.Windows.Forms;

namespace Automate
{
    internal static class Program
    {
        public static readonly string DefaultPersonalFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Automate");
        public static readonly string SettingsFilePath = Path.Combine(DefaultPersonalFolder, "Settings.json");

        public static Settings Settings { get; private set; }
        public static GitHubUpdateManager UpdateManager { get; private set; }

        [STAThread]
        private static void Main()
        {
            Settings = Settings.Load(SettingsFilePath);

            UpdateManager = new GitHubUpdateManager("Jaex", "Automate")
            {
                AutoUpdateEnabled = true,
                CheckPreReleaseUpdates = false
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            Settings.Save();
        }
    }
}