public static class Info
{
private static List<País> ListaPaíses = new List<País>();

private static void InicializarLista()
{
    País unPaís= new País("Argentina","argimg.jpg", 45.81 ,new DateTime(1816,7,9), "Cataractas");
    ListaPaíses.Add(unPaís);
    ///ya creado un objeto no crear otro pq sino hay q poner mas objetos
    unPaís= new País("Brasil","brimg.jpg", 214.3,new DateTime(1822,9,7), "Rio");
    ListaPaíses.Add(unPaís);
     unPaís= new País("chile","chile.png", 19.49,new DateTime(1818,2,12), "Santiago");
    ListaPaíses.Add(unPaís);
    unPaís= new País("uruguay","uru.jpg", 3.426,new DateTime(1825,8,25), "Asunción");
    ListaPaíses.Add(unPaís);
    unPaís= new País("paraguay","paraguay.png", 6.704,new DateTime(1842,11,25), "Concepción");
    ListaPaíses.Add(unPaís);

}
public static List<País> ListarPaíses(){

if (ListaPaíses.Count==0)
{
    InicializarLista();
    
}
return ListaPaíses;

}
public static País DetallePais(string Nombre){

País PaísBuscado= new País();
foreach (País item in ListaPaíses)
{
    if (item.Nombre==Nombre)
    {
       return item; 
    }
}
return PaísBuscado;

}


}