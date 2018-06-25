using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading ;
namespace Tasky.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = Setup.Start(platform);
        }

        [Test]
        public void AppLaunches()
        {
            //app.Repl();

            app.Screenshot("First Screen.");
            Thread.Sleep(1000); 
            app.Tap(Tasky_Repository.MenuAddTask);
            app.Screenshot("Task Details Screen.");
            app.EnterText(Tasky_Repository.TaskyName, "Test");
            app.EnterText(Tasky_Repository.TaskyNotes, "Test Tasky");
            app.Tap(Tasky_Repository.TaskyDoneSelect);
            app.Tap(Tasky_Repository.TaskySave);
            app.Screenshot("Task Details Screen.");
        }
        
        [Test]
        public void VerifySave()
        {
            //app.Repl();

            app.Screenshot("First Screen.");
            Thread.Sleep(1000);
            app.Tap(Tasky_Repository.MenuAddTask);
            app.Screenshot("Task Details Screen.");
            app.EnterText(Tasky_Repository.TaskyName, "Test");
            app.EnterText(Tasky_Repository.TaskyNotes, "Test Tasky");
            app.Tap(Tasky_Repository.TaskyDoneSelect);
            app.Tap(Tasky_Repository.TaskySave1);
            app.Screenshot("Task Details Screen.");
        }
        
        
        
        
    }
}
