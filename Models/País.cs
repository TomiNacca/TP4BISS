public class País
{
public string Nombre{get;private set;}
public string imgBandera{get;private set;}
public double Población{get;private set;}

public DateTime FechaIndependencia{get;private set;}
public string AtractivosTuristicos{get;private set;}
///va a almacenar muchos paises por eso no es clase estatica y es normal.
public País(){}
public País(string Nom, string Img, double Pob, DateTime FInd, string AT)
{
Nombre=Nom;
imgBandera=Img;
Población=Pob;
FechaIndependencia=FInd;
AtractivosTuristicos=AT;

}

}