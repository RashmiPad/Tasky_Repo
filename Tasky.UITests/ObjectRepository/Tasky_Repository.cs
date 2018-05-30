using System;
using Xamarin.UITest.Queries;

namespace Tasky.UITests
{
    public static class Tasky_Repository
    {
        //public Tasky_Repository()
        //{
        //}

        public static Func<AppQuery, AppQuery> MenuAddTask => (appQuery) => Device.OnPlatform<AppQuery>(iOS: appQuery.Marked("Add"), Android: appQuery.Id("AddButton"));
        public static Func<AppQuery, AppQuery> TaskyName => (appQuery) => Device.OnPlatform<AppQuery>(iOS: appQuery.Marked("task name"), Android: appQuery.Id("NameText"));
        public static Func<AppQuery, AppQuery> TaskyNotes => (appQuery) => Device.OnPlatform<AppQuery>(iOS: appQuery.Marked("Notes"), Android: appQuery.Id("NotesText"));
        public static Func<AppQuery, AppQuery> TaskyDoneSelect => (appQuery) => Device.OnPlatform<AppQuery>(iOS: appQuery.Marked("Done").Index(1), Android: appQuery.Id("chkDone"));
        public static Func<AppQuery, AppQuery> TaskySave => (appQuery) => Device.OnPlatform<AppQuery>(iOS: appQuery.Marked("Save"), Android: appQuery.Id("SaveButton"));


    }
}
