using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wrapper;

namespace BookingApp
{
    public static class BookingWatcher
    {
        public static UInterfaceBooking Home;
    }

    public class UInterfaceBooking : UInterface
    {
        protected new string MenuFilePath = @"D:\Работы\HotelIS\BookingApp\BookingMenuSetup.txt";
        protected Dictionary<string, UserControl> MenuBuilder = new Dictionary<string, UserControl>();
        public USerializableList Response;

        public UInterfaceBooking()
        {
            BookingWatcher.Home = this;

            MenuBuilder.Add("Главная", new MainPage());
            MenuBuilder.Add("Регистрация запроса", new RequestRegistrationMaster(this));
            MenuBuilder.Add("Обзор запросов", null);
            MenuBuilder.Add("Создание брони", null);
            MenuBuilder.Add("Обзор броней", null);
            MenuBuilder.Add("Обзор номерного фонда", null);
            MenuBuilder.Add("Выставление счетов", null);
            MenuBuilder.Add("Формирование документов", null);

            Functionaluty.Add("LoadGuest", LoadGuest);
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
            if (rqst.PlatformApp == "Booking")
            {
                Functionaluty[rqst.Function](rqst.Parameters);
            }
        }

        public void CancelModeSelection()
        {
            (Menu.Controls[Menu.Controls.Count - 1] as MenuElementClickable).OnElemClick();
        }

        private void LoadGuest(USerializableList paramls)
        {
            Response = paramls;
        }
    }
}
