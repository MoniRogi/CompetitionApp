using CompetitionApp;

Console.WriteLine("Witam na X Ogólnopolskim Turnieju Tańca Towarzyskiego we Wrocławiu!");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Aplikacja została stworzona specjalnie po to, aby ułatwić proces oceniania poszczególnych par w turnieju.");
Console.WriteLine("Na każdym turnieju w finale zostaje wybranych 7 par, które podlegają wnikliwej ocenie przez sędziów.");
Console.WriteLine();

bool CloseApp = false;

while (!CloseApp)
{
    Console.WriteLine(
    
        "1 - Zapisz ocenę pary w pamięci programu i wyświetl wyniki\n" +
        "2 - Zapisz ocenę pary w pliku .txt i wyświetl wyniki\n" +
        "X - Zamknij aplikację\n");

    Console.WriteLine("Co chcesz wybrać? \n Naciśnij 1, 2 lub X: ");
    var userInput = Console.ReadLine().ToUpper();

    switch (userInput)
    {
        case "1":
            AddGradesToMemory();
            break;

        case "2":
            AddGradesToTxtFile();
            break;

        case "X":
            CloseApp = true;
            break;

        default:
            Console.WriteLine("Błąd.\n");
            continue;
    }
} 
Console.WriteLine ("Naciśnij dowolny klawisz, aby wyjść.\n" );
Console.ReadKey();
        

Console.WriteLine();
Console.WriteLine("Proszę wpisać numer pary, a następnie odpowiednią ocenę (1-7) nadaną przez każdego z sędziów.");
Console.WriteLine();

private static void AddGradesToMemory()
{
    int coupleNumber = GetValueFromUser("Wpisz nr pary: ");
    
    if (!int.IsNullOrEmpty(coupleNumber)
    {
        var inMemoryMember = new MemberInMemory(coupleNumber);
        
        EnterGrade(inMemoryMember);
        inMemoryMember.GetStatistics();
    }
    else
    {
        Console.WriteLine("Miejsce do wpisanie numeru pary nie może pozostać puste!");
    }
}

private static void AddGradesToTxtFile()
{
    int coupleNumber = GetValueFromUser("Wpisz nr pary: ");

    if (!int.IsNullOrEmpty(coupleNumber)
    {
        var inMemoryMember = new MemberInMemory(coupleNumber);

        EnterGrade(inMemoryMember);
        inMemoryMember.GetStatistics();
    }
    else
    {
        Console.WriteLine("Miejsce do wpisanie numeru pary nie może pozostać puste!");
    }
}
private static void EnterGrade(IMember member)
{
    while (true)
    {
        Console.WriteLine($"Sędzia nr 1. Wpisz ocenę 1-7:");
        var input = Console.ReadLine();

        if (input == "q" || input == "Q")
        {
            break;
        }
        try
        {
            member.AddGrade(input);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine($"Aby wyjść z aplikacji i polazać wyniki prary nr {member.CoupleNumber} naciśnij 'q' lub 'Q'.");
        }
    }
}

private static string GetValueFromUser(string comment)
{
    Console.WriteLine (comment);
    string userInput = Console.ReadLine();
    return userInput;
}
    


Console.WriteLine("Sędzia nr 1. Wpisz ocenę 1-7");
Console.WriteLine();
Console.ReadLine();
Console.WriteLine("Sędzia nr 2. Wpisz ocenę 1-7");
Console.WriteLine();
Console.WriteLine("Sędzia nr 3. Wpisz ocenę 1-7");
Console.WriteLine();
Console.WriteLine("Sędzia nr 4. Wpisz ocenę 1-7");
Console.WriteLine();
Console.WriteLine("Sędzia nr 5. Wpisz ocenę 1-7");
Console.WriteLine();

var ststistics = member.GetStatistics();
Console.WriteLine($"average: {ststistics.Average}");
Console.WriteLine($"min: {ststistics.Min}");
Console.WriteLine($"max: {ststistics.Max}");
Console.WriteLine($"averageletter: {ststistics.AveragePlace}");