using OfferModule.Model;
using UnityEngine;

namespace SpriteLoaderModule
{
    public interface ISpriteLoader
    {
        public Sprite[] LoadResourcesSprites(Resource[] resources);
        public Sprite Load(string spriteName);
    }
}
