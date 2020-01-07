using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class RangedAttackController : MonoBehaviour
    {
        public GameObject Projectile;
        public float Height = 3;


        public void Fire(Vector3 startPos, Vector3 targetPos)
        {
            Projectile.transform.position = startPos;
            Vector3 top = startPos + (targetPos - startPos) / 2;
            Vector3 centerPos = new Vector3(top.x, top.y + Height, top.z);

            iTween.MoveTo(Projectile, iTween.Hash("path", new[] { startPos, centerPos, targetPos }, "time", 1f, "easetype", "linear", "oncomplete", "DoDestroy", "oncompletetarget", gameObject));
        }

        public void DoDestroy()
        {
            Destroy(gameObject);
        }
    }
}