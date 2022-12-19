using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ITAsk1PapersPlease
{
    internal class StatniHraniceSingleton
    {
        private static StatniHraniceSingleton _instance;
        public static StatniHraniceSingleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StatniHraniceSingleton();
                return _instance;
            }
        }
        private StatniHraniceSingleton()
        {

        }

        public List<string> seznamZakazanychJmen = new List<string>();
    }
}
