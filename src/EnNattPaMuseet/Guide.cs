using System;
using System.Collections.Generic;

namespace EnNattPaMuseet
{
    public class Guide
    {
        //Theese are created for an easy way to access methods in the classes 
        private OmodernaMuseet bobTheBuilder = new OmodernaMuseet();
        private ZornMuseet slobTheBuilder = new ZornMuseet();
        
        
        
        //======================================================================================	
	    //      Introduction to the program, this method is called from main in Program.cs
	    //=======================================================================================
        public void Introduction() {
            Console.Clear();
            Console.WriteLine("\n____________________  Välkommen till En natt på museet  ____________________ \n\n ");
            Console.WriteLine(@"Jag heter Konsola och jag kommer att vara din virtuella guide för detta äventyr. 

Du kommer under programmets gång att bland annat få bestämma vilket eller vilka museum
vi ska besöka och vilka konstverk du vill att jag ska berätta mer om. 
Jag kommer att presentera dina valmöjligheter med olika nummer och du väljer och 
styr programmet genom att skriva in önskad siffra.");
            Console.Write("\n\nTryck på valfri tangent för att ta dig vidare..");
            Console.ReadKey();
            ChooseMuseum();
        }


        //======================================================================================	
	    //                      User can choose to visit two different museums
        //   This method is called directly after introduction (above) or from StartTour (below)
	    //=======================================================================================
        public void ChooseMuseum() {
            Console.Clear();
            Console.WriteLine("\nVilket museum vill du besöka?\n");
            Console.WriteLine("[1] Omoderna Museet");
            Console.WriteLine("[2] Zornmuseet\n");
            string input = ""; 
            
            while(input != "1" && input != "2") {
                input = Console.ReadLine();
                switch (input)
                {
                    //The selected museum is built and is passed as an argument to the method StartTour
                    case "1": StartTour(bobTheBuilder.BuildOmodernaMuseet());
                    break;
                    case "2": StartTour(slobTheBuilder.BuildZornMuseet());
                    break;
                    default:Console.WriteLine("Välj mellan alternativ 1 eller 2\n");
                    break;
                }
            }     
        }

        //======================================================================================	
	    //       Method to visit the chosen museum and move between the different rooms
	    //=======================================================================================
        public void StartTour(Museum museum) {

            //Fetches the rooms in the museum and
            //..and set the starting position of the program to the first room in the list
            //..which is supposed to be the entrance
            List<Room> listOfRooms = museum.GetListOfRooms();
            Room currentRoom = listOfRooms[0];

            Console.Clear();
            Console.WriteLine("   Välkommen till " + museum.GetMuseumName());
            Console.WriteLine("_________________________________________");
            
            bool running = true;

            while (running) {

                //Variables declared for creating different choices depending on rooms and artworks
                //
                int count = 0; //Count is used for keeping track of how many choices this loop should have
                int changeRoom = 0; // Keeps track of if user choose to change room
                int lookAtArtworks = 0; // Keeps track of if user choose to look at the art
                int changeMuseum = 0; // Keeps track of if user choose to change museum
                int close = 0; // Keeps track of if user choose to close program

                List<string> menuChoices = new List<string>(); //Holds a menu of differens choices
               
                //Fetches the list of artworks and adjoining rooms for the current room               
                List<Artwork> artworks = currentRoom.GetArtworks();
                List<Room> adjoiningRooms = currentRoom.GetAdjoiningRooms();

                foreach (var adJoiningRoom in adjoiningRooms) {
                    count ++; //adds a choice (number) in the menu for each room in the list
                    menuChoices.Add($"[{count}] Gå till {adJoiningRoom.GetRoomName()}");  
                }
                changeRoom = count;
                
                //This menu choice will only appear if the room has artworks in it 
                if(artworks.Count > 0) {
                    count++;
                    menuChoices.Add($"[{count}] Titta på {artworks.Count} olika konstverk");
                    lookAtArtworks = count;
                }
                
                count ++;
                menuChoices.Add($"[{count}] Gå till ett annat museum");
                changeMuseum = count;

                count ++;
                menuChoices.Add($"[{count}] Avsluta programmet\n");
                close = count;
                
                //**************************************
                //The created menu is written to console
                //**************************************
                Console.WriteLine($"\nVi befinner oss just nu i {currentRoom.GetRoomName()}");
                Console.WriteLine("\nHär kan du göra följande val:");

                foreach (var menyval in menuChoices) {
                    Console.WriteLine(menyval);
                }

                //Checks input 
                int userChoice = 0;
                do {
                    Console.Write($"\nVälj mellan alternativ 1 till {count}: ");
                    try { 
                        userChoice = Convert.ToInt32(Console.ReadLine()); 
                    }
                    catch {
                        Console.WriteLine($"Felaktig inmatning."); 
                    }
                } while (userChoice < 1 || userChoice > count);
                
                
                //If the chosen number is in the range where change room is presented 
                //.. current room will change to the chosen one.
                if (userChoice <= changeRoom) {

                    int changeToRoom = userChoice -1;
                    currentRoom = adjoiningRooms[changeToRoom];
                    Console.Clear();
                }
                else if (userChoice == lookAtArtworks) {
                    //The method ShowArt is called 
                    ShowArt(currentRoom.GetArtworks(), currentRoom);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (userChoice == changeMuseum) {
                    //The loop is aborted and method to change museum is called
                    running = false;
                    ChooseMuseum();

                }
                else if (userChoice == close) {
                    Console.Clear();
                    Console.WriteLine("Du har valt att avsluta programmet");
                    running = false;
                    //No method is called and loop is aborted
                }
            }
        }

        
        
        //======================================================================================	
	    //                   Loops through all the artworks in the room
	    //=======================================================================================
        public void ShowArt(List<Artwork> list, Room room) {
            Console.Clear();
            Console.WriteLine($"I {room.GetRoomName()} finns {list.Count} konstverk:\n");
            int count = 0;
            foreach (var artwork in list) {
                count ++;
                Console.WriteLine($"********* {artwork.GetArtworkTitle()} *********\n");
                Console.WriteLine(artwork.ToString());
                Console.WriteLine("***********************************************\n\n");
                if (count == list.Count) {} // if it´s the last artwork no new text will appear
                else{
                    Console.Write("Tryck på valfri tangent för att visa nästa tavla..\n");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Tryck på valfri tangent för att återgå till menyvalen..");
        }
    }
}
