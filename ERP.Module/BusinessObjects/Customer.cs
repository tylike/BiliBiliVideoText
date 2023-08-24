using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System.Drawing;

namespace ERP.Module.BusinessObjects;

[NavigationItem]
public class Customer : BaseObject
{
    public Customer(Session s) : base(s)
    {
    }
    [XafDisplayName("姓名")]
    public string Name
    {
        get { return GetPropertyValue<string>(nameof(Name)); }
        set { SetPropertyValue(nameof(Name), value); }
    }
    [XafDisplayName("年龄")]
    public int Age
    {
        get { return GetPropertyValue<int>(nameof(Age)); }
        set { SetPropertyValue(nameof(Age), value); }
    }
    [XafDisplayName("出生日期")]
    public DateTime Birthday
    {
        get { return GetPropertyValue<DateTime>(nameof(Birthday)); }
        set { SetPropertyValue(nameof(Birthday), value); }
    }
    [XafDisplayName("是否审核")]
    public bool Checked
    {
        get { return GetPropertyValue<bool>(nameof(Checked)); }
        set { SetPropertyValue(nameof(Checked), value); }
    }
    [XafDisplayName("评分")]
    public decimal Score
    {
        get { return GetPropertyValue<decimal>(nameof(Score)); }
        set { SetPropertyValue(nameof(Score), value); }
    }
    [XafDisplayName("颜色标识")]
    [ValueConverter(typeof(ColorValueConverter))]
    public Color Color
    {
        get { return GetPropertyValue<Color>(nameof(Color)); }
        set { SetPropertyValue(nameof(Color), value); }
    }
    [XafDisplayName("简历")]
    public FileData Resume
    {
        get { return GetPropertyValue<FileData>(nameof(Resume)); }
        set { SetPropertyValue(nameof(Resume), value); }
    }
    [XafDisplayName("备注")]
    [Size(-1)]
    public string Memo
    {
        get { return GetPropertyValue<string>(nameof(Memo)); }
        set { SetPropertyValue(nameof(Memo), value); }
    }
}
