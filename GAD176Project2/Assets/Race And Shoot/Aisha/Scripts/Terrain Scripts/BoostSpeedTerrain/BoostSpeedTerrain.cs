using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Aisha.GAD176.Terrain
{
    
    public class BoostSpeedTerrain : BaseTerrainEffects
    {
        public BoostSO boostSO;

        protected override void AddEffect()
        {
            base.AddEffect();
            if(targetObject != null)
            {
                targetObject.velocity *= boostSO.boostAmount;
                StartCoroutine(Boost());
                Debug.Log("Boost Activated");
                Debug.Log(boostSO.boostAmount);
            }
           
        }

        private IEnumerator Boost()
        {
            yield return new WaitForSeconds(boostSO.boostDuration);

            if(targetObject != null)
            {
                targetObject.velocity /= boostSO.boostAmount;
                Debug.Log("Boost Deactivated");
            }
            
        }


    }
}
