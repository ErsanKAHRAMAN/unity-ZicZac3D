using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public static CameraControl Instance;
    public Ball currentBall;
    public Transform positionBall;
    Vector3 diff;

    public void Awake()
    {
        Instance = this;
        currentBall = Ball.Instance;

    }

    void Start()
    {
        diff = transform.position - positionBall.position;
    }

    
    void Update()
    {
        if(Ball.Instance.isFall == false)
        {
            transform.position = positionBall.position + diff;

        }
        
        
        
    }

    
}
