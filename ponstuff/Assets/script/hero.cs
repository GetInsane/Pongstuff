using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    
    double speedhit(double ballspeed)
    {
        double speed;
        speed = ballspeed / 1.7;
        return speed;
    }

    double slowball(double ballspeed)
    {
        double speed;
        speed = ballspeed * 1.7;
        return speed;
    }

}
