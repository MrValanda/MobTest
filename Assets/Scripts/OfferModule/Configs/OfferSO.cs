using OfferModule.Model;
using UnityEngine;

namespace OfferModule.Configs
{
   [CreateAssetMenu(menuName = "Create OfferSO", fileName = "OfferSO", order = 0)]
   public class OfferSO : ScriptableObject
   {
      [field:SerializeField] public Offer Offer { get; private set; }
   }
}
