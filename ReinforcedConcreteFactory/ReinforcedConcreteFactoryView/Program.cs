﻿using ReinforcedConcreteFactoryBusinessLogic.BusinessLogics;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryFileImplement.Implements;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace ReinforcedConcreteFactoryView
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            IUnityContainer container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            UnityContainer currentContainer = new UnityContainer();
            currentContainer.RegisterType<IMaterialStorage, MaterialStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderStorage, OrderStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IReinforcedStorage, ReinforcedStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IStoreHouseStorage, StoreHouseStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<MaterialLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<OrderLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReinforcedLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<StoreHouseLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}