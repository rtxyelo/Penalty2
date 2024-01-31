using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeaperBehaviour : MonoBehaviour
{
    public static int GoalKeaperPosition;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RandomGoalKeaperPosition()
    {
        GoalKeaperPosition = Random.Range(0, 10);
        _animator.Play("Target" + GoalKeaperPosition);
    }

    public int GetGoalKeaperPosition()
    {
        return GoalKeaperPosition;
    }
}
