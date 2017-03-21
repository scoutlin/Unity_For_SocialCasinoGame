using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns;
using PureMVC.Interfaces;

namespace Prototype
{
    public class PrototypeMacroCommnad : MacroCommand, ICommand
    {
        // Initialize MyMacroCommand
        protected override void InitializeMacroCommand()
        {
            //AddSubCommand(typeof(PrototypeSimpleCommnad));

            Debug.Log("PrototypeMacroCommnad");
        }
    }
}
