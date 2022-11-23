﻿using Kitchen;
using System;
using System.Reflection;
using Kitchen.Modules;

namespace KitchenLib.Event
{
    public class PlayerPauseView_SetupMenusArgs : EventArgs
    {
        public readonly MainMenuView instance;
        public readonly MethodInfo addMenu;
        public readonly ModuleList module_list;

        internal PlayerPauseView_SetupMenusArgs(MainMenuView instance, MethodInfo addMenu, ModuleList module_list)
        {
            this.instance = instance;
            this.addMenu = addMenu;
            this.module_list = module_list;
        }

        public void AddMenu(object[] parameters)
        {
            addMenu.Invoke(instance, parameters);
        }
    }
}