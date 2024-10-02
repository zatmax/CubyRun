using UnityEngine;

public class playercollision : MonoBehaviour {

    public playermovement movement;
    public GameManager GM;
   

    // une reference pour notre playermouvement
    // cette fonction tourne quand on touche un autre objet
    // on reçoit une information de collision
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle") //on vérifie si l'objet s'appelle "obstacle"
        {
            movement.enabled = false;
            GM.EndGame();

        }
    }
}

