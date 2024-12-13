using System;
using OfferModule;
using OfferModule.Configs;
using OfferModule.Model;
using OfferModule.View;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameBootstrap : MonoBehaviour
{
   [SerializeField] private OfferSelectView _offerSelectView;
   [SerializeField] private OffersSpawner _offersSpawner;
   [SerializeField] private OfferSO[] _offersSO;

   private Offer[] _offers;

   public void Start()
   {
      _offerSelectView.Initialize();
      _offerSelectView.ShowSelectedOffersButtonClicked += OnShowSelectedOffersButtonClicked;
   }

   private void OnDestroy()
   {
      _offerSelectView.Dispose();
   }

   private void OnShowSelectedOffersButtonClicked(int count)
   {
      _offers = new Offer[count];
      for (var i = 0; i < _offers.Length; i++)
      {
         _offers[i] = _offersSO[Random.Range(0, _offersSO.Length)].Offer;
      }

      _offersSpawner.Spawn(_offers);
   }
}
