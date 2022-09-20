
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem {

    public static void SaveScore (Score score)
    {

        BinaryFormatter formatter = new BinaryFormatter();

        //tallennusdatan sijainti
        string path = Application.persistentDataPath + "/score.data";
        FileStream stream = new FileStream(path, FileMode.Create);

        ScoreData data = new ScoreData(score);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static ScoreData LoadScore ()
    {
        string path = Application.persistentDataPath + "/score.data";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ScoreData data = formatter.Deserialize(stream) as ScoreData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("Save file not found in " + path);
            return null;
        }
    }

}
