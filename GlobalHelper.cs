using UnityEngine;

public static class GlobalHelper 
{
    public static string GenerateUniqueID(GameObject obj) {

        return $"{obj.scene.name}_{obj.transform.position.x}_{obj.transform.position.y}";
    
    }

    public static char[] playerName = {'D', 'E', 'F', 'A', 'U', 'L', 'T', 'N', 'A', 'M', 'E'};
}
