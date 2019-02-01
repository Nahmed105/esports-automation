﻿using System;
using NUnit.Framework;
using Tests.Base;

namespace League.Com.Tests
{
    [TestFixture, Parallelizable]
    public class Support : TestBase
    {
        [Test, Parallelizable, Category("support")]
        public void Game_service_online()
        {
            Esports.Goto();
            Esports.Support.Goto();
            Esports.ServiceStatus.Goto();
            Assert.That(Esports.ServiceStatus.ServiceOnline("Game"));
        }

        [Test, Parallelizable, Category("support")]
        public void Client_service_online()
        {
            Esports.Goto();
            Esports.Support.Goto();
            Esports.ServiceStatus.Goto();
            Assert.That(Esports.ServiceStatus.ServiceOnline("Client"));
        }

        [Test, Parallelizable, Category("support")]
        public void Store_service_online()
        {
            Esports.Goto();
            Esports.Support.Goto();
            Esports.ServiceStatus.Goto();
            Assert.That(Esports.ServiceStatus.ServiceOnline("Store"));
        }

        [Test, Parallelizable, Category("support")]
        public void Website_service_online()
        {
            Esports.Goto();
            Esports.Support.Goto();
            Esports.ServiceStatus.Goto();
            Assert.That(Esports.ServiceStatus.ServiceOnline("Website"));
        }
    }
}
