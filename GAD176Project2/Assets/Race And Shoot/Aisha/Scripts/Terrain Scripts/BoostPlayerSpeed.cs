using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Aisha.GAD176.Terrain
{
    
    public class BoostPlayerSpeed : BaseTerrainEffects
    {
        #region Variables
        private bool boost;
       
        [SerializeField] float boostDuration;
        [SerializeField] float boostAmount;
        #endregion



        protected override void AddEffect()
        {
            base.AddEffect();
            if(targetObject != null)
            {
                targetObject.velocity *= boostAmount;
                StartCoroutine(Boost());
                Debug.Log("Boost Activated");
            }
           
        }

     
        private IEnumerator Boost()
        {
            yield return new WaitForSeconds(boostDuration);

            if(targetObject != null)
            {
                targetObject.velocity /= boostAmount;
                Debug.Log("Boost Deactivated");
            }
            
        }


    }
}
