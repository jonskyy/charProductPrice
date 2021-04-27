using System;
using System.Windows.Forms;

namespace WindowsFormsApp_OData
{
    static class Program
    {
        /// <summary>
        /// Data download from https://services.odata.org/V3/OData/OData.svc/Products?$top=9&$orderby=Price&$format=json
        /// The chart dipicts Products and Prices.
        /// You can sort data and filter by Price.
        /// </summary>
        /// 
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CharProcuctPrice());
        }
    }
}
