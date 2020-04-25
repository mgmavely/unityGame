using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class playContinue : MonoBehaviour
{
    public Text playcont;
    public Player player;
    void Update() {
    string path = Application.persistentDataPath + "/level.yeur";
        if (File.Exists(path)) {
            Debug.Log("file");
            playcont.fontSize = 55;
            playcont.text = "CONTINUE";
        } else
		{
            Debug.Log("no file");
            playcont.text = "PLAY";
		}
    }
}
