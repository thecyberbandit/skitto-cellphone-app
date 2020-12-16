public class ListBankPlanet : BaseListBank
{
	private string[] _planets = {
		"Sun", "Mercury", "Venus", "Earth", "Mars", "Jupiter",
		"Saturn", "Uranus", "Neptune", "Pluto"
	};

	public override string GetListContent(int index)
	{
		return _planets[index];
	}

	public override int GetListLength()
	{
		return _planets.Length;
	}
}
