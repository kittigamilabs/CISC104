using System;
public class Chicken : Bird
{
    /// <summary>
    /// Do not call this method.  The default constructor throws an exception because
    /// the chicken needs a weight.
    /// </summary>
    /// <exception cref="NotSupportedException"></exception>
	public Chicken()
    {
        throw new NotSupportedException();
    }

    public Chicken(int WeightInOunces) : base()
	{
        base.WeightInOunces = WeightInOunces;
    }

    public override void RemoveBonesAndAdjustWeight()
    {
        if (this.HasBones)
        {
            this.WeightInOunces -= (int)((float)this.WeightInOunces * .32);
            this.HasBones = false;
        }
    }

    public override int GetCalories()
    {
        return this.WeightInOunces * 68;
    }
}

