using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

/*
 * You can attack a player anywhere in the game, unless the zone is listed below
 */
public partial class Player
{
    [Header("Player Vs Player System")]
    [SyncVar_] public int MinLevel = 0;
    [SyncVar_] public float StartPos = 0;
    [SyncVar_] public float EndPos = 0;

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
     * (Made Simple)
     */
    public bool InZoneName_Example()
    {
        return (transform.position.x > StartPos && transform.position.x < EndPos && transform.position.z > StartPos && transform.position.z < EndPos);
    }
}
