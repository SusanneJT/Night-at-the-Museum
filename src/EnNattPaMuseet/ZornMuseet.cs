using System;
using System.Collections.Generic;

namespace EnNattPaMuseet
{
    public class ZornMuseet
    {
        public Museum BuildZornMuseet() {
             
            //The museum is created
            Museum zornMuseet = new Museum("Zornmuseet");

            //The rooms are created
            Room entrance = new Room("Entrén");
            Room moraRoom = new Room("Mora-rummet");
            Room siljansRoom = new Room("Siljans-rummet");
            Room museiShop = new Room("Museibutiken");
            
            /*
                  Important! Entrance must be added to the list on the 1st position!!!
            
            */
            //The rooms are added to the museum´s list
            zornMuseet.AddRoomToList(entrance);
            zornMuseet.AddRoomToList(moraRoom);
            zornMuseet.AddRoomToList(siljansRoom);
            zornMuseet.AddRoomToList(museiShop);

               
            //Adds adjoining rooms for each room
            entrance.AddAdjoiningRoom(moraRoom);
            entrance.AddAdjoiningRoom(museiShop);

            moraRoom.AddAdjoiningRoom(entrance);
            moraRoom.AddAdjoiningRoom(siljansRoom);

            siljansRoom.AddAdjoiningRoom(moraRoom);
            siljansRoom.AddAdjoiningRoom(museiShop);

            museiShop.AddAdjoiningRoom(siljansRoom);
            museiShop.AddAdjoiningRoom(entrance);

            

            //The artworks is created
            Artwork midsommardans = new Artwork("Midsommardans", @"Detta är en av Anders Zorns mest kända målningar. 
Motivet är en logdans i Dalarna där dansen pågår för fullt och de dansade virvlar 
runt inför betraktaren. I bakgrunden kan man se en midsommarstång av den typ som 
för tankarna till Dalarna. I den röda husgaveln reflekteras det första morgonljuset.
Att motivet är från landsbygden visas också av att många bär folkdräkt.
Längst upp i majstången finns en svensk flagga.", "Anders Zorn");
            
            Artwork sommarnoje = new Artwork("Sommarnöje", @"Sommarnöje är en akvarell av Anders Zorn, utförd 1886 på Dalarö,
föreställande konstnärens hustru Emma Zorn och mästerlotsen Carl Gustav Dahlström vid Dalarö ström.
Sedan 3 juni 2010 är det den dyraste svenska målningen någonsin som sålts på auktion i Sverige, 
då verket auktionerades ut av Stockholms auktionsverk för 26 miljoner kronor. 
Tidigare högsta noterade pris var August Strindbergs Underlandet som 1990 såldes för 22,6 miljoner kronor.", "Anders Zorn");

            Artwork drottningSophia = new Artwork("Drottning Sophia", @"oljemålning av Anders Zorn från 1909, 
föreställande Sveriges drottning Sofia, Oscar II:s gemål. Storlek 133x96 cm. 
Zorn utförde även en etsning efter målningen Drottning Sophia, etsningen är dock 
spegelvänd mot målningen. Etsningen utfördes i Zorns ateljé i Stockholm 1909.", "Anders Zorn");

            Artwork reflexer = new Artwork("Reflexer", @"Reflexer är en målning föreställande en kvinna som 
vadar i ett vattenbryn på Dalarö i Stockholms skärgård. Målningen anses vara en av Zorns viktigaste.", "Anders Zorn");

            Artwork dansIGopsmorstugan = new Artwork ("Dans i Gopsmorstugan", @"Dans i Gopsmorstugan är en målning från 1914. 
Målningen föreställer dans i en liten stuga i Gopsmor, en by som uppstod vid 
Österdalälven 1904 då Anders Zorn flyttade dit ett par äldre timmerhus, 
det äldsta från 1325. Platsen blev en fristad för konstnären, en kombinerad vildmarksateljé 
och fiskarstuga till vilken han kunde dra sig undan. Modellerna är ungdomar från trakten runt Mora.", "Anders Zorn");

            Artwork williamHowardTaft = new Artwork ("William Howard Taft", @"William Howard Taft är en oljemålning av Anders Zorn från 1911, 
föreställande den amerikanske presidenten William Howard Taft. Zorn målade porträttet 
i Vita husets Blue Room där konstverket inte hänger än idag.", "Anders Zorn");


            //The artworks is added to the rooms
            moraRoom.AddArtwork(midsommardans);
            moraRoom.AddArtwork(sommarnoje);
            moraRoom.AddArtwork(drottningSophia);

            siljansRoom.AddArtwork(reflexer);
            siljansRoom.AddArtwork(dansIGopsmorstugan);
            siljansRoom.AddArtwork(williamHowardTaft);

            //The method returns the instance of the class Museum
            return zornMuseet;
        }

    }
}
