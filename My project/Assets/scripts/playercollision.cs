using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playerbehavior movement;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle"){
            Debug.Log("Collided");
            movement.enabled = false;
            FindObjectOfType<gamemanager>().Endgame();
        }
    }

}
