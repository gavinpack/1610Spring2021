using UnityEngine;

public class EnumScript : MonoBehaviour
{
    enum Direction {North, East, South, West};

    void Start () 
    {
        //Variable never used.
        //Direction myDirection;
        
        //myDirection = Direction.North;
        //Variable never used
    }
    
    Direction ReverseDirection (Direction dir)
    {
        if(dir == Direction.North)
            dir = Direction.South;
        else if(dir == Direction.South)
            dir = Direction.North;
        else if(dir == Direction.East)
            dir = Direction.West;
        else if(dir == Direction.West)
            dir = Direction.East;
        
        return dir;     
    }
}