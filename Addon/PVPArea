using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

/*
 * You can attack a player anywhere in the game, unless the zone is listed below
 */
public partial class Player
{
    [Header("Player Vs Player System")]
    [SyncVar_] public int MinLevel= 0;

    /*
     * IsAttackable
     * Checks if player is attackable or in safe
     */
    public bool IsAttackable()
    {
        return (!IsSafeZone());
    }

    public bool IsSafeZone()
    {
        return (InZoneName_Example());
    }

    /*
     * InZoneName_Example
     * You cannot attack a player if in these zones.
     */
    public bool InZoneName_Example()
    {
        return (transform.position.x > 0 && transform.position.x < 25 && transform.position.z > 0 && transform.position.z < 25);
    }
}
