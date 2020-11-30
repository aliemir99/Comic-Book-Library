using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookFactories
{
    public class ComicBookFactory
    {
        public static Func<IComicBookRepo> ComicBookRepoFunc { private get; set; }

        public static IComicBookRepo CreateComicBookRepo()
        {
            return ComicBookRepoFunc();
        }
    }
}
