using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour
{
    //private bool isActive = true;

    public Car car;
    public Line line;
    public Park park;

    [Space]
    [Header("Color :")]
    public Color carColor;
    [SerializeField] private Color lineColor;

    public void DeActivate()
    {
        //isActive = false;
    }
        // Auto positioning and assign the colors inthe editor ------
#if UNITY_EDITOR
    private void OnDrawGizmos() {
        if(!Application.isPlaying &&  line !=null && car !=null && park != null )
        {
            line.GetComponent<LineRenderer>().SetPosition(0, car.GetCarBottom().position);
            line.GetComponent<LineRenderer>().SetPosition(1, park.transform.position);

            car.SetColor(carColor);
            park.SetColor(carColor);
            line.SetColor(lineColor);
        
        }
    }
#endif

}
