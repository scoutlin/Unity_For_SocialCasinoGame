using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrototypeDO
{
    public class UserData
    {
        public string name = "8+9";
        public int age = 17;
    }


    public UserData userData;


    public PrototypeDO()
    {
        userData = new UserData();
    }
}
