using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    //tell the character the moving route

    public Route currentRoute;
    int routePosition;
    public int steps;

    bool isMoving;

    //roll dice
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)&& !isMoving)
        {
            steps = Random.Range(1, 7);
            Debug.Log("Dice Number = " + steps);

            if (routePosition + steps < currentRoute.childSquareList.Count)
            {
                StartCoroutine(Move());
            }
            else
            {
                Debug.Log("Need to reroll, too many steps you gonna take.");
            }


        }
        
    }

    //set the method to tell character move when roll a dice
    IEnumerator Move()
    {
        //don't do any movement when character is already moving
        if (isMoving)
        {
            yield break;
        }
        isMoving = true;

        //moving method
        while (steps > 0)
        {
            Vector3 nextPos = currentRoute.childSquareList[routePosition + 1].position;
            while (MovingToNext(nextPos))
            {
                yield return null;
            }
            yield return new WaitForSeconds(0.1f);
            steps--;
            routePosition++;
        }
        
        isMoving = false;

    }
        
        bool MovingToNext(Vector3 goal)
       {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 4f * Time.deltaTime));
         

       }

}
