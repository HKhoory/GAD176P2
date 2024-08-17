using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Aisha.GAD176.Terrain
{
    public class TerrainUIManager : MonoBehaviour
    {
        public TextMeshProUGUI effectText;

        public void DisplayEffectAdded(string effectName)
        {
            effectText.text = effectName + " Effect Added";
        }

        public void DisplayEffectRemoved(string effectName)
        {
            effectText.text = effectName + " Effect Removed";
        }
    }
}
