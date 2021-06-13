using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{

    public int nodeValue;

    public enum NodeType
    {
        dynamics,
        mechanica,
        automatics
    }

    public List<NodeType> unlockedNodes;
    public List<NodeType> nodesRequirament;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
