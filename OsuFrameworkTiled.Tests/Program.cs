// Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Linq;
using osu.Framework;
using osu.Framework.Platform;

namespace OsuFrameworkTiled.Tests
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            bool portable = args.Contains(@"--portable");

            using (GameHost host = Host.GetSuitableHost(@"visual-tests", portableInstallation: portable))
            {
                host.Run(new TiledVisualTestGame());
            }
        }
    }
}
