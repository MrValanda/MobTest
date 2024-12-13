using System;
using OfferModule.Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace OfferModule.View
{
    public class OfferView : MonoBehaviour
    {
        public event Action<OfferView> BuyButtonClicked;

        [SerializeField] private TMP_Text _title;
        [SerializeField] private TMP_Text _description;
        [SerializeField] private Image _offerImage;
        [SerializeField] private ResourceView[] _resourceViews;
        [SerializeField] private DiscountButtonView _discountButtonView;
      
        
        public void Initialize()
        {
            _discountButtonView.Initialize();
            _discountButtonView.BuyButtonClicked += OnBuyButtonClicked;
        }

        public void Dispose()
        {
            _discountButtonView.Dispose();
            _discountButtonView.BuyButtonClicked -= OnBuyButtonClicked;
        }

        public void Draw(Offer offer,Sprite[] resourceSprites,Sprite offerImage)
        {
            _title.text = offer.Title;
            _description.text = offer.Description;
            _offerImage.sprite = offerImage;

            _discountButtonView.Draw(offer);
            
            for (var i = 0; i < _resourceViews.Length; i++)
            {
                if (i < offer.Resources.Length)
                {
                    _resourceViews[i].Draw(offer.Resources[i], resourceSprites[i]);
                }
                else
                {
                    _resourceViews[i].Hide();
                }
            }
        }
        private void OnBuyButtonClicked()
        {
            BuyButtonClicked?.Invoke(this);
        }
    }
}
