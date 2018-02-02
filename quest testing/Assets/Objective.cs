using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{
    public enum OBJECTIVE_STATE { STARTED, IN_PROGRESS, COMPLETE }

    public abstract class Objective : MonoBehaviour
    {
        new protected string name;
        protected Quest parentQuest;
        protected OBJECTIVE_STATE state;
        protected List<GameObject> gameObjecesToActivate = new List<GameObject>();

        protected void Awake()
        {

        }

        protected void Start()
        {

        }

        protected void Update()
        {

        }

        public virtual void ActivateGameObjects()
        {
            foreach (GameObject gameobject in gameObjecesToActivate)
            {
                gameobject.SetActive(true);
            }
        }

        public virtual void DeactivateGameObjects()
        {
            foreach (GameObject gameobject in gameObjecesToActivate)
            {
                gameobject.SetActive(false);
            }
        }

    }
}
