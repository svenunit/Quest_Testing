using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem {
    public class ObjectiveTemplate : IQuestObjective {

        //set private variables
        //private GameObject itemToCollect;

        //Constructor: set everything you need for the quest, i.e. name, description, values

        public ObjectiveTemplate()
        {
            //
        }

        public OBJECTIVE_STATE GetCurrentState()
        {
            throw new NotImplementedException();
        }

        public void SetParentQuest(Quest quest)
        {
            throw new NotImplementedException();
        }

        public void UpdateProgress()
        {
            //Implement
            throw new System.NotImplementedException();
        }
    }
}
