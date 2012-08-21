using FubuMVC.Diagnostics.Chains;
using HtmlTags;

namespace FubuMVC.Diagnostics.Shared.Tags
{
    public enum HtmlEncoding
    {
        UseEncoding,
        NoEncoding
    }

    public class DetailsTableTag : TableTag
    {
        public DetailsTableTag()
        {
            AddClass("details");
            AddClass("table");
            AddClass("table-striped");
        }

        public void AddDetail(string label, string text, HtmlEncoding encoding = HtmlEncoding.UseEncoding)
        {
            AddBodyRow(x =>
            {
                x.Header().Add("span").Text(label);
                x.Cell(text).Encoded(encoding == HtmlEncoding.UseEncoding);
            });
        }
    }
}