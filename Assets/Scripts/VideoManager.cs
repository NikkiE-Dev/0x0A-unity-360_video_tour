using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour {


    private VideoPlayer videoPlayer;
    // Use this for initialization
    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    // This function is used to replace video playing on skybox
    public void SwapVideo(VideoClip newvideo)
    {
        videoPlayer.clip = newvideo;
    }
}
