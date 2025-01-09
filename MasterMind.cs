using System.Globalization;
using System.Resources;

namespace MasterMind;

public class MasterMind
{
	private static ResourceManager _rm = null!;

	public static void Game(string[] args)
	{
		_rm = new ResourceManager("MasterMind.Resources1", typeof(MasterMind).Assembly);
		CultureInfo cultureInfo = new CultureInfo("es");
		Thread.CurrentThread.CurrentUICulture = cultureInfo;

		string[] colors = _rm.GetString("colors")!.Split(" ");
		int tryLimit = 1;

		int colorCount = TryToParse();
		List<string> selectedColors = SelectColors(colorCount, colors);

		while (tryLimit <= 10)
		{
			List<string> playerTry = ShowColorMenu(colors, colorCount);
			var resultOfTry = CheckTry(selectedColors, playerTry);
			if (CheckWin(resultOfTry)) break;

			tryLimit++;
			Console.Write(_rm.GetString("next"));
			Console.ReadLine();
		}

		if (tryLimit != 11) return;
		Console.Clear();
		Console.WriteLine(_rm.GetString("loose") + string.Join(" ", selectedColors));
	}

	private static bool CheckWin(List<int> resultOfTry)
	{
		if (resultOfTry[0] == 1)
		{
			Console.WriteLine(_rm.GetString("win"));
			return true;
		}

		Console.WriteLine(_rm.GetString("good")!.Replace("[1]", $"{resultOfTry[1]}").Replace("[2]", resultOfTry[1] > 1 ? "s" : ""));
		Console.WriteLine(_rm.GetString("well-placed")!.Replace("[1]", $"{resultOfTry[2]}").Replace("[2]", resultOfTry[2] > 1 ? "s" : ""));
		return false;
	}

	private static List<string> SelectColors(int colorCount, string[] colors)
	{
		List<string> selectedColors = [];
		Random rand = new Random();
		for (int i = 0; i < colorCount; i++)
		{
			selectedColors.Add(colors[rand.Next(colors.Length)]);
		}

		return selectedColors;
	}

	private static int TryToParse()
	{
		try
		{
			return int.Parse(Console.ReadLine() ?? "4");
		}
		catch (Exception e)
		{
			Console.WriteLine(_rm.GetString("error") + e.Message);
			return 4;
		}
	}

	/// <summary>
	/// Verifie si l'essai du joueur est bon
	/// </summary>
	/// <param name="answer">">La réponse</param>
	/// <param name="playerTry">L'essai du joueur</param>
	/// <returns>Retourne un tableau de 3 int:
	///	<br/>	- Succès
	///	<br/>	- Bon
	///	<br/>	- Bien placé
	/// </returns>
	private static List<int> CheckTry(List<string> answer, List<string> playerTry)
	{
		int success = 1;
		int good = answer.Count;
		int wellPlaced = answer.Count;
		for (int i = 0; i < answer.Count; i++)
		{
			if (answer[i] == playerTry[i]) continue;

			success = 0;
			wellPlaced--;
			if (answer.Contains(playerTry[i])) continue;
			good--;
		}

		return [success, good, wellPlaced];
	}

	private static List<string> ShowColorMenu(string[] colors, int colorCount)
	{
		Console.Clear();
		int i = 1;
		foreach (string color in colors)
		{
			Console.WriteLine($@"{i++}. {color}");
		}

		Console.Write(_rm.GetString("selection")!.Replace("[1]", $"{colorCount}"));
		string[] answer = (Console.ReadLine() ?? "").Split(" ");

		List<string> filteredAnswer = [];
		foreach (var s in answer)
		{
			var filteredValue = s.Replace(" ", "");
			if (s == "") continue;
			if (!char.IsDigit(filteredValue[0])) continue;
			filteredAnswer.Add(colors[int.Parse(filteredValue[0].ToString()) - 1]);
		}

		return filteredAnswer;
	}
}