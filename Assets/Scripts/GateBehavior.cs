using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateBehavior : MonoBehaviour
{
    public GameObject MonsterGroup;
    public PlayerBehavior Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!MonsterGroup.GetComponentInChildren<MonsterBehavior>()) {
            Player.Unbreak();
            Destroy(gameObject);
        }
    }
}
