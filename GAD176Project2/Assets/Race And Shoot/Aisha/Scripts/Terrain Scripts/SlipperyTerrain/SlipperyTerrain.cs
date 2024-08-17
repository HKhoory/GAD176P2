using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aisha.GAD176.Terrain
{
    
    public class SlipperyTerrain : BaseTerrainEffects
    {
        public SlipSO slipSO;

        protected override void AddEffect()
        {
            base.AddEffect();
            if(targetObject != null)
            {
                StartCoroutine(TriggerRotate());
            }
           
        }

        IEnumerator TriggerRotate()
        {
            Debug.Log("Timer Started");

            float time = 0f;
            while (time < slipSO.rotationDuration)
            {
                targetObject.transform.Rotate(new Vector3(0, 0, slipSO.rotationSpeed) * Time.deltaTime);
                time += Time.deltaTime;
                yield return null;
            }

            Debug.Log("Timer Ended");
        }

    }
}