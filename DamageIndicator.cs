using UnityEngine;

public class DamageIndicator : MonoBehaviour
{
    [SerializeField]
    Transform player,tir,indicator;

    Vector2 tirPos, mePos,forward;
    float angle;
    void Update()
    {

        tirPos.x = tir.position.x;
        tirPos.y = tir.position.z;
        mePos.x = player.position.x;
        mePos.y = player.position.z;
        forward.x = player.forward.x;
        forward.y = player.forward.z;

        angle = Vector2.SignedAngle((mePos - tirPos).normalized, forward) + 180f ;

        indicator.eulerAngles = new Vector3(0, 0, -angle);
        tir.LookAt(player.position);
    }

}
