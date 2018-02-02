using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;

public class TEST : MonoBehaviour
{
    public GameObject MilkObject;
    public GameObject BowlObject;
    public GameObject CerealObject;

    public GameObject moreStuff;


    public Quest activeQuest;

    public static TEST instance;
    // Use this for initialization

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

        Quest tutorialQuest = new Quest("TutorialKitchen", 0, "blabla", "NO HINT FOR YOU!",
                              new Objective_Collect("KITCHEN COLLECTION OBJECTIVE", MilkObject, BowlObject, CerealObject),
                              new Objective_Collect("More things to do", moreStuff));


        activeQuest = tutorialQuest;
        activeQuest.ActivateCurrentObjective();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
