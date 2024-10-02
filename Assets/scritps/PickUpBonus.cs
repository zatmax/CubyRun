using UnityEngine;

public class PickUpBonus : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Bonus")//on vérifie si l'objet s'appelle "bonus"
        {
            Destroy(gameObject);
        }
    }

}
