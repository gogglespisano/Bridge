namespace Bridge.Html5
{
    /// <summary>
    /// The HTMLTableDataCellElement interface provides special properties and methods (beyond the regular HTMLTableCellElement and HTMLElement interfaces it also has available to it by inheritance) for manipulating the layout and presentation of table data cells in an HTML document.
    /// </summary>
    [Ignore]
    [Name("HTMLTableDataCellElement")]
    public class TableDataCellElement : TableCellElement
    {
        [Template("document.createElement('td')")]
        public TableDataCellElement()
        {
        }
    }
}
