// Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework;
using osu.Framework.Allocation;
using osu.Framework.IO.Stores;

namespace OsuFrameworkTiled.Tests
{
    public class TiledTestGame : Game
    {
        [BackgroundDependencyLoader]
        private void load()
        {
            Resources.AddStore(new NamespacedResourceStore<byte[]>(new DllResourceStore(typeof(TiledTestGame).Assembly), "Resources"));
        }
    }
}
