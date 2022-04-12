using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleEnemyMovement : MonoBehaviour
{

    private bool goingA = true;
    public float speed = 2.0f;

    public Transform EnemyObject;
    public Transform spotA;
    public Transform spotB;


    void Start()
    {
        
    }

    private void FixedUpdate() {
        if (goingA) {
            EnemyObject.transform.Translate(Vector2.right * speed * Time.deltaTime);
        } else { 
            EnemyObject.transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }        
    }


    private void Update() {
        if (EnemyObject.transform.position.x >= spotB.transform.position.x) {
            goingA = false;
        }
        if (EnemyObject.transform.position.x <= spotA.transform.position.x) {
            goingA = true;
        }
    }
}
