using System;
using System.Collections.Generic;

namespace EnNattPaMuseet
{
    public class OmodernaMuseet
    {
        public Museum BuildOmodernaMuseet() {
             
            //The museum is created (empty)
            Museum omodernaMuseet = new Museum("Omoderna Museet");

            //The rooms are created
            Room entrance = new Room("Entrén");
            Room hallway = new Room("korridoren");
            Room greenRoom = new Room("gröna rummet");
            Room redRoom = new Room("röda rummet");
            Room blueRoom = new Room("blåa rummet");
            Room whiteRoom = new Room("vita rummet");
            Room blackRoom = new Room("svarta rummet");
            Room purpleRoom = new Room("lila rummet");
            
        
           
            //The rooms are added to the museum´s list
            /*
                  Important! Entrance must be added to the list on the 1st position!!!
            
            */
            omodernaMuseet.AddRoomToList(entrance);
            omodernaMuseet.AddRoomToList(hallway);
            omodernaMuseet.AddRoomToList(greenRoom);
            omodernaMuseet.AddRoomToList(redRoom);
            omodernaMuseet.AddRoomToList(blueRoom);
            omodernaMuseet.AddRoomToList(whiteRoom);
            omodernaMuseet.AddRoomToList(blackRoom);
            omodernaMuseet.AddRoomToList(purpleRoom);

            
            
            //Adds adjoining rooms for the green room
            greenRoom.AddAdjoiningRoom(redRoom);
            greenRoom.AddAdjoiningRoom(blueRoom);
            greenRoom.AddAdjoiningRoom(hallway);

            //Adds adjoining rooms for the red room
            redRoom.AddAdjoiningRoom(greenRoom);
            redRoom.AddAdjoiningRoom(purpleRoom);

            //Adds adjoining rooms for the blue room
            blueRoom.AddAdjoiningRoom(greenRoom);
            blueRoom.AddAdjoiningRoom(whiteRoom);
            blueRoom.AddAdjoiningRoom(blackRoom);
            blueRoom.AddAdjoiningRoom(purpleRoom);

            //Adds adjoining rooms for the hallway 
            hallway.AddAdjoiningRoom(greenRoom);
            hallway.AddAdjoiningRoom(entrance);

            //Adds adjoining rooms for the entrance
            entrance.AddAdjoiningRoom(hallway);

            //Adds adjoining rooms for the white room
            whiteRoom.AddAdjoiningRoom(blueRoom);

            //Adds adjoining rooms for the black room
            blackRoom.AddAdjoiningRoom(blueRoom);

            //Adds adjoining rooms for the purple room
            purpleRoom.AddAdjoiningRoom(blueRoom);
            purpleRoom.AddAdjoiningRoom(redRoom);


            //The artworks are created
            Artwork VenusFodelse = new Artwork("Venus födelse", @"En målning som illusterar myten om 
hur gudinnan Venus föds ur havets skum. Målningen tros ha varit ett 
beställningsverk av Lorenzo de’Medici men inget vet säkert, 
vilket kanske inte är så konstigt då det trots allt gått över 500 år sedan Boticelli 
färdigställde det omtalade verket.", "Sandro Boticelli");
            
            Artwork nackrosor = new Artwork("Näckrosor", @"'Le Bassin aux Nympheas' är den franska 
originaltiteln på detta impressionistiska mästerverk och 
betyder ordagrant ”Näckrosdammen”. Tavlan, som var färdig 1919, 
ingår i en serie som innehåller runt 250 oljemålningar.", "Claude Monet");

            Artwork nattvakten = new Artwork("Nattvakten", @"Denna storslagna oljemålning stod klar 1642 och 
heter egentligen 'Kapten Frans Banning Coqs skyttekompani'. 
Målningen illustrerar Amsterdams nattvakt i full utryckning ledda 
av just Kapten Banning Coqs och dennes sidekick Willem van Ruytenburch.", "Rembrandt van Rijn");

            Artwork skriet = new Artwork("Skriet", @"En målning i fyra versioner som föreställer en person 
som står och skriker vid en solnedgång. Ångest och demoner menar vissa, 
medan andra hävdar att Munch var inspirerade av de blodröda 
solnedgångarna som kunde skådas i Oslo efter det dramatiska 
vulkanutbrottet på Krakatoa i Indien. Och dramatisk är även historien 
om verket Skriet, vars berättelse innefattar både multimiljardärer, 
stölder, rån och mördare på film.", "Edvard Munch");

            Artwork flickaMedParlorhange = new Artwork ("Flicka med pärlörhänge", @"Ingen vet exakt när denna 
vackra tavla målades eller vem flickan på motivet är. 
Från början var bakgrunden i målningen grön. Med tiden 
har den dock mörknat och är idag närmast svart.", "Johannes Vermeer");

            Artwork guernica = new Artwork ("Guernica", @"'Guernica' är en av Pablo Picassos mest berömda och 
fängslande målningar. Inte bara på grund av dess omedelbara 
visuella effekt och storlek (3,49 x 7,76 meter), utan även för 
vad den skildrar; bombningen av den baskiska staden Guernica under 
det spanska inbördeskriget.", "Pablo Picasso");

            Artwork adamsSkapelse  = new Artwork ("Adams skapelse ", @"Efter att det Sixtinska kapellet i Vatikanstaten revs
av påven efter en allt för blöt nattvard lyckades denna takfresk räddas. 
Den skapades av ingen mindre än Michelangelo år 1511 och målningen illustrerar 
hur Gud ger liv åt Adam.", "Michelangelo");

            Artwork Nattvarden  = new Artwork ("Nattvarden", @"Upphovsmannen Leonardo da Vinci uppförde i slutet av 
1400-talet målningen direkt på det milanesiska klostret Santa Maria delle Grazies putsväggar.
Efter ett besök av påven gick dock klostret samma öde till mötes som det sixtinska kapellet.
Tavlan gick som tur var att rädda och efter en restaurering för över 40 miljoner kronor förgyller
den nu en av väggarna i det Omoderna museet.", "Leonardo da Vinci");

            Artwork stjarnenatt  = new Artwork ("Stjärnenatt", @"Vem kan motstå Vincent van Goghs djärva penseldrag i
denna fantastiska målning? Verket, med originaltiteln ”De Sterrenacht”, skapades 1889
och föreställer utsikten från van Goghs rum från den tid han var inlagd på ett mentalsjukhus 
tilsammans med påven i den lilla franska staden Saint-Rémy.", "Vincent van Gogh");

            Artwork  monaLisa  = new Artwork ("Mona Lisa", @" 'Mona Lisa', eller 'La Gioconda' som är dess originaltitel,
har figurerat världen över i allt från filmer till massproducerade turistsouvernirer.
Målningen blev färdigställd 1507 efter fjorton års arbete. Beställare var den italienske politikern 
Francesco del Giocondo som ville hänga tavlan i sitt toalettskåp, vilket också är anledningen 
till att tavlan är så liten. Det är nog många som blivit snopna när de stegat in på 
Omoderna museet och upptäckt att världens mest berömda målning endast mäter 7 x 3 cm…", "Leonardo da Vinci");

            Artwork  denGuleKristus  = new Artwork ("Den gule Kristus", @" Målningen är, tillsammans med Den gröne Kristus, 
Gauguins viktigaste bidrag till symbolismen som i kontrast till realismen och naturalismen 
ville återknyta till äldre tiders allegoriska måleri. Den tillkom i Pont-Aven i Bretagne dit 
Gauguin kom för första gången 1886. Här mötte han Émile Bernard och tillsammans utvecklade de 
syntetism med stora, rena färgytor omgivna av svarta konturer", " Paul Gauguin");



            //The artworks are added to the different rooms
            greenRoom.AddArtwork(VenusFodelse);
            greenRoom.AddArtwork(nackrosor);

            redRoom.AddArtwork(nattvakten);
            redRoom.AddArtwork(skriet);
            redRoom.AddArtwork(flickaMedParlorhange);

            blueRoom.AddArtwork(guernica);

            whiteRoom.AddArtwork(adamsSkapelse);

            purpleRoom.AddArtwork(Nattvarden);
            purpleRoom.AddArtwork(stjarnenatt);
            purpleRoom.AddArtwork(monaLisa);
            purpleRoom.AddArtwork(denGuleKristus);

            //The method returns the instance of the class Museum
            return omodernaMuseet;
        }
    }
}
