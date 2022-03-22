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

	public Wine()
	{

	}

	public double distanceTo(Wine other) {
		return null;
	}
}
