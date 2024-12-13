using OfferModule.Model;
using SpriteLoaderModule;
using UnityEngine;

namespace OfferModule
{
   public class OffersSpawner : MonoBehaviour
   {
      private readonly ISpriteLoader _spriteLoader = new ResourceSpriteLoader();
      
      [SerializeField] private Transform _spawnParent;
      [SerializeField] private OfferBootstrap _offerBootstrap;

      public void Spawn(Offer[] offers)
      {
         for (var i = 0; i < offers.Length; i++)
         {
            Instantiate(_offerBootstrap, _spawnParent).Initialize(offers[i], _spriteLoader);
         }
      }
   }
}
