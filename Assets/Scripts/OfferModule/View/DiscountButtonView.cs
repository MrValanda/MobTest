using System;
using OfferModule.Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace OfferModule.View
{
    public class DiscountButtonView : MonoBehaviour
    {
        public event Action BuyButtonClicked;

        [SerializeField] private Button _buyButton;
        [SerializeField] private TMP_Text _price;
        [SerializeField] private TMP_Text _fakePrice;
        [SerializeField] private GameObject _discount;
        [SerializeField] private TMP_Text _discountAmount;

        public void Initialize()
        {
            _buyButton.onClick.AddListener(OnBuyButtonClick);
        }

        public void Dispose()
        {
            _buyButton.onClick.RemoveListener(OnBuyButtonClick);
        }

        public void Draw(Offer offer)
        {
            if (offer.HasDiscount)
            {
                _discount.SetActive(true);
                _discountAmount.text = $"-{100 * offer.Discount}%";
                _fakePrice.text = $"${offer.Price}";
                _fakePrice.gameObject.SetActive(true);
            }
            else
            {
                _discount.SetActive(false);
                _fakePrice.gameObject.SetActive(false);
            }

            _price.text = $"${offer.CalculateDiscountPrice()}";
        }

        private void OnBuyButtonClick()
        {
            BuyButtonClicked?.Invoke();
        }
    }
}