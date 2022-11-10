using System;
public class Turkey : Bird
{
    /// <summary>
    /// Do not call this method.  The default constructor throws an exception because
    /// the turkey needs a weight.
    /// </summary>
    /// <exception cref="NotSupportedException"></exception>
	public Turkey()
    {
        throw new NotSupportedException();
    }

    public Turkey(int WeightInOunces) : base()
	{
        base.WeightInOunces = WeightInOunces;
	}

    public override void RemoveBonesAndAdjustWeight()
    {
        if(this.HasBones)
        {
            this.WeightInOunces -= (int)((float)this.WeightInOunces * .27);
            // I think I removed a line here
        }
    }

    public override int GetCalories()
    {
        return this.WeightInOunces * 54;
    }
}

