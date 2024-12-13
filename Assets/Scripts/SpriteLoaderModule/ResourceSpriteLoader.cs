using System.Linq;
using OfferModule.Model;
using UnityEngine;

namespace SpriteLoaderModule
{
    public class ResourceSpriteLoader : ISpriteLoader
    {
        private const string Path = "Sprites/";

        public Sprite[] LoadResourcesSprites(Resource[] resources)
        {
            return resources
                .Select(x => Load(x.SpriteName))
                .ToArray();
        }

        public Sprite Load(string spriteName)
        {
            return Resources.Load<Sprite>(Path + spriteName);
        }
    }
}