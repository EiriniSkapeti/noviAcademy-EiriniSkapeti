using WorldRank;

var playerRepo = new InMemoryPlayerRepository();
var walletRepo = new InMemoryWalletRepository();

int idCounter = 1;

while (true)
{
    Console.WriteLine("\n=== WorldRank ===");
    Console.WriteLine("1. Add Player");
    Console.WriteLine("2. List Players");
    Console.WriteLine("3. Find Player");
    Console.WriteLine("4. Add Wallet");
    Console.WriteLine("5. List Player Wallets");
    Console.WriteLine("6. Delete Player");
    Console.WriteLine("0. Exit");

    Console.Write("> ");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Name: ");
            var name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name))
            {
                var player = new Player(idCounter++, name);
                playerRepo.AddPlayer(player);
                Console.WriteLine("Player added.");
            }
            break;


        case "2":
            foreach (var player in playerRepo.Players)
            {
                Console.WriteLine(player);
            }
            break;


        case "3":
            Console.Write("Player ID: ");

            if (int.TryParse(Console.ReadLine(), out int searchId))
            {
                var player = playerRepo.FindPlayer(searchId);

                Console.WriteLine(player?.ToString() ?? "Player not found.");
            }
            break;


        case "4":
            Console.Write("Player ID: ");

            if (int.TryParse(Console.ReadLine(), out int playerId))
            {
                Console.Write("Currency (EUR/USD/GBP): ");

                if (Enum.TryParse(Console.ReadLine(), true, out Currency currency))
                {
                    var wallet = new Wallet(currency);

                    walletRepo.Add(wallet, playerId);

                    Console.WriteLine("Wallet added.");
                }
            }
            break;


        case "5":
            Console.Write("Player ID: ");

            if (int.TryParse(Console.ReadLine(), out int id))
            {
                foreach (var wallet in walletRepo.GetByPlayer(id))
                {
                    Console.WriteLine(wallet);
                }
            }
            break;


        case "6":
            Console.Write("Player ID: ");

            if (int.TryParse(Console.ReadLine(), out int deleteId))
            {
                playerRepo.DeletePlayer(deleteId);
            }
            break;


        case "0":
            return;


        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}