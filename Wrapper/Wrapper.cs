using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;

namespace Wrapper
{
    public abstract class UInterface
    {
        public delegate void RequestMaker(string func, USerializableList paramls = null);
        protected delegate void ResponseExecution(USerializableList paramls);

        protected Dictionary<string, ResponseExecution> Functionaluty = new Dictionary<string, ResponseExecution>();

        public RequestMaker requestMaker;

        protected List<string> Collection = new List<string>();
        protected List<int> Headers = new List<int>();

        protected List<MenuElement> Elems = new List<MenuElement>();
        protected string MenuFilePath;
        protected ToolsMenu Menu;

        public Form Platform;

        public UInterface()
        {

        }

        public virtual ToolsMenu BindToPlatform(Form platform)
        {
            Platform = platform;
            ReadMenuFile(MenuFilePath);
            MenuAssemble(Platform);
            return Menu;
        }

        protected void ReadMenuFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != "endd")
                {
                    Collection.Add(line);
                }
                while ((line = reader.ReadLine()) != null)
                {
                    Headers.Add(int.Parse(line));
                }
            }
        }

        protected void MenuAssemble(Form platform)
        {
            Menu = new ToolsMenu(platform);
            int i = 0;
            int count = Collection.Count;
            Collection.Reverse();
            foreach (string elem in Collection)
            {
                if (Headers.Contains(count - i - 1))
                    Menu.Controls.Add(NewHeader(elem));
                else
                    Menu.Controls.Add(NewElement(elem));
                i++;
            }
            (Menu.Controls[i - 1] as MenuElementClickable).OnElemClick();
            Collection.Reverse();
        }

        protected abstract MenuElementClickable NewElement(string label);

        protected MenuElementHeader NewHeader(string label)
        {
            return new MenuElementHeader(label);
        }

        public void GetRequestFunc(RequestMaker requestMaker_)
        {
            requestMaker = requestMaker_;
        }

        public abstract void GetResponse(Request rqst);
    }

    public class Theme
    {
        //public static Color PrimaryBackColor = Color.FromArgb(58, 64, 77);
        //public static Color SecondryBackColor = Color.FromArgb(39, 44, 53);
        //public static Color DarkBackColor = Color.FromArgb(35, 35, 45);

        //public static Color PrimaryForeColor = Color.FromArgb(0, 255, 249);
        //public static Color SecondryForeColor = Color.FromArgb(22, 150, 150);

        public static Color PrimaryBackColor = Color.FromArgb(47, 45, 43);
        public static Color SecondryBackColor = Color.FromArgb(31, 33, 31);
        public static Color DarkBackColor = Color.FromArgb(101, 75, 25);

        public static Color PrimaryForeColor = Color.FromArgb(242, 228, 203);
        public static Color SecondryForeColor = Color.FromArgb(190, 180, 110);
    }
}
