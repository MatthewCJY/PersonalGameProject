using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ProceduralGenerationAlgo
{
    public static HashSet<Vector2Int> SimpleRandomWalk(Vector2Int startPosition, int walkLength)
    {
        HashSet<Vector2Int> path = new HashSet<Vector2Int>();

        path.Add(startPosition);
        var previousPosition = startPosition;
        
        for(int i = 0; i < walkLength; i++) 
        {
            var newPosition = previousPosition + Direction2D.GetRandomCardinalDirection();  // Taking a step in a random direction from prev position
            path.Add(newPosition);                                                          // Adding it to hashset
            previousPosition = newPosition;                                                 // Set previous position as the new one
        }
        return path;
    }
}

public static class Direction2D
{
    public static List<Vector2Int> cardinalDirectionList = new List<Vector2Int>
    {
        new Vector2Int(0,  1), // up
        new Vector2Int(1,  0), // right
        new Vector2Int(0, -1), // down
        new Vector2Int(-1, 0)  // left
    };
    public static Vector2Int GetRandomCardinalDirection()
    {
        return cardinalDirectionList[Random.Range(0, cardinalDirectionList.Count)]; //getting a random direction from cardinal direction list
    }
}
