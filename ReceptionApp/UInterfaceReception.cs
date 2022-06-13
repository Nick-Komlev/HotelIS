using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wrapper;

namespace ReceptionApp
{
    public class UInterfaceReception : UInterface
    {
        protected new string MenuFilePath = @"D:\Работы\HotelIS\ReceptionApp\ReceptionMenuSetup.txt";
        protected Dictionary<string, UserControl> MenuBuilder = new Dictionary<string, UserControl>();

        public UInterfaceReception()
        {
            MenuBuilder.Add("Главная", new MainPage());
            MenuBuilder.Add("Создание записей о гостях", null);
            MenuBuilder.Add("Регистрация гостей", null);
            MenuBuilder.Add("Обзор гостей", null);
            MenuBuilder.Add("Подселение", null);
            MenuBuilder.Add("Назначение номеров", null);
            MenuBuilder.Add("Заселение", null);
            MenuBuilder.Add("Переселение", null);
            MenuBuilder.Add("Обзор броней", null);
            MenuBuilder.Add("Выставление счетов", null);
            MenuBuilder.Add("Формирование документов", null);

        }

        public override ToolsMenu BindToPlatform(Form platform)
        {
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
            throw new System.NotImplementedException();
        }
    }
}
