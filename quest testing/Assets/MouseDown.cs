using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDown : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {


    }


    private void OnMouseDown()
    {
        TEST.instance.activeQuest.GetCurrentObjective().UpdateProgress();
    }
}
