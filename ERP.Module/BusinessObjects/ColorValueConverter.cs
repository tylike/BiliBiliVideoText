using DevExpress.Xpo.Metadata;
using System.Drawing;

namespace ERP.Module.BusinessObjects;

public class ColorValueConverter : ValueConverter
{
    public override Type StorageType
    {
        get { return typeof(Int32); }
    }
    public override object ConvertToStorageType(object value)
    {
        if (!(value is Color)) return null;
        Color color = (Color)value;
        return color.IsEmpty ? -1 : color.ToArgb();
    }
    public override object ConvertFromStorageType(object value)
    {
        if (!(value is Int32)) return null;
        Int32 argbCode = Convert.ToInt32(value);
        return argbCode == -1 ? Color.Empty : Color.FromArgb(argbCode);
    }
}
