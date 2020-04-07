using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace WA.ExMethods.Tests
{
    [TestFixture]
    public class ExDataTableTests
    {
	    [Test]
	    public void WA_AddNewRow_WhenCalled()
	    {
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));

			dataTable.WA_AddNewRow(row =>
			{
				row["Id"] = 1;
				row["Name"] = "Allen";
			});

			dataTable.Rows.Count.Should().Be(1);
	    }
    }
}
