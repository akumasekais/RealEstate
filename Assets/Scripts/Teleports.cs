using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleports : MonoBehaviour
{
    public Transform player;
    public Transform startLoc;
    public Transform Bathroom;
    public Transform Kitchen;
    public Transform Lounge;
    public Transform Bedroom;
    public Transform Outside;
    public Transform Fireplace;
 

    public void TeleStart()
    {
        player.transform.position = startLoc.transform.position;
    }

    public void TeleLoc1()
    {
        player.transform.position = Bathroom.transform.position;
    }

    public void TeleLoc2()
    {
        player.transform.position = Kitchen.transform.position;
    }

    public void TeleLoc3()
    {
        player.transform.position = Lounge.transform.position;
    }

    public void TeleLoc4()
    {
        player.transform.position = Bedroom.transform.position;
    }


    public void TeleLoc5()
    {
        player.transform.position = Outside.transform.position;
    }
    public void TeleLoc6()
    {
        player.transform.position = Fireplace.transform.position;
    }

}
