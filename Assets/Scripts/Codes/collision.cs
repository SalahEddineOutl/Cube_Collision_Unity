using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public controlle mouvement;
    public Transform Player;
    public float A = 0.7f;
    public Score CS;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="Obstacle")
        {

            mouvement.enabled = false;
            CS.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
    private void Update()
    {
        if(Player.position.y<A)
        {
            mouvement.enabled = false;
            CS.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }


}
