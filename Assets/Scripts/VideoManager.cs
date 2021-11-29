using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour {


    private VideoPlayer videoPlayer;

    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    public void SwapVideo(VideoClip newvideo)
    {
        videoPlayer.clip = newvideo;
    }

    // IEnumerator PlayVideo(string videoName)
    // {
    //     yield return new WaitForSeconds(.5f);
    // }
}
