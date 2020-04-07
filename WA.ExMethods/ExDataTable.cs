using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.ExMethods
{
	/// <summary>
	/// DataTable 的擴充方法
	/// </summary>
    public static class ExDataTable
    {
		/// <summary>
		/// 為 DataTable 加入一筆新記錄
		/// </summary>
		/// <param name="dataTable"></param>
		/// <param name="addNewRowAction"></param>
	    public static void WA_AddNewRow(this DataTable dataTable, Action<DataRow> assignColumnsValue)
	    {
		    var newRow = dataTable.NewRow();
		    assignColumnsValue(newRow);
		    dataTable.Rows.Add(newRow);
	    }
    }
}
