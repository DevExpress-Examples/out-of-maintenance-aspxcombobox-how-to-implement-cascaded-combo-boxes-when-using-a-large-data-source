using System.Collections.Generic;
using System.Linq;

public partial class _Default : System.Web.UI.Page {

    protected void cbCars_ItemRequestedByValue(object source, DevExpress.Web.ASPxEditors.ListEditItemRequestedByValueEventArgs e) {
        if(e.Value != null && e.Value is int) {
            var data = MyDataSource.GetData(cbLocation.Text);
            var query = from r in data where r.Value == (int)e.Value select r;
            cbCars.DataSource = query;
            cbCars.DataBind();
        }
    }
    protected void cbCars_ItemsRequestedByFilterCondition(object source, DevExpress.Web.ASPxEditors.ListEditItemsRequestedByFilterConditionEventArgs e) {
        var data = MyDataSource.GetData(cbLocation.Text);
        var query = from r in data where r.Text.StartsWith(e.Filter) select r;
        cbCars.DataSource = query.Skip(e.BeginIndex).Take(e.EndIndex - e.BeginIndex + 1);
        cbCars.DataBind();
    }
}
public static class MyDataSource {
    public class MyDataSourceItem {
        public int Value { get; set; }
        public string Text { get; set; }
    }
    public static IQueryable<MyDataSourceItem> GetData(string location) {
        List<MyDataSourceItem> ds = new List<MyDataSourceItem>();
        for(int i = 0; i < 100; i++)
            ds.Add(new MyDataSourceItem() { Text = string.Format("Car#{0} for {1}", i, location), Value = i });
        return ds.AsQueryable();
    }
}