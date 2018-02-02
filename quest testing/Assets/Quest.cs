using UnityEngine;
using System.Collections.Generic;

namespace QuestSystem
{
    //Exposes class to inspector
    [System.Serializable]
    public class Quest
    {
        // Things that a quest ought to have
        public string title;
        public int id;
        public int nextQuest;               //next quest ID
        public string description;
        public string hint;

        public List<GameObject> objectsToActivate;
        // Associate questObjective with the individual objective NOT the quest

        public List<IQuestObjective> questObjectives;
        //Einzelner string, also jeden Teilschritt als eigene Quest erfassen oder eine Liste übergeben?
        //public string QuestObjective;
        //public List<IQuestObjective> objectives;


        // List of GameObjects that are set to be active during the Quest (i.e. Collectibles, TextBoxes)

        public Quest(string title, int id, string description, string hint, params IQuestObjective[] questObjectives)
        {
            this.title = title;
            this.id = id;
            this.description = description;
            this.hint = hint;
            this.objectsToActivate = new List<GameObject>();
            this.questObjectives = new List<IQuestObjective>();
            foreach (IQuestObjective questObjective in questObjectives)
            {
                this.questObjectives.Add(questObjective);
                questObjective.SetParentQuest(this);
            }


        }

        // List of Objectives
        //private List<IQuestObjective> objectives;

        // Events
        // OnCompletion

        // OnUpdate
        public void OnUpdate()
        {
            Debug.Log("QUEST OnUpdate!");
            // Check for all objectives complete
            for (int i = 0; i < questObjectives.Count; i++)
            {
                if (questObjectives[i].GetCurrentState() != OBJECTIVE_STATE.COMPLETE)
                {
                    // Quest not complete, go to next objective
                    ActivateCurrentObjective();
                    return;
                }

            }
            // Quest complete, go to next quest
            Debug.Log("QUEST COMPLETE!");

        }

        public IQuestObjective GetCurrentObjective()
        {
            for (int i = 0; i < this.questObjectives.Count; i++)
            {
                if (questObjectives[i].GetCurrentState() != OBJECTIVE_STATE.COMPLETE) return questObjectives[i];
            }
            return null;
        }

        public void ActivateCurrentObjective()
        {
            // Activate gameObjects in current objective
            Objective activeObjective = GetCurrentObjective() as Objective;
            activeObjective.ActivateGameObjects();
        }

    }
}
