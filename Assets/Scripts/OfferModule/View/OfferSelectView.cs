using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace OfferModule.View
{
    public class OfferSelectView : MonoBehaviour
    {
        public event Action<int> ShowSelectedOffersButtonClicked;
        
        [SerializeField] private TMP_InputField _inputField;
        [SerializeField] private Button _showSelectedOffersButton;

        public void Initialize()
        {
            _showSelectedOffersButton.onClick.AddListener(OnShowSelectedOffersClick);
        }

        public void Dispose()
        {
            _showSelectedOffersButton.onClick.RemoveListener(OnShowSelectedOffersClick);
        }

        private void OnShowSelectedOffersClick()
        {
            if (int.TryParse(_inputField.text, out int result))
            {
                gameObject.SetActive(false);
                ShowSelectedOffersButtonClicked?.Invoke(result);
            }
        }
    }
}
