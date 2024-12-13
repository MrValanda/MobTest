using System;
using UnityEngine;

namespace OfferModule.Model
{
    [Serializable]
    public class Offer
    {
        [field: SerializeField] public string Title { get; private set; }
        [field: SerializeField] public string Description { get; private set; }
        [field: SerializeField] public Resource[] Resources { get; private set; }
        [field: SerializeField] public float Price { get; private set; }
        [field: SerializeField, Range(0f, 1f)] public float Discount { get; private set; }
        [field: SerializeField] public string SpriteName { get; private set; }

        public bool HasDiscount => Discount > 0f;

        public float CalculateDiscountPrice()
        {
            return Price - Price * Discount;
        }
    }
}
