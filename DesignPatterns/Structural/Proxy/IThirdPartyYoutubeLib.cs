namespace DesignPatterns.Structural.Proxy;

public interface IThirdPartyYoutubeLib
{
    
    List<string> ListVideos();
    string GetVideoInfo(string videoId);
    byte[] DonwloadVideo(string videoId);
}