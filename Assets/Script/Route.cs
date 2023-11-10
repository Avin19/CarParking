using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour
{
    private bool isActive = true;

    [SerializeField] private Car car;
    [SerializeField] private Line line;
    [SerializeField] private Park park;

    [Space]
    [Header("Color :")]
    [SerializeField] private Color carColor, parkColor;
    [SerializeField] private Color lineColor;

    public void DeActivate()
    {
        isActive =false;
    }
        // Auto positioning and assign the colors inthe editor ------
#if UNITY_EDITOR
    private void OnDrawGizmos() {
        if(!Application.isPlaying &&  line !=null && car !=null && park != null )
        {
            line.GetComponent<LineRenderer>().SetPosition(0, car.transform.position);
            line.GetComponent<LineRenderer>().SetPosition(1, park.transform.position);
        }
    }
#endif

}
