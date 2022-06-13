using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wrapper;

namespace CashierApp
{
    public class UInterfaceCashier : UInterface
    {
        protected new string MenuFilePath = @"D:\Работы\HotelIS\CashierApp\CashierMenuSetup.txt";
        protected Dictionary<string, UserControl> MenuBuilder = new Dictionary<string, UserControl>();

        public UInterfaceCashier()
        {
            MenuBuilder.Add("Главная", new MainPage());
            MenuBuilder.Add("Промежуточные счета", null);
            MenuBuilder.Add("Перенос на другой счет", null);
            MenuBuilder.Add("Деление начислений", null);
            MenuBuilder.Add("Объединение начислений", null);
            MenuBuilder.Add("Регистрация приема оплаты", null);
            MenuBuilder.Add("Регистрация операций обмена", null);
            MenuBuilder.Add("Формирование выписки", null);
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
