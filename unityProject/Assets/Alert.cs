using UnityEngine;
using System.Collections;

public class Alert : State
{
    public State followState;
    public Color alertColor;
    public float changeRate;
    public float timeToChange;

    private Color normalColor;
    private float timeToExit;
    private float addedTime;

	public Renderer renderer;

	void Start(){
		renderer = GetComponent<Renderer>();
	}

    void OnEnable()
    {
        normalColor = renderer.material.color;
        timeToExit = 0;
        addedTime = 0;
    }

    void Update()
    {
        timeToExit += Time.deltaTime;
        addedTime += Time.deltaTime;

        if (addedTime >= changeRate)
        {
            if (renderer.material.color.Equals(normalColor)) { renderer.material.color = alertColor; }
            else { renderer.material.color = normalColor; }

            addedTime = 0;
        }
    }

    public override void CheckExit()
    {
        if (timeToExit >= timeToChange)
        {
            renderer.material.color = normalColor;
            stateMachine.ChangeState(followState);
        }
    }
}