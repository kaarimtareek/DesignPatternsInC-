namespace DesignPatterns.Structural.Proxy;

public class ThirdPartyYoutubeLib : IThirdPartyYoutubeLib
{
    public List<string> ListVideos()
    {
       return ["Video 1", "Video 2", "Video 3", "Video 4"]; 
    }

    public string GetVideoInfo(string videoId)
    {
        return $"Video : {videoId}";
    }

    public byte[] DonwloadVideo(string videoId)
    {
        return [];
    }
}