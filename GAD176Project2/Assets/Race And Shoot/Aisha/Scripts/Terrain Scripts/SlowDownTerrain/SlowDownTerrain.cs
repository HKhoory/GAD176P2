using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Aisha.GAD176.Terrain
{
    public class SlowDownTerrain: BaseTerrainEffects
    {
        public SlowDownSO slowdownSO;

        protected override void AddEffect()
        {
            base.AddEffect();
            if(targetObject != null)
            {
                //Reduce speed
                targetObject.velocity *= 1 / slowdownSO.speedReduction;
                Debug.Log("Speed Reduced");
            }
        }

        protected override void RemoveEffect()
        {
            base.RemoveEffect();
            if (targetObject != null)
            {
                //Revert speed back to previous
                targetObject.velocity *= slowdownSO.speedReduction;
                Debug.Log("Speed Reverted");
            }
        }

    }
}
