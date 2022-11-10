using System;
public class Bird
{
	public bool HasBones { get; protected set; }
	public int WeightInOunces { get; protected set; }

	public Bird()
	{
		this.HasBones = true;
	}

    public Bird(int weightInOunces)
    {
        throw new NotImplementedException();
    }

	/// <summary>
    /// Removes the bones from the bird.  At the end of this method, this bird will be deboned.
    /// </summary>
    /// <returns>
    /// If the bird has bones, remove the bones and returns true.
    /// Else, bones already removed and returns false.
    /// </returns>
	public bool Debone()
    {
		if (this.HasBones)
		{
            RemoveBonesAndAdjustWeight();

            return true;
		}
		else return false;
    }

    /// <summary>
    /// Used to modify the weight of the bird, when the bones are removed.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
	public virtual void RemoveBonesAndAdjustWeight()
    {
        throw new NotImplementedException();
    }

	/// <summary>
    /// Used to get the total number of calories in the bird.
    /// </summary>
    /// <returns>
    /// An integer value, representing the number of calories in the bird.
    /// </returns>
    /// <exception cref="NotImplementedException"></exception>
	public virtual int GetCalories()
    {
		throw new NotImplementedException();
    }
}

