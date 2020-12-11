using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookFactories
{
    public class LoginFactory
    {
        public static Func<ILoginRepo> LoginRepoFunc { private get; set; }

        public static ILoginRepo createLoginRepo()
        {
            return LoginRepoFunc();
        }
    }
}
