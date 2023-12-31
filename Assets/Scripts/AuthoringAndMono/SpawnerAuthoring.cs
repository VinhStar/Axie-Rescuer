using AxieRescuer;
using Unity.Entities;
using UnityEngine;
namespace AxieRescuer
{ 
public class SpawnerAuthoring : MonoBehaviour
{
        public class SpanwnerBaker : Baker<SpawnerAuthoring>
        {
            public override void Bake(SpawnerAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.None);
                AddBuffer<SpawnBuffer>(entity);
            }

        }
    }
}