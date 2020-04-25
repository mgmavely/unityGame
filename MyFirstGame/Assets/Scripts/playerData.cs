using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class playerData
{
    public int level;
    public int maxlevel;

    public playerData (Player player)
	{
        level = player.level;
        maxlevel = player.maxlevel;
    }
}
