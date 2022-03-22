using System;

public class Wine
{
	private decimal alcohol { get => alcohol; set { alcohol = value; } };
	private decimal malic { get => malic; set { malic = value; } };
	private decimal ash { get => ash; set { ash = value; } };
	private decimal ashAlkalinity { get => ashAlkalinity; set { ashAlkalinity = value; } };
	private decimal magnesium { get => magnesium; set { magnesium = value; } };
	private decimal totalPhenols { get => totalPhenols; set { totalPhenols = value; } };
	private decimal flavanoids { get => flavanoids; set { flavanoids = value; } };
	private decimal nfnPhenols { get => nfnPhenols; set { nfnPhenols = value; } };
	private decimal proanthocyanins { get => proanthocyanins; set { proanthocyanins = value; } };
	private decimal colorIntensity { get => colorIntensity; set { colorIntensity = value; } };
	private decimal hue { get => hue; set { hue = value; } };
	private decimal od { get => od; set { od = value; } };
	private decimal proline { get => proline; set { proline = value; } };
	//The class of the wine. Called category here as class is a restricted keyword.
	private int category { get => category; set { category = value; } };

	//Main constructor - for test and actual use
	public Wine(decimal alcohol, decimal malic, decimal ash, decimal ashAlkalinity, decimal magnesium, decimal totalPhenols, decimal flavanoids, decimal nfnPhenols, decimal proanthocyanins, decimal colorIntensity, decimal hue, decimal od, decimal proline)
	{
		this.alcohol = alcohol;
		this.malic = malic;
		this.ash = ash;
		this.ashAlkalinity = ashAlkalinity;
		this.magnesium = magnesium;
		this.totalPhenols = totalPhenols;
		this.flavanoids = flavanoids;
		this.nfnPhenols = nfnPhenols;
		this.proanthocyanins = proanthocyanins;
		this.colorIntensity = colorIntensity;
		this.hue = hue;
		this.od = od;
		this.proline = proline;
	}

	//Training constructor - adds category information
	public Wine(decimal alcohol, decimal malic, decimal ash, decimal ashAlkalinity, decimal magnesium, decimal totalPhenols, decimal flavanoids, decimal nfnPhenols, decimal proanthocyanins, decimal colorIntensity, decimal hue, decimal od, decimal proline, int category)
	{
		this.alcohol = alcohol;
		this.malic = malic;
		this.ash = ash;
		this.ashAlkalinity = ashAlkalinity;
		this.magnesium = magnesium;
		this.totalPhenols = totalPhenols;
		this.flavanoids = flavanoids;
		this.nfnPhenols = nfnPhenols;
		this.proanthocyanins = proanthocyanins;
		this.colorIntensity = colorIntensity;
		this.hue = hue;
		this.od = od;
		this.proline = proline;
		this.category = category;
	}

	public double distanceTo(Wine other) {
		return null;
	}

	public bool categorise(int category) { 
		this.category = category;
		return true;
	}
}
