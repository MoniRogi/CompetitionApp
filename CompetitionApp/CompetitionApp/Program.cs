using CompetitionApp;

Console.WriteLine("Witam na X Ogólnopolskim Turnieju Tańca Towarzyskiego we Wrocławiu!");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Aplikacja została stworzona specjalnie po to, aby ułatwić proces oceniania poszczególnych par w turnieju.");
Console.WriteLine();

bool CloseApp = false;


while (!CloseApp)
{
    Console.WriteLine(
    
        "1 - Zapisz ocenę pary w pamięci programu i wyświetl wyniki\n" +
        "2 - Zapisz ocenę pary w pliku .txt i wyświetl wyniki\n" +
        "x - Zamknij aplikację\n");

    Console.WriteLine("Co chcesz wybrać? \n Naciśnij 1, 2 lub x: ");
    var userInput = Console.ReadLine().ToUpper();

    switch (userInput)
    {
        case "1":
            AddGradesToMemory();
            break;

        case "2":
            AddGradesToTxtFile();
            break;

        case "x":
            CloseApp = true;
            break;

        default:
            Console.WriteLine("Błąd.\n");
            continue;
    }
} 

        

Console.WriteLine();
Console.WriteLine("Proszę wpisać numer pary, a następnie odpowiednią ocenę (1-7) nadaną przez każdego z sędziów.");
Console.WriteLine();
Console.WriteLine();

static void AddGradesToMemory()
{
    string coupleNumber = GetValueFromUser("Wpisz nr pary: ");
    
    if (!string.IsNullOrEmpty(coupleNumber))
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

static void AddGradesToTxtFile()
{
    string coupleNumber = GetValueFromUser("Wpisz nr pary: ");

    if (!string.IsNullOrEmpty(coupleNumber))
    {
        var inMemoryMember = new MemberInFile(coupleNumber);

        EnterGrade(inMemoryMember);
        inMemoryMember.GetStatistics();
    }
    else
    {
        Console.WriteLine("Miejsce do wpisanie numeru pary nie może pozostać puste!");
    }
}
static void EnterGrade(IMember grade)
{
    while (true)
    {
        string coupleNumber = new coupleNumber;
        Console.WriteLine($"Sędzia nr 1. Wpisz ocenę 1-7 parze nr {coupleNumber}:");
        var input = Console.ReadLine();

        if (input == "q" || input == "Q")
        {
            break;
        }
        try
        {  
            grade.AddGrade(input);
                               
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
            Console.WriteLine($"Aby wyjść z aplikacji i polazać wyniki prary nr {coupleNumber} naciśnij 'q' lub 'Q'.");
        }
    }
}

static string GetValueFromUser(string comment)
{
    Console.WriteLine(comment);
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




var statistics = grade.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Averageletter: {statistics.AveragePlace}");