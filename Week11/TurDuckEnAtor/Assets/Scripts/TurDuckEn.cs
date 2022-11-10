using System;

// I didn't intentionally break anything in this class
public class TurDuckEn : Bird
{
    private Turkey turkey;
    private Duck duck;
    private Chicken chicken;

    public bool IsPreparedForOven { get; private set; }
    public bool IsCooked { get; private set; }

    public int CookedMinutes { get; private set; }

	/// <summary>
    /// Do not call this method.  The default constructor throws an exception because
    /// it is not a TurDuckEn without a Turkey, Duck, and Chicken
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
	public TurDuckEn()
	{
		throw new NotImplementedException();
	}

	public TurDuckEn(Turkey turkey, Duck duck, Chicken chicken)
    {
        if(turkey.HasBones || duck.HasBones || chicken.HasBones)
        {
            // The birds better all have their bones removed first, otherwise we complain with an exception.
            throw new NotSupportedException();
        }

        // Accept the components to make the TurDuckEn
        this.turkey = turkey;
        this.duck = duck;
        this.chicken = chicken;

        // Calculate the total weight in ounces
        base.WeightInOunces = GetTotalWeightInOunces();

        // It is not yet prepared for the oven.
        this.IsPreparedForOven = false;

        // It is not yet cooked.
        this.IsCooked = false;
        this.CookedMinutes = 0;
    }

    /// <summary>
    /// This will raise an exception.  The turducken components need to be deboned before assembly.
    /// </summary>
    /// <exception cref="NotSupportedException"></exception>
    public override void RemoveBonesAndAdjustWeight()
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// Returns the number of calories in the entire TurDuckEn
    /// </summary>
    /// <returns>
    /// An integer value reflecting the total calories in the TurDuckEn
    /// </returns>
    public override int GetCalories()
    {
        return (this.turkey.GetCalories() + this.duck.GetCalories() + this.chicken.GetCalories());
    }

    public void PrepareForOven()
    {
        this.IsPreparedForOven = true;
    }

    public int RequiredMinutesOfCooking()
    {
        return this.GetTotalWeightInOunces();
    }

    public void CookOneMinute()
    {
        if(this.CookedMinutes < this.RequiredMinutesOfCooking())
        {
            this.CookedMinutes++;
        }

        if(this.CookedMinutes >= this.RequiredMinutesOfCooking())
        {
            this.IsCooked = true;
        }
    }

    /// <summary>
    /// Get the weight of the TurDuckEn in ounces
    /// </summary>
    /// <returns>
    /// An integer value reflecting the total ounces of the TurDuckEn.
    /// </returns>
    public int GetTotalWeightInOunces()
    {
        return (this.turkey.WeightInOunces + this.duck.WeightInOunces + this.chicken.WeightInOunces);
    }
}

