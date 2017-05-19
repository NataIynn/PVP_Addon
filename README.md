# PVP_Addon
Allows you set safe zones in the world.

- Still in early development.

```CSharp
//player is attackable & checks minimum level
    if(entity is Player && IsAttackable()) {
        if (level < MinLevel || target.level < MinLevel) {
            return;
        }
    //player is in safe zone
    } else if (entity is Player && IsSafeZone()) {
        Debug.Log("You cannot attack a player in safe zone.");
        return;
    }
```

# Usage

1. Create the safe zone.

```CSharp
    public bool InZoneName_Example()
    {
        return (transform.position.x > StartPos && transform.position.x < EndPos && transform.position.z > StartPos && transform.position.z < EndPos);
    }
```

2. Add the safe zone to.

```CSharp
    public bool IsSafeZone()
    {
        return (InZoneName_Example());
    }
```
