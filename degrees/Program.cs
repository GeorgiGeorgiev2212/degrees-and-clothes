//Tozi Console.WriteLine zapitwa koq chas ot denq e s pomoshta na string
Console.WriteLine("Enter the time of day");
//stringa s koito se pita koq chast ot denq
string daytime = Console.ReadLine();
//Tozi Console.WriteLine zapitva za tempetaturata v celzii i int - celi chisla
Console.WriteLine("Enter the temperature in degrees: ");
//tazi promenliva pita za tempetaturata v celzii i int - celi chisla
int degrees = int.Parse(Console.ReadLine());
//tova uslovie pita dali tazi chast ot denq e sutrinta
if (daytime == "Morning")
{
    //Ako tova uslovie e izpulneno pita kolko gradusa e s pomoshta na operatora switch case
    switch (degrees)
        {
        //za vseki vuveden gradus ot 1 do 25 izpulva tova koeto e napisano v case i kazva kakvo trqbva da obleche
        case 1:

            Console.WriteLine("Outfit = Shirt, Shoes = Sneakers");
            break;
        case 2:
            Console.WriteLine("Outfit = Sweater, Shoes = Sneakers");
            break;
        case 3:
            Console.WriteLine("Outfit = Sweater, Shoes = Sneakers");
            break;
        case 4:
            Console.WriteLine("Outfit = Sweater, Shoes = Sneakers");
            break;

        case 5:
            Console.WriteLine("Outfit = Sweater, Shoes = Sneakers");
            break;
        case 6:
            Console.WriteLine("Outfit = Sweater, Shoes = Sneakers");
            break;
        case 7:
            Console.WriteLine("Outfit = Sweater, Shoes = Sneakers");
            break;

        case 8:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Sneakers");
            break;

        case 9:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Sneakers");
            break;
        case 10:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Sneakers");
            break;
        case 11:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Sneakers");
            break;
        case 12:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Sneakers");
            break;
        case 13:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Sneakers");
            break;
        case 14:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Sneakers");
            break;
        case 15:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Sneakers");
            break;
        case 16:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Sneakers");
            break;
        case 17:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Sneakers");
            break;
        case 18:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Sneakers");
            break;
        case 19:
            Console.WriteLine("Öutfit = Shirt, Shoes = Moccasins");
            break;
        case 20:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 21:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 22:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 23:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 24:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 25:
            Console.WriteLine("Öutfit = T-shirt, Shoes = Sandals");
            break;






    }
}
// tozi else if pita dali chasta ot denq e sledobed
else if (daytime == "Afternoon")
{


    //Ako tova uslovie e izpulneno pita kolko gradusa e s pomoshta na operatora switch case
    switch (degrees)
    {



        //za vseki vuveden gradus ot 1 do 25 izpulva tova koeto e napisano v case i kazva kakvo trqbva da obleche
        case 1:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 2:
            Console.WriteLine("Outfit = Sweater, Shoes = Moccasins");
            break;
        case 3:
            Console.WriteLine("Outfit = Sweater, Shoes = Moccasins");
            break;
        case 4:
            Console.WriteLine("Outfit = Sweater, Shoes = Moccasins");
            break;

        case 5:
            Console.WriteLine("Outfit = Sweater, Shoes = Moccasins");
            break;
        case 6:
            Console.WriteLine("Outfit = Sweater, Shoes = Moccasins");
            break;
        case 7:
            Console.WriteLine("Outfit = Sweater, Shoes = Moccasins");
            break;

        case 8:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Moccasins");
            break;

        case 9:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Moccasins");
            break;
        case 10:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Moccasins");
            break;
        case 11:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Moccasins");
            break;
        case 12:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Moccasins");
            break;
        case 13:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Moccasins");
            break;
        case 14:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Moccasins");
            break;
        case 15:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Moccasins");
            break;
        case 16:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Moccasins");
            break;
        case 17:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Moccasins");
            break;
        case 18:
            Console.WriteLine("Outfit = Sweatshirt, Shoes = Moccasins");
            break;
        case 19:
            Console.WriteLine("Öutfit = Shirt, Shoes = Sandals");
            break;
        case 20:
            Console.WriteLine("Outfit = Shirt, Shoes = Sandals");
            break;
        case 21:
            Console.WriteLine("Outfit = Shirt, Shoes = Sandals");
            break;
        case 22:
            Console.WriteLine("Outfit = Shirt, Shoes = Sandals");
            break;
        case 23:
            Console.WriteLine("Outfit = Shirt, Shoes = Sandals");
            break;
        case 24:
            Console.WriteLine("Outfit = Shirt, Shoes = Sandals");
            break;
        case 25:
            Console.WriteLine("Öutfit = Swim Suit, Shoes = Barefoot");
            break;

    }


}
// tozi else if pita dali chasta ot denq e vecher
else if (daytime == "Evening")
{

    //Ako tova uslovie e izpulneno pita kolko gradusa e s pomoshta na operatora switch case
    switch (degrees)
    {
        //za vseki vuveden gradus ot 1 do 25 izpulva tova koeto e napisano v case i kazva kakvo trqbva da obleche                                                                                             
        case 1:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 2:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 3:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 4:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;

        case 5:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 6:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 7:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;

        case 8:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;

        case 9:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 10:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 11:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 12:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 13:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 14:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 15:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 16:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 17:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 18:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 19:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 20:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 21:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 22:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 23:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 24:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;
        case 25:
            Console.WriteLine("Outfit = Shirt, Shoes = Moccasins");
            break;



}   }