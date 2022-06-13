using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using Wrapper;
using System.Runtime.Serialization;

namespace AdminApp
{
    public static class AdminWatcher
    {
        public static UInterfaceAdmin Home;
    }

    public class UInterfaceAdmin : UInterface
    {

        protected new string MenuFilePath = @"D:\Работы\HotelIS\AdminApp\AdminMenuSetup.txt";
        protected Dictionary<string, UserControl> MenuBuilder = new Dictionary<string, UserControl>();
        public USerializableList Response;

        public UInterfaceAdmin()
        {
            AdminWatcher.Home = this;

            MenuBuilder.Add("Главная", new MainPage());
            MenuBuilder.Add("Установка ценовых политик", null);
            MenuBuilder.Add("Установка бизнес-процессов", null);
            MenuBuilder.Add("Создание объекта", new ObjectCreationMaster());
            MenuBuilder.Add("Создание статуса", new StateCreationMaster());
            MenuBuilder.Add("Установка модели", null);
            MenuBuilder.Add("Создать пользователя", null);
            MenuBuilder.Add("Настройка пользователей", null);
            MenuBuilder.Add("Обзор справочника", null);
            MenuBuilder.Add("Журнал событий", null);
            MenuBuilder.Add("Журнал бизнес-процессов", null);

            Functionaluty.Add("Configure", Configure);
            Functionaluty.Add("LoadState", LoadState);
            Functionaluty.Add("CreateState", CreateState);
            Functionaluty.Add("CreateObject", CreateObject);
        }

        public override ToolsMenu BindToPlatform(Form platform)
        {
            Platform = platform;
            ReadMenuFile(MenuFilePath);
            MenuAssemble(platform);
            return Menu;
        }

        protected override MenuElementClickable NewElement(string label)
        {
            return new MenuElementClickable(label, MenuBuilder[label]);
        }

        public override void GetResponse(Request rqst)
        {
            if (rqst.PlatformApp == "Admin")
            {
                Functionaluty[rqst.Function](rqst.Parameters);
            }
        }

        private void Configure(USerializableList paramls)
        {
            Console.WriteLine("Configuration complete");
        }

        private void LoadState(USerializableList paramls)
        {
            Response = paramls;
        }

        private void CreateState(USerializableList paramls)
        {
            Console.WriteLine("State added");
        }

        private void CreateObject(USerializableList paramls)
        {
            Console.WriteLine("Object added");
        }
    }
}
