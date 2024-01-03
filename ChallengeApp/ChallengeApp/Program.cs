
using ChallengeApp;

Emplloyee emplloyee1 = new Emplloyee("Jan", "Kowalski", "38");
Emplloyee emplloyee2 = new Emplloyee("Małgorzata", "Nowakowska", "25");
Emplloyee emplloyee3 = new Emplloyee("Mia", "Toretto", "29");

emplloyee1.AddScore(5);
emplloyee1.AddScore(2);
emplloyee1.AddScore(4);
emplloyee1.AddScore(6);
emplloyee1.AddScore(2);

emplloyee2.AddScore(3);
emplloyee2.AddScore(1);
emplloyee2.AddScore(8);
emplloyee2.AddScore(2);
emplloyee2.AddScore(3);

emplloyee3.AddScore(6);
emplloyee3.AddScore(10);
emplloyee3.AddScore(9);
emplloyee3.AddScore(2);
emplloyee3.AddScore(7);

List<Emplloyee> emplloyees = new List<Emplloyee>()
{
    emplloyee1, emplloyee2, emplloyee3
};

int maxResault = -1;
Emplloyee emplloyeeWithMaxResault = null;

foreach (var emplloyee in emplloyees)
{
    if (emplloyee.Result > maxResault)
    {
        emplloyeeWithMaxResault = emplloyee;

    }


}

Console.WriteLine("Pracownikiem z największą liczbą punktów jest"  + emplloyeeWithMaxResault.Name + " " + emplloyeeWithMaxResault.Surname + ", wiek: " + emplloyeeWithMaxResault.Age + " z liczbą punktów " + emplloyeeWithMaxResault.Result);









