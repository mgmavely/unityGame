using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
public static class saveSystem
{
    public static void savePlayer (Player player)
	{
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/level.yeur";
        FileStream stream = new FileStream(path, FileMode.Create);

        playerData data = new playerData(player);
        Debug.Log(data.maxlevel);

        formatter.Serialize(stream, data);
        stream.Close();
	}

    public static playerData LoadPlayer()
	{
        string path = Application.persistentDataPath + "/level.yeur";
        if (File.Exists(path))
		{
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            try
            {
                playerData data = formatter.Deserialize(stream) as playerData;
                stream.Close();
                Debug.Log(data.maxlevel);
                return data;
            } finally
			{
                stream.Close();
			}
        } else
		{
            Debug.LogError("Save file not found in " + path);
            return null;
		}
    }
}
