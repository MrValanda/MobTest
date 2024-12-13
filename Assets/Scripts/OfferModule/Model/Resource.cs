using System;
using UnityEngine;

namespace OfferModule.Model
{
    [Serializable]
    public class Resource
    {
        [field: SerializeField] public int Amount { get; private set; }
        [field: SerializeField] public string SpriteName { get; private set; }
    }
}