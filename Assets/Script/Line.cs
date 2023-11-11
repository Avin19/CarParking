using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{   [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private float minPointDistance;
    [HideInInspector] public List<Vector3> points = new();
    [HideInInspector] public int pointCount =0; 

    public void SetColor(Color color)
    {
        lineRenderer.sharedMaterials[0].color = color;
    }



   
}
