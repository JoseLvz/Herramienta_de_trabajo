using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public Transform PointA,PointB;

    public Color gizmosColor = Color.green;



    private void OnDrawGizmos() {
        Gizmos.color = gizmosColor;


        Gizmos.DrawLine(PointA.position, PointB.position);
    }
}
 

