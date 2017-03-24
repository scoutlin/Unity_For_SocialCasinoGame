using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Init
{
    public class InitDO
    {
        public class UserData
        {
            public string name = "8+9";
            public int age = 17;
        }


        public UserData userData;


        public InitDO()
        {
            userData = new UserData();
        }
    }
}
