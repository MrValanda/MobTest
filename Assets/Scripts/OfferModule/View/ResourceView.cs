using OfferModule.Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace OfferModule.View
{
    public class ResourceView : MonoBehaviour
    {
        [SerializeField] private Image _resourceImage;
        [SerializeField] private TMP_Text _resourceAmount;
        public void Draw(Resource resource, Sprite resourceSprite)
        {
            gameObject.SetActive(true);
            _resourceAmount.text = resource.Amount.ToString();
            _resourceImage.sprite = resourceSprite;
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}