

namespace ComicBookFactories
{
    public interface ILoginRepo
    {
         int LoginUser(string username, string password);
         int RegisterUser(string username, string password);
    }
}
