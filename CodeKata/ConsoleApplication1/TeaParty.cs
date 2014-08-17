using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    class TeaParty : ITeaPartyKata
    {
        public string Welcome(string lastName, bool isWoman, bool isKnighted)
        {
            string greeting = "";
            string title = "";
            //Greet person with Hello X Y where X is Mr, Ms or Sir/Dame and Y is surname
            if (isWoman == false)
            {
                if (isKnighted == false)
                {
                    title = "Mr.";
                }
                else
                {
                    title = "Sir";
                }
            }
            else
            {
                if (isKnighted == false)
                {
                    title = "Ms.";

                }
                else
                {
                    title = "Lady";
                }
            }
            greeting = String.Format("Hello {0} {1}", title, lastName);
            return greeting;
        }
    }
}

public interface ITeaPartyKata
{
    string Welcome(string lastName, bool isWoman, bool isKnighted);
}