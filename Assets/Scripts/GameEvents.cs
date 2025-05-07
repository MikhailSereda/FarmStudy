using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace Golf
{
    public static class GameEvents
    {
         public static System.Action onCollisionStone;
         public static System.Action onStickHit;
         public static void CollisionStonesInvoke(Collision collision)
         {
            onCollisionStone?.Invoke();
         }
         public static void StickHit()
         {
            onStickHit?.Invoke();
         }
    }
}