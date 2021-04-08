// Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;
using osuTK;
using TiledCS;

namespace OsuFrameworkTiled.Tests.Visual.Tilesets
{
    public class TestSceneTileset : TiledTestScene
    {
        [BackgroundDependencyLoader]
        private void load(TextureStore textures)
        {
            TiledTileset tileset = new TiledTileset("..\\..\\..\\Resources\\Tilesets\\default.tsx");

            FillFlowContainer tileContainer;

            Add(new FillFlowContainer
            {
                Direction = FillDirection.Vertical,
                RelativeSizeAxes = Axes.Both,
                Children = new Drawable[]
                {
                    new SpriteText
                    {
                        Text = tileset.Name,
                        Font = FontUsage.Default.With(size: 30)
                    },
                    tileContainer = new FillFlowContainer
                    {
                        Direction = FillDirection.Full,
                        AutoSizeAxes = Axes.Both,
                    }
                }
            });

            foreach (var tile in tileset.Tiles)
            {
                // create sprites with tile.image.source
                tileContainer.Add(new Container
                {
                    Size = new Vector2(50),
                    Child = new SpriteText
                    {
                        Text = tile.id.ToString(),
                        Anchor = Anchor.Centre,
                        Origin = Anchor.Centre,
                    }
                });
            }
        }
    }
}
