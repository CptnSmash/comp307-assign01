using System;
using System.Diagnostics;

public class Wine
{
	/// <summary>
    /// 
    /// </summary>
	private decimal[] values;
	public decimal[] Values {
		get => values;
		set { values = value; }; 
	}
	//The class of the wine. Called category here as class is a restricted keyword.
	private int category;
	public int Category {
		get => category;
		set { category = value; };
	}

	//Main constructor - for test and actual use
	public Wine(decimal[] values) {
		this.values = values;
	}

	//Training constructor - adds category information
	public Wine(decimal[] values, int category) {
		this.values = values;
		this.category = category;
	}

	/// <summary>
    /// Returns the Euclidean distance between this Wine and another. Used for finding the nearest other Wines for k-Nearest Neightbour algorithm.
    /// </summary>
    /// <param name="other">The Wine to find the distance to.</param>
    /// <returns>A decimal type number representing the distance between the two Wines.</returns>
	public decimal distanceTo(Wine other) {
		decimal[] otherValues = other.Values;
		if (values.Length != otherValues.Length) {
			throw new ArgumentException("Cannot find distance between points: Values arrays have differnt lengths.");
		}
		decimal dist = 0.0;
		for (int i = 0; i < values.Length; i++) {
			dist += Math.Pow(otherValues[i] - values[i], 2);
		}
		dist = Math.Sqrt(dist);
		Debug.Assert(dist >= 0);
		return dist;
	}
}
