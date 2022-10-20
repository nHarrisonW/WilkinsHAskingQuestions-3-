//N. Harrison Wilkins
//10-20-2022
//GitHub Project Part 3
//This console project will ask users what their name is and what time they woke up, before printing out a response of their name an time that they woke up.
//PEER REVIEW IN README

Console.Clear();

//VARIABLES ARE DEFINED HERE
string playAgain;
string myName;
string time;

do{
Console.WriteLine("HELLO SENTIENT ONE! WHAT IS YOUR NAME?");
myName = Console.ReadLine().ToUpper();
//INPUT FOR NAME
while(myName == string.Empty){
    Console.WriteLine("DON'T JUST SIT THERE! SAY SOMETHING");
    myName = Console.ReadLine().ToUpper();
}
if(myName != string.Empty){
Console.WriteLine("GOOD MORNING " + myName + "! WHAT TIME DID YOU WAKE UP THIS MORNING?");
time = Console.ReadLine().ToUpper();
while(time == string.Empty){
    Console.WriteLine("BE SERIOUS THIS TIME! GIVE ME A TIME!");
    time = Console.ReadLine().ToUpper();
}

if(time != string.Empty){

Console.WriteLine("WOW, " + myName +", " + time + " SURE IS EARLY!");
Console.WriteLine("ENTER \"Y\" TO RESTART, OR ENTER ANY KEY TO EXIT!");
}

}
playAgain = Console.ReadLine().ToUpper();
}while(playAgain == "Y");
