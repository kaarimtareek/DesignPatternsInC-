namespace DesignPatterns.Structural.Proxy;

public class CachedYoutube : IThirdPartyYoutubeLib
{
    private List<string> videos;
    private byte[] cachedVideo;

    private IThirdPartyYoutubeLib thirdPartyYoutubeLib;
    private bool shouldReset;
    public CachedYoutube(List<string> videos, IThirdPartyYoutubeLib thirdPartyYoutubeLib)
    {
        this.videos = videos;
        this.thirdPartyYoutubeLib = thirdPartyYoutubeLib;
        this.shouldReset = false;
        cachedVideo = [];
    }

    public CachedYoutube(IThirdPartyYoutubeLib thirdPartyYoutubeLib)
    {
        this.thirdPartyYoutubeLib = thirdPartyYoutubeLib;
        this.videos = new List<string>();
        this.shouldReset = false;
        cachedVideo = [];
    }
    public List<string> ListVideos()
    {
        if (videos.Count ==0 || !this.shouldReset)
        {
            videos = thirdPartyYoutubeLib.ListVideos();
        }
        return videos;
    }

    public string GetVideoInfo(string videoId)
    {
        string video = this.videos.FirstOrDefault(v => v == videoId);
        if (video == null)
        {
            video = this.thirdPartyYoutubeLib.GetVideoInfo(videoId);
        }
        return video;
    }

    public byte[] DonwloadVideo(string videoId)
    {
        if (this.cachedVideo == null || this.cachedVideo.Length == 0 || this.shouldReset)
        {
            this.cachedVideo = this.thirdPartyYoutubeLib.DonwloadVideo(videoId);
        }
        return this.cachedVideo;
    }
}