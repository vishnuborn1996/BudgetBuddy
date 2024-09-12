namespace BudgetBuddy.Data;

public class MonthlyIncome
{
	/// <summary>
	/// Gets or sets the month.
	/// </summary>
	/// <value>
	/// The month.
	/// </value>
	public BudgetMonth Month { get; set; }

	/// <summary>
	/// Gets or sets the month identifier.
	/// </summary>
	/// <value>
	/// The month identifier.
	/// </value>
	public Guid MonthId { get; set; }

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
	public DateTime ReceivedOn { get; set; }

	/// <summary>
	/// Gets or sets the name.
	/// </summary>
	/// <value>
	/// The name.
	/// </value>
	public string Name { get; set; }

	/// <summary>
	/// Gets or sets the description.
	/// </summary>
	/// <value>
	/// The description.
	/// </value>
	public string Description { get; set; }
}
