namespace MasterMind;

public class Languages
{
	public Dictionary<string, string> selectedLanguageTemplate = new();

	public void InitializeLanguages(string selectedLanguage)
	{
		List<string> templates = ["colors", "next", "loose", "win", "good", "well-placed", "error", "selection"];
		string[][] languages =
		[
			[
				"Rouge Bleu Jaune Orange Vert Violet Rose",
				"Appuyez sur Entrée pour continuer",
				"Vous venez de perdre, la bonne réponse était: ",
				"Bravo vous avez gagné !",
				"Vous avez [1] bon[2]",
				"Vous avez [1] bien placé[2]",
				"Erreur: ",
				"Veuillez sélectionner [1] couleurs (séparer par des espace): "
			],
			[
				"Red Blue Yellow Orange Green Purple Pink",
				"Press Enter to continue",
				"You just lost, the correct answer was:",
				"Bravo you won!",
				"You got [1] right[2]",
				"You have [1] well placed",
				"Error:",
				"Please select [1] colors (separated by spaces): "
			],
			[
				"Rojo Azul Amarillo Naranja Verde Morado Rosa",
				"Presione Enter para continuar",
				"Acabas de perder, la respuesta correcta era: ",
				"Bien hecho, has ganado!",
				"Has acertado[2] [1]",
				"Bien situado[2] [1]",
				"Error: ",
				"Por favor, seleccione [1] colores (separados por espacios): "
			]
		];

		int selection = -1;
		switch (selectedLanguage)
		{
			case "french":
				selection = 0;
				break;
			case "english":
				selection = 1;
				break;
			case "spanish":
				selection = 2;
				break;
			default:
				selection = -1;
				break;
		}

		int i = 0;
		foreach (string template in templates)
		{
			selectedLanguageTemplate.Add(template, languages[selection][i]);
			i++;
		}
	}
}