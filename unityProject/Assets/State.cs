using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(StateMachine))]
public class State : MonoBehaviour
{
    protected StateMachine stateMachine;

    void Awake()
    {
        stateMachine = GetComponent<StateMachine>();
    }

    public virtual void CheckExit() { }
}
