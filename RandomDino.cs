using System;


namespace DinoSpin
{
    class Random_Dino
    {
        List<string> Herbi_List = new List<string> { "Diabloceratops", "Dryosaurus", "Hypsilophodon", "Pachycephalosaurus", "Stegosaurus", "Tenontosaurus",
        "Maiasaura"};
        List<string> Carni_List = new List<string> { "Carnotaurus", "Ceratosaurus", "Deinosuchus", "Dilophosaurus", "Herrerasaurus",
        "Omniraptor", "Pteranodon", "Troodon"};
        List<string> omni_List = new List<string> { "Beipiaosaurus", "Gallimimus" };


        public void Dino_Selector()
        {
            bool run_program = true;
            Random random = new Random();
           
            while (run_program)
            {
                Console.WriteLine("What do you want to play as?\n" +
               "1. Herbi\n" +
               "2. Carni\n" +
               "3. Omni\n" +
               "4. Exit");
                Console.Write("Input: ");
                string user_answer = Console.ReadLine();
                // Null check
                while (string.IsNullOrEmpty(user_answer))
                {
                    Console.WriteLine("Your answer can not be empty");
                    user_answer = Console.ReadLine();
                }
                // Switch statement for user input
                switch (user_answer)
                {
                    case "1":
                        Console.WriteLine(Herbi_List[random.Next(0, Herbi_List.Count)]);
                        break;
                    case "2":
                        Console.WriteLine(Carni_List[random.Next(0, Carni_List.Count)]);
                        break;
                    case "3":
                        Console.WriteLine(omni_List[random.Next(0, omni_List.Count)]);
                        break;
                    case "4":
                        Console.WriteLine("Program ending...");
                        run_program = false;
                        break;
                }
            }

        }
    }
}
