﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns;
using PureMVC.Interfaces;

namespace Init
{
    public class InitMacroCommnad : MacroCommand, ICommand
    {
        // Initialize MyMacroCommand
        protected override void InitializeMacroCommand()
        {
            //AddSubCommand(typeof(PrototypeSimpleCommnad));

            Debug.Log("PrototypeMacroCommnad");
        }
    }
}
