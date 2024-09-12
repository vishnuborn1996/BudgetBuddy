namespace BudgetBuddy.Data;

public class BudgetMonth
{
	/// <summary>
	/// Initializes a new instance of the <see cref="BudgetMonth"/> class.
	/// </summary>
	public BudgetMonth()
    {
		this.Expenses = [];
		this.Incomes = [];	
    }

    /// <summary>
    /// Gets or sets the month.
    /// </summary>
    /// <value>
    /// The month.
    /// </value>
    public int Month { get; set; }
	/// <summary>
	/// Gets or sets the year.
	/// </summary>
	/// <value>
	/// The year.
	/// </value>
	public int Year { get; set; }
	/// <summary>
	/// Gets or sets the name.
	/// </summary>
	/// <value>
	/// The name.
	/// </value>
	public string Name { get; set; }

	/// <summary>
	/// Gets or sets the income.
	/// </summary>
	/// <value>
	/// The income.
	/// </value>
	public ICollection<MonthlyIncome> Incomes { get; set; }
	/// <summary>
	/// Gets or sets the expenses.
	/// </summary>
	/// <value>
	/// The expenses.
	/// </value>
	public ICollection<MonthlyExpense> Expenses { get; set; }
}
