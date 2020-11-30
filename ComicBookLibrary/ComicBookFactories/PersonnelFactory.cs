using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookFactories
{
    public class PersonnelFactory
    {
        public static Func<IPersonnelRepo> PersonnelRepoFunc { private get; set; }

        public static IPersonnelRepo CreatePersonnelRepo()
        {
            return PersonnelRepoFunc();
        }
    }
}
