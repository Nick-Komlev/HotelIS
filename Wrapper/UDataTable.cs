using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Drawing;
using System;

namespace Wrapper
{
    public class UDataTable : Panel
    {
        public int ColumnCount;
        public List<DataTableColumn> Columns = new List<DataTableColumn>();
        public int RowCount;
        public List<DataTableRow> Rows = new List<DataTableRow>();
        private DataTableHeader Header;
        private Type BinderType;
        public bool ReadOnly ;
        private int ColumnWidthCoef;


        public UDataTable(Dictionary<string, Control> colNameColTypePairs, bool readOnly = false, int coef = 1)
        {
            ColumnWidthCoef = coef;
            BorderStyle = BorderStyle.FixedSingle;
            AutoScroll = true;
            ColumnCount = colNameColTypePairs.Count;
            ReadOnly = readOnly;

            HeaderAdd();

            foreach (string name in colNameColTypePairs.Keys)
            {
                ColumnAdd(name, colNameColTypePairs[name]);
            }

            ZeroColumnAdd();

            Columns.Reverse();
            EmptyRowAdd();
        }

        public UDataTable(Type binderType, bool readOnly = false, int coef = 1)
        {
            ColumnWidthCoef = coef;
            BorderStyle = BorderStyle.FixedSingle;
            AutoScroll = true;
            ReadOnly = readOnly;

            Bind(binderType);

            ZeroColumnAdd();

            Columns.Reverse();

            EmptyRowAdd();
        }

        private void HeaderAdd()
        {
            Header = new DataTableHeader(ColumnWidthCoef, ReadOnly);
            Controls.Add(Header);
        }

        private void ColumnAdd(string name, Control type)
        {
            Header.AddColumn(name, type);
        }

        private void Bind(Type type)
        {
            BinderType = type;
            ColumnCount = type.GetFields().Count();
            HeaderAdd();

            foreach (FieldInfo field in type.GetFields().Reverse())
            {
                ColumnAdd(field.Name, new ULabel());
            }
        }

        private void ZeroColumnAdd()
        {
            Panel pn = new Panel
            {
                Tag = "ZeroColumn",
                Dock = DockStyle.Left,
                Width = 30,
                BorderStyle = BorderStyle.FixedSingle
            };
            Header.Controls.Add(pn);
        }

        public void Add(object obj)
        {
            if (BinderType != null)
            {
                try
                {
                    Rows[RowCount].Fill(obj);
                    RowAdd();
                }

                catch
                {
                    throw new Exception("Wrong type of the object");
                }
            }
        }

        public void Clear()
        {
            RowCount = 0;
            Rows.Clear();
            EmptyRowAdd();
        }

        public void EmptyRowAdd()
        {
            DataTableRow row = new DataTableRow(Header, RowCount);
            Rows.Add(row);
            RefreshControls();
        }

        public void RowAdd()
        {
            RowCount++;
            EmptyRowAdd();
        }

        private void RefreshControls()
        {
            Rows.Reverse();
            Controls.Clear();
            Controls.AddRange(Rows.ToArray());
            Rows.Reverse();
            Controls.Add(Header);
        }

        public void DeleteRow(int index)
        {
            Controls.RemoveAt(RowCount - index);
            for (int i = index + 1; i <= RowCount; i++)
            {
                Rows[i].RowIndex--;
            }
            Rows.RemoveAt(index);
            RowCount--;
        }
    }

    public class DataTableRow : Panel
    {
        public int RowIndex;
        public DataTableHeader Header;

        public DataTableRow(DataTableHeader header, int index)
        {
            RowIndex = index;
            Header = header;

            Height = 30;
            Dock = DockStyle.Top;
            BorderStyle = BorderStyle.FixedSingle;

            if (!Header.ReadOnly)
                EmptyRowAdd();
            else
                RowAdd();
        }

        private void EmptyRowAdd()
        {
            Panel pn = new Panel
            {
                Dock = DockStyle.Left,
                Width = 30,
                BorderStyle = BorderStyle.FixedSingle
            };

            Button btn = new Button
            {
                Text = "+",
                Dock = DockStyle.Fill
            };
            btn.Click += Btn_Click_Add;
            

            pn.Controls.Add(btn);

            Controls.Add(pn);
        }

        private void RowAdd()
        {
            Controls.Clear();
            foreach (Control control in Header.Controls)
            {
                 if (control.Tag != null)
                {
                    ZeroColumnAdd();
                }
                 else
                {
                    Control template = (control as DataTableColumn).ColumnType;

                    Control ctr = (Control)Activator.CreateInstance(template.GetType());
                    if (template.GetType().Equals(typeof(UComboBox)))
                    {
                        foreach (object item in (template as UComboBox).Items)
                        {
                            (ctr as UComboBox).Items.Add(item);
                        }
                    }

                    else if (template.GetType().Equals(typeof(UChooserLink)))
                    {
                        (ctr as UChooserLink).SetParameters((template as UChooserLink).Caller, (template as UChooserLink).Chooser);
                    }

                    DataTableCell cell = new DataTableCell(ctr)
                    {
                        Width = control.Width,
                        Name = (control as DataTableColumn).ColumnName
                    };
                    Controls.Add(cell);
                }
            }
        }

        private void ZeroColumnAdd()
        {

            Button btn = new Button
            {
                Text = "X",
                Dock = DockStyle.Fill,
                Visible = !Header.ReadOnly
            };
            btn.Click += Btn_Click_Delete;

            Panel pn = new Panel
            {
                Dock = DockStyle.Left,
                Width = 30,
                BorderStyle = BorderStyle.FixedSingle
            };
            pn.Controls.Add(btn);
            Controls.Add(pn);
        }

        public void Fill(object obj)
        {
            foreach (FieldInfo field in obj.GetType().GetFields().Reverse())
            {
                (Controls[field.Name].Controls[0] as ULabel).Text = (field.GetValue(obj).ToString());
            }
        }

        private void Btn_Click_Delete(object sender, System.EventArgs e)
        {
            (Parent as UDataTable).DeleteRow(RowIndex);
        }

        private void Btn_Click_Add(object sender, System.EventArgs e)
        {
            RowAdd();
            if (!Header.ReadOnly)
                (Parent as UDataTable).RowAdd();
        }
    }

    public class DataTableCell : Panel
    {
        public string Value;
        private Control CellControl;

        public DataTableCell(Control cellControl)
        {
            Dock = DockStyle.Left;
            BorderStyle = BorderStyle.FixedSingle;

            CellControl = cellControl;
            Controls.Add(CellControl);
            CellControl.Dock = DockStyle.Fill;

            CellControl.TextChanged += CellControl_TextChanged;
        }

        private void CellControl_TextChanged(object sender, System.EventArgs e)
        {
            Value = CellControl.Text;
        }
    }

    public class DataTableHeader : Panel
    {
        public bool ReadOnly;
        private int WidthCoef;

        public DataTableHeader(int coef, bool readOnly = false)
        {
            Dock = DockStyle.Top;
            Height = 30;
            BackColor = Theme.SecondryBackColor;
            ReadOnly = readOnly;
            WidthCoef = coef;
        }

        public void AddColumn(string name, Control type)
        {
            DataTableColumn column = new DataTableColumn(name, type, WidthCoef);
            Controls.Add(column);
        }
    }

    public class DataTableColumn : Panel
    {
        public string ColumnName;
        public Control ColumnType;
        public int LabelWidth;

        public DataTableColumn(string name, Control controlType, int coef = 1)
        {
            ColumnName = name;
            ColumnType = controlType;

            Dock = DockStyle.Left;
            BorderStyle = BorderStyle.FixedSingle;

            Label lb = new Label
            {
                Text = name,
                AutoSize = true
            };

            Width = lb.Text.Length * 10 + (30 * coef);
            Controls.Add(lb);
            lb.Location = new Point(lb.Location.X + (10 * coef) - (5 - lb.Text.Length), lb.Location.Y + 7);
        }
    }
}
