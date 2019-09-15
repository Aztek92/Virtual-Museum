using UnityEngine;
using System.Collections;


namespace Completed
{

    struct AudioResource
    {
        string DataPath;
    }

    public class ResourceManager : MonoBehaviour
    {
        public AudioClip Data; // Data for which we stream from.
        public WWW Path;        // Data path for which we pull from.
        public static ResourceManager instance = null;
        public AudioSource Clip;    //we apparently need a container for an audio source.

        public void Awake()
        {
            Clip = this.gameObject.GetComponent<AudioSource>();
            // Enforce the Singleton
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(gameObject);

            // Setting Paths
            string[] URL = System.IO.Directory.GetFiles(Application.dataPath + "/StreamedResource/Audio/");
            print(URL[0]);
            Path = new WWW("file:///" + URL[0]);
            //Path += Directory.GetFiles (Path, "main");
            print(Path.url);
            Clip.clip = Path.GetAudioClip(false, true, AudioType.OGGVORBIS);
            Clip.Play();
            print(Clip.name);
        }
    }

}