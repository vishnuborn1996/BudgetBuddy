using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Data;

public class MonthlyExpense
{
	/// <summary>
	/// Gets or sets the created on.
	/// </summary>
	/// <value>
	/// The created on.
	/// </value>
	public DateTime CreatedOn { get; set; }

	/// <summary>
	/// Gets or sets the paid on.
	/// </summary>
	/// <value>
	/// The paid on.
	/// </value>
	public DateTime PaidOn { get; set; }

	/// <summary>
	/// Gets or sets the name.
	/// </summary>
	/// <value>
	/// The name.
	/// </value>
	public string  Name { get; set; }

	/// <summary>
	/// Gets or sets the description.
	/// </summary>
	/// <value>
	/// The description.
	/// </value>
	public string  Description { get; set; }
}
