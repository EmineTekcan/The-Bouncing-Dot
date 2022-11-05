using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    
    void Update()
    {
        StartCoroutine(Rotate());
    }

    IEnumerator Rotate()
    {

        float mousePosX = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,transform.position.y,transform.position.z
            )).x ;


        if(Input.GetMouseButtonDown(0) && mousePosX > 0)
        {
            transform.Rotate(0, 0, -30f);
            yield return new WaitForSeconds(0.1f);
            transform.Rotate(0, 0, -30f);

        }
        else if(Input.GetMouseButtonDown(0) && mousePosX < 0)
        {
            transform.Rotate(0, 0, 30f);
            yield return new WaitForSeconds(0.1f);
            transform.Rotate(0, 0, 30f);
        }
    }
}
