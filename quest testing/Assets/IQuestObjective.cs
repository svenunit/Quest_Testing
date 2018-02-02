using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Generell structure /methods to implement in objectives
*/

namespace QuestSystem
{
    public interface IQuestObjective
    {
        //get private values (i.e. name, description)
        OBJECTIVE_STATE GetCurrentState();
        //methods
        void UpdateProgress();
        // Quest advance method needed
        void SetParentQuest(Quest quest);
       // void SetGameObjectsActive();

    }
}
