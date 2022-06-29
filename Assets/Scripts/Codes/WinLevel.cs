using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel : MonoBehaviour
{
    public GameManager Levelwin;
    void OnTriggerEnter()
    {
        Levelwin.CompleteLevel();
    }
}
