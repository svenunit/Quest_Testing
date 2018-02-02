using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{

    public class Objective_Collect : Objective, IQuestObjective
    {
        private List<GameObject> objectsToCollect;
        private int itemCounter;
        //set private variables
        //private GameObject itemToCollect;

        //Constructor: set everything you need for the quest, i.e. name, description, values

        public Objective_Collect(string name, params GameObject[] objectsToCollect)
        {
            this.name = name;
            state = OBJECTIVE_STATE.STARTED;
            this.objectsToCollect = new List<GameObject>();
            foreach (GameObject objectToCollect in objectsToCollect)
            {
                this.objectsToCollect.Add(objectToCollect);
                this.gameObjecesToActivate.Add(objectToCollect);
            }
            itemCounter = 0;
        }

        public void UpdateProgress()
        {
            ++itemCounter;
            Debug.Log("UpdateProgress on " + this.name);
            if (itemCounter >= objectsToCollect.Count)
            {
                // Objective complete
                state = OBJECTIVE_STATE.COMPLETE;
                DeactivateGameObjects();
                parentQuest.OnUpdate();
            }
            else
            {
                state = OBJECTIVE_STATE.IN_PROGRESS;
            }
        }

        public OBJECTIVE_STATE GetCurrentState()
        {
            return state;
        }

        public void SetParentQuest(Quest quest)
        {
            parentQuest = quest;
        }

        public override void ActivateGameObjects()
        {
            base.ActivateGameObjects();

        }
    }
}
