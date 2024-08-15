using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aisha.GAD176.Terrain
{
    
    public class RotatePlayer : BaseTerrainEffects
    {
        #region Variables 
        
        [SerializeField] float rotationDuration;
        [SerializeField] float rotationSpeed;

        #endregion



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
            while (time < rotationDuration)
            {
                targetObject.transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
                time += Time.deltaTime;
                yield return null;
            }

            Debug.Log("Timer Ended");
        }

    }
}