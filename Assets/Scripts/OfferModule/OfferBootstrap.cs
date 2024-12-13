using OfferModule.Model;
using OfferModule.View;
using SpriteLoaderModule;
using UnityEngine;

namespace OfferModule
{
    public class OfferBootstrap : MonoBehaviour
    {
        [SerializeField] private OfferView _offerView;

        public void Initialize(Offer offer,ISpriteLoader spriteLoader)
        {
            _offerView.Initialize();
            _offerView.Draw(offer, spriteLoader.LoadResourcesSprites(offer.Resources),
                spriteLoader.Load(offer.SpriteName));
        }

        private void OnDestroy()
        {
            _offerView.Dispose();
        }
    }
}
